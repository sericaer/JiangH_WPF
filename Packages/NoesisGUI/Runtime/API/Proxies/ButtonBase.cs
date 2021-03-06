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
using System.Windows.Input;

namespace Noesis
{

public class ButtonBase : ContentControl {
  internal new static ButtonBase CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ButtonBase(cPtr, cMemoryOwn);
  }

  internal ButtonBase(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ButtonBase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ButtonBase() {
  }

  #region Routed Events
  public event RoutedEventHandler Click {
    add {
      AddHandler(NoesisGUI_PINVOKE.ButtonBase_ClickEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.ButtonBase_ClickEvent_get(), value);
    }
  }
  #endregion

  public ICommand Command {
    get {
      return (ICommand)GetCommandHelper();
    }
    set {
      SetCommandHelper(value);
    }
  }

  public static DependencyProperty ClickModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_ClickModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CommandProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_CommandProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CommandParameterProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_CommandParameterProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CommandTargetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_CommandTargetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsPressedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_IsPressedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ClickEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_ClickEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ClickMode ClickMode {
    set {
      NoesisGUI_PINVOKE.ButtonBase_ClickMode_set(swigCPtr, (int)value);
    } 
    get {
      ClickMode ret = (ClickMode)NoesisGUI_PINVOKE.ButtonBase_ClickMode_get(swigCPtr);
      return ret;
    } 
  }

  public object CommandParameter {
    set {
      NoesisGUI_PINVOKE.ButtonBase_CommandParameter_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_CommandParameter_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public UIElement CommandTarget {
    set {
      NoesisGUI_PINVOKE.ButtonBase_CommandTarget_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_CommandTarget_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsPressed {
    get {
      bool ret = NoesisGUI_PINVOKE.ButtonBase_IsPressed_get(swigCPtr);
      return ret;
    } 
  }

  private object GetCommandHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.ButtonBase_GetCommandHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private void SetCommandHelper(object command) {
    NoesisGUI_PINVOKE.ButtonBase_SetCommandHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(command));
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ButtonBase(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

