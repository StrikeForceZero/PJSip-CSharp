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

public class VideoDevInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VideoDevInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VideoDevInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VideoDevInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_VideoDevInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int id {
    set {
      pjsua2PINVOKE.VideoDevInfo_id_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.VideoDevInfo_id_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      pjsua2PINVOKE.VideoDevInfo_name_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.VideoDevInfo_name_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string driver {
    set {
      pjsua2PINVOKE.VideoDevInfo_driver_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.VideoDevInfo_driver_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pjmedia_dir dir {
    set {
      pjsua2PINVOKE.VideoDevInfo_dir_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_dir ret = (pjmedia_dir)pjsua2PINVOKE.VideoDevInfo_dir_get(swigCPtr);
      return ret;
    } 
  }

  public uint caps {
    set {
      pjsua2PINVOKE.VideoDevInfo_caps_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.VideoDevInfo_caps_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_pj__MediaFormat_t fmt {
    set {
      pjsua2PINVOKE.VideoDevInfo_fmt_set(swigCPtr, SWIGTYPE_p_std__vectorT_pj__MediaFormat_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.VideoDevInfo_fmt_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_pj__MediaFormat_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_pj__MediaFormat_t(cPtr, false);
      return ret;
    } 
  }

  public VideoDevInfo() : this(pjsua2PINVOKE.new_VideoDevInfo(), true) {
  }

}

}
