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

public class IpChangeParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IpChangeParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IpChangeParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IpChangeParam() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_IpChangeParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool restartListener {
    set {
      pjsua2PINVOKE.IpChangeParam_restartListener_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.IpChangeParam_restartListener_get(swigCPtr);
      return ret;
    } 
  }

  public uint restartLisDelay {
    set {
      pjsua2PINVOKE.IpChangeParam_restartLisDelay_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.IpChangeParam_restartLisDelay_get(swigCPtr);
      return ret;
    } 
  }

  public IpChangeParam() : this(pjsua2PINVOKE.new_IpChangeParam(), true) {
  }

}

}
