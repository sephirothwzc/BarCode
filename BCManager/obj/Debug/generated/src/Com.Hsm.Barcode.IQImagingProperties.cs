using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']"
	[global::Android.Runtime.Register ("com/hsm/barcode/IQImagingProperties", DoNotGenerateAcw=true)]
	public partial class IQImagingProperties : global::Java.Lang.Object {


		static IntPtr AspectRatio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='AspectRatio']"
		[Register ("AspectRatio")]
		public int AspectRatio {
			get {
				if (AspectRatio_jfieldId == IntPtr.Zero)
					AspectRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "AspectRatio", "I");
				return JNIEnv.GetIntField (Handle, AspectRatio_jfieldId);
			}
			set {
				if (AspectRatio_jfieldId == IntPtr.Zero)
					AspectRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "AspectRatio", "I");
				try {
					JNIEnv.SetField (Handle, AspectRatio_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Format']"
		[Register ("Format")]
		public int Format {
			get {
				if (Format_jfieldId == IntPtr.Zero)
					Format_jfieldId = JNIEnv.GetFieldID (class_ref, "Format", "I");
				return JNIEnv.GetIntField (Handle, Format_jfieldId);
			}
			set {
				if (Format_jfieldId == IntPtr.Zero)
					Format_jfieldId = JNIEnv.GetFieldID (class_ref, "Format", "I");
				try {
					JNIEnv.SetField (Handle, Format_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Height']"
		[Register ("Height")]
		public int Height {
			get {
				if (Height_jfieldId == IntPtr.Zero)
					Height_jfieldId = JNIEnv.GetFieldID (class_ref, "Height", "I");
				return JNIEnv.GetIntField (Handle, Height_jfieldId);
			}
			set {
				if (Height_jfieldId == IntPtr.Zero)
					Height_jfieldId = JNIEnv.GetFieldID (class_ref, "Height", "I");
				try {
					JNIEnv.SetField (Handle, Height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Reserved_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Reserved']"
		[Register ("Reserved")]
		public int Reserved {
			get {
				if (Reserved_jfieldId == IntPtr.Zero)
					Reserved_jfieldId = JNIEnv.GetFieldID (class_ref, "Reserved", "I");
				return JNIEnv.GetIntField (Handle, Reserved_jfieldId);
			}
			set {
				if (Reserved_jfieldId == IntPtr.Zero)
					Reserved_jfieldId = JNIEnv.GetFieldID (class_ref, "Reserved", "I");
				try {
					JNIEnv.SetField (Handle, Reserved_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Resolution_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Resolution']"
		[Register ("Resolution")]
		public int Resolution {
			get {
				if (Resolution_jfieldId == IntPtr.Zero)
					Resolution_jfieldId = JNIEnv.GetFieldID (class_ref, "Resolution", "I");
				return JNIEnv.GetIntField (Handle, Resolution_jfieldId);
			}
			set {
				if (Resolution_jfieldId == IntPtr.Zero)
					Resolution_jfieldId = JNIEnv.GetFieldID (class_ref, "Resolution", "I");
				try {
					JNIEnv.SetField (Handle, Resolution_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Width']"
		[Register ("Width")]
		public int Width {
			get {
				if (Width_jfieldId == IntPtr.Zero)
					Width_jfieldId = JNIEnv.GetFieldID (class_ref, "Width", "I");
				return JNIEnv.GetIntField (Handle, Width_jfieldId);
			}
			set {
				if (Width_jfieldId == IntPtr.Zero)
					Width_jfieldId = JNIEnv.GetFieldID (class_ref, "Width", "I");
				try {
					JNIEnv.SetField (Handle, Width_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr X_Offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='X_Offset']"
		[Register ("X_Offset")]
		public int XOffset {
			get {
				if (X_Offset_jfieldId == IntPtr.Zero)
					X_Offset_jfieldId = JNIEnv.GetFieldID (class_ref, "X_Offset", "I");
				return JNIEnv.GetIntField (Handle, X_Offset_jfieldId);
			}
			set {
				if (X_Offset_jfieldId == IntPtr.Zero)
					X_Offset_jfieldId = JNIEnv.GetFieldID (class_ref, "X_Offset", "I");
				try {
					JNIEnv.SetField (Handle, X_Offset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Y_Offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/field[@name='Y_Offset']"
		[Register ("Y_Offset")]
		public int YOffset {
			get {
				if (Y_Offset_jfieldId == IntPtr.Zero)
					Y_Offset_jfieldId = JNIEnv.GetFieldID (class_ref, "Y_Offset", "I");
				return JNIEnv.GetIntField (Handle, Y_Offset_jfieldId);
			}
			set {
				if (Y_Offset_jfieldId == IntPtr.Zero)
					Y_Offset_jfieldId = JNIEnv.GetFieldID (class_ref, "Y_Offset", "I");
				try {
					JNIEnv.SetField (Handle, Y_Offset_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/IQImagingProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQImagingProperties); }
		}

		protected IQImagingProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='IQImagingProperties']/constructor[@name='IQImagingProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IQImagingProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (IQImagingProperties)) {
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
