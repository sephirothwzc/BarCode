using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']"
	[global::Android.Runtime.Register ("android/hardware/bcreader/BCRBarCodeValue", DoNotGenerateAcw=true)]
	public partial class BCRBarCodeValue : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_ALL']"
		[Register ("CODE_TYPE_ALL")]
		public const int CodeTypeAll = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_AZTEC']"
		[Register ("CODE_TYPE_AZTEC")]
		public const int CodeTypeAztec = (int) 59;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_BOOKLAN_EAN']"
		[Register ("CODE_TYPE_BOOKLAN_EAN")]
		public const int CodeTypeBooklanEan = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CHINESE_2_OF_5']"
		[Register ("CODE_TYPE_CHINESE_2_OF_5")]
		public const int CodeTypeChinese2Of5 = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODABAR']"
		[Register ("CODE_TYPE_CODABAR")]
		public const int CodeTypeCodabar = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_11']"
		[Register ("CODE_TYPE_CODE_11")]
		public const int CodeTypeCode11 = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_128']"
		[Register ("CODE_TYPE_CODE_128")]
		public const int CodeTypeCode128 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_32']"
		[Register ("CODE_TYPE_CODE_32")]
		public const int CodeTypeCode32 = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_39']"
		[Register ("CODE_TYPE_CODE_39")]
		public const int CodeTypeCode39 = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_39_FULL_ASCII']"
		[Register ("CODE_TYPE_CODE_39_FULL_ASCII")]
		public const int CodeTypeCode39FullAscii = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_CODE_93']"
		[Register ("CODE_TYPE_CODE_93")]
		public const int CodeTypeCode93 = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_COMPOSITE_CODES']"
		[Register ("CODE_TYPE_COMPOSITE_CODES")]
		public const int CodeTypeCompositeCodes = (int) 55;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_DATA_MATRIX']"
		[Register ("CODE_TYPE_DATA_MATRIX")]
		public const int CodeTypeDataMatrix = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_DISCRETE_2_OF_5']"
		[Register ("CODE_TYPE_DISCRETE_2_OF_5")]
		public const int CodeTypeDiscrete2Of5 = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_GS1_128']"
		[Register ("CODE_TYPE_GS1_128")]
		public const int CodeTypeGs1128 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_GS1_DATABAR_VAR']"
		[Register ("CODE_TYPE_GS1_DATABAR_VAR")]
		public const int CodeTypeGs1DatabarVar = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_INTERLEAVED_2_OF_5']"
		[Register ("CODE_TYPE_INTERLEAVED_2_OF_5")]
		public const int CodeTypeInterleaved2Of5 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_ISBT_128']"
		[Register ("CODE_TYPE_ISBT_128")]
		public const int CodeTypeIsbt128 = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_ISBT_CONCAT']"
		[Register ("CODE_TYPE_ISBT_CONCAT")]
		public const int CodeTypeIsbtConcat = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_ISSN']"
		[Register ("CODE_TYPE_ISSN")]
		public const int CodeTypeIssn = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_KOREAN_3_OF_5']"
		[Register ("CODE_TYPE_KOREAN_3_OF_5")]
		public const int CodeTypeKorean3Of5 = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_MATRIX_2_OF_5']"
		[Register ("CODE_TYPE_MATRIX_2_OF_5")]
		public const int CodeTypeMatrix2Of5 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_MAXICODE']"
		[Register ("CODE_TYPE_MAXICODE")]
		public const int CodeTypeMaxicode = (int) 56;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_MICROPDF417']"
		[Register ("CODE_TYPE_MICROPDF417")]
		public const int CodeTypeMicropdf417 = (int) 53;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_MICROQR']"
		[Register ("CODE_TYPE_MICROQR")]
		public const int CodeTypeMicroqr = (int) 58;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_MSI']"
		[Register ("CODE_TYPE_MSI")]
		public const int CodeTypeMsi = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_PDF417']"
		[Register ("CODE_TYPE_PDF417")]
		public const int CodeTypePdf417 = (int) 52;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_QR_CODE']"
		[Register ("CODE_TYPE_QR_CODE")]
		public const int CodeTypeQrCode = (int) 57;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_TLC_39']"
		[Register ("CODE_TYPE_TLC_39")]
		public const int CodeTypeTlc39 = (int) 54;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_TRIOPTIC_CODE_39']"
		[Register ("CODE_TYPE_TRIOPTIC_CODE_39")]
		public const int CodeTypeTriopticCode39 = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_UCC_COUPON_EXT']"
		[Register ("CODE_TYPE_UCC_COUPON_EXT")]
		public const int CodeTypeUccCouponExt = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_UNKNOWN']"
		[Register ("CODE_TYPE_UNKNOWN")]
		public const int CodeTypeUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_UPC_EAN']"
		[Register ("CODE_TYPE_UPC_EAN")]
		public const int CodeTypeUpcEan = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/field[@name='CODE_TYPE_UPC_EAN_SUPPLEMENTALS']"
		[Register ("CODE_TYPE_UPC_EAN_SUPPLEMENTALS")]
		public const int CodeTypeUpcEanSupplementals = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/hardware/bcreader/BCRBarCodeValue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCRBarCodeValue); }
		}

		protected BCRBarCodeValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRBarCodeValue']/constructor[@name='BCRBarCodeValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCRBarCodeValue ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BCRBarCodeValue)) {
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
