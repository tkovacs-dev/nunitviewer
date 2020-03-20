using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resources = NUnitTestResultsViewerCode.Properties.Resources;
using NUnitTestResultsViewerCode.UI;
using NUnitTestResultsViewerCode.Items;
using System.IO;
using System.Drawing.Imaging;

namespace NUnitTestResultsViewerCode
{
  /// <summary>
  /// Main form
  /// </summary>
  public partial class FormMain : Form
  {
    private Dictionary<Type, ICompResultsUI> _UI = new Dictionary<Type, ICompResultsUI>();
    private Dictionary<TestResultsEnum, bool> _shownItems = new Dictionary<TestResultsEnum, bool>();
    private string _filename;
    private FormFind formFind = null;

    /// <summary>
    /// Initializes form main class.
    /// </summary>
    public FormMain()
    {
      InitializeComponent();
    }

    private void openToolStripMenuItem_Click( object sender, EventArgs e )
    {
      loadXML();
    }

    /// <summary>
    /// Load Test Case XML file.
    /// </summary>
    private void loadXML()
    {
      var openDialog = new OpenFileDialog()
      {
        Filter = "XML file|*.xml|All files(*.*)|*.*",
        FilterIndex = 1,
        Title = "Select NUnit Test Results XML file"
      };

      if ( openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
      {
        _filename = openDialog.FileName;

        readTestResults();
      }
    }

    private void readTestResults()
    {
      if ( !File.Exists( _filename ) )
      {
        return;
      }

      this.Cursor = Cursors.WaitCursor;
      var results = TestResultsReader.ReadTestResults( _filename );

      trvResults.SuspendLayout();
      trvResults.Nodes.Clear();
      if ( null != results )
      {
        trvResults.Nodes.Add( filterNodes( results ) );

        lblLoaded.Text = _filename;
        lblTotal.Text = string.Format( "Total: {0}   ", results.TotalCount );
        lblerrors.Text = string.Format( "Errors: {0}   ", results.ErrorsCount );
        lblFailure.Text = string.Format( "Failure: {0}   ", results.FailuresCount );
        lblInvalid.Text = string.Format( "Invalid: {0}   ", results.InvalidCount );
      }
      else
      {
        setDefaultValues();
      }

      if ( trvResults.Nodes.Count > 0 )
      {
        trvResults.Nodes[0].EnsureVisible();
      }

      trvResults.ResumeLayout( false );
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Remove nodes from tree.
    /// </summary>
    /// <param name="results"></param>
    /// <returns></returns>
    private TreeNode filterNodes( TreeNode results )
    {
      List<TreeNode> toBeRemoved = new List<TreeNode>();
      foreach ( TreeNode t in results.Nodes )
      {
        TestResult testCase = t as TestResult;
        if ( null != testCase )
        {
          if ( !_shownItems[testCase.TestResultValue] )
          {
            toBeRemoved.Add( testCase );
            continue;
          }
        }
          
        filterNodes( t );
      }

      foreach ( TreeNode t in toBeRemoved )
      {
        results.Nodes.Remove( t );
      }

      results.Expand();
      return results;
    }

    private void FormMain_Load( object sender, EventArgs e )
    {
      ImageList list = new ImageList();
      list.ColorDepth = ColorDepth.Depth24Bit;
      list.Images.Add( "  ", new Bitmap( 16, 16 ) );
      list.Images.Add( Defines.IMAGE_KEY_SUCCESS, Resources.circle_green );
      list.Images.Add( Defines.IMAGE_KEY_FAILURE, Resources.circle_red );
      list.Images.Add( Defines.IMAGE_KEY_SKIPPED, Resources.circle_gray );
      list.Images.Add( Defines.IMAGE_KEY_IGNORED, Resources.circle_orange );
      list.Images.Add( Defines.IMAGE_KEY_INCONCLUSIVE, Resources.circle_blue );

      trvResults.ImageList = list;

      var compNUnitTestResults = new CompNUnitTestResults()
      {
        Dock = DockStyle.Fill,
        BorderStyle = BorderStyle.FixedSingle
      };
      var compTestSuite = new CompTestResult()
      {
        Dock = DockStyle.Fill,
        BorderStyle = BorderStyle.FixedSingle
      };
      var compTestCase = new CompTestCase()
      {
        Dock = DockStyle.Fill
      };

      _UI.Add( typeof( NUnitTestResults ), compNUnitTestResults );
      _UI.Add( typeof( TestSuite ), compTestSuite );
      _UI.Add( typeof( TestCase ), compTestCase );

      foreach ( TestResultsEnum en in Enum.GetValues( typeof( TestResultsEnum ) ) )
      {
        _shownItems.Add( en, true );
      }

      setDefaultValues();
    }

    private void setDefaultValues()
    {
      lblLoaded.Text = string.Empty;
      lblTotal.Text = string.Empty;
      lblerrors.Text = string.Empty;
      lblInvalid.Text = string.Empty;
      lblFailure.Text = string.Empty;
    }

    private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
    {
      new AboutBox().ShowDialog();
    }

    private void collapseAllToolStripMenuItem_Click( object sender, EventArgs e )
    {
      trvResults.CollapseAll();
    }

    private void expandAllToolStripMenuItem_Click( object sender, EventArgs e )
    {
      trvResults.ExpandAll();
    }

    private void trvResults_AfterSelect( object sender, TreeViewEventArgs e )
    {
      splitContainer1.Panel2.SuspendLayout();
      while ( splitContainer1.Panel2.Controls.Count >= 1 )
      {
        splitContainer1.Panel2.Controls.RemoveAt( 0 );
      }

      if ( _UI.ContainsKey( e.Node.GetType() ) )
      {
        ICompResultsUI comp = _UI[e.Node.GetType()];
        comp.InitializeData( e.Node as BaseItem );
        splitContainer1.Panel2.Controls.Add( comp as UserControl );
      }
      splitContainer1.Panel2.ResumeLayout();
    }

    private void testCasesTreeToolStripMenuItem_Click( object sender, EventArgs e )
    {
      splitContainer1.Panel1Collapsed = !testCasesTreeToolStripMenuItem.Checked;
    }

    private void detailedInformationToolStripMenuItem_Click( object sender, EventArgs e )
    {
      splitContainer1.Panel2Collapsed = !detailedInformationToolStripMenuItem.Checked;
    }

    private void errorsToolStripMenuItem_CheckedChanged( object sender, EventArgs e )
    {
      _shownItems[TestResultsEnum.Error] = errorsToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Failure] = failuresToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Ignored] = ignoredToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Inconclusive] = inconclusiveToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Invalid] = invalidToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Skipped] = skippedToolStripMenuItem.Checked;
      _shownItems[TestResultsEnum.Success] = successToolStripMenuItem.Checked;

      tsbErrors.Checked = errorsToolStripMenuItem.Checked;
      tsbFailures.Checked = failuresToolStripMenuItem.Checked;
      tsbIgnored.Checked = ignoredToolStripMenuItem.Checked;
      tsbInconclusive.Checked = inconclusiveToolStripMenuItem.Checked;
      tsbInvalid.Checked = invalidToolStripMenuItem.Checked;
      tsbSkipped.Checked = skippedToolStripMenuItem.Checked;
      tsbSucceed.Checked = successToolStripMenuItem.Checked;

      if ( File.Exists( _filename ) )
      {
        readTestResults();
      }
    }

    private void tsbErrors_CheckedChanged( object sender, EventArgs e )
    {
      errorsToolStripMenuItem.Checked = tsbErrors.Checked;
      failuresToolStripMenuItem.Checked = tsbFailures.Checked;
      ignoredToolStripMenuItem.Checked = tsbIgnored.Checked;
      inconclusiveToolStripMenuItem.Checked = tsbInconclusive.Checked;
      invalidToolStripMenuItem.Checked = tsbInvalid.Checked;
      skippedToolStripMenuItem.Checked = tsbSkipped.Checked;
      successToolStripMenuItem.Checked = tsbSucceed.Checked;
    }

    private void findToolStripMenuItem_Click( object sender, EventArgs e )
    {
      if ( null == formFind )
      {
        formFind = new FormFind( this.trvResults );
        formFind.FormClosed += new FormClosedEventHandler( formFind_FormClosed );
        formFind.Owner = this;
        formFind.Location = this.trvResults.PointToScreen( new Point( this.trvResults.Left + this.trvResults.Width + 20, this.trvResults.Top + 15 ) );
        formFind.Show();
      }
      formFind.Activate();
    }

    private void formFind_FormClosed( object sender, FormClosedEventArgs e )
    {
      formFind = null;

      foreach ( var n in this.trvResults.GetAllNodes() )
      {
        n.ForeColor = Color.Black;
        n.BackColor = Color.White;
      }
    }

    private void exitToolStripMenuItem_Click( object sender, EventArgs e )
    {
      Close();
    }
  }
}
