using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']"
	[global::Android.Runtime.Register ("com/hsm/barcode/DecodeResult", DoNotGenerateAcw=true)]
	public partial class DecodeResult : global::Java.Lang.Object {


		static IntPtr aimId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='aimId']"
		[Register ("aimId")]
		public sbyte AimId {
			get {
				if (aimId_jfieldId == IntPtr.Zero)
					aimId_jfieldId = JNIEnv.GetFieldID (class_ref, "aimId", "B");
				return JNIEnv.GetByteField (Handle, aimId_jfieldId);
			}
			set {
				if (aimId_jfieldId == IntPtr.Zero)
					aimId_jfieldId = JNIEnv.GetFieldID (class_ref, "aimId", "B");
				try {
					JNIEnv.SetField (Handle, aimId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr aimModifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='aimModifier']"
		[Register ("aimModifier")]
		public sbyte AimModifier {
			get {
				if (aimModifier_jfieldId == IntPtr.Zero)
					aimModifier_jfieldId = JNIEnv.GetFieldID (class_ref, "aimModifier", "B");
				return JNIEnv.GetByteField (Handle, aimModifier_jfieldId);
			}
			set {
				if (aimModifier_jfieldId == IntPtr.Zero)
					aimModifier_jfieldId = JNIEnv.GetFieldID (class_ref, "aimModifier", "B");
				try {
					JNIEnv.SetField (Handle, aimModifier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr barcodeData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='barcodeData']"
		[Register ("barcodeData")]
		public string BarcodeData {
			get {
				if (barcodeData_jfieldId == IntPtr.Zero)
					barcodeData_jfieldId = JNIEnv.GetFieldID (class_ref, "barcodeData", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, barcodeData_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (barcodeData_jfieldId == IntPtr.Zero)
					barcodeData_jfieldId = JNIEnv.GetFieldID (class_ref, "barcodeData", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, barcodeData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr byteBarcodeData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='byteBarcodeData']"
		[Register ("byteBarcodeData")]
		public IList<byte> ByteBarcodeData {
			get {
				if (byteBarcodeData_jfieldId == IntPtr.Zero)
					byteBarcodeData_jfieldId = JNIEnv.GetFieldID (class_ref, "byteBarcodeData", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, byteBarcodeData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (byteBarcodeData_jfieldId == IntPtr.Zero)
					byteBarcodeData_jfieldId = JNIEnv.GetFieldID (class_ref, "byteBarcodeData", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, byteBarcodeData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr codeId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='codeId']"
		[Register ("codeId")]
		public sbyte CodeId {
			get {
				if (codeId_jfieldId == IntPtr.Zero)
					codeId_jfieldId = JNIEnv.GetFieldID (class_ref, "codeId", "B");
				return JNIEnv.GetByteField (Handle, codeId_jfieldId);
			}
			set {
				if (codeId_jfieldId == IntPtr.Zero)
					codeId_jfieldId = JNIEnv.GetFieldID (class_ref, "codeId", "B");
				try {
					JNIEnv.SetField (Handle, codeId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/field[@name='length']"
		[Register ("length")]
		public int Length {
			get {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
				return JNIEnv.GetIntField (Handle, length_jfieldId);
			}
			set {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
				try {
					JNIEnv.SetField (Handle, length_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/DecodeResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecodeResult); }
		}

		protected DecodeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecodeResult']/constructor[@name='DecodeResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DecodeResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DecodeResult)) {
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
