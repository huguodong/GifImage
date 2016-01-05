using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ant.Liao {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ant.liao']/interface[@name='GifAction']"
	[Register ("com/ant/liao/GifAction", "", "Com.Ant.Liao.IGifActionInvoker")]
	public partial interface IGifAction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ant.liao']/interface[@name='GifAction']/method[@name='parseOk' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("parseOk", "(ZI)V", "GetParseOk_ZIHandler:Com.Ant.Liao.IGifActionInvoker, GifViewJar")]
		void ParseOk (bool p0, int p1);

	}

	[global::Android.Runtime.Register ("com/ant/liao/GifAction", DoNotGenerateAcw=true)]
	internal class IGifActionInvoker : global::Java.Lang.Object, IGifAction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ant/liao/GifAction");
		IntPtr class_ref;

		public static IGifAction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGifAction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ant.liao.GifAction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGifActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGifActionInvoker); }
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
			global::Com.Ant.Liao.IGifAction __this = global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.IGifAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseOk (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_parseOk_ZI;
		public unsafe void ParseOk (bool p0, int p1)
		{
			if (id_parseOk_ZI == IntPtr.Zero)
				id_parseOk_ZI = JNIEnv.GetMethodID (class_ref, "parseOk", "(ZI)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_parseOk_ZI, __args);
		}

	}

}
