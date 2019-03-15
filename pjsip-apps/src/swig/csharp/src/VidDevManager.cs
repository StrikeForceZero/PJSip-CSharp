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

public class VidDevManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VidDevManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VidDevManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void refreshDevs() {
    pjsua2PINVOKE.VidDevManager_refreshDevs(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getDevCount() {
    uint ret = pjsua2PINVOKE.VidDevManager_getDevCount(swigCPtr);
    return ret;
  }

  public VideoDevInfo getDevInfo(int dev_id) {
    VideoDevInfo ret = new VideoDevInfo(pjsua2PINVOKE.VidDevManager_getDevInfo(swigCPtr, dev_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VideoDevInfoVector enumDev() {
    VideoDevInfoVector ret = new VideoDevInfoVector(pjsua2PINVOKE.VidDevManager_enumDev(swigCPtr), false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int lookupDev(string drv_name, string dev_name) {
    int ret = pjsua2PINVOKE.VidDevManager_lookupDev(swigCPtr, drv_name, dev_name);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string capName(pjmedia_vid_dev_cap cap) {
    string ret = pjsua2PINVOKE.VidDevManager_capName(swigCPtr, (int)cap);
    return ret;
  }

  public void setFormat(int dev_id, MediaFormatVideo format, bool keep) {
    pjsua2PINVOKE.VidDevManager_setFormat(swigCPtr, dev_id, MediaFormatVideo.getCPtr(format), keep);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public MediaFormatVideo getFormat(int dev_id) {
    MediaFormatVideo ret = new MediaFormatVideo(pjsua2PINVOKE.VidDevManager_getFormat(swigCPtr, dev_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setInputScale(int dev_id, MediaSize scale, bool keep) {
    pjsua2PINVOKE.VidDevManager_setInputScale(swigCPtr, dev_id, MediaSize.getCPtr(scale), keep);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public MediaSize getInputScale(int dev_id) {
    MediaSize ret = new MediaSize(pjsua2PINVOKE.VidDevManager_getInputScale(swigCPtr, dev_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOutputWindowFlags(int dev_id, int flags, bool keep) {
    pjsua2PINVOKE.VidDevManager_setOutputWindowFlags(swigCPtr, dev_id, flags, keep);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public int getOutputWindowFlags(int dev_id) {
    int ret = pjsua2PINVOKE.VidDevManager_getOutputWindowFlags(swigCPtr, dev_id);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void switchDev(int dev_id, VideoSwitchParam param) {
    pjsua2PINVOKE.VidDevManager_switchDev(swigCPtr, dev_id, VideoSwitchParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isCaptureActive(int dev_id) {
    bool ret = pjsua2PINVOKE.VidDevManager_isCaptureActive(swigCPtr, dev_id);
    return ret;
  }

  public void setCaptureOrient(int dev_id, pjmedia_orient orient, bool keep) {
    pjsua2PINVOKE.VidDevManager_setCaptureOrient__SWIG_0(swigCPtr, dev_id, (int)orient, keep);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCaptureOrient(int dev_id, pjmedia_orient orient) {
    pjsua2PINVOKE.VidDevManager_setCaptureOrient__SWIG_1(swigCPtr, dev_id, (int)orient);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
