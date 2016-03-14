using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']"
	[global::Android.Runtime.Register ("com/hsm/barcode/ImageAttributes", DoNotGenerateAcw=true)]
	public partial class ImageAttributes : global::Java.Lang.Object {


		static IntPtr ExposureValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='ExposureValue']"
		[Register ("ExposureValue")]
		public int ExposureValue {
			get {
				if (ExposureValue_jfieldId == IntPtr.Zero)
					ExposureValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ExposureValue", "I");
				return JNIEnv.GetIntField (Handle, ExposureValue_jfieldId);
			}
			set {
				if (ExposureValue_jfieldId == IntPtr.Zero)
					ExposureValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ExposureValue", "I");
				try {
					JNIEnv.SetField (Handle, ExposureValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr GainValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='GainValue']"
		[Register ("GainValue")]
		public int GainValue {
			get {
				if (GainValue_jfieldId == IntPtr.Zero)
					GainValue_jfieldId = JNIEnv.GetFieldID (class_ref, "GainValue", "I");
				return JNIEnv.GetIntField (Handle, GainValue_jfieldId);
			}
			set {
				if (GainValue_jfieldId == IntPtr.Zero)
					GainValue_jfieldId = JNIEnv.GetFieldID (class_ref, "GainValue", "I");
				try {
					JNIEnv.SetField (Handle, GainValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IlluminationClipValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='IlluminationClipValue']"
		[Register ("IlluminationClipValue")]
		public int IlluminationClipValue {
			get {
				if (IlluminationClipValue_jfieldId == IntPtr.Zero)
					IlluminationClipValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationClipValue", "I");
				return JNIEnv.GetIntField (Handle, IlluminationClipValue_jfieldId);
			}
			set {
				if (IlluminationClipValue_jfieldId == IntPtr.Zero)
					IlluminationClipValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationClipValue", "I");
				try {
					JNIEnv.SetField (Handle, IlluminationClipValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IlluminationMaxValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='IlluminationMaxValue']"
		[Register ("IlluminationMaxValue")]
		public int IlluminationMaxValue {
			get {
				if (IlluminationMaxValue_jfieldId == IntPtr.Zero)
					IlluminationMaxValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationMaxValue", "I");
				return JNIEnv.GetIntField (Handle, IlluminationMaxValue_jfieldId);
			}
			set {
				if (IlluminationMaxValue_jfieldId == IntPtr.Zero)
					IlluminationMaxValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationMaxValue", "I");
				try {
					JNIEnv.SetField (Handle, IlluminationMaxValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IlluminationValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='IlluminationValue']"
		[Register ("IlluminationValue")]
		public int IlluminationValue {
			get {
				if (IlluminationValue_jfieldId == IntPtr.Zero)
					IlluminationValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationValue", "I");
				return JNIEnv.GetIntField (Handle, IlluminationValue_jfieldId);
			}
			set {
				if (IlluminationValue_jfieldId == IntPtr.Zero)
					IlluminationValue_jfieldId = JNIEnv.GetFieldID (class_ref, "IlluminationValue", "I");
				try {
					JNIEnv.SetField (Handle, IlluminationValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ImageSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/field[@name='ImageSize']"
		[Register ("ImageSize")]
		public int ImageSize {
			get {
				if (ImageSize_jfieldId == IntPtr.Zero)
					ImageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "ImageSize", "I");
				return JNIEnv.GetIntField (Handle, ImageSize_jfieldId);
			}
			set {
				if (ImageSize_jfieldId == IntPtr.Zero)
					ImageSize_jfieldId = JNIEnv.GetFieldID (class_ref, "ImageSize", "I");
				try {
					JNIEnv.SetField (Handle, ImageSize_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/ImageAttributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageAttributes); }
		}

		protected ImageAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImageAttributes']/constructor[@name='ImageAttributes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageAttributes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageAttributes)) {
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
