using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']"
	[global::Android.Runtime.Register ("aclasdriver/aclasMagcardApi", DoNotGenerateAcw=true)]
	public partial class AclasMagcardApi : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/aclasMagcardApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AclasMagcardApi); }
		}

		protected AclasMagcardApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']/constructor[@name='aclasMagcardApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AclasMagcardApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AclasMagcardApi)) {
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
			global::Aclasdriver.AclasMagcardApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasMagcardApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep ();
		}
#pragma warning restore 0169

		static IntPtr id_beep;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']/method[@name='beep' and count(parameter)=0]"
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
			global::Aclasdriver.AclasMagcardApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasMagcardApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']/method[@name='close' and count(parameter)=0]"
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
			global::Aclasdriver.AclasMagcardApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasMagcardApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']/method[@name='open' and count(parameter)=0]"
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

		static Delegate cb_read_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRead_arrayLjava_lang_String_Handler ()
		{
			if (cb_read_arrayLjava_lang_String_ == null)
				cb_read_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayLjava_lang_String_);
			return cb_read_arrayLjava_lang_String_;
		}

		static int n_Read_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.AclasMagcardApi __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.AclasMagcardApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='aclasMagcardApi']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("read", "([Ljava/lang/String;)I", "GetRead_arrayLjava_lang_String_Handler")]
		public virtual unsafe int Read (string[] p0)
		{
			if (id_read_arrayLjava_lang_String_ == IntPtr.Zero)
				id_read_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "read", "([Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([Ljava/lang/String;)I"), __args);
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
