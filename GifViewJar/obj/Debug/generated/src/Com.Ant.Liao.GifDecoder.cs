using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ant.Liao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']"
	[global::Android.Runtime.Register ("com/ant/liao/GifDecoder", DoNotGenerateAcw=true)]
	public partial class GifDecoder : global::Java.Lang.Thread {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='STATUS_FINISH']"
		[Register ("STATUS_FINISH")]
		public const int StatusFinish = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='STATUS_FORMAT_ERROR']"
		[Register ("STATUS_FORMAT_ERROR")]
		public const int StatusFormatError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='STATUS_OPEN_ERROR']"
		[Register ("STATUS_OPEN_ERROR")]
		public const int StatusOpenError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='STATUS_PARSING']"
		[Register ("STATUS_PARSING")]
		public const int StatusParsing = (int) 0;

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ant/liao/GifDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDecoder); }
		}

		protected GifDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLcom_ant_liao_GifAction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/constructor[@name='GifDecoder' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.ant.liao.GifAction']]"
		[Register (".ctor", "([BLcom/ant/liao/GifAction;)V", "")]
		public unsafe GifDecoder (byte[] p0, global::Com.Ant.Liao.IGifAction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLcom/ant/liao/GifAction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLcom/ant/liao/GifAction;)V", __args);
					return;
				}

				if (id_ctor_arrayBLcom_ant_liao_GifAction_ == IntPtr.Zero)
					id_ctor_arrayBLcom_ant_liao_GifAction_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLcom/ant/liao/GifAction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLcom_ant_liao_GifAction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLcom_ant_liao_GifAction_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_Lcom_ant_liao_GifAction_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/constructor[@name='GifDecoder' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.ant.liao.GifAction']]"
		[Register (".ctor", "(Ljava/io/InputStream;Lcom/ant/liao/GifAction;)V", "")]
		public unsafe GifDecoder (global::System.IO.Stream p0, global::Com.Ant.Liao.IGifAction p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;Lcom/ant/liao/GifAction;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;Lcom/ant/liao/GifAction;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_Lcom_ant_liao_GifAction_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_Lcom_ant_liao_GifAction_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Lcom/ant/liao/GifAction;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Lcom_ant_liao_GifAction_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_Lcom_ant_liao_GifAction_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCurrentFrame;
#pragma warning disable 0169
		static Delegate GetGetCurrentFrameHandler ()
		{
			if (cb_getCurrentFrame == null)
				cb_getCurrentFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentFrame);
			return cb_getCurrentFrame;
		}

		static IntPtr n_GetCurrentFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentFrame);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentFrame;
		public virtual unsafe global::Com.Ant.Liao.GifFrame CurrentFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getCurrentFrame' and count(parameter)=0]"
			[Register ("getCurrentFrame", "()Lcom/ant/liao/GifFrame;", "GetGetCurrentFrameHandler")]
			get {
				if (id_getCurrentFrame == IntPtr.Zero)
					id_getCurrentFrame = JNIEnv.GetMethodID (class_ref, "getCurrentFrame", "()Lcom/ant/liao/GifFrame;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentFrame", "()Lcom/ant/liao/GifFrame;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFrameCount;
#pragma warning disable 0169
		static Delegate GetGetFrameCountHandler ()
		{
			if (cb_getFrameCount == null)
				cb_getFrameCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameCount);
			return cb_getFrameCount;
		}

		static int n_GetFrameCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameCount;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameCount;
		public virtual unsafe int FrameCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getFrameCount' and count(parameter)=0]"
			[Register ("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get {
				if (id_getFrameCount == IntPtr.Zero)
					id_getFrameCount = JNIEnv.GetMethodID (class_ref, "getFrameCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFrameCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		public virtual unsafe global::Android.Graphics.Bitmap Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/Bitmap;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoopCount;
#pragma warning disable 0169
		static Delegate GetGetLoopCountHandler ()
		{
			if (cb_getLoopCount == null)
				cb_getLoopCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoopCount);
			return cb_getLoopCount;
		}

		static int n_GetLoopCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoopCount;
		}
#pragma warning restore 0169

		static IntPtr id_getLoopCount;
		public virtual unsafe int LoopCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getLoopCount' and count(parameter)=0]"
			[Register ("getLoopCount", "()I", "GetGetLoopCountHandler")]
			get {
				if (id_getLoopCount == IntPtr.Zero)
					id_getLoopCount = JNIEnv.GetMethodID (class_ref, "getLoopCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLoopCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoopCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_free;
#pragma warning disable 0169
		static Delegate GetFreeHandler ()
		{
			if (cb_free == null)
				cb_free = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Free);
			return cb_free;
		}

		static void n_Free (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Free ();
		}
#pragma warning restore 0169

		static IntPtr id_free;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='free' and count(parameter)=0]"
		[Register ("free", "()V", "GetFreeHandler")]
		public virtual unsafe void Free ()
		{
			if (id_free == IntPtr.Zero)
				id_free = JNIEnv.GetMethodID (class_ref, "free", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_free);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "free", "()V"));
			} finally {
			}
		}

		static Delegate cb_getDelay_I;
