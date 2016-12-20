using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']"
	[global::Android.Runtime.Register ("aclasdriver/AclasLcd0", DoNotGenerateAcw=true)]
	public partial class AclasLcd0 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/AclasLcd0", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AclasLcd0); }
		}

		protected AclasLcd0 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/constructor[@name='AclasLcd0' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AclasLcd0 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AclasLcd0)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_GetHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_GetHeight == null)
				cb_GetHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_GetHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_GetHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='GetHeight' and count(parameter)=0]"
			[Register ("GetHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_GetHeight == IntPtr.Zero)
					id_GetHeight = JNIEnv.GetMethodID (class_ref, "GetHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_GetWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_GetWidth == null)
				cb_GetWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_GetWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_GetWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='GetWidth' and count(parameter)=0]"
			[Register ("GetWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_GetWidth == IntPtr.Zero)
					id_GetWidth = JNIEnv.GetMethodID (class_ref, "GetWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_SetBacklight_I;
#pragma warning disable 0169
		static Delegate GetSetBacklight_IHandler ()
		{
			if (cb_SetBacklight_I == null)
				cb_SetBacklight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBacklight_I);
			return cb_SetBacklight_I;
		}

		static void n_SetBacklight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBacklight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetBacklight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='SetBacklight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetBacklight", "(I)V", "GetSetBacklight_IHandler")]
		public virtual unsafe void SetBacklight (int p0)
		{
			if (id_SetBacklight_I == IntPtr.Zero)
				id_SetBacklight_I = JNIEnv.GetMethodID (class_ref, "SetBacklight", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_SetBacklight_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetBacklight", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_SetContrast_I;
#pragma warning disable 0169
		static Delegate GetSetContrast_IHandler ()
		{
			if (cb_SetContrast_I == null)
				cb_SetContrast_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContrast_I);
			return cb_SetContrast_I;
		}

		static void n_SetContrast_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContrast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetContrast_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='SetContrast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetContrast", "(I)V", "GetSetContrast_IHandler")]
		public virtual unsafe void SetContrast (int p0)
		{
			if (id_SetContrast_I == IntPtr.Zero)
				id_SetContrast_I = JNIEnv.GetMethodID (class_ref, "SetContrast", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_SetContrast_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetContrast", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_WriteBitMap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetWriteBitMap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_WriteBitMap_Landroid_graphics_Bitmap_ == null)
				cb_WriteBitMap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_WriteBitMap_Landroid_graphics_Bitmap_);
			return cb_WriteBitMap_Landroid_graphics_Bitmap_;
		}

		static int n_WriteBitMap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.WriteBitMap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_WriteBitMap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='WriteBitMap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("WriteBitMap", "(Landroid/graphics/Bitmap;)I", "GetWriteBitMap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe int WriteBitMap (global::Android.Graphics.Bitmap p0)
		{
			if (id_WriteBitMap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_WriteBitMap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "WriteBitMap", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_WriteBitMap_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteBitMap", "(Landroid/graphics/Bitmap;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_WriteDotMatrix_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteDotMatrix_arrayBHandler ()
		{
			if (cb_WriteDotMatrix_arrayB == null)
				cb_WriteDotMatrix_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_WriteDotMatrix_arrayB);
			return cb_WriteDotMatrix_arrayB;
		}

		static int n_WriteDotMatrix_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteDotMatrix (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_WriteDotMatrix_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='WriteDotMatrix' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("WriteDotMatrix", "([B)I", "GetWriteDotMatrix_arrayBHandler")]
		public virtual unsafe int WriteDotMatrix (byte[] p0)
		{
			if (id_WriteDotMatrix_arrayB == IntPtr.Zero)
				id_WriteDotMatrix_arrayB = JNIEnv.GetMethodID (class_ref, "WriteDotMatrix", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_WriteDotMatrix_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteDotMatrix", "([B)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Open);
			return cb_open;
		}

		static int n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()I", "GetOpenHandler")]
		public virtual unsafe int Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_open);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeMsg_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteMsg_arrayBHandler ()
		{
			if (cb_writeMsg_arrayB == null)
				cb_writeMsg_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteMsg_arrayB);
			return cb_writeMsg_arrayB;
		}

		static void n_WriteMsg_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.AclasLcd0 __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasLcd0> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteMsg (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeMsg_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='AclasLcd0']/method[@name='writeMsg' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeMsg", "([B)V", "GetWriteMsg_arrayBHandler")]
		public virtual unsafe void WriteMsg (byte[] p0)
		{
			if (id_writeMsg_arrayB == IntPtr.Zero)
				id_writeMsg_arrayB = JNIEnv.GetMethodID (class_ref, "writeMsg", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeMsg_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeMsg", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
