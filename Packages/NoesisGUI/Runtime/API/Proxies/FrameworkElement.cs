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

public partial class FrameworkElement : UIElement {
  internal new static FrameworkElement CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new FrameworkElement(cPtr, cMemoryOwn);
  }

  internal FrameworkElement(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(FrameworkElement obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  public event ContextMenuEventHandler ContextMenuClosing {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_ContextMenuClosingEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_ContextMenuClosingEvent_get(), value);
    }
  }

  public event ContextMenuEventHandler ContextMenuOpening {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_ContextMenuOpeningEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_ContextMenuOpeningEvent_get(), value);
    }
  }

  public event RoutedEventHandler Loaded {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_LoadedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_LoadedEvent_get(), value);
    }
  }

  public event RoutedEventHandler Reloaded {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_ReloadedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_ReloadedEvent_get(), value);
    }
  }

  public event RequestBringIntoViewEventHandler RequestBringIntoView {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_RequestBringIntoViewEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_RequestBringIntoViewEvent_get(), value);
    }
  }

  public event SizeChangedEventHandler SizeChanged {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_SizeChangedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_SizeChangedEvent_get(), value);
    }
  }

  public event ToolTipEventHandler ToolTipClosing {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_ToolTipClosingEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_ToolTipClosingEvent_get(), value);
    }
  }

  public event ToolTipEventHandler ToolTipOpening {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_ToolTipOpeningEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_ToolTipOpeningEvent_get(), value);
    }
  }

  public event RoutedEventHandler Unloaded {
    add {
      AddHandler(NoesisGUI_PINVOKE.FrameworkElement_UnloadedEvent_get(), value);
    }
    remove {
      RemoveHandler(NoesisGUI_PINVOKE.FrameworkElement_UnloadedEvent_get(), value);
    }
  }

  public event DependencyPropertyChangedEventHandler DataContextChanged {
    add {
      AddEventHandler("DataContextChanged", value);
    }
    remove {
      RemoveEventHandler("DataContextChanged", value);
    }
  }

  public event EventHandler Initialized {
    add {
      AddEventHandler("Initialized", value);
    }
    remove {
      RemoveEventHandler("Initialized", value);
    }
  }

  #endregion

  public FrameworkElement() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(FrameworkElement)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_FrameworkElement();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static FlowDirection GetFlowDirection(DependencyObject d) {
    FlowDirection ret = (FlowDirection)NoesisGUI_PINVOKE.FrameworkElement_GetFlowDirection(DependencyObject.getCPtr(d));
    return ret;
  }

  public static void SetFlowDirection(DependencyObject d, FlowDirection flowDirection) {
    NoesisGUI_PINVOKE.FrameworkElement_SetFlowDirection(DependencyObject.getCPtr(d), (int)flowDirection);
  }

  public BindingExpression GetBindingExpression(DependencyProperty dp) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_GetBindingExpression(swigCPtr, DependencyProperty.getCPtr(dp));
    return (BindingExpression)Noesis.Extend.GetProxy(cPtr, false);
  }

  public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_SetBinding__SWIG_0(swigCPtr, DependencyProperty.getCPtr(dp), BindingBase.getCPtr(binding));
    BindingExpressionBase ret = (cPtr == IntPtr.Zero) ? null : new BindingExpressionBase(cPtr, false);
    return ret;
  }

  public BindingExpression SetBinding(DependencyProperty dp, string path) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_SetBinding__SWIG_1(swigCPtr, DependencyProperty.getCPtr(dp), path != null ? path : string.Empty);
    return (BindingExpression)Noesis.Extend.GetProxy(cPtr, false);
  }

  public void BringIntoView() {
    NoesisGUI_PINVOKE.FrameworkElement_BringIntoView__SWIG_0(swigCPtr);
  }

  public void BringIntoView(Rect targetRectangle) {
    NoesisGUI_PINVOKE.FrameworkElement_BringIntoView__SWIG_1(swigCPtr, ref targetRectangle);
  }

  public bool ApplyTemplate() {
    bool ret = NoesisGUI_PINVOKE.FrameworkElement_ApplyTemplate(swigCPtr);
    return ret;
  }

  public object GetTemplateChild(string name) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_GetTemplateChild(swigCPtr, name != null ? name : string.Empty);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public object FindName(string name) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_FindName(swigCPtr, name != null ? name : string.Empty);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  public void RegisterName(string name, object arg1) {
    NoesisGUI_PINVOKE.FrameworkElement_RegisterName(swigCPtr, name != null ? name : string.Empty, Noesis.Extend.GetInstanceHandle(arg1));
  }

  public void UnregisterName(string name) {
    NoesisGUI_PINVOKE.FrameworkElement_UnregisterName(swigCPtr, name != null ? name : string.Empty);
  }

  public void UpdateName(string name, object arg1) {
    NoesisGUI_PINVOKE.FrameworkElement_UpdateName(swigCPtr, name != null ? name : string.Empty, Noesis.Extend.GetInstanceHandle(arg1));
  }

  public override sealed bool MoveFocus(TraversalRequest request) {
    bool ret = NoesisGUI_PINVOKE.FrameworkElement_MoveFocus(swigCPtr, TraversalRequest.getCPtr(request));
    return ret;
  }

  public override sealed DependencyObject PredictFocus(FocusNavigationDirection direction) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_PredictFocus(swigCPtr, (int)direction);
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  public static DependencyProperty ActualHeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ActualHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ActualWidthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ActualWidthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BlendingModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_BlendingModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ContextMenuProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ContextMenuProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CursorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_CursorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DataContextProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_DataContextProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty DefaultStyleKeyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_DefaultStyleKeyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FlowDirectionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_FlowDirectionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FocusVisualStyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_FocusVisualStyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ForceCursorProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ForceCursorProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_HeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HorizontalAlignmentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_HorizontalAlignmentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty InputScopeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_InputScopeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty LayoutTransformProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_LayoutTransformProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MarginProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_MarginProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MaxHeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_MaxHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MaxWidthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_MaxWidthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MinHeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_MinHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MinWidthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_MinWidthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty NameProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_NameProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OverridesDefaultStyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_OverridesDefaultStyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PPAAModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_PPAAModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PPAAInProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_PPAAInProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PPAAOutProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_PPAAOutProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_StyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TagProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_TagProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ToolTipProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ToolTipProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty UseLayoutRoundingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_UseLayoutRoundingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty VerticalAlignmentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_VerticalAlignmentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty WidthProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_WidthProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ContextMenuClosingEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ContextMenuClosingEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ContextMenuOpeningEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ContextMenuOpeningEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent LoadedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_LoadedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ReloadedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ReloadedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent RequestBringIntoViewEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_RequestBringIntoViewEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent SizeChangedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_SizeChangedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ToolTipClosingEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ToolTipClosingEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent ToolTipOpeningEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ToolTipOpeningEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent UnloadedEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_UnloadedEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float ActualHeight {
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_ActualHeight_get(swigCPtr);
      return ret;
    } 
  }

  public float ActualWidth {
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_ActualWidth_get(swigCPtr);
      return ret;
    } 
  }

  public BlendingMode BlendingMode {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_BlendingMode_set(swigCPtr, (int)value);
    } 
    get {
      BlendingMode ret = (BlendingMode)NoesisGUI_PINVOKE.FrameworkElement_BlendingMode_get(swigCPtr);
      return ret;
    } 
  }

  public ContextMenu ContextMenu {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_ContextMenu_set(swigCPtr, ContextMenu.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ContextMenu_get(swigCPtr);
      return (ContextMenu)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Cursor Cursor {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Cursor_set(swigCPtr, (int)value);
    } 
    get {
      Cursor ret = (Cursor)NoesisGUI_PINVOKE.FrameworkElement_Cursor_get(swigCPtr);
      return ret;
    } 
  }

  public object DataContext {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_DataContext_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_DataContext_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Type DefaultStyleKey {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_DefaultStyleKey_set(swigCPtr, value != null ? Noesis.Extend.EnsureNativeType(value) : IntPtr.Zero);
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_DefaultStyleKey_get(swigCPtr);
      if (cPtr != IntPtr.Zero) {
        Noesis.Extend.NativeTypeInfo info = Noesis.Extend.GetNativeTypeInfo(cPtr);
        return info.Type;
      }
      return null;
    }
  }

  public FlowDirection FlowDirection {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_FlowDirection_set(swigCPtr, (int)value);
    } 
    get {
      FlowDirection ret = (FlowDirection)NoesisGUI_PINVOKE.FrameworkElement_FlowDirection_get(swigCPtr);
      return ret;
    } 
  }

  public Style FocusVisualStyle {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_FocusVisualStyle_set(swigCPtr, Style.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_FocusVisualStyle_get(swigCPtr);
      return (Style)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool ForceCursor {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_ForceCursor_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.FrameworkElement_ForceCursor_get(swigCPtr);
      return ret;
    } 
  }

  public float Height {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Height_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_Height_get(swigCPtr);
      return ret;
    } 
  }

  public HorizontalAlignment HorizontalAlignment {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_HorizontalAlignment_set(swigCPtr, (int)value);
    } 
    get {
      HorizontalAlignment ret = (HorizontalAlignment)NoesisGUI_PINVOKE.FrameworkElement_HorizontalAlignment_get(swigCPtr);
      return ret;
    } 
  }

  public InputScope InputScope {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_InputScope_set(swigCPtr, (int)value);
    } 
    get {
      InputScope ret = (InputScope)NoesisGUI_PINVOKE.FrameworkElement_InputScope_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsInitialized {
    get {
      bool ret = NoesisGUI_PINVOKE.FrameworkElement_IsInitialized_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsLoaded {
    get {
      bool ret = NoesisGUI_PINVOKE.FrameworkElement_IsLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public Transform LayoutTransform {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_LayoutTransform_set(swigCPtr, Transform.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_LayoutTransform_get(swigCPtr);
      return (Transform)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Thickness Margin {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Margin_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.FrameworkElement_Margin_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Thickness>(ret);
      }
      else {
        return new Thickness();
      }
    }

  }

  public float MaxHeight {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_MaxHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_MaxHeight_get(swigCPtr);
      return ret;
    } 
  }

  public float MaxWidth {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_MaxWidth_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_MaxWidth_get(swigCPtr);
      return ret;
    } 
  }

  public float MinHeight {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_MinHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_MinHeight_get(swigCPtr);
      return ret;
    } 
  }

  public float MinWidth {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_MinWidth_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_MinWidth_get(swigCPtr);
      return ret;
    } 
  }

  public string Name {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Name_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.FrameworkElement_Name_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public bool OverridesDefaultStyle {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_OverridesDefaultStyle_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.FrameworkElement_OverridesDefaultStyle_get(swigCPtr);
      return ret;
    } 
  }

  public PPAAMode PPAAMode {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_PPAAMode_set(swigCPtr, (int)value);
    } 
    get {
      PPAAMode ret = (PPAAMode)NoesisGUI_PINVOKE.FrameworkElement_PPAAMode_get(swigCPtr);
      return ret;
    } 
  }

  public float PPAAIn {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_PPAAIn_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_PPAAIn_get(swigCPtr);
      return ret;
    } 
  }

  public float PPAAOut {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_PPAAOut_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_PPAAOut_get(swigCPtr);
      return ret;
    } 
  }

  public Style Style {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Style_set(swigCPtr, Style.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_Style_get(swigCPtr);
      return (Style)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public object Tag {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Tag_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_Tag_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public object ToolTip {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_ToolTip_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_ToolTip_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool UseLayoutRounding {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_UseLayoutRounding_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.FrameworkElement_UseLayoutRounding_get(swigCPtr);
      return ret;
    } 
  }

  public VerticalAlignment VerticalAlignment {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_VerticalAlignment_set(swigCPtr, (int)value);
    } 
    get {
      VerticalAlignment ret = (VerticalAlignment)NoesisGUI_PINVOKE.FrameworkElement_VerticalAlignment_get(swigCPtr);
      return ret;
    } 
  }

  public float Width {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Width_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.FrameworkElement_Width_get(swigCPtr);
      return ret;
    } 
  }

  public TriggerCollection Triggers {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_Triggers_get(swigCPtr);
      return (TriggerCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FrameworkElement Parent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_Parent_get(swigCPtr);
      return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FrameworkElement TemplatedParent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_TemplatedParent_get(swigCPtr);
      return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ResourceDictionary Resources {
    set {
      NoesisGUI_PINVOKE.FrameworkElement_Resources_set(swigCPtr, ResourceDictionary.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_Resources_get(swigCPtr);
      return (ResourceDictionary)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static FrameworkElement FindTreeElement(object instance) {
    IntPtr cPtr = NoesisGUI_PINVOKE.FrameworkElement_FindTreeElement(Noesis.Extend.GetInstanceHandle(instance));
    return (FrameworkElement)Noesis.Extend.GetProxy(cPtr, false);
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_FrameworkElement(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}
