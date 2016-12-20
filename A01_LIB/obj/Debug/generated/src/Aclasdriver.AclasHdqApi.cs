using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']"
	[global::Android.Runtime.Register ("aclasdriver/aclasHdqApi", DoNotGenerateAcw=true)]
	public partial class AclasHdqApi : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/aclasHdqApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AclasHdqApi); }
		}

		protected AclasHdqApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']/constructor[@name='aclasHdqApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AclasHdqApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AclasHdqApi)) {
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

		static Delegate cb_beep;
#pragma warning disable 0169
		static Delegate GetBeepHandler ()
		{
			if (cb_beep == null)
				cb_beep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Beep);
			return cb_beep;
		}

		static int n_Beep (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasHdqApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasHdqApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep ();
		}
#pragma warning restore 0169

		static IntPtr id_beep;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']/method[@name='beep' and count(parameter)=0]"
		[Register ("beep", "()I", "GetBeepHandler")]
		public virtual unsafe int Beep ()
		{
			if (id_beep == IntPtr.Zero)
				id_beep = JNIEnv.GetMethodID (class_ref, "beep", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_beep);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beep", "()I"));
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
			global::Aclasdriver.AclasHdqApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasHdqApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']/method[@name='close' and count(parameter)=0]"
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
			global::Aclasdriver.AclasHdqApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasHdqApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']/method[@name='open' and count(parameter)=0]"
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

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Read);
			return cb_read;
		}

		static IntPtr n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.AclasHdqApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasHdqApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Read ());
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasHdqApi']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()[B", "GetReadHandler")]
		public virtual unsafe byte[] Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_read), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
