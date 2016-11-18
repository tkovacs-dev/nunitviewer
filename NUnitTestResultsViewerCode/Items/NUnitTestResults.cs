using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace NUnitTestResultsViewerCode.Items
{
  /// <summary>
  /// Provides root element for test-cases results.
  /// </summary>
  public class NUnitTestResults : BaseItem
  {
    #region Constructor

    /// <summary>
    /// Initializes TestResults class.
    /// </summary>
    /// <param name="element"></param>
    private NUnitTestResults( XElement element )
      : base( element )
    {

    }

    /// <summary>
    /// Load test result from xml.
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static NUnitTestResults Load( XElement element )
    {
      var testresult = new NUnitTestResults( element );

      foreach( var el in element.Elements( "test-suite" ) )
      {
        var testsuite = TestSuite.Load( el );
        testresult.Add( testsuite );
      }

      return testresult;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Get/Set total cases count.
    /// </summary>
    public int TotalCount
    {
      get
      {
        return (int)readAttribute<int>( "total" );
      }
    }

    /// <summary>
    /// Get/Set error cases count.
    /// </summary>
    public int ErrorsCount
    {
      get
      {
        return (int)readAttribute<int>( "errors" );
      }
    }

    /// <summary>
    /// Get/Set failure tests count.
    /// </summary>
    public int FailuresCount
    {
      get
      {
        return (int)readAttribute<int>( "failures" );
      }
    }

    /// <summary>
    /// Get/Set not runned tests count.
    /// </summary>
    public int NotRunCount
    {
      get
      {
        return (int)readAttribute<int>( "not-run" );
      }
    }

    /// <summary>
    /// Get/Set Inconclusive tests count
    /// </summary>   
    public int InconclusiveCount
    {
      get
      {
        return (int)readAttribute<int>( "inconclusive" );
      }
    }

    /// <summary>
    /// Get/Set ignored tests count.
    /// </summary>
    public int IgnoredCount
    {
      get
      {
        return (int)readAttribute<int>( "ignored" );
      }
    }

    /// <summary>
    /// Get/Set Skipped tests count.
    /// </summary>
    public int SkippedCount
    {
      get
      {
        return (int)readAttribute<int>( "skipped" );
      }
    }

    /// <summary>
    /// Get/Set Invalid tests count.
    /// </summary>
    public int InvalidCount
    {
      get
      {
        return (int)readAttribute<int>( "invalid" );
      }
    }

    /// <summary>
    /// Get/Set test runs date time.
    /// </summary>
    public DateTime DateTime
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    #endregion

    protected override void intialize()
    {
      base.intialize();

      if( FailuresCount > 0 || ErrorsCount > 0 || InvalidCount > 0 )
      {
        ImageKey = Defines.IMAGE_KEY_FAILURE;
      }
      else if( IgnoredCount > 0 )
      {
        ImageKey = Defines.IMAGE_KEY_IGNORED;
      }
      else if( SkippedCount > 0 )
      {
        ImageKey = Defines.IMAGE_KEY_SKIPPED;
      }
      else if( InconclusiveCount > 0 )
      {
        ImageKey = Defines.IMAGE_KEY_INCONCLUSIVE;
      }
      else
      {
        ImageKey = Defines.IMAGE_KEY_SUCCESS;
      }
      SelectedImageKey = ImageKey;
    }
  }
}
