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

public class ToneDigitMapDigit : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ToneDigitMapDigit(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ToneDigitMapDigit obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToneDigitMapDigit() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_ToneDigitMapDigit(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string digit {
    set {
      pjsua2PINVOKE.ToneDigitMapDigit_digit_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.ToneDigitMapDigit_digit_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int freq1 {
    set {
      pjsua2PINVOKE.ToneDigitMapDigit_freq1_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.ToneDigitMapDigit_freq1_get(swigCPtr);
      return ret;
    } 
  }

  public int freq2 {
    set {
      pjsua2PINVOKE.ToneDigitMapDigit_freq2_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.ToneDigitMapDigit_freq2_get(swigCPtr);
      return ret;
    } 
  }

  public ToneDigitMapDigit() : this(pjsua2PINVOKE.new_ToneDigitMapDigit(), true) {
  }

}

}
