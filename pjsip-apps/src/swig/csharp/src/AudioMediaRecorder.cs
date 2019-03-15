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

public class AudioMediaRecorder : AudioMedia {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AudioMediaRecorder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AudioMediaRecorder_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioMediaRecorder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AudioMediaRecorder() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AudioMediaRecorder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public AudioMediaRecorder() : this(pjsua2PINVOKE.new_AudioMediaRecorder(), true) {
  }

  public void createRecorder(string file_name, uint enc_type, SWIGTYPE_p_pj_ssize_t max_size, uint options) {
    pjsua2PINVOKE.AudioMediaRecorder_createRecorder__SWIG_0(swigCPtr, file_name, enc_type, SWIGTYPE_p_pj_ssize_t.getCPtr(max_size), options);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createRecorder(string file_name, uint enc_type, SWIGTYPE_p_pj_ssize_t max_size) {
    pjsua2PINVOKE.AudioMediaRecorder_createRecorder__SWIG_1(swigCPtr, file_name, enc_type, SWIGTYPE_p_pj_ssize_t.getCPtr(max_size));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createRecorder(string file_name, uint enc_type) {
    pjsua2PINVOKE.AudioMediaRecorder_createRecorder__SWIG_2(swigCPtr, file_name, enc_type);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createRecorder(string file_name) {
    pjsua2PINVOKE.AudioMediaRecorder_createRecorder__SWIG_3(swigCPtr, file_name);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static AudioMediaRecorder typecastFromAudioMedia(AudioMedia media) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.AudioMediaRecorder_typecastFromAudioMedia(AudioMedia.getCPtr(media));
    AudioMediaRecorder ret = (cPtr == global::System.IntPtr.Zero) ? null : new AudioMediaRecorder(cPtr, false);
    return ret;
  }

}

}
