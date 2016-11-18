using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnitTestResultsViewerCode.Items;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace NUnitTestResultsViewerCode
{
  /// <summary>
  /// Reads testesults.xml file.
  /// </summary>
  class TestResultsReader
  {
    private const string TEST_RESULTS = "test-results";
    public static NUnitTestResults ReadTestResults( string filename )
    {
      if( !File.Exists( filename ) )
      {
        MessageBox.Show( "File not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        return null;
      }

      XElement root = null;

      try
      {
        root = XDocument.Load( filename ).Root;
      }
      catch( XmlException )
      {
        MessageBox.Show( "Can not read xml file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
        return null;
      }

      return NUnitTestResults.Load( root );
    }
  }
}
