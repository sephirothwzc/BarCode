using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues']"
	[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues", DoNotGenerateAcw=true)]
	public sealed partial class DecoderConfigValues : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$EngineID", DoNotGenerateAcw=true)]
		public sealed partial class EngineID : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_4200_ENGINE']"
			[Register ("IMAGER_4200_ENGINE")]
			public const int Imager4200Engine = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_IT4000_ENGINE']"
			[Register ("IMAGER_IT4000_ENGINE")]
			public const int ImagerIt4000Engine = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_IT4100_ENGINE']"
			[Register ("IMAGER_IT4100_ENGINE")]
			public const int ImagerIt4100Engine = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_IT4300_ENGINE']"
			[Register ("IMAGER_IT4300_ENGINE")]
			public const int ImagerIt4300Engine = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_IT5100_ENGINE']"
			[Register ("IMAGER_IT5100_ENGINE")]
			public const int ImagerIt5100Engine = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_IT5300_ENGINE']"
			[Register ("IMAGER_IT5300_ENGINE")]
			public const int ImagerIt5300Engine = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_N5600_ENGINE']"
			[Register ("IMAGER_N5600_ENGINE")]
			public const int ImagerN5600Engine = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='IMAGER_N5603_ENGINE']"
			[Register ("IMAGER_N5603_ENGINE")]
			public const int ImagerN5603Engine = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='LASER_SE1200_ENGINE']"
			[Register ("LASER_SE1200_ENGINE")]
			public const int LaserSe1200Engine = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='LASER_SE1223_ENGINE']"
			[Register ("LASER_SE1223_ENGINE")]
			public const int LaserSe1223Engine = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='NONE']"
			[Register ("NONE")]
			public const int None = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineID']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const int Unknown = (int) -1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$EngineID", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EngineID); }
			}

			internal EngineID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineType']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$EngineType", DoNotGenerateAcw=true)]
		public sealed partial class EngineType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineType']/field[@name='IMAGER']"
			[Register ("IMAGER")]
			public const int Imager = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineType']/field[@name='LASER']"
			[Register ("LASER")]
			public const int Laser = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineType']/field[@name='NONE']"
			[Register ("NONE")]
			public const int None = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.EngineType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const int Unknown = (int) -1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$EngineType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EngineType); }
			}

			internal EngineType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.ExposureMode']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$ExposureMode", DoNotGenerateAcw=true)]
		public sealed partial class ExposureMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.ExposureMode']/field[@name='FIXED']"
			[Register ("FIXED")]
			public const int Fixed = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.ExposureMode']/field[@name='HHP']"
			[Register ("HHP")]
			public const int Hhp = (int) 2;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$ExposureMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExposureMode); }
			}

			internal ExposureMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.IQImageFormat']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$IQImageFormat", DoNotGenerateAcw=true)]
		public sealed partial class IQImageFormat : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.IQImageFormat']/field[@name='RAW_BINARY']"
			[Register ("RAW_BINARY")]
			public const int RawBinary = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.IQImageFormat']/field[@name='RAW_GRAY']"
			[Register ("RAW_GRAY")]
			public const int RawGray = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$IQImageFormat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IQImageFormat); }
			}

			internal IQImageFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$LightsMode", DoNotGenerateAcw=true)]
		public sealed partial class LightsMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']/field[@name='AIMER_ONLY']"
			[Register ("AIMER_ONLY")]
			public const int AimerOnly = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']/field[@name='CONCURRENT']"
			[Register ("CONCURRENT")]
			public const int Concurrent = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']/field[@name='ILLUM_AIM_OFF']"
			[Register ("ILLUM_AIM_OFF")]
			public const int IllumAimOff = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']/field[@name='ILLUM_AIM_ON']"
			[Register ("ILLUM_AIM_ON")]
			public const int IllumAimOn = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.LightsMode']/field[@name='ILLUM_ONLY']"
			[Register ("ILLUM_ONLY")]
			public const int IllumOnly = (int) 2;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$LightsMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LightsMode); }
			}

			internal LightsMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRMode']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$OCRMode", DoNotGenerateAcw=true)]
		public sealed partial class OCRMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRMode']/field[@name='OCR_BOTH']"
			[Register ("OCR_BOTH")]
			public const int OcrBoth = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRMode']/field[@name='OCR_INVERSE']"
			[Register ("OCR_INVERSE")]
			public const int OcrInverse = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRMode']/field[@name='OCR_NORMAL_VIDEO']"
			[Register ("OCR_NORMAL_VIDEO")]
			public const int OcrNormalVideo = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRMode']/field[@name='OCR_OFF']"
			[Register ("OCR_OFF")]
			public const int OcrOff = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$OCRMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OCRMode); }
			}

			internal OCRMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$OCRTemplate", DoNotGenerateAcw=true)]
		public sealed partial class OCRTemplate : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']/field[@name='ISBN']"
			[Register ("ISBN")]
			public const int Isbn = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']/field[@name='MICRE13B']"
			[Register ("MICRE13B")]
			public const int Micre13b = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']/field[@name='PASSPORT']"
			[Register ("PASSPORT")]
			public const int Passport = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']/field[@name='PRICE_FIELD']"
			[Register ("PRICE_FIELD")]
			public const int PriceField = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.OCRTemplate']/field[@name='USER']"
			[Register ("USER")]
			public const int User = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$OCRTemplate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OCRTemplate); }
			}

			internal OCRTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$SymbologyFlags", DoNotGenerateAcw=true)]
		public sealed partial class SymbologyFlags : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_128_APPEND']"
			[Register ("SYMBOLOGY_128_APPEND")]
			public const int Symbology128Append = (int) 524288;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_2_DIGIT_ADDENDA']"
			[Register ("SYMBOLOGY_2_DIGIT_ADDENDA")]
			public const int Symbology2DigitAddenda = (int) 128;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_5_DIGIT_ADDENDA']"
			[Register ("SYMBOLOGY_5_DIGIT_ADDENDA")]
			public const int Symbology5DigitAddenda = (int) 256;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_ADDENDA_REQUIRED']"
			[Register ("SYMBOLOGY_ADDENDA_REQUIRED")]
			public const int SymbologyAddendaRequired = (int) 512;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_ADDENDA_SEPARATOR']"
			[Register ("SYMBOLOGY_ADDENDA_SEPARATOR")]
			public const int SymbologyAddendaSeparator = (int) 1024;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_AUSTRALIAN_BAR_WIDTH']"
			[Register ("SYMBOLOGY_AUSTRALIAN_BAR_WIDTH")]
			public const int SymbologyAustralianBarWidth = (int) 65536;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_AUS_POST_ALPHANUMERIC_C_TABLE']"
			[Register ("SYMBOLOGY_AUS_POST_ALPHANUMERIC_C_TABLE")]
			public const int SymbologyAusPostAlphanumericCTable = (int) 2097152;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_AUS_POST_COMBINATION_N_AND_C_TABLES']"
			[Register ("SYMBOLOGY_AUS_POST_COMBINATION_N_AND_C_TABLES")]
			public const int SymbologyAusPostCombinationNAndCTables = (int) 4194304;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_AUS_POST_NUMERIC_N_TABLE']"
			[Register ("SYMBOLOGY_AUS_POST_NUMERIC_N_TABLE")]
			public const int SymbologyAusPostNumericNTable = (int) 1048576;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_CHECK_ENABLE']"
			[Register ("SYMBOLOGY_CHECK_ENABLE")]
			public const int SymbologyCheckEnable = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_CHECK_TRANSMIT']"
			[Register ("SYMBOLOGY_CHECK_TRANSMIT")]
			public const int SymbologyCheckTransmit = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_CODABAR_CONCATENATE']"
			[Register ("SYMBOLOGY_CODABAR_CONCATENATE")]
			public const int SymbologyCodabarConcatenate = (int) 536870912;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_COMPOSITE_UPC']"
			[Register ("SYMBOLOGY_COMPOSITE_UPC")]
			public const int SymbologyCompositeUpc = (int) 8192;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_ENABLE']"
			[Register ("SYMBOLOGY_ENABLE")]
			public const int SymbologyEnable = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_ENABLE_APPEND_MODE']"
			[Register ("SYMBOLOGY_ENABLE_APPEND_MODE")]
			public const int SymbologyEnableAppendMode = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_ENABLE_FULLASCII']"
			[Register ("SYMBOLOGY_ENABLE_FULLASCII")]
			public const int SymbologyEnableFullascii = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_EXPANDED_UPCE']"
			[Register ("SYMBOLOGY_EXPANDED_UPCE")]
			public const int SymbologyExpandedUpce = (int) 2048;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_NUM_SYS_TRANSMIT']"
			[Register ("SYMBOLOGY_NUM_SYS_TRANSMIT")]
			public const int SymbologyNumSysTransmit = (int) 64;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_POSICODE_LIMITED_1']"
			[Register ("SYMBOLOGY_POSICODE_LIMITED_1")]
			public const int SymbologyPosicodeLimited1 = (int) 134217728;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_POSICODE_LIMITED_2']"
			[Register ("SYMBOLOGY_POSICODE_LIMITED_2")]
			public const int SymbologyPosicodeLimited2 = (int) 268435456;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_RSE_ENABLE']"
			[Register ("SYMBOLOGY_RSE_ENABLE")]
			public const int SymbologyRseEnable = (int) 8388608;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_RSL_ENABLE']"
			[Register ("SYMBOLOGY_RSL_ENABLE")]
			public const int SymbologyRslEnable = (int) 16777216;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_RSS_ENABLE']"
			[Register ("SYMBOLOGY_RSS_ENABLE")]
			public const int SymbologyRssEnable = (int) 33554432;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_RSX_ENABLE_MASK']"
			[Register ("SYMBOLOGY_RSX_ENABLE_MASK")]
			public const int SymbologyRsxEnableMask = (int) 58720256;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_START_STOP_XMIT']"
			[Register ("SYMBOLOGY_START_STOP_XMIT")]
			public const int SymbologyStartStopXmit = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_TELEPEN_OLD_STYLE']"
			[Register ("SYMBOLOGY_TELEPEN_OLD_STYLE")]
			public const int SymbologyTelepenOldStyle = (int) 67108864;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYMBOLOGY_UPCE1_ENABLE']"
			[Register ("SYMBOLOGY_UPCE1_ENABLE")]
			public const int SymbologyUpce1Enable = (int) 4096;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYM_MASK_ALL']"
			[Register ("SYM_MASK_ALL")]
			public const int SymMaskAll = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYM_MASK_FLAGS']"
			[Register ("SYM_MASK_FLAGS")]
			public const int SymMaskFlags = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYM_MASK_MAX_LEN']"
			[Register ("SYM_MASK_MAX_LEN")]
			public const int SymMaskMaxLen = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyFlags']/field[@name='SYM_MASK_MIN_LEN']"
			[Register ("SYM_MASK_MIN_LEN")]
			public const int SymMaskMinLen = (int) 2;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$SymbologyFlags", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SymbologyFlags); }
			}

			internal SymbologyFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderConfigValues$SymbologyID", DoNotGenerateAcw=true)]
		public sealed partial class SymbologyID : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYMBOLOGIES']"
			[Register ("SYMBOLOGIES")]
			public const int Symbologies = (int) 52;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_ALL']"
			[Register ("SYM_ALL")]
			public const int SymAll = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_AUSPOST']"
			[Register ("SYM_AUSPOST")]
			public const int SymAuspost = (int) 25;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_AZTEC']"
			[Register ("SYM_AZTEC")]
			public const int SymAztec = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_BPO']"
			[Register ("SYM_BPO")]
			public const int SymBpo = (int) 23;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CANPOST']"
			[Register ("SYM_CANPOST")]
			public const int SymCanpost = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CHINAPOST']"
			[Register ("SYM_CHINAPOST")]
			public const int SymChinapost = (int) 38;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODABAR']"
			[Register ("SYM_CODABAR")]
			public const int SymCodabar = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODABLOCK']"
			[Register ("SYM_CODABLOCK")]
			public const int SymCodablock = (int) 27;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE11']"
			[Register ("SYM_CODE11")]
			public const int SymCode11 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE128']"
			[Register ("SYM_CODE128")]
			public const int SymCode128 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE16K']"
			[Register ("SYM_CODE16K")]
			public const int SymCode16k = (int) 41;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE32']"
			[Register ("SYM_CODE32")]
			public const int SymCode32 = (int) 34;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE39']"
			[Register ("SYM_CODE39")]
			public const int SymCode39 = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE49']"
			[Register ("SYM_CODE49")]
			public const int SymCode49 = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_CODE93']"
			[Register ("SYM_CODE93")]
			public const int SymCode93 = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_COMPOSITE']"
			[Register ("SYM_COMPOSITE")]
			public const int SymComposite = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_COUPONCODE']"
			[Register ("SYM_COUPONCODE")]
			public const int SymCouponcode = (int) 43;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_DATAMATRIX']"
			[Register ("SYM_DATAMATRIX")]
			public const int SymDatamatrix = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_DUTCHPOST']"
			[Register ("SYM_DUTCHPOST")]
			public const int SymDutchpost = (int) 30;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_EAN13']"
			[Register ("SYM_EAN13")]
			public const int SymEan13 = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_EAN8']"
			[Register ("SYM_EAN8")]
			public const int SymEan8 = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_GRIDMATRIX']"
			[Register ("SYM_GRIDMATRIX")]
			public const int SymGridmatrix = (int) 49;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_GS1_128']"
			[Register ("SYM_GS1_128")]
			public const int SymGs1128 = (int) 47;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_HANXIN']"
			[Register ("SYM_HANXIN")]
			public const int SymHanxin = (int) 48;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_IATA25']"
			[Register ("SYM_IATA25")]
			public const int SymIata25 = (int) 26;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_IDTAG']"
			[Register ("SYM_IDTAG")]
			public const int SymIdtag = (int) 45;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_INT25']"
			[Register ("SYM_INT25")]
			public const int SymInt25 = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_ISBT']"
			[Register ("SYM_ISBT")]
			public const int SymIsbt = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_JAPOST']"
			[Register ("SYM_JAPOST")]
			public const int SymJapost = (int) 28;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_KOREAPOST']"
			[Register ("SYM_KOREAPOST")]
			public const int SymKoreapost = (int) 39;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_LABEL']"
			[Register ("SYM_LABEL")]
			public const int SymLabel = (int) 46;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_MATRIX25']"
			[Register ("SYM_MATRIX25")]
			public const int SymMatrix25 = (int) 36;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_MAXICODE']"
			[Register ("SYM_MAXICODE")]
			public const int SymMaxicode = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_MICROPDF']"
			[Register ("SYM_MICROPDF")]
			public const int SymMicropdf = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_MSI']"
			[Register ("SYM_MSI")]
			public const int SymMsi = (int) 31;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_OCR']"
			[Register ("SYM_OCR")]
			public const int SymOcr = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_PDF417']"
			[Register ("SYM_PDF417")]
			public const int SymPdf417 = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_PLANET']"
			[Register ("SYM_PLANET")]
			public const int SymPlanet = (int) 29;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_PLESSEY']"
			[Register ("SYM_PLESSEY")]
			public const int SymPlessey = (int) 37;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_POSICODE']"
			[Register ("SYM_POSICODE")]
			public const int SymPosicode = (int) 42;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_POSTALS']"
			[Register ("SYM_POSTALS")]
			public const int SymPostals = (int) 50;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_POSTNET']"
			[Register ("SYM_POSTNET")]
			public const int SymPostnet = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_QR']"
			[Register ("SYM_QR")]
			public const int SymQr = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_RSS']"
			[Register ("SYM_RSS")]
			public const int SymRss = (int) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_STRT25']"
			[Register ("SYM_STRT25")]
			public const int SymStrt25 = (int) 35;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_TELEPEN']"
			[Register ("SYM_TELEPEN")]
			public const int SymTelepen = (int) 40;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_TLCODE39']"
			[Register ("SYM_TLCODE39")]
			public const int SymTlcode39 = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_TRIOPTIC']"
			[Register ("SYM_TRIOPTIC")]
			public const int SymTrioptic = (int) 33;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_UPCA']"
			[Register ("SYM_UPCA")]
			public const int SymUpca = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_UPCE0']"
			[Register ("SYM_UPCE0")]
			public const int SymUpce0 = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_UPCE1']"
			[Register ("SYM_UPCE1")]
			public const int SymUpce1 = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_USPS4CB']"
			[Register ("SYM_USPS4CB")]
			public const int SymUsps4cb = (int) 44;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderConfigValues.SymbologyID']/field[@name='SYM_US_POSTALS1']"
			[Register ("SYM_US_POSTALS1")]
			public const int SymUsPostals1 = (int) 51;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderConfigValues$SymbologyID", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SymbologyID); }
			}

			internal SymbologyID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal DecoderConfigValues (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
