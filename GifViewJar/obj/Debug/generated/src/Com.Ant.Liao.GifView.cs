using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ant.Liao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']"
	[global::Android.Runtime.Register ("com/ant/liao/GifView", DoNotGenerateAcw=true)]
	public partial class GifView : global::Android.Views.View, global::Com.Ant.Liao.IGifAction {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.DrawThread']"
		[global::Android.Runtime.Register ("com/ant/liao/GifView$DrawThread", DoNotGenerateAcw=true)]
		public partial class DrawThread : global::Java.Lang.Thread {

			protected DrawThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']"
		[global::Android.Runtime.Register ("com/ant/liao/GifView$GifImageType", DoNotGenerateAcw=true)]
		public sealed partial class GifImageType : global::Java.Lang.Enum {


			static IntPtr COVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']/field[@name='COVER']"
			[Register ("COVER")]
			public static global::Com.Ant.Liao.GifView.GifImageType Cover {
				get {
					if (COVER_jfieldId == IntPtr.Zero)
						COVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COVER", "Lcom/ant/liao/GifView$GifImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView.GifImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYNC_DECODER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']/field[@name='SYNC_DECODER']"
			[Register ("SYNC_DECODER")]
			public static global::Com.Ant.Liao.GifView.GifImageType SyncDecoder {
				get {
					if (SYNC_DECODER_jfieldId == IntPtr.Zero)
						SYNC_DECODER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNC_DECODER", "Lcom/ant/liao/GifView$GifImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYNC_DECODER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView.GifImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WAIT_FINISH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']/field[@name='WAIT_FINISH']"
			[Register ("WAIT_FINISH")]
			public static global::Com.Ant.Liao.GifView.GifImageType WaitFinish {
				get {
					if (WAIT_FINISH_jfieldId == IntPtr.Zero)
						WAIT_FINISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAIT_FINISH", "Lcom/ant/liao/GifView$GifImageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAIT_FINISH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView.GifImageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ant/liao/GifView$GifImageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GifImageType); }
			}

			internal GifImageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ant/liao/GifView$GifImageType;", "")]
			public static unsafe global::Com.Ant.Liao.GifView.GifImageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ant/liao/GifView$GifImageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Ant.Liao.GifView.GifImageType __ret = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView.GifImageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView.GifImageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ant/liao/GifView$GifImageType;", "")]
			public static unsafe global::Com.Ant.Liao.GifView.GifImageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ant/liao/GifView$GifImageType;");
				try {
					return (global::Com.Ant.Liao.GifView.GifImageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Ant.Liao.GifView.GifImageType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ant/liao/GifView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifView); }
		}

		protected GifView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/constructor[@name='GifView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GifView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GifView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/constructor[@name='GifView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe GifView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/constructor[@name='GifView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe GifView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (GifView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_parseOk_ZI;
#pragma warning disable 0169
		static Delegate GetParseOk_ZIHandler ()
		{
			if (cb_parseOk_ZI == null)
				cb_parseOk_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int>) n_ParseOk_ZI);
			return cb_parseOk_ZI;
		}

		static void n_ParseOk_ZI (IntPtr jnienv, IntPtr native__this, bool p0, int p1)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseOk (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_parseOk_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='parseOk' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("parseOk", "(ZI)V", "GetParseOk_ZIHandler")]
		public virtual unsafe void ParseOk (bool p0, int p1)
		{
			if (id_parseOk_ZI == IntPtr.Zero)
				id_parseOk_ZI = JNIEnv.GetMethodID (class_ref, "parseOk", "(ZI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_parseOk_ZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseOk", "(ZI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGifImage_arrayB;
#pragma warning disable 0169
		static Delegate GetSetGifImage_arrayBHandler ()
		{
			if (cb_setGifImage_arrayB == null)
				cb_setGifImage_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGifImage_arrayB);
			return cb_setGifImage_arrayB;
		}

		static void n_SetGifImage_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetGifImage (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGifImage_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='setGifImage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setGifImage", "([B)V", "GetSetGifImage_arrayBHandler")]
		public virtual unsafe void SetGifImage (byte[] p0)
		{
			if (id_setGifImage_arrayB == IntPtr.Zero)
				id_setGifImage_arrayB = JNIEnv.GetMethodID (class_ref, "setGifImage", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGifImage_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGifImage", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setGifImage_I;
#pragma warning disable 0169
		static Delegate GetSetGifImage_IHandler ()
		{
			if (cb_setGifImage_I == null)
				cb_setGifImage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGifImage_I);
			return cb_setGifImage_I;
		}

		static void n_SetGifImage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGifImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGifImage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='setGifImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGifImage", "(I)V", "GetSetGifImage_IHandler")]
		public virtual unsafe void SetGifImage (int p0)
		{
			if (id_setGifImage_I == IntPtr.Zero)
				id_setGifImage_I = JNIEnv.GetMethodID (class_ref, "setGifImage", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGifImage_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGifImage", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGifImage_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetGifImage_Ljava_io_InputStream_Handler ()
		{
			if (cb_setGifImage_Ljava_io_InputStream_ == null)
				cb_setGifImage_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGifImage_Ljava_io_InputStream_);
			return cb_setGifImage_Ljava_io_InputStream_;
		}

		static void n_SetGifImage_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGifImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGifImage_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='setGifImage' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setGifImage", "(Ljava/io/InputStream;)V", "GetSetGifImage_Ljava_io_InputStream_Handler")]
		public virtual unsafe void SetGifImage (global::System.IO.Stream p0)
		{
			if (id_setGifImage_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setGifImage_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setGifImage", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGifImage_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGifImage", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGifImageType_Lcom_ant_liao_GifView_GifImageType_;
#pragma warning disable 0169
		static Delegate GetSetGifImageType_Lcom_ant_liao_GifView_GifImageType_Handler ()
		{
			if (cb_setGifImageType_Lcom_ant_liao_GifView_GifImageType_ == null)
				cb_setGifImageType_Lcom_ant_liao_GifView_GifImageType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGifImageType_Lcom_ant_liao_GifView_GifImageType_);
			return cb_setGifImageType_Lcom_ant_liao_GifView_GifImageType_;
		}

		static void n_SetGifImageType_Lcom_ant_liao_GifView_GifImageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Ant.Liao.GifView.GifImageType p0 = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView.GifImageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGifImageType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGifImageType_Lcom_ant_liao_GifView_GifImageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='setGifImageType' and count(parameter)=1 and parameter[1][@type='com.ant.liao.GifView.GifImageType']]"
		[Register ("setGifImageType", "(Lcom/ant/liao/GifView$GifImageType;)V", "GetSetGifImageType_Lcom_ant_liao_GifView_GifImageType_Handler")]
		public virtual unsafe void SetGifImageType (global::Com.Ant.Liao.GifView.GifImageType p0)
		{
			if (id_setGifImageType_Lcom_ant_liao_GifView_GifImageType_ == IntPtr.Zero)
				id_setGifImageType_Lcom_ant_liao_GifView_GifImageType_ = JNIEnv.GetMethodID (class_ref, "setGifImageType", "(Lcom/ant/liao/GifView$GifImageType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGifImageType_Lcom_ant_liao_GifView_GifImageType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGifImageType", "(Lcom/ant/liao/GifView$GifImageType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShowDimension_II;
#pragma warning disable 0169
		static Delegate GetSetShowDimension_IIHandler ()
		{
			if (cb_setShowDimension_II == null)
				cb_setShowDimension_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetShowDimension_II);
			return cb_setShowDimension_II;
		}

		static void n_SetShowDimension_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowDimension (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setShowDimension_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='setShowDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setShowDimension", "(II)V", "GetSetShowDimension_IIHandler")]
		public virtual unsafe void SetShowDimension (int p0, int p1)
		{
			if (id_setShowDimension_II == IntPtr.Zero)
				id_setShowDimension_II = JNIEnv.GetMethodID (class_ref, "setShowDimension", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowDimension_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowDimension", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showAnimation;
#pragma warning disable 0169
		static Delegate GetShowAnimationHandler ()
		{
			if (cb_showAnimation == null)
				cb_showAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowAnimation);
			return cb_showAnimation;
		}

		static void n_ShowAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_showAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='showAnimation' and count(parameter)=0]"
		[Register ("showAnimation", "()V", "GetShowAnimationHandler")]
		public virtual unsafe void ShowAnimation ()
		{
			if (id_showAnimation == IntPtr.Zero)
				id_showAnimation = JNIEnv.GetMethodID (class_ref, "showAnimation", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAnimation", "()V"));
			} finally {
			}
		}

		static Delegate cb_showCover;
#pragma warning disable 0169
		static Delegate GetShowCoverHandler ()
		{
			if (cb_showCover == null)
				cb_showCover = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowCover);
			return cb_showCover;
		}

		static void n_ShowCover (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Ant.Liao.GifView __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCover ();
		}
#pragma warning restore 0169

		static IntPtr id_showCover;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/class[@name='GifView']/method[@name='showCover' and count(parameter)=0]"
		[Register ("showCover", "()V", "GetShowCoverHandler")]
		public virtual unsafe void ShowCover ()
		{
			if (id_showCover == IntPtr.Zero)
				id_showCover = JNIEnv.GetMethodID (class_ref, "showCover", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showCover);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showCover", "()V"));
			} finally {
			}
		}

	}
}
