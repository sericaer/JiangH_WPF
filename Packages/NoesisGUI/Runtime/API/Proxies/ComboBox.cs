//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class ComboBox : Selector {
  internal new static ComboBox CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ComboBox(cPtr, cMemoryOwn);
  }

  internal ComboBox(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ComboBox obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ComboBox() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ComboBox)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ComboBox();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public void ScrollIntoView(object item) {
    NoesisGUI_PINVOKE.ComboBox_ScrollIntoView(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
  }

  public static DependencyProperty IsDropDownOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_IsDropDownOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsEditableProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_IsEditableProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsReadOnlyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_IsReadOnlyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MaxDropDownHeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_MaxDropDownHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlaceholderProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_PlaceholderProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SelectionBoxItemProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_SelectionBoxItemProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SelectionBoxItemTemplateProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_SelectionBoxItemTemplateProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StaysOpenOnEditProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_StaysOpenOnEditProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_TextProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsDropDownOpen {
    set {
      NoesisGUI_PINVOKE.ComboBox_IsDropDownOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ComboBox_IsDropDownOpen_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEditable {
    set {
      NoesisGUI_PINVOKE.ComboBox_IsEditable_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ComboBox_IsEditable_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsReadOnly {
    set {
      NoesisGUI_PINVOKE.ComboBox_IsReadOnly_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ComboBox_IsReadOnly_get(swigCPtr);
      return ret;
    } 
  }

  public float MaxDropDownHeight {
    set {
      NoesisGUI_PINVOKE.ComboBox_MaxDropDownHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.ComboBox_MaxDropDownHeight_get(swigCPtr);
      return ret;
    } 
  }

  public object SelectionBoxItem {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_SelectionBoxItem_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public DataTemplate SelectionBoxItemTemplate {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ComboBox_SelectionBoxItemTemplate_get(swigCPtr);
      return (DataTemplate)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool StaysOpenOnEdit {
    set {
      NoesisGUI_PINVOKE.ComboBox_StaysOpenOnEdit_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ComboBox_StaysOpenOnEdit_get(swigCPtr);
      return ret;
    } 
  }

  public string Text {
    set {
      NoesisGUI_PINVOKE.ComboBox_Text_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.ComboBox_Text_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public string Placeholder {
    set {
      NoesisGUI_PINVOKE.ComboBox_Placeholder_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.ComboBox_Placeholder_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ComboBox(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

