using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='drawer']"
	[global::Android.Runtime.Register ("aclasdriver/drawer", DoNotGenerateAcw=true)]
	public partial class Drawer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/drawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Drawer); }
		}

		protected Drawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='drawer']/constructor[@name='drawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Drawer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Drawer)) {
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
			global::Aclasdriver.Drawer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='drawer']/method[@name='open' and count(parameter)=0]"
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

	}
}
