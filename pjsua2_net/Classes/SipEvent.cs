//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PJSIP {

public class SipEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SipEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public pjsip_event_id_e type {
    set {
      pjsua2PINVOKE.SipEvent_type_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_event_id_e ret = (pjsip_event_id_e)pjsua2PINVOKE.SipEvent_type_get(swigCPtr);
      return ret;
    } 
  }

  public SipEventBody body {
    set {
      pjsua2PINVOKE.SipEvent_body_set(swigCPtr, SipEventBody.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEvent_body_get(swigCPtr);
      SipEventBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipEventBody(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pjEvent {
    set {
      pjsua2PINVOKE.SipEvent_pjEvent_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEvent_pjEvent_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SipEvent() : this(pjsua2PINVOKE.new_SipEvent(), true) {
  }

}

}
