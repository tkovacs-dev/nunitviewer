using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnitTestResultsViewerCode.Items;

namespace NUnitTestResultsViewerCode.UI
{
  /// <summary>
  /// UI for NUnitTestResults class.
  /// </summary>
  public partial class CompNUnitTestResults : UserControl, ICompResultsUI
  {
    /// <summary>
    /// Initializes NUnitTestResultsViewerCode.UI.CompNUnitTestResults
    /// </summary>
    public CompNUnitTestResults()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Initialize data.
    /// </summary>
    public void InitializeData( BaseItem result )
    {
      var results = result as NUnitTestResults;

      if( null == results )
      {
        throw new ArgumentException( "Invalid argument type." );
      }

      lblErrors.Text = results.ErrorsCount.ToString();
      lblFailures.Text = results.FailuresCount.ToString();
      lblInvalid.Text = results.InvalidCount.ToString();

      lblErrors.ForeColor = results.ErrorsCount > 0 ? Color.Red : Color.Black;
      lblFailures.ForeColor = results.FailuresCount > 0 ? Color.Red : Color.Black;
      lblInvalid.ForeColor = results.InvalidCount > 0 ? Color.Red : Color.Black;

      lblIgnored.Text = results.IgnoredCount.ToString();
      lblInconclusive.Text = results.InconclusiveCount.ToString();
      lblNotRun.Text = results.NotRunCount.ToString();
      lblSkipped.Text = results.SkippedCount.ToString();
      lblTotal.Text = results.TotalCount.ToString();
    }
  }
}
