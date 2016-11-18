using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NUnitTestResultsViewerCode.Items
{
  /// <summary>
  /// Test results
  /// </summary>
  public enum TestResultsEnum
  {
    Success,
    Failure,
    Inconclusive,
    Ignored,
    Skipped,
    Invalid,
    Error,
  }

  /// <summary>
  /// Represent base test item class.
  /// </summary>
  public abstract class BaseItem : TreeNode
  {
    protected XElement _element = null;

    /// <summary>
    /// Initializes baseitem class.
    /// </summary>
    /// <param name="element"></param>
    protected BaseItem( XElement element )
    {
      _element = element;

      intialize();
    }

    /// <summary>
    /// Initialize with default values.
    /// </summary>
    protected virtual void intialize()
    {
      Name = _element.Attribute( "name" ).Value;
      Text = Name;
    }

    ///// <summary>
    ///// Result of test
    ///// </summary>
    //public TestResultsEnum TestResult
    //{
    //  get;
    //  set;
    //}

    /// <summary>
    /// Add item as child element.
    /// </summary>
    /// <param name="item"></param>
    public virtual void Add( BaseItem item )
    {
      this.Nodes.Add( item );
    }

    /// <summary>
    /// Read attribute from node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="nodeName"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    protected object readAttribute<T>( string attributeName )
    {
      var attr = _element.Attribute( attributeName );
      if( null == attr )
      {
        throw new ArgumentException( "Attribute not found" );
      }

      if( typeof( T ) == typeof( string ) )
      {
        return attr.Value;
      }
      else if( typeof( T ).IsEnum )
      {
        if( !Enum.IsDefined( typeof( T ), attr.Value ) )
        {
          throw new InvalidCastException( "Can not cast value to specified enum." );
        }
        return Enum.Parse( typeof( T ), attr.Value );
      }
      else
      {
        var method = typeof( T ).GetMethod( "Parse", new Type[] { typeof( string ) } );
        if( null == method )
        {
          throw new NotSupportedException( "Unsupported type." );
        }
        return method.Invoke( null, new[] { attr.Value } );
      }

      throw new NotSupportedException( "Unsupported type." );
    }
  }
}
