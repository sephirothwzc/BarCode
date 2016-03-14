using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing']"
	[global::Android.Runtime.Register ("com/hsm/barcode/DecodeWindowing", DoNotGenerateAcw=true)]
	public partial class DecodeWindowing : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecodeWindowing$DecodeWindow", DoNotGenerateAcw=true)]
		public sealed partial class DecodeWindow : global::Java.Lang.Object {


			static IntPtr LowerRightX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']/field[@name='LowerRightX']"
			[Register ("LowerRightX")]
			public int LowerRightX {
				get {
					if (LowerRightX_jfieldId == IntPtr.Zero)
						LowerRightX_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRightX", "I");
					return JNIEnv.GetIntField (Handle, LowerRightX_jfieldId);
				}
				set {
					if (LowerRightX_jfieldId == IntPtr.Zero)
						LowerRightX_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRightX", "I");
					try {
						JNIEnv.SetField (Handle, LowerRightX_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr LowerRightY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']/field[@name='LowerRightY']"
			[Register ("LowerRightY")]
			public int LowerRightY {
				get {
					if (LowerRightY_jfieldId == IntPtr.Zero)
						LowerRightY_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRightY", "I");
					return JNIEnv.GetIntField (Handle, LowerRightY_jfieldId);
				}
				set {
					if (LowerRightY_jfieldId == IntPtr.Zero)
						LowerRightY_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRightY", "I");
					try {
						JNIEnv.SetField (Handle, LowerRightY_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeftX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']/field[@name='UpperLeftX']"
			[Register ("UpperLeftX")]
			public int UpperLeftX {
				get {
					if (UpperLeftX_jfieldId == IntPtr.Zero)
						UpperLeftX_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeftX", "I");
					return JNIEnv.GetIntField (Handle, UpperLeftX_jfieldId);
				}
				set {
					if (UpperLeftX_jfieldId == IntPtr.Zero)
						UpperLeftX_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeftX", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeftX_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeftY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']/field[@name='UpperLeftY']"
			[Register ("UpperLeftY")]
			public int UpperLeftY {
				get {
					if (UpperLeftY_jfieldId == IntPtr.Zero)
						UpperLeftY_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeftY", "I");
					return JNIEnv.GetIntField (Handle, UpperLeftY_jfieldId);
				}
				set {
					if (UpperLeftY_jfieldId == IntPtr.Zero)
						UpperLeftY_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeftY", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeftY_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecodeWindowing$DecodeWindow", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecodeWindow); }
			}

			internal DecodeWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindow']/constructor[@name='DecodeWindowing.DecodeWindow' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DecodeWindow ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DecodeWindow)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecodeWindowing$DecodeWindowLimits", DoNotGenerateAcw=true)]
		public sealed partial class DecodeWindowLimits : global::Java.Lang.Object {


			static IntPtr LowerRight_X_Max_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='LowerRight_X_Max']"
			[Register ("LowerRight_X_Max")]
			public int LowerRightXMax {
				get {
					if (LowerRight_X_Max_jfieldId == IntPtr.Zero)
						LowerRight_X_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_X_Max", "I");
					return JNIEnv.GetIntField (Handle, LowerRight_X_Max_jfieldId);
				}
				set {
					if (LowerRight_X_Max_jfieldId == IntPtr.Zero)
						LowerRight_X_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_X_Max", "I");
					try {
						JNIEnv.SetField (Handle, LowerRight_X_Max_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr LowerRight_X_Min_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='LowerRight_X_Min']"
			[Register ("LowerRight_X_Min")]
			public int LowerRightXMin {
				get {
					if (LowerRight_X_Min_jfieldId == IntPtr.Zero)
						LowerRight_X_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_X_Min", "I");
					return JNIEnv.GetIntField (Handle, LowerRight_X_Min_jfieldId);
				}
				set {
					if (LowerRight_X_Min_jfieldId == IntPtr.Zero)
						LowerRight_X_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_X_Min", "I");
					try {
						JNIEnv.SetField (Handle, LowerRight_X_Min_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr LowerRight_Y_Max_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='LowerRight_Y_Max']"
			[Register ("LowerRight_Y_Max")]
			public int LowerRightYMax {
				get {
					if (LowerRight_Y_Max_jfieldId == IntPtr.Zero)
						LowerRight_Y_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_Y_Max", "I");
					return JNIEnv.GetIntField (Handle, LowerRight_Y_Max_jfieldId);
				}
				set {
					if (LowerRight_Y_Max_jfieldId == IntPtr.Zero)
						LowerRight_Y_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_Y_Max", "I");
					try {
						JNIEnv.SetField (Handle, LowerRight_Y_Max_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr LowerRight_Y_Min_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='LowerRight_Y_Min']"
			[Register ("LowerRight_Y_Min")]
			public int LowerRightYMin {
				get {
					if (LowerRight_Y_Min_jfieldId == IntPtr.Zero)
						LowerRight_Y_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_Y_Min", "I");
					return JNIEnv.GetIntField (Handle, LowerRight_Y_Min_jfieldId);
				}
				set {
					if (LowerRight_Y_Min_jfieldId == IntPtr.Zero)
						LowerRight_Y_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "LowerRight_Y_Min", "I");
					try {
						JNIEnv.SetField (Handle, LowerRight_Y_Min_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeft_X_Max_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='UpperLeft_X_Max']"
			[Register ("UpperLeft_X_Max")]
			public int UpperLeftXMax {
				get {
					if (UpperLeft_X_Max_jfieldId == IntPtr.Zero)
						UpperLeft_X_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_X_Max", "I");
					return JNIEnv.GetIntField (Handle, UpperLeft_X_Max_jfieldId);
				}
				set {
					if (UpperLeft_X_Max_jfieldId == IntPtr.Zero)
						UpperLeft_X_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_X_Max", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeft_X_Max_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeft_X_Min_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='UpperLeft_X_Min']"
			[Register ("UpperLeft_X_Min")]
			public int UpperLeftXMin {
				get {
					if (UpperLeft_X_Min_jfieldId == IntPtr.Zero)
						UpperLeft_X_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_X_Min", "I");
					return JNIEnv.GetIntField (Handle, UpperLeft_X_Min_jfieldId);
				}
				set {
					if (UpperLeft_X_Min_jfieldId == IntPtr.Zero)
						UpperLeft_X_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_X_Min", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeft_X_Min_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeft_Y_Max_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='UpperLeft_Y_Max']"
			[Register ("UpperLeft_Y_Max")]
			public int UpperLeftYMax {
				get {
					if (UpperLeft_Y_Max_jfieldId == IntPtr.Zero)
						UpperLeft_Y_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_Y_Max", "I");
					return JNIEnv.GetIntField (Handle, UpperLeft_Y_Max_jfieldId);
				}
				set {
					if (UpperLeft_Y_Max_jfieldId == IntPtr.Zero)
						UpperLeft_Y_Max_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_Y_Max", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeft_Y_Max_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr UpperLeft_Y_Min_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/field[@name='UpperLeft_Y_Min']"
			[Register ("UpperLeft_Y_Min")]
			public int UpperLeftYMin {
				get {
					if (UpperLeft_Y_Min_jfieldId == IntPtr.Zero)
						UpperLeft_Y_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_Y_Min", "I");
					return JNIEnv.GetIntField (Handle, UpperLeft_Y_Min_jfieldId);
				}
				set {
					if (UpperLeft_Y_Min_jfieldId == IntPtr.Zero)
						UpperLeft_Y_Min_jfieldId = JNIEnv.GetFieldID (class_ref, "UpperLeft_Y_Min", "I");
					try {
						JNIEnv.SetField (Handle, UpperLeft_Y_Min_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecodeWindowing$DecodeWindowLimits", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecodeWindowLimits); }
			}

			internal DecodeWindowLimits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowLimits']/constructor[@name='DecodeWindowing.DecodeWindowLimits' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DecodeWindowLimits ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DecodeWindowLimits)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowMode']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecodeWindowing$DecodeWindowMode", DoNotGenerateAcw=true)]
		public sealed partial class DecodeWindowMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowMode']/field[@name='DECODE_WINDOW_MODE_AIMER']"
			[Register ("DECODE_WINDOW_MODE_AIMER")]
			public const int DecodeWindowModeAimer = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowMode']/field[@name='DECODE_WINDOW_MODE_DISABLED']"
			[Register ("DECODE_WINDOW_MODE_DISABLED")]
			public const int DecodeWindowModeDisabled = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowMode']/field[@name='DECODE_WINDOW_MODE_FIELD_OF_VIEW']"
			[Register ("DECODE_WINDOW_MODE_FIELD_OF_VIEW")]
			public const int DecodeWindowModeFieldOfView = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowMode']/field[@name='DECODE_WINDOW_MODE_SUB_IMAGE']"
			[Register ("DECODE_WINDOW_MODE_SUB_IMAGE")]
			public const int DecodeWindowModeSubImage = (int) 3;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecodeWindowing$DecodeWindowMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecodeWindowMode); }
			}

			internal DecodeWindowMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowShowWindow']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecodeWindowing$DecodeWindowShowWindow", DoNotGenerateAcw=true)]
		public sealed partial class DecodeWindowShowWindow : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowShowWindow']/field[@name='DECODE_WINDOW_SHOW_WINDOW_BLACK']"
			[Register ("DECODE_WINDOW_SHOW_WINDOW_BLACK")]
			public const int DecodeWindowShowWindowBlack = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowShowWindow']/field[@name='DECODE_WINDOW_SHOW_WINDOW_DISABLED']"
			[Register ("DECODE_WINDOW_SHOW_WINDOW_DISABLED")]
			public const int DecodeWindowShowWindowDisabled = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing.DecodeWindowShowWindow']/field[@name='DECODE_WINDOW_SHOW_WINDOW_WHITE']"
			[Register ("DECODE_WINDOW_SHOW_WINDOW_WHITE")]
			public const int DecodeWindowShowWindowWhite = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecodeWindowing$DecodeWindowShowWindow", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecodeWindowShowWindow); }
			}

			internal DecodeWindowShowWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/DecodeWindowing", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodeWindowing); }
		}

		protected DecodeWindowing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeWindowing']/constructor[@name='DecodeWindowing' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DecodeWindowing ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DecodeWindowing)) {
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
