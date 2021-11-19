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
using System.Collections.Generic;

namespace Noesis
{

public static class DragDrop {
  public static void DoDragDrop(DependencyObject dragSource, object data, DragDropEffects allowedEffects,
    DragDropCompletedCallback onDragDropCompleted) {
    DragDropCallbackInfo info = new DragDropCallbackInfo { Callback = onDragDropCompleted };
    int callbackId = info.GetHashCode();
    _dragDropCallbacks[callbackId] = info;
    DoDragDropHelper(dragSource, data, allowedEffects, callbackId, _dragDropCompleted);
  }

  #region DragDrop callback
  private delegate void Callback_DragDropCompleted(int callbackId, IntPtr source,
    IntPtr data, IntPtr target, IntPtr dropPoint, int effects);
  private static Callback_DragDropCompleted _dragDropCompleted = OnDragDropCompleted;

  [MonoPInvokeCallback(typeof(Callback_DragDropCompleted))]
  private static void OnDragDropCompleted(int callbackId, IntPtr source,
    IntPtr data, IntPtr target, IntPtr dropPoint, int effects) {
    try {
      DragDropCallbackInfo info = _dragDropCallbacks[callbackId];
      info.Callback((DependencyObject)Extend.GetProxy(source, false),
        new DataObject(Extend.GetProxy(data, false)), (UIElement)Extend.GetProxy(target, false),
        Marshal.PtrToStructure<Point>(dropPoint), (DragDropEffects)effects);
      _dragDropCallbacks.Remove(callbackId);
    }
    catch (Exception e) {
      Noesis.Error.UnhandledException(e);
    }
  }

  private static void DoDragDropHelper(DependencyObject source, object data,
    DragDropEffects allowedEffects, int callbackId, Callback_DragDropCompleted callback) {
    DragDrop_DoDragDrop(DependencyObject.getCPtr(source), Extend.GetInstanceHandle(data),
    (int)allowedEffects, callbackId, callback);
  }

  [DllImport(Library.Name)]
  private static extern void DragDrop_DoDragDrop(HandleRef source, HandleRef data, int allowedEffects,
    int callbackId, Callback_DragDropCompleted callback);

  private struct DragDropCallbackInfo {
    public DragDropCompletedCallback Callback { get; set; }
  }

  private static Dictionary<int, DragDropCallbackInfo> _dragDropCallbacks =
    new Dictionary<int, DragDropCallbackInfo>();
  #endregion

  public static RoutedEvent PreviewQueryContinueDragEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewQueryContinueDragEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent QueryContinueDragEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_QueryContinueDragEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewGiveFeedbackEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewGiveFeedbackEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent GiveFeedbackEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_GiveFeedbackEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewDragEnterEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewDragEnterEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragEnterEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_DragEnterEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewDragOverEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewDragOverEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragOverEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_DragOverEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewDragLeaveEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewDragLeaveEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DragLeaveEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_DragLeaveEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewDropEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_PreviewDropEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent DropEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DragDrop_DropEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

