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

public class MediaFormatAudio : MediaFormat {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MediaFormatAudio(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.MediaFormatAudio_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaFormatAudio obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaFormatAudio() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaFormatAudio(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint clockRate {
    set {
      pjsua2PINVOKE.MediaFormatAudio_clockRate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_clockRate_get(swigCPtr);
      return ret;
    } 
  }

  public uint channelCount {
    set {
      pjsua2PINVOKE.MediaFormatAudio_channelCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_channelCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint frameTimeUsec {
    set {
      pjsua2PINVOKE.MediaFormatAudio_frameTimeUsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_frameTimeUsec_get(swigCPtr);
      return ret;
    } 
  }

  public uint bitsPerSample {
    set {
      pjsua2PINVOKE.MediaFormatAudio_bitsPerSample_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_bitsPerSample_get(swigCPtr);
      return ret;
    } 
  }

  public uint avgBps {
    set {
      pjsua2PINVOKE.MediaFormatAudio_avgBps_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_avgBps_get(swigCPtr);
      return ret;
    } 
  }

  public uint maxBps {
    set {
      pjsua2PINVOKE.MediaFormatAudio_maxBps_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatAudio_maxBps_get(swigCPtr);
      return ret;
    } 
  }

  public MediaFormatAudio() : this(pjsua2PINVOKE.new_MediaFormatAudio(), true) {
  }

}

}
