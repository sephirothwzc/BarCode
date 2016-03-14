using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']"
	[global::Android.Runtime.Register ("com/hsm/barcode/ImagerProperties", DoNotGenerateAcw=true)]
	public partial class ImagerProperties : global::Java.Lang.Object {


		static IntPtr AimerColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='AimerColor']"
		[Register ("AimerColor")]
		public int AimerColor {
			get {
				if (AimerColor_jfieldId == IntPtr.Zero)
					AimerColor_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerColor", "I");
				return JNIEnv.GetIntField (Handle, AimerColor_jfieldId);
			}
			set {
				if (AimerColor_jfieldId == IntPtr.Zero)
					AimerColor_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerColor", "I");
				try {
					JNIEnv.SetField (Handle, AimerColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr AimerType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='AimerType']"
		[Register ("AimerType")]
		public int AimerType {
			get {
				if (AimerType_jfieldId == IntPtr.Zero)
					AimerType_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerType", "I");
				return JNIEnv.GetIntField (Handle, AimerType_jfieldId);
			}
			set {
				if (AimerType_jfieldId == IntPtr.Zero)
					AimerType_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerType", "I");
				try {
					JNIEnv.SetField (Handle, AimerType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr AimerXoffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='AimerXoffset']"
		[Register ("AimerXoffset")]
		public int AimerXoffset {
			get {
				if (AimerXoffset_jfieldId == IntPtr.Zero)
					AimerXoffset_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerXoffset", "I");
				return JNIEnv.GetIntField (Handle, AimerXoffset_jfieldId);
			}
			set {
				if (AimerXoffset_jfieldId == IntPtr.Zero)
					AimerXoffset_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerXoffset", "I");
				try {
					JNIEnv.SetField (Handle, AimerXoffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr AimerYoffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='AimerYoffset']"
		[Register ("AimerYoffset")]
		public int AimerYoffset {
			get {
				if (AimerYoffset_jfieldId == IntPtr.Zero)
					AimerYoffset_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerYoffset", "I");
				return JNIEnv.GetIntField (Handle, AimerYoffset_jfieldId);
			}
			set {
				if (AimerYoffset_jfieldId == IntPtr.Zero)
					AimerYoffset_jfieldId = JNIEnv.GetFieldID (class_ref, "AimerYoffset", "I");
				try {
					JNIEnv.SetField (Handle, AimerYoffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr BitsPerPixel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='BitsPerPixel']"
		[Register ("BitsPerPixel")]
		public int BitsPerPixel {
			get {
				if (BitsPerPixel_jfieldId == IntPtr.Zero)
					BitsPerPixel_jfieldId = JNIEnv.GetFieldID (class_ref, "BitsPerPixel", "I");
				return JNIEnv.GetIntField (Handle, BitsPerPixel_jfieldId);
			}
			set {
				if (BitsPerPixel_jfieldId == IntPtr.Zero)
					BitsPerPixel_jfieldId = JNIEnv.GetFieldID (class_ref, "BitsPerPixel", "I");
				try {
					JNIEnv.SetField (Handle, BitsPerPixel_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ColorFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='ColorFormat']"
		[Register ("ColorFormat")]
		public int ColorFormat {
			get {
				if (ColorFormat_jfieldId == IntPtr.Zero)
					ColorFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "ColorFormat", "I");
				return JNIEnv.GetIntField (Handle, ColorFormat_jfieldId);
			}
			set {
				if (ColorFormat_jfieldId == IntPtr.Zero)
					ColorFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "ColorFormat", "I");
				try {
					JNIEnv.SetField (Handle, ColorFormat_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Columns_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='Columns']"
		[Register ("Columns")]
		public int Columns {
			get {
				if (Columns_jfieldId == IntPtr.Zero)
					Columns_jfieldId = JNIEnv.GetFieldID (class_ref, "Columns", "I");
				return JNIEnv.GetIntField (Handle, Columns_jfieldId);
			}
			set {
				if (Columns_jfieldId == IntPtr.Zero)
					Columns_jfieldId = JNIEnv.GetFieldID (class_ref, "Columns", "I");
				try {
					JNIEnv.SetField (Handle, Columns_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr EngineID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='EngineID']"
		[Register ("EngineID")]
		public int EngineID {
			get {
				if (EngineID_jfieldId == IntPtr.Zero)
					EngineID_jfieldId = JNIEnv.GetFieldID (class_ref, "EngineID", "I");
				return JNIEnv.GetIntField (Handle, EngineID_jfieldId);
			}
			set {
				if (EngineID_jfieldId == IntPtr.Zero)
					EngineID_jfieldId = JNIEnv.GetFieldID (class_ref, "EngineID", "I");
				try {
					JNIEnv.SetField (Handle, EngineID_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr EnginePartNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='EnginePartNum']"
		[Register ("EnginePartNum")]
		public string EnginePartNum {
			get {
				if (EnginePartNum_jfieldId == IntPtr.Zero)
					EnginePartNum_jfieldId = JNIEnv.GetFieldID (class_ref, "EnginePartNum", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, EnginePartNum_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EnginePartNum_jfieldId == IntPtr.Zero)
					EnginePartNum_jfieldId = JNIEnv.GetFieldID (class_ref, "EnginePartNum", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, EnginePartNum_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EngineSerialNum_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='EngineSerialNum']"
		[Register ("EngineSerialNum")]
		public string EngineSerialNum {
			get {
				if (EngineSerialNum_jfieldId == IntPtr.Zero)
					EngineSerialNum_jfieldId = JNIEnv.GetFieldID (class_ref, "EngineSerialNum", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, EngineSerialNum_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EngineSerialNum_jfieldId == IntPtr.Zero)
					EngineSerialNum_jfieldId = JNIEnv.GetFieldID (class_ref, "EngineSerialNum", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, EngineSerialNum_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FirmwareEngineID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='FirmwareEngineID']"
		[Register ("FirmwareEngineID")]
		public int FirmwareEngineID {
			get {
				if (FirmwareEngineID_jfieldId == IntPtr.Zero)
					FirmwareEngineID_jfieldId = JNIEnv.GetFieldID (class_ref, "FirmwareEngineID", "I");
				return JNIEnv.GetIntField (Handle, FirmwareEngineID_jfieldId);
			}
			set {
				if (FirmwareEngineID_jfieldId == IntPtr.Zero)
					FirmwareEngineID_jfieldId = JNIEnv.GetFieldID (class_ref, "FirmwareEngineID", "I");
				try {
					JNIEnv.SetField (Handle, FirmwareEngineID_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr IllumColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='IllumColor']"
		[Register ("IllumColor")]
		public int IllumColor {
			get {
				if (IllumColor_jfieldId == IntPtr.Zero)
					IllumColor_jfieldId = JNIEnv.GetFieldID (class_ref, "IllumColor", "I");
				return JNIEnv.GetIntField (Handle, IllumColor_jfieldId);
			}
			set {
				if (IllumColor_jfieldId == IntPtr.Zero)
					IllumColor_jfieldId = JNIEnv.GetFieldID (class_ref, "IllumColor", "I");
				try {
					JNIEnv.SetField (Handle, IllumColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr NumBuffers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='NumBuffers']"
		[Register ("NumBuffers")]
		public int NumBuffers {
			get {
				if (NumBuffers_jfieldId == IntPtr.Zero)
					NumBuffers_jfieldId = JNIEnv.GetFieldID (class_ref, "NumBuffers", "I");
				return JNIEnv.GetIntField (Handle, NumBuffers_jfieldId);
			}
			set {
				if (NumBuffers_jfieldId == IntPtr.Zero)
					NumBuffers_jfieldId = JNIEnv.GetFieldID (class_ref, "NumBuffers", "I");
				try {
					JNIEnv.SetField (Handle, NumBuffers_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Optics_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='Optics']"
		[Register ("Optics")]
		public int Optics {
			get {
				if (Optics_jfieldId == IntPtr.Zero)
					Optics_jfieldId = JNIEnv.GetFieldID (class_ref, "Optics", "I");
				return JNIEnv.GetIntField (Handle, Optics_jfieldId);
			}
			set {
				if (Optics_jfieldId == IntPtr.Zero)
					Optics_jfieldId = JNIEnv.GetFieldID (class_ref, "Optics", "I");
				try {
					JNIEnv.SetField (Handle, Optics_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr PSOCMajorRev_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='PSOCMajorRev']"
		[Register ("PSOCMajorRev")]
		public int PSOCMajorRev {
			get {
				if (PSOCMajorRev_jfieldId == IntPtr.Zero)
					PSOCMajorRev_jfieldId = JNIEnv.GetFieldID (class_ref, "PSOCMajorRev", "I");
				return JNIEnv.GetIntField (Handle, PSOCMajorRev_jfieldId);
			}
			set {
				if (PSOCMajorRev_jfieldId == IntPtr.Zero)
					PSOCMajorRev_jfieldId = JNIEnv.GetFieldID (class_ref, "PSOCMajorRev", "I");
				try {
					JNIEnv.SetField (Handle, PSOCMajorRev_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr PSOCMinorRev_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='PSOCMinorRev']"
		[Register ("PSOCMinorRev")]
		public int PSOCMinorRev {
			get {
				if (PSOCMinorRev_jfieldId == IntPtr.Zero)
					PSOCMinorRev_jfieldId = JNIEnv.GetFieldID (class_ref, "PSOCMinorRev", "I");
				return JNIEnv.GetIntField (Handle, PSOCMinorRev_jfieldId);
			}
			set {
				if (PSOCMinorRev_jfieldId == IntPtr.Zero)
					PSOCMinorRev_jfieldId = JNIEnv.GetFieldID (class_ref, "PSOCMinorRev", "I");
				try {
					JNIEnv.SetField (Handle, PSOCMinorRev_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Rotation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='Rotation']"
		[Register ("Rotation")]
		public int Rotation {
			get {
				if (Rotation_jfieldId == IntPtr.Zero)
					Rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "Rotation", "I");
				return JNIEnv.GetIntField (Handle, Rotation_jfieldId);
			}
			set {
				if (Rotation_jfieldId == IntPtr.Zero)
					Rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "Rotation", "I");
				try {
					JNIEnv.SetField (Handle, Rotation_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Rows_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='Rows']"
		[Register ("Rows")]
		public int Rows {
			get {
				if (Rows_jfieldId == IntPtr.Zero)
					Rows_jfieldId = JNIEnv.GetFieldID (class_ref, "Rows", "I");
				return JNIEnv.GetIntField (Handle, Rows_jfieldId);
			}
			set {
				if (Rows_jfieldId == IntPtr.Zero)
					Rows_jfieldId = JNIEnv.GetFieldID (class_ref, "Rows", "I");
				try {
					JNIEnv.SetField (Handle, Rows_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='Size']"
		[Register ("Size")]
		public int Size {
			get {
				if (Size_jfieldId == IntPtr.Zero)
					Size_jfieldId = JNIEnv.GetFieldID (class_ref, "Size", "I");
				return JNIEnv.GetIntField (Handle, Size_jfieldId);
			}
			set {
				if (Size_jfieldId == IntPtr.Zero)
					Size_jfieldId = JNIEnv.GetFieldID (class_ref, "Size", "I");
				try {
					JNIEnv.SetField (Handle, Size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr YDepth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/field[@name='YDepth']"
		[Register ("YDepth")]
		public int YDepth {
			get {
				if (YDepth_jfieldId == IntPtr.Zero)
					YDepth_jfieldId = JNIEnv.GetFieldID (class_ref, "YDepth", "I");
				return JNIEnv.GetIntField (Handle, YDepth_jfieldId);
			}
			set {
				if (YDepth_jfieldId == IntPtr.Zero)
					YDepth_jfieldId = JNIEnv.GetFieldID (class_ref, "YDepth", "I");
				try {
					JNIEnv.SetField (Handle, YDepth_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/ImagerProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImagerProperties); }
		}

		protected ImagerProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ImagerProperties']/constructor[@name='ImagerProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImagerProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImagerProperties)) {
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
