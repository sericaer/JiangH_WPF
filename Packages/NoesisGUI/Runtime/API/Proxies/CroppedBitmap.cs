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

public class CroppedBitmap : BitmapSource {
  internal new static CroppedBitmap CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new CroppedBitmap(cPtr, cMemoryOwn);
  }

  internal CroppedBitmap(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(CroppedBitmap obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public CroppedBitmap() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(CroppedBitmap)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_CroppedBitmap__SWIG_0();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public CroppedBitmap(BitmapSource source, Int32Rect sourceRect) : this(NoesisGUI_PINVOKE.new_CroppedBitmap__SWIG_1(BitmapSource.getCPtr(source), ref sourceRect), true) {
  }

  public static DependencyProperty SourceProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CroppedBitmap_SourceProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SourceRectProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CroppedBitmap_SourceRectProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public BitmapSource Source {
    set {
      NoesisGUI_PINVOKE.CroppedBitmap_Source_set(swigCPtr, BitmapSource.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CroppedBitmap_Source_get(swigCPtr);
      return (BitmapSource)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Int32Rect SourceRect {
    set {
      NoesisGUI_PINVOKE.CroppedBitmap_SourceRect_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.CroppedBitmap_SourceRect_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Int32Rect>(ret);
      }
      else {
        return new Int32Rect();
      }
    }

  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_CroppedBitmap(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

