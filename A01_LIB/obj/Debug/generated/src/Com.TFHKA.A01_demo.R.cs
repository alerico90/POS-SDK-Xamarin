using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TFHKA.A01_demo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R']"
	[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$anim", DoNotGenerateAcw=true)]
		public sealed partial class Anim : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']/field[@name='slide_left_in']"
			[Register ("slide_left_in")]
			public const int SlideLeftIn = (int) 2130968576;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']/field[@name='slide_left_out']"
			[Register ("slide_left_out")]
			public const int SlideLeftOut = (int) 2130968577;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']/field[@name='slide_right_in']"
			[Register ("slide_right_in")]
			public const int SlideRightIn = (int) 2130968578;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']/field[@name='slide_right_out']"
			[Register ("slide_right_out")]
			public const int SlideRightOut = (int) 2130968579;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$anim", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Anim); }
			}

			internal Anim (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.anim']/constructor[@name='R.anim' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Anim ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Anim)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.array']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$array", DoNotGenerateAcw=true)]
		public sealed partial class Array : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.array']/field[@name='DotModePic']"
			[Register ("DotModePic")]
			public const int DotModePic = (int) 2131165184;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.array']/field[@name='SerialBoudRate']"
			[Register ("SerialBoudRate")]
			public const int SerialBoudRate = (int) 2131165186;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.array']/field[@name='SerialNum']"
			[Register ("SerialNum")]
			public const int SerialNum = (int) 2131165185;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$array", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Array); }
			}

			internal Array (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.array']/constructor[@name='R.array' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Array ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Array)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Attr)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.dimen']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$dimen", DoNotGenerateAcw=true)]
		public sealed partial class Dimen : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.dimen']/field[@name='activity_horizontal_margin']"
			[Register ("activity_horizontal_margin")]
			public const int ActivityHorizontalMargin = (int) 2131034112;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.dimen']/field[@name='activity_vertical_margin']"
			[Register ("activity_vertical_margin")]
			public const int ActivityVerticalMargin = (int) 2131034113;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$dimen", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dimen); }
			}

			internal Dimen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.dimen']/constructor[@name='R.dimen' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Dimen ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Dimen)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$drawable", DoNotGenerateAcw=true)]
		public sealed partial class Drawable : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='android_man']"
			[Register ("android_man")]
			public const int AndroidMan = (int) 2130837504;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='ic_launcher']"
			[Register ("ic_launcher")]
			public const int IcLauncher = (int) 2130837505;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='lcd']"
			[Register ("lcd")]
			public const int Lcd = (int) 2130837506;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='logo']"
			[Register ("logo")]
			public const int Logo = (int) 2130837507;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='magcard']"
			[Register ("magcard")]
			public const int Magcard = (int) 2130837508;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='pow']"
			[Register ("pow")]
			public const int Pow = (int) 2130837509;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='printpng']"
			[Register ("printpng")]
			public const int Printpng = (int) 2130837510;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='processbar']"
			[Register ("processbar")]
			public const int Processbar = (int) 2130837511;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='rfid']"
			[Register ("rfid")]
			public const int Rfid = (int) 2130837512;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='smartcardpng']"
			[Register ("smartcardpng")]
			public const int Smartcardpng = (int) 2130837513;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='test1']"
			[Register ("test1")]
			public const int Test1 = (int) 2130837514;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='test2']"
			[Register ("test2")]
			public const int Test2 = (int) 2130837515;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='thumb']"
			[Register ("thumb")]
			public const int Thumb = (int) 2130837516;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='thumb2']"
			[Register ("thumb2")]
			public const int Thumb2 = (int) 2130837517;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/field[@name='thumb3']"
			[Register ("thumb3")]
			public const int Thumb3 = (int) 2130837518;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$drawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Drawable); }
			}

			internal Drawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.drawable']/constructor[@name='R.drawable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Drawable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Drawable)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_changemode']"
			[Register ("button_changemode")]
			public const int ButtonChangemode = (int) 2131296261;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_continue']"
			[Register ("button_continue")]
			public const int ButtonContinue = (int) 2131296267;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_exit']"
			[Register ("button_exit")]
			public const int ButtonExit = (int) 2131296268;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_feed']"
			[Register ("button_feed")]
			public const int ButtonFeed = (int) 2131296265;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_print']"
			[Register ("button_print")]
			public const int ButtonPrint = (int) 2131296264;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='button_stop']"
			[Register ("button_stop")]
			public const int ButtonStop = (int) 2131296266;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='container_printer']"
			[Register ("container_printer")]
			public const int ContainerPrinter = (int) 2131296256;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='desctxt']"
			[Register ("desctxt")]
			public const int Desctxt = (int) 2131296269;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='seekBar1']"
			[Register ("seekBar1")]
			public const int SeekBar1 = (int) 2131296262;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='spinner1']"
			[Register ("spinner1")]
			public const int Spinner1 = (int) 2131296263;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='textView_contrast']"
			[Register ("textView_contrast")]
			public const int TextViewContrast = (int) 2131296258;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='textView_dotwidth']"
			[Register ("textView_dotwidth")]
			public const int TextViewDotwidth = (int) 2131296257;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='textView_mode']"
			[Register ("textView_mode")]
			public const int TextViewMode = (int) 2131296260;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='textView_paperstatus']"
			[Register ("textView_paperstatus")]
			public const int TextViewPaperstatus = (int) 2131296259;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/field[@name='titlebutton']"
			[Register ("titlebutton")]
			public const int Titlebutton = (int) 2131296270;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Id ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Id)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.layout']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$layout", DoNotGenerateAcw=true)]
		public sealed partial class Layout : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.layout']/field[@name='printer_main']"
			[Register ("printer_main")]
			public const int PrinterMain = (int) 2130903040;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$layout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Layout); }
			}

			internal Layout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.layout']/constructor[@name='R.layout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Layout ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Layout)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.menu']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$menu", DoNotGenerateAcw=true)]
		public sealed partial class Menu : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.menu']/field[@name='main']"
			[Register ("main")]
			public const int Main = (int) 2131230720;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$menu", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Menu); }
			}

			internal Menu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.menu']/constructor[@name='R.menu' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Menu ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Menu)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']"
		[global::Android.Runtime.Register ("com/TFHKA/a01_demo/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='ATR']"
			[Register ("ATR")]
			public const int Atr = (int) 2131099683;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='AclasDemo']"
			[Register ("AclasDemo")]
			public const int AclasDemo = (int) 2131099708;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='AddMoney']"
			[Register ("AddMoney")]
			public const int AddMoney = (int) 2131099673;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='BlockTest']"
			[Register ("BlockTest")]
			public const int BlockTest = (int) 2131099678;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='CardInfo']"
			[Register ("CardInfo")]
			public const int CardInfo = (int) 2131099675;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='CardNo']"
			[Register ("CardNo")]
			public const int CardNo = (int) 2131099671;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Continue']"
			[Register ("Continue")]
			public const int Continue = (int) 2131099670;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='DecMoney']"
			[Register ("DecMoney")]
			public const int DecMoney = (int) 2131099674;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Description']"
			[Register ("Description")]
			public const int Description = (int) 2131099687;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='DrawerOpen']"
			[Register ("DrawerOpen")]
			public const int DrawerOpen = (int) 2131099701;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Exit']"
			[Register ("Exit")]
			public const int Exit = (int) 2131099676;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='InitCard']"
			[Register ("InitCard")]
			public const int InitCard = (int) 2131099672;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='KM3Demo']"
			[Register ("KM3Demo")]
			public const int KM3Demo = (int) 2131099702;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Num_100']"
			[Register ("Num_100")]
			public const int Num100 = (int) 2131099677;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Print']"
			[Register ("Print")]
			public const int Print = (int) 2131099688;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='SendMsg']"
			[Register ("SendMsg")]
			public const int SendMsg = (int) 2131099649;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='Title']"
			[Register ("Title")]
			public const int Title = (int) 2131099686;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='USBRFID']"
			[Register ("USBRFID")]
			public const int Usbrfid = (int) 2131099703;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='about']"
			[Register ("about")]
			public const int About = (int) 2131099653;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='action_settings']"
			[Register ("action_settings")]
			public const int ActionSettings = (int) 2131099684;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='app_name']"
			[Register ("app_name")]
			public const int AppName = (int) 2131099690;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='changemode']"
			[Register ("changemode")]
			public const int Changemode = (int) 2131099655;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='clear']"
			[Register ("clear")]
			public const int Clear = (int) 2131099650;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='contrast']"
			[Register ("contrast")]
			public const int Contrast = (int) 2131099669;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='dotmode']"
			[Register ("dotmode")]
			public const int Dotmode = (int) 2131099668;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='dotwidth']"
			[Register ("dotwidth")]
			public const int Dotwidth = (int) 2131099656;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='epsonmode']"
			[Register ("epsonmode")]
			public const int Epsonmode = (int) 2131099667;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='feed']"
			[Register ("feed")]
			public const int Feed = (int) 2131099657;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='getdotwidth']"
			[Register ("getdotwidth")]
			public const int Getdotwidth = (int) 2131099662;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='getpaperstatus']"
			[Register ("getpaperstatus")]
			public const int Getpaperstatus = (int) 2131099663;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='havepaper']"
			[Register ("havepaper")]
			public const int Havepaper = (int) 2131099666;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='hdq_tab']"
			[Register ("hdq_tab")]
			public const int HdqTab = (int) 2131099696;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='hdqdisconnect']"
			[Register ("hdqdisconnect")]
			public const int Hdqdisconnect = (int) 2131099648;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='hello']"
			[Register ("hello")]
			public const int Hello = (int) 2131099689;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='hello_world']"
			[Register ("hello_world")]
			public const int HelloWorld = (int) 2131099685;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='lcd_tab']"
			[Register ("lcd_tab")]
			public const int LcdTab = (int) 2131099694;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='macerr']"
			[Register ("macerr")]
			public const int Macerr = (int) 2131099654;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='magcard']"
			[Register ("magcard")]
			public const int Magcard = (int) 2131099652;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='magcard_tab']"
			[Register ("magcard_tab")]
			public const int MagcardTab = (int) 2131099695;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='mode']"
			[Register ("mode")]
			public const int Mode = (int) 2131099661;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='nopaper']"
			[Register ("nopaper")]
			public const int Nopaper = (int) 2131099665;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='paperstatus']"
			[Register ("paperstatus")]
			public const int Paperstatus = (int) 2131099664;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='printer_tab']"
			[Register ("printer_tab")]
			public const int PrinterTab = (int) 2131099691;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='rfid_tab']"
			[Register ("rfid_tab")]
			public const int RfidTab = (int) 2131099692;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='scale']"
			[Register ("scale")]
			public const int Scale = (int) 2131099679;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='scale_tare']"
			[Register ("scale_tare")]
			public const int ScaleTare = (int) 2131099681;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='scale_weight']"
			[Register ("scale_weight")]
			public const int ScaleWeight = (int) 2131099680;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='scale_zero']"
			[Register ("scale_zero")]
			public const int ScaleZero = (int) 2131099682;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='senddot']"
			[Register ("senddot")]
			public const int Senddot = (int) 2131099651;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='serial_show']"
			[Register ("serial_show")]
			public const int SerialShow = (int) 2131099698;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='serial_tab']"
			[Register ("serial_tab")]
			public const int SerialTab = (int) 2131099697;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='serialerr']"
			[Register ("serialerr")]
			public const int Serialerr = (int) 2131099699;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='serialread']"
			[Register ("serialread")]
			public const int Serialread = (int) 2131099700;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='smartcard_tab']"
			[Register ("smartcard_tab")]
			public const int SmartcardTab = (int) 2131099693;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='stop']"
			[Register ("stop")]
			public const int Stop = (int) 2131099658;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='usbrfid_show']"
			[Register ("usbrfid_show")]
			public const int UsbrfidShow = (int) 2131099704;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='usbrfiderr']"
			[Register ("usbrfiderr")]
			public const int Usbrfiderr = (int) 2131099705;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='usbrfidok']"
			[Register ("usbrfidok")]
			public const int Usbrfidok = (int) 2131099706;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/field[@name='usbrfidread']"
			[Register ("usbrfidread")]
			public const int Usbrfidread = (int) 2131099707;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/TFHKA/a01_demo/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe String ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (String)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/TFHKA/a01_demo/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.TFHKA.a01_demo']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
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

	}
}
