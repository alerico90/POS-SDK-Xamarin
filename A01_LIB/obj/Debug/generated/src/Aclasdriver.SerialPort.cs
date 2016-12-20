using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Aclasdriver {

	// Metadata.xml XPath class reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']"
	[global::Android.Runtime.Register ("aclasdriver/SerialPort", DoNotGenerateAcw=true)]
	public partial class SerialPort : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "SerialPort";

		static IntPtr mFd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/field[@name='mFd']"
		[Register ("mFd")]
		public global::Java.IO.FileDescriptor MFd {
			get {
				if (mFd_jfieldId == IntPtr.Zero)
					mFd_jfieldId = JNIEnv.GetFieldID (class_ref, "mFd", "Ljava/io/FileDescriptor;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mFd_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFd_jfieldId == IntPtr.Zero)
					mFd_jfieldId = JNIEnv.GetFieldID (class_ref, "mFd", "Ljava/io/FileDescriptor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mFd_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFileInputStream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/field[@name='mFileInputStream']"
		[Register ("mFileInputStream")]
		public global::System.IO.Stream MFileInputStream {
			get {
				if (mFileInputStream_jfieldId == IntPtr.Zero)
					mFileInputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileInputStream", "Ljava/io/FileInputStream;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mFileInputStream_jfieldId);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileInputStream_jfieldId == IntPtr.Zero)
					mFileInputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileInputStream", "Ljava/io/FileInputStream;");
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mFileInputStream_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFileOutputStream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/field[@name='mFileOutputStream']"
		[Register ("mFileOutputStream")]
		public global::System.IO.Stream MFileOutputStream {
			get {
				if (mFileOutputStream_jfieldId == IntPtr.Zero)
					mFileOutputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileOutputStream", "Ljava/io/FileOutputStream;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mFileOutputStream_jfieldId);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileOutputStream_jfieldId == IntPtr.Zero)
					mFileOutputStream_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileOutputStream", "Ljava/io/FileOutputStream;");
				IntPtr native_value = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mFileOutputStream_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("aclasdriver/SerialPort", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerialPort); }
		}

		protected SerialPort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/constructor[@name='SerialPort' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/File;II)V", "")]
		public unsafe SerialPort (global::Java.IO.File p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SerialPort)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_II == IntPtr.Zero)
					id_ctor_Ljava_io_File_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_II, __args);
			} finally {
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.SerialPort __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Aclasdriver.SerialPort __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Aclasdriver.SerialPort __this = global::Java.Lang.Object.GetObject<global::Aclasdriver.SerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/method[@name='close' and count(parameter)=0]"
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

		static IntPtr id_open_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='aclasdriver']/class[@name='SerialPort']/method[@name='open' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("open", "(Ljava/lang/String;II)Ljava/io/FileDescriptor;", "")]
		public static unsafe global::Java.IO.FileDescriptor Open (string p0, int p1, int p2)
		{
			if (id_open_Ljava_lang_String_II == IntPtr.Zero)
				id_open_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "open", "(Ljava/lang/String;II)Ljava/io/FileDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.IO.FileDescriptor __ret = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_open_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
