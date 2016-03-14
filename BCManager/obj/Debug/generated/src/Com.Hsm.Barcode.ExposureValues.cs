using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues']"
	[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues", DoNotGenerateAcw=true)]
	public sealed partial class ExposureValues : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ConformImage']"
		[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues$ConformImage", DoNotGenerateAcw=true)]
		public sealed partial class ConformImage : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ConformImage']/field[@name='CONFORM_IMAGE']"
			[Register ("CONFORM_IMAGE")]
			public const int ConformImage = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ConformImage']/field[@name='DO_NOT_COFORM_IMAGE']"
			[Register ("DO_NOT_COFORM_IMAGE")]
			public const int DoNotCoformImage = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/ExposureValues$ConformImage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConformImage); }
			}

			internal ConformImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureMethod']"
		[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues$ExposureMethod", DoNotGenerateAcw=true)]
		public sealed partial class ExposureMethod : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureMethod']/field[@name='CENTER_ONLY']"
			[Register ("CENTER_ONLY")]
			public const int CenterOnly = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureMethod']/field[@name='CENTER_WEIGHTED']"
			[Register ("CENTER_WEIGHTED")]
			public const int CenterWeighted = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureMethod']/field[@name='UNIFORM']"
			[Register ("UNIFORM")]
			public const int Uniform = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/ExposureValues$ExposureMethod", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExposureMethod); }
			}

			internal ExposureMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']"
		[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues$ExposureSettings", DoNotGenerateAcw=true)]
		public partial class ExposureSettings : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_CONFORM_IMAGE']"
			[Register ("DEC_ES_CONFORM_IMAGE")]
			public const int DecEsConformImage = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_CONFORM_TRIES']"
			[Register ("DEC_ES_CONFORM_TRIES")]
			public const int DecEsConformTries = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_EXPOSURE_METHOD']"
			[Register ("DEC_ES_EXPOSURE_METHOD")]
			public const int DecEsExposureMethod = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_FIXED_EXP']"
			[Register ("DEC_ES_FIXED_EXP")]
			public const int DecEsFixedExp = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_FIXED_FRAME_RATE']"
			[Register ("DEC_ES_FIXED_FRAME_RATE")]
			public const int DecEsFixedFrameRate = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_FIXED_GAIN']"
			[Register ("DEC_ES_FIXED_GAIN")]
			public const int DecEsFixedGain = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_FRAME_RATE']"
			[Register ("DEC_ES_FRAME_RATE")]
			public const int DecEsFrameRate = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_MAX_EXP']"
			[Register ("DEC_ES_MAX_EXP")]
			public const int DecEsMaxExp = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_MAX_GAIN']"
			[Register ("DEC_ES_MAX_GAIN")]
			public const int DecEsMaxGain = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_SPECULAR_EXCLUSION']"
			[Register ("DEC_ES_SPECULAR_EXCLUSION")]
			public const int DecEsSpecularExclusion = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_SPECULAR_LIMIT']"
			[Register ("DEC_ES_SPECULAR_LIMIT")]
			public const int DecEsSpecularLimit = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_SPECULAR_SAT']"
			[Register ("DEC_ES_SPECULAR_SAT")]
			public const int DecEsSpecularSat = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_TARGET_ACCEPT_GAP']"
			[Register ("DEC_ES_TARGET_ACCEPT_GAP")]
			public const int DecEsTargetAcceptGap = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_TARGET_PERCENTILE']"
			[Register ("DEC_ES_TARGET_PERCENTILE")]
			public const int DecEsTargetPercentile = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/field[@name='DEC_ES_TARGET_VALUE']"
			[Register ("DEC_ES_TARGET_VALUE")]
			public const int DecEsTargetValue = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/ExposureValues$ExposureSettings", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExposureSettings); }
			}

			protected ExposureSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_hsm_barcode_ExposureValues_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettings']/constructor[@name='ExposureValues.ExposureSettings' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.ExposureValues']]"
			[Register (".ctor", "(Lcom/hsm/barcode/ExposureValues;)V", "")]
			public unsafe ExposureSettings (global::Com.Hsm.Barcode.ExposureValues __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (ExposureSettings)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_hsm_barcode_ExposureValues_ == IntPtr.Zero)
						id_ctor_Lcom_hsm_barcode_ExposureValues_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/hsm/barcode/ExposureValues;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_hsm_barcode_ExposureValues_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_hsm_barcode_ExposureValues_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']"
		[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues$ExposureSettingsMinMax", DoNotGenerateAcw=true)]
		public partial class ExposureSettingsMinMax : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_CONFORM_IMAGE']"
			[Register ("DEC_MAX_ES_CONFORM_IMAGE")]
			public const int DecMaxEsConformImage = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_CONFORM_TRIES']"
			[Register ("DEC_MAX_ES_CONFORM_TRIES")]
			public const int DecMaxEsConformTries = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_EXPOSURE_METHOD']"
			[Register ("DEC_MAX_ES_EXPOSURE_METHOD")]
			public const int DecMaxEsExposureMethod = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_FIXED_EXP']"
			[Register ("DEC_MAX_ES_FIXED_EXP")]
			public const int DecMaxEsFixedExp = (int) 7874;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_FIXED_FRAME_RATE']"
			[Register ("DEC_MAX_ES_FIXED_FRAME_RATE")]
			public const int DecMaxEsFixedFrameRate = (int) 30;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_FIXED_GAIN']"
			[Register ("DEC_MAX_ES_FIXED_GAIN")]
			public const int DecMaxEsFixedGain = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_FRAME_RATE']"
			[Register ("DEC_MAX_ES_FRAME_RATE")]
			public const int DecMaxEsFrameRate = (int) 30;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_MAX_EXP']"
			[Register ("DEC_MAX_ES_MAX_EXP")]
			public const int DecMaxEsMaxExp = (int) 7874;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_MAX_GAIN']"
			[Register ("DEC_MAX_ES_MAX_GAIN")]
			public const int DecMaxEsMaxGain = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_SPECULAR_EXCLUSION']"
			[Register ("DEC_MAX_ES_SPECULAR_EXCLUSION")]
			public const int DecMaxEsSpecularExclusion = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_SPECULAR_LIMIT']"
			[Register ("DEC_MAX_ES_SPECULAR_LIMIT")]
			public const int DecMaxEsSpecularLimit = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_SPECULAR_SAT']"
			[Register ("DEC_MAX_ES_SPECULAR_SAT")]
			public const int DecMaxEsSpecularSat = (int) 255;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_TARGET_ACCEPT_GAP']"
			[Register ("DEC_MAX_ES_TARGET_ACCEPT_GAP")]
			public const int DecMaxEsTargetAcceptGap = (int) 50;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_TARGET_PERCENTILE']"
			[Register ("DEC_MAX_ES_TARGET_PERCENTILE")]
			public const int DecMaxEsTargetPercentile = (int) 99;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MAX_ES_TARGET_VALUE']"
			[Register ("DEC_MAX_ES_TARGET_VALUE")]
			public const int DecMaxEsTargetValue = (int) 255;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_CONFORM_IMAGE']"
			[Register ("DEC_MIN_ES_CONFORM_IMAGE")]
			public const int DecMinEsConformImage = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_CONFORM_TRIES']"
			[Register ("DEC_MIN_ES_CONFORM_TRIES")]
			public const int DecMinEsConformTries = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_EXPOSURE_METHOD']"
			[Register ("DEC_MIN_ES_EXPOSURE_METHOD")]
			public const int DecMinEsExposureMethod = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_FIXED_EXP']"
			[Register ("DEC_MIN_ES_FIXED_EXP")]
			public const int DecMinEsFixedExp = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_FIXED_FRAME_RATE']"
			[Register ("DEC_MIN_ES_FIXED_FRAME_RATE")]
			public const int DecMinEsFixedFrameRate = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_FIXED_GAIN']"
			[Register ("DEC_MIN_ES_FIXED_GAIN")]
			public const int DecMinEsFixedGain = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_FRAME_RATE']"
			[Register ("DEC_MIN_ES_FRAME_RATE")]
			public const int DecMinEsFrameRate = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_MAX_EXP']"
			[Register ("DEC_MIN_ES_MAX_EXP")]
			public const int DecMinEsMaxExp = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_MAX_GAIN']"
			[Register ("DEC_MIN_ES_MAX_GAIN")]
			public const int DecMinEsMaxGain = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_SPECULAR_EXCLUSION']"
			[Register ("DEC_MIN_ES_SPECULAR_EXCLUSION")]
			public const int DecMinEsSpecularExclusion = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_SPECULAR_LIMIT']"
			[Register ("DEC_MIN_ES_SPECULAR_LIMIT")]
			public const int DecMinEsSpecularLimit = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_SPECULAR_SAT']"
			[Register ("DEC_MIN_ES_SPECULAR_SAT")]
			public const int DecMinEsSpecularSat = (int) 200;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_TARGET_ACCEPT_GAP']"
			[Register ("DEC_MIN_ES_TARGET_ACCEPT_GAP")]
			public const int DecMinEsTargetAcceptGap = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_TARGET_PERCENTILE']"
			[Register ("DEC_MIN_ES_TARGET_PERCENTILE")]
			public const int DecMinEsTargetPercentile = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/field[@name='DEC_MIN_ES_TARGET_VALUE']"
			[Register ("DEC_MIN_ES_TARGET_VALUE")]
			public const int DecMinEsTargetValue = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/ExposureValues$ExposureSettingsMinMax", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExposureSettingsMinMax); }
			}

			protected ExposureSettingsMinMax (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_hsm_barcode_ExposureValues_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.ExposureSettingsMinMax']/constructor[@name='ExposureValues.ExposureSettingsMinMax' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.ExposureValues']]"
			[Register (".ctor", "(Lcom/hsm/barcode/ExposureValues;)V", "")]
			public unsafe ExposureSettingsMinMax (global::Com.Hsm.Barcode.ExposureValues __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (ExposureSettingsMinMax)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_hsm_barcode_ExposureValues_ == IntPtr.Zero)
						id_ctor_Lcom_hsm_barcode_ExposureValues_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/hsm/barcode/ExposureValues;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_hsm_barcode_ExposureValues_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_hsm_barcode_ExposureValues_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']"
		[global::Android.Runtime.Register ("com/hsm/barcode/ExposureValues$SpecularExclusion", DoNotGenerateAcw=true)]
		public sealed partial class SpecularExclusion : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']/field[@name='AGGRESSIVE']"
			[Register ("AGGRESSIVE")]
			public const int Aggressive = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']/field[@name='MINIMAL']"
			[Register ("MINIMAL")]
			public const int Minimal = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']/field[@name='MODERATE']"
			[Register ("MODERATE")]
			public const int Moderate = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']/field[@name='OFF']"
			[Register ("OFF")]
			public const int Off = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='ExposureValues.SpecularExclusion']/field[@name='SPECIAL']"
			[Register ("SPECIAL")]
			public const int Special = (int) 4;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/ExposureValues$SpecularExclusion", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpecularExclusion); }
			}

			internal SpecularExclusion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal ExposureValues (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
