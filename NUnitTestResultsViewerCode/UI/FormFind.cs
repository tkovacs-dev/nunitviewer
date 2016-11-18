using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NUnitTestResultsViewerCode.Properties;
using System.Text.RegularExpressions;

namespace NUnitTestResultsViewerCode.UI
{
  public partial class FormFind : Form
  {
    private TreeView _treeView;
    private TreeNode[] _foundNodes = null;
    private int _currentIndex = -1;

    public FormFind( TreeView treeView )
    {
      InitializeComponent();

      this._treeView = treeView;
      this.Icon = Icon.FromHandle( Resources.find.GetHicon() );
    }

    private void btnHightlight_Click( object sender, EventArgs e )
    {
      btnClear_Click( sender, e );
      foreach ( var n in getResults() )
      {
        higlight( n );
      }
    }

    private void btnClear_Click( object sender, EventArgs e )
    {
      foreach ( var n in _treeView.GetAllNodes() )
      {
        dehiglight( n );
      }
    }

    private TreeNode[] getResults()
    {
      if ( null == _foundNodes )
      {
        List<TreeNode> list = new List<TreeNode>();

        foreach ( TreeNode n in _treeView.GetAllNodes() )
        {
          if ( chkWholeWord.Checked && string.Compare( n.Text, txtSearchFor.Text, !chkMatchCase.Checked ) == 0 )
          {
            list.Add( n );
            continue;
          }

          if ( !chkWholeWord.Checked && n.Text.IndexOf( txtSearchFor.Text, chkMatchCase.Checked ? StringComparison.InvariantCulture : StringComparison.InvariantCultureIgnoreCase ) >= 0 )
          {
            list.Add( n );
            continue;
          }
        }

        _foundNodes = list.ToArray();
      }
      return _foundNodes;
    }

    private void txtSearchFor_TextChanged( object sender, EventArgs e )
    {
      _foundNodes = null;
    }

    private void btnFindNext_Click( object sender, EventArgs e )
    {
      if ( getResults().Length > _currentIndex && _currentIndex >= 0 )
      {
        dehiglight( getResults()[_currentIndex] );
      }
      else
      {
        btnClear_Click( sender, e );
      }

      if ( _currentIndex + 1 == getResults().Length )
      {
        _currentIndex = -1;
      }

      for ( int i = _currentIndex + 1; i < getResults().Length; i++ )
      {
        if ( null == getResults()[i].TreeView )
        {
          continue;
        }

        _treeView.SelectedNode = null;
        _treeView.SelectedNode = getResults()[i];
        _treeView.SelectedNode.EnsureVisible();
        _treeView.SelectedNode = null;

        higlight( getResults()[i] );

        _currentIndex = i;
        return;
      }

      _currentIndex = -1;
    }

    private void higlight( TreeNode node )
    {
      if ( null != node )
      {
        node.BackColor = Color.Gold;
      }
    }

    private void dehiglight( TreeNode node )
    {
      if ( null != node )
      {
        node.ForeColor = Color.Black;
        node.BackColor = Color.White;
      }
    }

    private void chkMatchCase_CheckedChanged( object sender, EventArgs e )
    {
      _foundNodes = null;
    }

    private void chkWholeWord_CheckedChanged( object sender, EventArgs e )
    {
      _foundNodes = null;
    }

    private void txtSearchFor_KeyDown( object sender, KeyEventArgs e )
    {
      if ( e.KeyCode == Keys.Enter )
      {
        btnFindNext_Click( sender, e );
      }
    }

  }
}
