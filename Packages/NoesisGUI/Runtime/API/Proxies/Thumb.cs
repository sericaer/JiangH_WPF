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

public class Thumb : Control {
  internal new static Thumb CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Thumb(cPtr, cMemoryOwn);
  }

  internal Thumb(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Thumb obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event DragCompletedEventHandler DragCompleted {
    add {
      AddHandler(NoesisGUI_PINVOKE.Thumb_DragCompletedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.Thumb_DragCompletedEvent_get(), value);
    }
  }

  public event DragDeltaEventHandler DragDelta {
    add {
      AddHandler(NoesisGUI_PINVOKE.Thumb_DragDeltaEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.Thumb_DragDeltaEvent_get(), value);
    }
  }

  public event DragStartedEventHandler DragStarted {
    add {
      AddHandler(NoesisGUI_PINVOKE.Thumb_DragStartedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.Thumb_DragStartedEvent_get(), value);
    }
  }

  #endregion

  public Thumb() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Thumb)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Thumb();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public void CancelDrag() {
    NoesisGUI_PINVOKE.Thumb_CancelDrag(swigCPtr);
  }

  public static DependencyProperty IsDraggingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Thumb_IsDraggingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragCompletedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Thumb_DragCompletedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragDeltaEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Thumb_DragDeltaEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragStartedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Thumb_DragStartedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsDragging {
    get {
      bool ret = NoesisGUI_PINVOKE.Thumb_IsDragging_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Thumb(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

