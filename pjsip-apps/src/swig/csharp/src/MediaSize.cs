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

public class MediaSize : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaSize(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaSize obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaSize() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaSize(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint w {
    set {
      pjsua2PINVOKE.MediaSize_w_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaSize_w_get(swigCPtr);
      return ret;
    } 
  }

  public uint h {
    set {
      pjsua2PINVOKE.MediaSize_h_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaSize_h_get(swigCPtr);
      return ret;
    } 
  }

  public MediaSize() : this(pjsua2PINVOKE.new_MediaSize(), true) {
  }

}

}
