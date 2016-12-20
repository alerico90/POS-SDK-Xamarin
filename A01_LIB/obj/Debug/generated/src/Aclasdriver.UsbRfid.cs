using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']"
	[global::Android.Runtime.Register ("aclasdriver/UsbRfid", DoNotGenerateAcw=true)]
	public partial class UsbRfid : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/UsbRfid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbRfid); }
		}

		protected UsbRfid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']/constructor[@name='UsbRfid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsbRfid ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UsbRfid)) {
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Close);
			return cb_close;
		}

		static int n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.UsbRfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.UsbRfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "GetCloseHandler")]
		public virtual unsafe int Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_close);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()I"));
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
			global::Aclasdriver.UsbRfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.UsbRfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']/method[@name='open' and count(parameter)=0]"
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

		static Delegate cb_read_I;
#pragma warning disable 0169
		static Delegate GetRead_IHandler ()
		{
			if (cb_read_I == null)
				cb_read_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Read_I);
			return cb_read_I;
		}

		static IntPtr n_Read_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.UsbRfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.UsbRfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Read (p0));
		}
#pragma warning restore 0169

		static IntPtr id_read_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']/method[@name='read' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("read", "(I)[B", "GetRead_IHandler")]
		public virtual unsafe byte[] Read (int p0)
		{
			if (id_read_I == IntPtr.Zero)
				id_read_I = JNIEnv.GetMethodID (class_ref, "read", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static int n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.UsbRfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.UsbRfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='UsbRfid']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)I", "GetWrite_arrayBHandler")]
		public virtual unsafe int Write (byte[] p0)
		{
			if (id_write_arrayB == IntPtr.Zero)
				id_write_arrayB = JNIEnv.GetMethodID (class_ref, "write", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_write_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([B)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
