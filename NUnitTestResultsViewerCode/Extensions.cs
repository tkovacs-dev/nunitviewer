using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NUnitTestResultsViewerCode
{
  /// <summary>
  /// Provides different extension methods.
  /// </summary>
  static class Extensions
  {
    /// <summary>
    /// Returns all tree nodes from treeview
    /// </summary>
    /// <param name="treeView"></param>
    /// <returns></returns>
    public static IEnumerable<TreeNode> GetAllNodes( this TreeView treeView )
    {
      List<TreeNode> nodes = new List<TreeNode>();

      getchildNodes( treeView.Nodes, nodes );

      return nodes;
    }

    private static void getchildNodes( TreeNodeCollection treeNodeCollection, List<TreeNode> nodes )
    {
      foreach ( TreeNode n in treeNodeCollection )
      {
        nodes.Add( n );
        getchildNodes( n.Nodes, nodes );
      }
    }
  }
}
