using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']"
	[global::Android.Runtime.Register ("aclasdriver/SmartCard", DoNotGenerateAcw=true)]
	public partial class SmartCard : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/SmartCard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmartCard); }
		}

		protected SmartCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/constructor[@name='SmartCard' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SmartCard ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SmartCard)) {
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

		static Delegate cb_ApduCommand_IIIIIarrayBI;
#pragma warning disable 0169
		static Delegate GetApduCommand_IIIIIarrayBIHandler ()
		{
			if (cb_ApduCommand_IIIIIarrayBI == null)
				cb_ApduCommand_IIIIIarrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, IntPtr, int, IntPtr>) n_ApduCommand_IIIIIarrayBI);
			return cb_ApduCommand_IIIIIarrayBI;
		}

		static IntPtr n_ApduCommand_IIIIIarrayBI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, IntPtr native_p5, int p6)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p5 = (byte[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ApduCommand (p0, p1, p2, p3, p4, p5, p6));
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_ApduCommand_IIIIIarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='ApduCommand' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
		[Register ("ApduCommand", "(IIIII[BI)[B", "GetApduCommand_IIIIIarrayBIHandler")]
		public virtual unsafe byte[] ApduCommand (int p0, int p1, int p2, int p3, int p4, byte[] p5, int p6)
		{
			if (id_ApduCommand_IIIIIarrayBI == IntPtr.Zero)
				id_ApduCommand_IIIIIarrayBI = JNIEnv.GetMethodID (class_ref, "ApduCommand", "(IIIII[BI)[B");
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_ApduCommand_IIIIIarrayBI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ApduCommand", "(IIIII[BI)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
			}
		}

		static Delegate cb_Close_I;
#pragma warning disable 0169
		static Delegate GetClose_IHandler ()
		{
			if (cb_Close_I == null)
				cb_Close_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Close_I);
			return cb_Close_I;
		}

		static void n_Close_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Close_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='Close' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Close", "(I)V", "GetClose_IHandler")]
		public virtual unsafe void Close (int p0)
		{
			if (id_Close_I == IntPtr.Zero)
				id_Close_I = JNIEnv.GetMethodID (class_ref, "Close", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_Close_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Close", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_GetATR_I;
#pragma warning disable 0169
		static Delegate GetGetATR_IHandler ()
		{
			if (cb_GetATR_I == null)
				cb_GetATR_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetATR_I);
			return cb_GetATR_I;
		}

		static IntPtr n_GetATR_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetATR (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetATR_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='GetATR' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetATR", "(I)[B", "GetGetATR_IHandler")]
		public virtual unsafe byte[] GetATR (int p0)
		{
			if (id_GetATR_I == IntPtr.Zero)
				id_GetATR_I = JNIEnv.GetMethodID (class_ref, "GetATR", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetATR_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetATR", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_GetChallenge8_I;
#pragma warning disable 0169
		static Delegate GetGetChallenge8_IHandler ()
		{
			if (cb_GetChallenge8_I == null)
				cb_GetChallenge8_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetChallenge8_I);
			return cb_GetChallenge8_I;
		}

		static IntPtr n_GetChallenge8_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetChallenge8 (p0));
		}
#pragma warning restore 0169

		static IntPtr id_GetChallenge8_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='GetChallenge8' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetChallenge8", "(I)[B", "GetGetChallenge8_IHandler")]
		public virtual unsafe byte[] GetChallenge8 (int p0)
		{
			if (id_GetChallenge8_I == IntPtr.Zero)
				id_GetChallenge8_I = JNIEnv.GetMethodID (class_ref, "GetChallenge8", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetChallenge8_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetChallenge8", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_GetResponse_IB;
#pragma warning disable 0169
		static Delegate GetGetResponse_IBHandler ()
		{
			if (cb_GetResponse_IB == null)
				cb_GetResponse_IB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr>) n_GetResponse_IB);
			return cb_GetResponse_IB;
		}

		static IntPtr n_GetResponse_IB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetResponse (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_GetResponse_IB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='GetResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte']]"
		[Register ("GetResponse", "(IB)[B", "GetGetResponse_IBHandler")]
		public virtual unsafe byte[] GetResponse (int p0, sbyte p1)
		{
			if (id_GetResponse_IB == IntPtr.Zero)
				id_GetResponse_IB = JNIEnv.GetMethodID (class_ref, "GetResponse", "(IB)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_GetResponse_IB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetResponse", "(IB)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_GetState_I;
#pragma warning disable 0169
		static Delegate GetGetState_IHandler ()
		{
			if (cb_GetState_I == null)
				cb_GetState_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetState_I);
			return cb_GetState_I;
		}

		static int n_GetState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_GetState_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='GetState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetState", "(I)I", "GetGetState_IHandler")]
		public virtual unsafe int GetState (int p0)
		{
			if (id_GetState_I == IntPtr.Zero)
				id_GetState_I = JNIEnv.GetMethodID (class_ref, "GetState", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_GetState_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetState", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_IsCardRemoved_I;
#pragma warning disable 0169
		static Delegate GetIsCardRemoved_IHandler ()
		{
			if (cb_IsCardRemoved_I == null)
				cb_IsCardRemoved_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_IsCardRemoved_I);
			return cb_IsCardRemoved_I;
		}

		static int n_IsCardRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCardRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_IsCardRemoved_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='IsCardRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("IsCardRemoved", "(I)I", "GetIsCardRemoved_IHandler")]
		public virtual unsafe int IsCardRemoved (int p0)
		{
			if (id_IsCardRemoved_I == IntPtr.Zero)
				id_IsCardRemoved_I = JNIEnv.GetMethodID (class_ref, "IsCardRemoved", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_IsCardRemoved_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsCardRemoved", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_Open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_Open_I == null)
				cb_Open_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Open_I);
			return cb_Open_I;
		}

		static int n_Open_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Open_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='Open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Open", "(I)I", "GetOpen_IHandler")]
		public virtual unsafe int Open (int p0)
		{
			if (id_Open_I == IntPtr.Zero)
				id_Open_I = JNIEnv.GetMethodID (class_ref, "Open", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Open_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Open", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_Pread_IarrayBII;
#pragma warning disable 0169
		static Delegate GetPread_IarrayBIIHandler ()
		{
			if (cb_Pread_IarrayBII == null)
				cb_Pread_IarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, int>) n_Pread_IarrayBII);
			return cb_Pread_IarrayBII;
		}

		static int n_Pread_IarrayBII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Pread (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Pread_IarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='Pread' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("Pread", "(I[BII)I", "GetPread_IarrayBIIHandler")]
		public virtual unsafe int Pread (int p0, byte[] p1, int p2, int p3)
		{
			if (id_Pread_IarrayBII == IntPtr.Zero)
				id_Pread_IarrayBII = JNIEnv.GetMethodID (class_ref, "Pread", "(I[BII)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_Pread_IarrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Pread", "(I[BII)I"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_Pwrite_IarrayBII;
#pragma warning disable 0169
		static Delegate GetPwrite_IarrayBIIHandler ()
		{
			if (cb_Pwrite_IarrayBII == null)
				cb_Pwrite_IarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, int, int>) n_Pwrite_IarrayBII);
			return cb_Pwrite_IarrayBII;
		}

		static int n_Pwrite_IarrayBII (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Pwrite (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Pwrite_IarrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='Pwrite' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("Pwrite", "(I[BII)I", "GetPwrite_IarrayBIIHandler")]
		public virtual unsafe int Pwrite (int p0, byte[] p1, int p2, int p3)
		{
			if (id_Pwrite_IarrayBII == IntPtr.Zero)
				id_Pwrite_IarrayBII = JNIEnv.GetMethodID (class_ref, "Pwrite", "(I[BII)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_Pwrite_IarrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Pwrite", "(I[BII)I"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_ReadBinary_CUR_IBB;
#pragma warning disable 0169
		static Delegate GetReadBinary_CUR_IBBHandler ()
		{
			if (cb_ReadBinary_CUR_IBB == null)
				cb_ReadBinary_CUR_IBB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, sbyte, IntPtr>) n_ReadBinary_CUR_IBB);
			return cb_ReadBinary_CUR_IBB;
		}

		static IntPtr n_ReadBinary_CUR_IBB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, sbyte p2)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadBinary_CUR (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_ReadBinary_CUR_IBB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='ReadBinary_CUR' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte']]"
		[Register ("ReadBinary_CUR", "(IBB)[B", "GetReadBinary_CUR_IBBHandler")]
		public virtual unsafe byte[] ReadBinary_CUR (int p0, sbyte p1, sbyte p2)
		{
			if (id_ReadBinary_CUR_IBB == IntPtr.Zero)
				id_ReadBinary_CUR_IBB = JNIEnv.GetMethodID (class_ref, "ReadBinary_CUR", "(IBB)[B");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_ReadBinary_CUR_IBB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReadBinary_CUR", "(IBB)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_SelectFile_IarrayB;
#pragma warning disable 0169
		static Delegate GetSelectFile_IarrayBHandler ()
		{
			if (cb_SelectFile_IarrayB == null)
				cb_SelectFile_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SelectFile_IarrayB);
			return cb_SelectFile_IarrayB;
		}

		static IntPtr n_SelectFile_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.SelectFile (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SelectFile_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='SelectFile' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("SelectFile", "(I[B)[B", "GetSelectFile_IarrayBHandler")]
		public virtual unsafe byte[] SelectFile (int p0, byte[] p1)
		{
			if (id_SelectFile_IarrayB == IntPtr.Zero)
				id_SelectFile_IarrayB = JNIEnv.GetMethodID (class_ref, "SelectFile", "(I[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_SelectFile_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SelectFile", "(I[B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_SendCommand_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetSendCommand_IarrayBarrayBHandler ()
		{
			if (cb_SendCommand_IarrayBarrayB == null)
				cb_SendCommand_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_SendCommand_IarrayBarrayB);
			return cb_SendCommand_IarrayBarrayB;
		}

		static int n_SendCommand_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SendCommand (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_SendCommand_IarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='SendCommand' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("SendCommand", "(I[B[B)I", "GetSendCommand_IarrayBarrayBHandler")]
		public virtual unsafe int SendCommand (int p0, byte[] p1, byte[] p2)
		{
			if (id_SendCommand_IarrayBarrayB == IntPtr.Zero)
				id_SendCommand_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "SendCommand", "(I[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_SendCommand_IarrayBarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SendCommand", "(I[B[B)I"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_SetCardType_II;
#pragma warning disable 0169
		static Delegate GetSetCardType_IIHandler ()
		{
			if (cb_SetCardType_II == null)
				cb_SetCardType_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_SetCardType_II);
			return cb_SetCardType_II;
		}

		static int n_SetCardType_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCardType (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_SetCardType_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='SetCardType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("SetCardType", "(II)I", "GetSetCardType_IIHandler")]
		public virtual unsafe int SetCardType (int p0, int p1)
		{
			if (id_SetCardType_II == IntPtr.Zero)
				id_SetCardType_II = JNIEnv.GetMethodID (class_ref, "SetCardType", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_SetCardType_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCardType", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_TestCardReady_I;
#pragma warning disable 0169
		static Delegate GetTestCardReady_IHandler ()
		{
			if (cb_TestCardReady_I == null)
				cb_TestCardReady_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_TestCardReady_I);
			return cb_TestCardReady_I;
		}

		static int n_TestCardReady_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TestCardReady (p0);
		}
#pragma warning restore 0169

		static IntPtr id_TestCardReady_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='TestCardReady' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("TestCardReady", "(I)I", "GetTestCardReady_IHandler")]
		public virtual unsafe int TestCardReady (int p0)
		{
			if (id_TestCardReady_I == IntPtr.Zero)
				id_TestCardReady_I = JNIEnv.GetMethodID (class_ref, "TestCardReady", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_TestCardReady_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "TestCardReady", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_VerifyPIN_IBarrayB;
#pragma warning disable 0169
		static Delegate GetVerifyPIN_IBarrayBHandler ()
		{
			if (cb_VerifyPIN_IBarrayB == null)
				cb_VerifyPIN_IBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr, IntPtr>) n_VerifyPIN_IBarrayB);
			return cb_VerifyPIN_IBarrayB;
		}

		static IntPtr n_VerifyPIN_IBarrayB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, IntPtr native_p2)
		{
			global::Aclasdriver.SmartCard __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SmartCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.VerifyPIN (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_VerifyPIN_IBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SmartCard']/method[@name='VerifyPIN' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("VerifyPIN", "(IB[B)[B", "GetVerifyPIN_IBarrayBHandler")]
		public virtual unsafe byte[] VerifyPIN (int p0, sbyte p1, byte[] p2)
		{
			if (id_VerifyPIN_IBarrayB == IntPtr.Zero)
				id_VerifyPIN_IBarrayB = JNIEnv.GetMethodID (class_ref, "VerifyPIN", "(IB[B)[B");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_VerifyPIN_IBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "VerifyPIN", "(IB[B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
