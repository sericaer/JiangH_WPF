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

public class ToolTip : ContentControl {
  internal new static ToolTip CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ToolTip(cPtr, cMemoryOwn);
  }

  internal ToolTip(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ToolTip obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event RoutedEventHandler Closed {
    add {
      AddHandler(NoesisGUI_PINVOKE.ToolTip_ClosedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.ToolTip_ClosedEvent_get(), value);
    }
  }

  public event RoutedEventHandler Opened {
    add {
      AddHandler(NoesisGUI_PINVOKE.ToolTip_OpenedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.ToolTip_OpenedEvent_get(), value);
    }
  }

  #endregion

  public ToolTip() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ToolTip)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ToolTip();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public Popup GetPopup() {
    IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_GetPopup(swigCPtr);
    return (Popup)Noesis.Extend.GetProxy(cPtr, false);
  }

  public static DependencyProperty HasDropShadowProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_HasDropShadowProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HorizontalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_HorizontalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_IsOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_PlacementProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementRectangleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_PlacementRectangleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementTargetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_PlacementTargetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StaysOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_StaysOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty VerticalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_VerticalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ClosedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_ClosedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent OpenedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_OpenedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool HasDropShadow {
    set {
      NoesisGUI_PINVOKE.ToolTip_HasDropShadow_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ToolTip_HasDropShadow_get(swigCPtr);
      return ret;
    } 
  }

  public float HorizontalOffset {
    set {
      NoesisGUI_PINVOKE.ToolTip_HorizontalOffset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.ToolTip_HorizontalOffset_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsOpen {
    set {
      NoesisGUI_PINVOKE.ToolTip_IsOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ToolTip_IsOpen_get(swigCPtr);
      return ret;
    } 
  }

  public PlacementMode Placement {
    set {
      NoesisGUI_PINVOKE.ToolTip_Placement_set(swigCPtr, (int)value);
    } 
    get {
      PlacementMode ret = (PlacementMode)NoesisGUI_PINVOKE.ToolTip_Placement_get(swigCPtr);
      return ret;
    } 
  }

  public Rect PlacementRectangle {
    set {
      NoesisGUI_PINVOKE.ToolTip_PlacementRectangle_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.ToolTip_PlacementRectangle_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }

  }

  public UIElement PlacementTarget {
    set {
      NoesisGUI_PINVOKE.ToolTip_PlacementTarget_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolTip_PlacementTarget_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool StaysOpen {
    set {
      NoesisGUI_PINVOKE.ToolTip_StaysOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ToolTip_StaysOpen_get(swigCPtr);
      return ret;
    } 
  }

  public float VerticalOffset {
    set {
      NoesisGUI_PINVOKE.ToolTip_VerticalOffset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.ToolTip_VerticalOffset_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ToolTip(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

