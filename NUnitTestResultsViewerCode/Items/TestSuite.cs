using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace NUnitTestResultsViewerCode.Items
{
  /// <summary>
  /// Represent test suite class.
  /// </summary>
  class TestSuite : TestResult
  {
    /// <summary>
    /// Initializes testsuite class.
    /// </summary>
    /// <param name="element"></param>
    private TestSuite( XElement element )
      : base( element )
    {
    }

    /// <summary>
    /// Load test suite
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static TestSuite Load( XElement element )
    {
      var testsuite = new TestSuite( element );

      foreach( var res in element.Elements( "results" ) )
      {
        foreach( var el in res.Elements( "test-suite" ) )
        {
          testsuite.Add( TestSuite.Load( el ) );
        }
        foreach( var el in res.Elements( "test-case" ) )
        {
          testsuite.Add( TestCase.Load( el ) );
        }
      }

      return testsuite;
    }
  }
}
