using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']"
	[global::Android.Runtime.Register ("aclasdriver/rfid", DoNotGenerateAcw=true)]
	public partial class Rfid : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/rfid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rfid); }
		}

		protected Rfid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/constructor[@name='rfid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Rfid ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Rfid)) {
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

		static Delegate cb_AuthKey_IarrayB;
#pragma warning disable 0169
		static Delegate GetAuthKey_IarrayBHandler ()
		{
			if (cb_AuthKey_IarrayB == null)
				cb_AuthKey_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_AuthKey_IarrayB);
			return cb_AuthKey_IarrayB;
		}

		static bool n_AuthKey_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.AuthKey (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_AuthKey_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='AuthKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("AuthKey", "(I[B)Z", "GetAuthKey_IarrayBHandler")]
		public virtual unsafe bool AuthKey (int p0, byte[] p1)
		{
			if (id_AuthKey_IarrayB == IntPtr.Zero)
				id_AuthKey_IarrayB = JNIEnv.GetMethodID (class_ref, "AuthKey", "(I[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_AuthKey_IarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AuthKey", "(I[B)Z"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_ReadCardBlock_I;
#pragma warning disable 0169
		static Delegate GetReadCardBlock_IHandler ()
		{
			if (cb_ReadCardBlock_I == null)
				cb_ReadCardBlock_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadCardBlock_I);
			return cb_ReadCardBlock_I;
		}

		static IntPtr n_ReadCardBlock_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadCardBlock (p0));
		}
#pragma warning restore 0169

		static IntPtr id_ReadCardBlock_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='ReadCardBlock' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ReadCardBlock", "(I)[B", "GetReadCardBlock_IHandler")]
		public virtual unsafe byte[] ReadCardBlock (int p0)
		{
			if (id_ReadCardBlock_I == IntPtr.Zero)
				id_ReadCardBlock_I = JNIEnv.GetMethodID (class_ref, "ReadCardBlock", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_ReadCardBlock_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReadCardBlock", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_ReadCardNo;
#pragma warning disable 0169
		static Delegate GetReadCardNoHandler ()
		{
			if (cb_ReadCardNo == null)
				cb_ReadCardNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadCardNo);
			return cb_ReadCardNo;
		}

		static IntPtr n_ReadCardNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadCardNo ());
		}
#pragma warning restore 0169

		static IntPtr id_ReadCardNo;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='ReadCardNo' and count(parameter)=0]"
		[Register ("ReadCardNo", "()Ljava/lang/String;", "GetReadCardNoHandler")]
		public virtual unsafe string ReadCardNo ()
		{
			if (id_ReadCardNo == IntPtr.Zero)
				id_ReadCardNo = JNIEnv.GetMethodID (class_ref, "ReadCardNo", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_ReadCardNo), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReadCardNo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SetCardPsw_IarrayB;
#pragma warning disable 0169
		static Delegate GetSetCardPsw_IarrayBHandler ()
		{
			if (cb_SetCardPsw_IarrayB == null)
				cb_SetCardPsw_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetCardPsw_IarrayB);
			return cb_SetCardPsw_IarrayB;
		}

		static bool n_SetCardPsw_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SetCardPsw (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SetCardPsw_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='SetCardPsw' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("SetCardPsw", "(I[B)Z", "GetSetCardPsw_IarrayBHandler")]
		public virtual unsafe bool SetCardPsw (int p0, byte[] p1)
		{
			if (id_SetCardPsw_IarrayB == IntPtr.Zero)
				id_SetCardPsw_IarrayB = JNIEnv.GetMethodID (class_ref, "SetCardPsw", "(I[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_SetCardPsw_IarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCardPsw", "(I[B)Z"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_WriteCardBlock_IarrayB;
#pragma warning disable 0169
		static Delegate GetWriteCardBlock_IarrayBHandler ()
		{
			if (cb_WriteCardBlock_IarrayB == null)
				cb_WriteCardBlock_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_WriteCardBlock_IarrayB);
			return cb_WriteCardBlock_IarrayB;
		}

		static bool n_WriteCardBlock_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.WriteCardBlock (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_WriteCardBlock_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='WriteCardBlock' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("WriteCardBlock", "(I[B)Z", "GetWriteCardBlock_IarrayBHandler")]
		public virtual unsafe bool WriteCardBlock (int p0, byte[] p1)
		{
			if (id_WriteCardBlock_IarrayB == IntPtr.Zero)
				id_WriteCardBlock_IarrayB = JNIEnv.GetMethodID (class_ref, "WriteCardBlock", "(I[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_WriteCardBlock_IarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "WriteCardBlock", "(I[B)Z"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep ();
		}
#pragma warning restore 0169

		static IntPtr id_beep;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='beep' and count(parameter)=0]"
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
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='close' and count(parameter)=0]"
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
			global::Aclasdriver.Rfid __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Rfid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='rfid']/method[@name='open' and count(parameter)=0]"
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
