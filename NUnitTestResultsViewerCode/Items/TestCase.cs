using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace NUnitTestResultsViewerCode.Items
{
  class TestCase : TestResult
  {
    /// <summary>
    /// Initializes TestCase class.
    /// </summary>
    /// <param name="element"></param>
    private TestCase( XElement element )
      : base( element )
    {
    }

    /// <summary>
    /// Load test case.
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    public static TestCase Load( XElement element )
    {
      return new TestCase( element );
    }

    /// <summary>
    /// Test Case output message.
    /// </summary>
    public string Message
    {
      get
      {
        return readDescenadantNodeValue( "message" );
      }
    }

    /// <summary>
    /// Message stack trace.
    /// </summary>
    public string StackTrace
    {
      get
      {
        return readDescenadantNodeValue( "stack-trace" );
      }
    }

    private string readDescenadantNodeValue( string nodename )
    {
      var node = _element.Descendants( nodename ).FirstOrDefault();
      if( null == node )
      {
        return string.Empty;
      }
      return node.Value;
    }

    /// <summary>
    /// Throw an InvalidOperationException. Test Cases can not have child elements.
    /// </summary>
    /// <param name="item"></param>
    public override void Add( BaseItem item )
    {
      throw new InvalidOperationException( "Test Cases could not contains child elements." );
    }
  }
}
