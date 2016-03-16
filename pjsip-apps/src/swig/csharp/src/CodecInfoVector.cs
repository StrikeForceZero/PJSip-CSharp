//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2 {

public class CodecInfoVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<CodecInfo>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CodecInfoVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CodecInfoVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CodecInfoVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_CodecInfoVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CodecInfoVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (CodecInfo element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public CodecInfo this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(CodecInfo[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(CodecInfo[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, CodecInfo[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<CodecInfo> global::System.Collections.Generic.IEnumerable<CodecInfo>.GetEnumerator() {
    return new CodecInfoVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new CodecInfoVectorEnumerator(this);
  }

  public CodecInfoVectorEnumerator GetEnumerator() {
    return new CodecInfoVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class CodecInfoVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<CodecInfo>
  {
    private CodecInfoVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public CodecInfoVectorEnumerator(CodecInfoVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public CodecInfo Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (CodecInfo)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    pjsua2PINVOKE.CodecInfoVector_Clear(swigCPtr);
  }

  public void Add(CodecInfo x) {
    pjsua2PINVOKE.CodecInfoVector_Add(swigCPtr, CodecInfo.getCPtr(x));
  }

  private uint size() {
    uint ret = pjsua2PINVOKE.CodecInfoVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = pjsua2PINVOKE.CodecInfoVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    pjsua2PINVOKE.CodecInfoVector_reserve(swigCPtr, n);
  }

  public CodecInfoVector() : this(pjsua2PINVOKE.new_CodecInfoVector__SWIG_0(), true) {
  }

  public CodecInfoVector(CodecInfoVector other) : this(pjsua2PINVOKE.new_CodecInfoVector__SWIG_1(CodecInfoVector.getCPtr(other)), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CodecInfoVector(int capacity) : this(pjsua2PINVOKE.new_CodecInfoVector__SWIG_2(capacity), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  private CodecInfo getitemcopy(int index) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.CodecInfoVector_getitemcopy(swigCPtr, index);
    CodecInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CodecInfo(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private CodecInfo getitem(int index) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.CodecInfoVector_getitem(swigCPtr, index);
    CodecInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new CodecInfo(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, CodecInfo val) {
    pjsua2PINVOKE.CodecInfoVector_setitem(swigCPtr, index, CodecInfo.getCPtr(val));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(CodecInfoVector values) {
    pjsua2PINVOKE.CodecInfoVector_AddRange(swigCPtr, CodecInfoVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CodecInfoVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.CodecInfoVector_GetRange(swigCPtr, index, count);
    CodecInfoVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new CodecInfoVector(cPtr, true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, CodecInfo x) {
    pjsua2PINVOKE.CodecInfoVector_Insert(swigCPtr, index, CodecInfo.getCPtr(x));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, CodecInfoVector values) {
    pjsua2PINVOKE.CodecInfoVector_InsertRange(swigCPtr, index, CodecInfoVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    pjsua2PINVOKE.CodecInfoVector_RemoveAt(swigCPtr, index);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    pjsua2PINVOKE.CodecInfoVector_RemoveRange(swigCPtr, index, count);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static CodecInfoVector Repeat(CodecInfo value, int count) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.CodecInfoVector_Repeat(CodecInfo.getCPtr(value), count);
    CodecInfoVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new CodecInfoVector(cPtr, true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    pjsua2PINVOKE.CodecInfoVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    pjsua2PINVOKE.CodecInfoVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, CodecInfoVector values) {
    pjsua2PINVOKE.CodecInfoVector_SetRange(swigCPtr, index, CodecInfoVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(CodecInfo value) {
    bool ret = pjsua2PINVOKE.CodecInfoVector_Contains(swigCPtr, CodecInfo.getCPtr(value));
    return ret;
  }

  public int IndexOf(CodecInfo value) {
    int ret = pjsua2PINVOKE.CodecInfoVector_IndexOf(swigCPtr, CodecInfo.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(CodecInfo value) {
    int ret = pjsua2PINVOKE.CodecInfoVector_LastIndexOf(swigCPtr, CodecInfo.getCPtr(value));
    return ret;
  }

  public bool Remove(CodecInfo value) {
    bool ret = pjsua2PINVOKE.CodecInfoVector_Remove(swigCPtr, CodecInfo.getCPtr(value));
    return ret;
  }

}

}
