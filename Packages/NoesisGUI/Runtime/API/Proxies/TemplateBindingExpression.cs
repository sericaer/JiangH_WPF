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

public class TemplateBindingExpression : Expression {
  internal new static TemplateBindingExpression CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TemplateBindingExpression(cPtr, cMemoryOwn);
  }

  internal TemplateBindingExpression(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TemplateBindingExpression obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected TemplateBindingExpression() {
  }

  public TemplateBindingExtension TemplateBindingExtension {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TemplateBindingExpression_TemplateBindingExtension_get(swigCPtr);
      TemplateBindingExtension ret = (cPtr == IntPtr.Zero) ? null : new TemplateBindingExtension(cPtr, false);
      return ret;
    } 
  }

}

}

