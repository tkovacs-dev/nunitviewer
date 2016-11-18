using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Drawing;
using NUnitTestResultsViewerCode.Properties;

namespace NUnitTestResultsViewerCode.Items
{
  /// <summary>
  /// Represent Test Results base class.
  /// </summary>
  abstract class TestResult : BaseItem
  {
    /// <summary>
    /// Initializes class.
    /// </summary>
    /// <param name="element"></param>
    protected TestResult( XElement element )
      : base( element )
    {
    }

    /// <summary>
    /// Is test has been executed.
    /// </summary>
    public bool IsExecuted
    {
      get
      {
        return (bool)readAttribute<bool>( "executed" );
      }
    }

    /// <summary>
    /// Test Result.
    /// </summary>
    public TestResultsEnum TestResultValue
    {
      get
      {
        return (TestResultsEnum)readAttribute<TestResultsEnum>( "result" );
      }
    }

    /// <summary>
    /// Exucution time.
    /// </summary>
    public string Time
    {
      get
      {
        if( !IsExecuted )
        {
          return null;
        }
        return (string)readAttribute<string>( "time" );
      }
    }

    /// <summary>
    /// Count of asserts.
    /// </summary>
    public int? Asserts
    {
      get
      {
        if( !IsExecuted )
        {
          return null;
        }
        return (int)readAttribute<int>( "asserts" );
      }
    }

    /// <summary>
    /// Initializes with default value.
    /// </summary>
    protected override void intialize()
    {
      base.intialize();

      switch( TestResultValue )
      {
        case TestResultsEnum.Success:
          ImageKey = Defines.IMAGE_KEY_SUCCESS;
          SelectedImageKey = ImageKey;
          break;
        case TestResultsEnum.Failure:
        case TestResultsEnum.Error:
        case TestResultsEnum.Invalid:
          ImageKey = Defines.IMAGE_KEY_FAILURE;
          SelectedImageKey = ImageKey;
          break;
        case TestResultsEnum.Skipped:
          ImageKey = Defines.IMAGE_KEY_SKIPPED;
          SelectedImageKey = ImageKey;
          break;
        case TestResultsEnum.Ignored:
          ImageKey = Defines.IMAGE_KEY_IGNORED;
          SelectedImageKey = ImageKey;
          break;
        case TestResultsEnum.Inconclusive:
          ImageKey = Defines.IMAGE_KEY_INCONCLUSIVE;
          SelectedImageKey = ImageKey;
          break;

      }
    }
  }
}
