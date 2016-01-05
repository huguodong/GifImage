using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Ant.Liao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ant.liao']/class[@name='GifFrame']"
	[global::Android.Runtime.Register ("com/ant/liao/GifFrame", DoNotGenerateAcw=true)]
	public partial class GifFrame : global::Java.Lang.Object {


		static IntPtr delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifFrame']/field[@name='delay']"
		[Register ("delay")]
		public int Delay {
			get {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "I");
				return JNIEnv.GetIntField (Handle, delay_jfieldId);
			}
			set {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "I");
				try {
					JNIEnv.SetField (Handle, delay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr image_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifFrame']/field[@name='image']"
		[Register ("image")]
		public global::Android.Graphics.Bitmap Image {
			get {
				if (image_jfieldId == IntPtr.Zero)
					image_jfieldId = JNIEnv.GetFieldID (class_ref, "image", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, image_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (image_jfieldId == IntPtr.Zero)
					image_jfieldId = JNIEnv.GetFieldID (class_ref, "image", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, image_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr nextFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ant.liao']/class[@name='GifFrame']/field[@name='nextFrame']"
		[Register ("nextFrame")]
		public global::Com.Ant.Liao.GifFrame NextFrame {
			get {
				if (nextFrame_jfieldId == IntPtr.Zero)
					nextFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "nextFrame", "Lcom/ant/liao/GifFrame;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, nextFrame_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Ant.Liao.GifFrame> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nextFrame_jfieldId == IntPtr.Zero)
					nextFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "nextFrame", "Lcom/ant/liao/GifFrame;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, nextFrame_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ant/liao/GifFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifFrame); }
		}

		protected GifFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ant.liao']/class[@name='GifFrame']/constructor[@name='GifFrame' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;I)V", "")]
		public unsafe GifFrame (global::Android.Graphics.Bitmap p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GifFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_I == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_I, __args);
			} finally {
			}
		}

	}
}
