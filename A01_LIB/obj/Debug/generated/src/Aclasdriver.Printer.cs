using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='printer']"
	[global::Android.Runtime.Register ("aclasdriver/printer", DoNotGenerateAcw=true)]
	public partial class Printer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/printer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Printer); }
		}

		protected Printer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/constructor[@name='printer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Printer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Printer)) {
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

		static Delegate cb_GetDotWidth;
#pragma warning disable 0169
		static Delegate GetGetDotWidthHandler ()
		{
			if (cb_GetDotWidth == null)
				cb_GetDotWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDotWidth);
			return cb_GetDotWidth;
		}

		static int n_GetDotWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DotWidth;
		}
#pragma warning restore 0169

		static IntPtr id_GetDotWidth;
		public virtual unsafe int DotWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='GetDotWidth' and count(parameter)=0]"
			[Register ("GetDotWidth", "()I", "GetGetDotWidthHandler")]
			get {
				if (id_GetDotWidth == IntPtr.Zero)
					id_GetDotWidth = JNIEnv.GetMethodID (class_ref, "GetDotWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_GetDotWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetDotWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_IsPaperExist;
#pragma warning disable 0169
		static Delegate GetIsPaperExistHandler ()
		{
			if (cb_IsPaperExist == null)
				cb_IsPaperExist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaperExist);
			return cb_IsPaperExist;
		}

		static bool n_IsPaperExist (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaperExist;
		}
#pragma warning restore 0169

		static IntPtr id_IsPaperExist;
		public virtual unsafe bool IsPaperExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='IsPaperExist' and count(parameter)=0]"
			[Register ("IsPaperExist", "()Z", "GetIsPaperExistHandler")]
			get {
				if (id_IsPaperExist == IntPtr.Zero)
					id_IsPaperExist = JNIEnv.GetMethodID (class_ref, "IsPaperExist", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_IsPaperExist);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "IsPaperExist", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_Close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_Close == null)
				cb_Close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_Close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_Close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Close' and count(parameter)=0]"
		[Register ("Close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_Close == IntPtr.Zero)
				id_Close = JNIEnv.GetMethodID (class_ref, "Close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_Close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Close", "()V"));
			} finally {
			}
		}

		static Delegate cb_Conitnue;
#pragma warning disable 0169
		static Delegate GetConitnueHandler ()
		{
			if (cb_Conitnue == null)
				cb_Conitnue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Conitnue);
			return cb_Conitnue;
		}

		static int n_Conitnue (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Conitnue ();
		}
#pragma warning restore 0169

		static IntPtr id_Conitnue;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Conitnue' and count(parameter)=0]"
		[Register ("Conitnue", "()I", "GetConitnueHandler")]
		public virtual unsafe int Conitnue ()
		{
			if (id_Conitnue == IntPtr.Zero)
				id_Conitnue = JNIEnv.GetMethodID (class_ref, "Conitnue", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Conitnue);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Conitnue", "()I"));
			} finally {
			}
		}

		static Delegate cb_Feed_I;
#pragma warning disable 0169
		static Delegate GetFeed_IHandler ()
		{
			if (cb_Feed_I == null)
				cb_Feed_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Feed_I);
			return cb_Feed_I;
		}

		static int n_Feed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Feed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Feed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Feed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Feed", "(I)I", "GetFeed_IHandler")]
		public virtual unsafe int Feed (int p0)
		{
			if (id_Feed_I == IntPtr.Zero)
				id_Feed_I = JNIEnv.GetMethodID (class_ref, "Feed", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Feed_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Feed", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_Open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_Open == null)
				cb_Open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Open);
			return cb_Open;
		}

		static int n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_Open;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Open' and count(parameter)=0]"
		[Register ("Open", "()I", "GetOpenHandler")]
		public virtual unsafe int Open ()
		{
			if (id_Open == IntPtr.Zero)
				id_Open = JNIEnv.GetMethodID (class_ref, "Open", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Open);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Open", "()I"));
			} finally {
			}
		}

		static Delegate cb_Read_I;
#pragma warning disable 0169
		static Delegate GetRead_IHandler ()
		{
			if (cb_Read_I == null)
				cb_Read_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Read_I);
			return cb_Read_I;
		}

		static IntPtr n_Read_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Read (p0));
		}
#pragma warning restore 0169

		static IntPtr id_Read_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Read' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Read", "(I)[B", "GetRead_IHandler")]
		public virtual unsafe byte[] Read (int p0)
		{
			if (id_Read_I == IntPtr.Zero)
				id_Read_I = JNIEnv.GetMethodID (class_ref, "Read", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_Read_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Read", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_SetContrast_I;
#pragma warning disable 0169
		static Delegate GetSetContrast_IHandler ()
		{
			if (cb_SetContrast_I == null)
				cb_SetContrast_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetContrast_I);
			return cb_SetContrast_I;
		}

		static int n_SetContrast_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetContrast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetContrast_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='SetContrast' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetContrast", "(I)I", "GetSetContrast_IHandler")]
		public virtual unsafe int SetContrast (int p0)
		{
			if (id_SetContrast_I == IntPtr.Zero)
				id_SetContrast_I = JNIEnv.GetMethodID (class_ref, "SetContrast", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_SetContrast_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetContrast", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_SetPrintMode_I;
#pragma warning disable 0169
		static Delegate GetSetPrintMode_IHandler ()
		{
			if (cb_SetPrintMode_I == null)
				cb_SetPrintMode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetPrintMode_I);
			return cb_SetPrintMode_I;
		}

		static int n_SetPrintMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPrintMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetPrintMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='SetPrintMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetPrintMode", "(I)I", "GetSetPrintMode_IHandler")]
		public virtual unsafe int SetPrintMode (int p0)
		{
			if (id_SetPrintMode_I == IntPtr.Zero)
				id_SetPrintMode_I = JNIEnv.GetMethodID (class_ref, "SetPrintMode", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_SetPrintMode_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetPrintMode", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_Stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_Stop == null)
				cb_Stop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Stop);
			return cb_Stop;
		}

		static int n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_Stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Stop' and count(parameter)=0]"
		[Register ("Stop", "()I", "GetStopHandler")]
		public virtual unsafe int Stop ()
		{
			if (id_Stop == IntPtr.Zero)
				id_Stop = JNIEnv.GetMethodID (class_ref, "Stop", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_Stop);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Stop", "()I"));
			} finally {
			}
		}

		static Delegate cb_Write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_Write_arrayB == null)
				cb_Write_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayB);
			return cb_Write_arrayB;
		}

		static int n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Aclasdriver.Printer __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.Printer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_Write_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='printer']/method[@name='Write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Write", "([B)I", "GetWrite_arrayBHandler")]
		public virtual unsafe int Write (byte[] p0)
		{
			if (id_Write_arrayB == IntPtr.Zero)
				id_Write_arrayB = JNIEnv.GetMethodID (class_ref, "Write", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_Write_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Write", "([B)I"), __args);
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
