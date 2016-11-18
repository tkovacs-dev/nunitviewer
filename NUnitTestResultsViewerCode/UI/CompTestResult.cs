using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NUnitTestResultsViewerCode.UI
{
  /// <summary>
  /// Represent UI for TestSuite
  /// </summary>
  public partial class CompTestResult : UserControl, ICompResultsUI
  {
    /// <summary>
    /// Initializes Test Suite class.
    /// </summary>
    public CompTestResult()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Initialize interface with default data. 
    /// </summary>
    /// <param name="result"></param>
    public void InitializeData( Items.BaseItem result )
    {
      var res = result as Items.TestResult;

      if( null == res )
      {
        throw new ArgumentException( "Invalid argument type." );
      }

      var isExecuted = res.IsExecuted;

      lblAsserts.Visible = isExecuted;
      lblTime.Visible = isExecuted;
      lblAssertsCap.Visible = isExecuted;
      lblTimeCap.Visible = isExecuted;

      if( isExecuted )
      {
        lblAsserts.Text = res.Asserts.Value.ToString();
        lblTime.Text = res.Time;
      }

      lblExecuted.Text = res.IsExecuted.ToString();
      lblName.Text = res.Name;
      lblresult.Text = res.TestResultValue.ToString();
      lblresult.ForeColor = ( res.TestResultValue == Items.TestResultsEnum.Error ||
        res.TestResultValue == Items.TestResultsEnum.Failure ||
        res.TestResultValue == Items.TestResultsEnum.Invalid ) ? Color.Red : Color.Black;
    }
  }
}
