//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PJSIP {

public class CallMediaInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CallMediaInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CallMediaInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CallMediaInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_CallMediaInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint index {
    set {
      pjsua2PINVOKE.CallMediaInfo_index_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallMediaInfo_index_get(swigCPtr);
      return ret;
    } 
  }

  public pjmedia_type type {
    set {
      pjsua2PINVOKE.CallMediaInfo_type_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_type ret = (pjmedia_type)pjsua2PINVOKE.CallMediaInfo_type_get(swigCPtr);
      return ret;
    } 
  }

  public pjmedia_dir dir {
    set {
      pjsua2PINVOKE.CallMediaInfo_dir_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_dir ret = (pjmedia_dir)pjsua2PINVOKE.CallMediaInfo_dir_get(swigCPtr);
      return ret;
    } 
  }

  public pjsua_call_media_status status {
    set {
      pjsua2PINVOKE.CallMediaInfo_status_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_call_media_status ret = (pjsua_call_media_status)pjsua2PINVOKE.CallMediaInfo_status_get(swigCPtr);
      return ret;
    } 
  }

  public int audioConfSlot {
    set {
      pjsua2PINVOKE.CallMediaInfo_audioConfSlot_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.CallMediaInfo_audioConfSlot_get(swigCPtr);
      return ret;
    } 
  }

  public int videoIncomingWindowId {
    set {
      pjsua2PINVOKE.CallMediaInfo_videoIncomingWindowId_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.CallMediaInfo_videoIncomingWindowId_get(swigCPtr);
      return ret;
    } 
  }

  public VideoWindow videoWindow {
    set {
      pjsua2PINVOKE.CallMediaInfo_videoWindow_set(swigCPtr, VideoWindow.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.CallMediaInfo_videoWindow_get(swigCPtr);
      VideoWindow ret = (cPtr == global::System.IntPtr.Zero) ? null : new VideoWindow(cPtr, false);
      return ret;
    } 
  }

  public int videoCapDev {
    set {
      pjsua2PINVOKE.CallMediaInfo_videoCapDev_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.CallMediaInfo_videoCapDev_get(swigCPtr);
      return ret;
    } 
  }

  public CallMediaInfo() : this(pjsua2PINVOKE.new_CallMediaInfo(), true) {
  }

}

}