#pragma warning disable 0169
		static Delegate GetGetDelay_IHandler ()
		{
			if (cb_getDelay_I == null)
				cb_getDelay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDelay_I);
			return cb_getDelay_I;
		}

		static int n_GetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDelay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDelay", "(I)I", "GetGetDelay_IHandler")]
		public virtual unsafe int GetDelay (int p0)
		{
			if (id_getDelay_I == IntPtr.Zero)
				id_getDelay_I = JNIEnv.GetMethodID (class_ref, "getDelay", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDelay_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getDelays;
#pragma warning disable 0169
		static Delegate GetGetDelaysHandler ()
		{
			if (cb_getDelays == null)
				cb_getDelays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDelays);
			return cb_getDelays;
		}

		static IntPtr n_GetDelays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDelays ());
		}
#pragma warning restore 0169

		static IntPtr id_getDelays;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getDelays' and count(parameter)=0]"
		[Register ("getDelays", "()[I", "GetGetDelaysHandler")]
		public virtual unsafe int[] GetDelays ()
		{
			if (id_getDelays == IntPtr.Zero)
				id_getDelays = JNIEnv.GetMethodID (class_ref, "getDelays", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDelays), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelays", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getFrame_I;
#pragma warning disable 0169
		static Delegate GetGetFrame_IHandler ()
		{
			if (cb_getFrame_I == null)
				cb_getFrame_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFrame_I);
			return cb_getFrame_I;
		}

		static IntPtr n_GetFrame_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFrame (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFrame_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getFrame' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFrame", "(I)Lcom/ant/liao/GifFrame;", "GetGetFrame_IHandler")]
		public virtual unsafe global::Com.Ant.Liao.GifFrame GetFrame (int p0)
		{
			if (id_getFrame_I == IntPtr.Zero)
				id_getFrame_I = JNIEnv.GetMethodID (class_ref, "getFrame", "(I)Lcom/ant/liao/GifFrame;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallObjectMethod  (Handle, id_getFrame_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrame", "(I)Lcom/ant/liao/GifFrame;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFrameImage_I;
#pragma warning disable 0169
		static Delegate GetGetFrameImage_IHandler ()
		{
			if (cb_getFrameImage_I == null)
				cb_getFrameImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFrameImage_I);
			return cb_getFrameImage_I;
		}

		static IntPtr n_GetFrameImage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFrameImage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFrameImage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='getFrameImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFrameImage", "(I)Landroid/graphics/Bitmap;", "GetGetFrameImage_IHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetFrameImage (int p0)
		{
			if (id_getFrameImage_I == IntPtr.Zero)
				id_getFrameImage_I = JNIEnv.GetMethodID (class_ref, "getFrameImage", "(I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getFrameImage_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameImage", "(I)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		static IntPtr id_next;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lcom/ant/liao/GifFrame;", "GetNextHandler")]
		public virtual unsafe global::Com.Ant.Liao.GifFrame Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Lcom/ant/liao/GifFrame;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallObjectMethod  (Handle, id_next), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "()Lcom/ant/liao/GifFrame;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_parseOk;
#pragma warning disable 0169
		static Delegate GetParseOkHandler ()
		{
			if (cb_parseOk == null)
				cb_parseOk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ParseOk);
			return cb_parseOk;
		}

		static bool n_ParseOk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ParseOk ();
		}
#pragma warning restore 0169

		static IntPtr id_parseOk;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='parseOk' and count(parameter)=0]"
		[Register ("parseOk", "()Z", "GetParseOkHandler")]
		public virtual unsafe bool ParseOk ()
		{
			if (id_parseOk == IntPtr.Zero)
				id_parseOk = JNIEnv.GetMethodID (class_ref, "parseOk", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_parseOk);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseOk", "()Z"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifDecoder']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
