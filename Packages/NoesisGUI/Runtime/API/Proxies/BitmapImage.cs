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

public class BitmapImage : BitmapSource {
  internal new static BitmapImage CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BitmapImage(cPtr, cMemoryOwn);
  }

  internal BitmapImage(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BitmapImage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public BitmapImage(Uri uriSource) {
    UriSource = uriSource;
  }

  public BitmapImage() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_BitmapImage();
  }

  public static DependencyProperty UriSourceProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BitmapImage_UriSourceProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Uri UriSource {
    set {
      NoesisGUI_PINVOKE.BitmapImage_UriSource_set(swigCPtr, value != null ? value.OriginalString : string.Empty);
    }
    get {
      IntPtr uriPtr = NoesisGUI_PINVOKE.BitmapImage_UriSource_get(swigCPtr);
      string uri = Noesis.Extend.StringFromNativeUtf8(uriPtr);
      return new Uri(uri, UriKind.RelativeOrAbsolute);
    }
  }

}

}

