using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException']"
	[global::Android.Runtime.Register ("com/hsm/barcode/DecoderException", DoNotGenerateAcw=true)]
	public partial class DecoderException : global::Java.Lang.Exception {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']"
		[global::Android.Runtime.Register ("com/hsm/barcode/DecoderException$ResultID", DoNotGenerateAcw=true)]
		public sealed partial class ResultID : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_BADREGION']"
			[Register ("RESULT_ERR_BADREGION")]
			public const int ResultErrBadregion = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_BADSMARTIMAGE']"
			[Register ("RESULT_ERR_BADSMARTIMAGE")]
			public const int ResultErrBadsmartimage = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_CANCEL']"
			[Register ("RESULT_ERR_CANCEL")]
			public const int ResultErrCancel = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_DRIVER']"
			[Register ("RESULT_ERR_DRIVER")]
			public const int ResultErrDriver = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_ENGINEBUSY']"
			[Register ("RESULT_ERR_ENGINEBUSY")]
			public const int ResultErrEnginebusy = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_EXCEPTION']"
			[Register ("RESULT_ERR_EXCEPTION")]
			public const int ResultErrException = (int) 18;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_EXMFILE_INVALID']"
			[Register ("RESULT_ERR_EXMFILE_INVALID")]
			public const int ResultErrExmfileInvalid = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_LOAD_EXMFILE']"
			[Register ("RESULT_ERR_LOAD_EXMFILE")]
			public const int ResultErrLoadExmfile = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_MEMORY']"
			[Register ("RESULT_ERR_MEMORY")]
			public const int ResultErrMemory = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_MISSING_EXMSECTION']"
			[Register ("RESULT_ERR_MISSING_EXMSECTION")]
			public const int ResultErrMissingExmsection = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NODATA']"
			[Register ("RESULT_ERR_NODATA")]
			public const int ResultErrNodata = (int) 24;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NODECODE']"
			[Register ("RESULT_ERR_NODECODE")]
			public const int ResultErrNodecode = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NOIMAGE']"
			[Register ("RESULT_ERR_NOIMAGE")]
			public const int ResultErrNoimage = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NORESPONSE']"
			[Register ("RESULT_ERR_NORESPONSE")]
			public const int ResultErrNoresponse = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NOTCONNECTED']"
			[Register ("RESULT_ERR_NOTCONNECTED")]
			public const int ResultErrNotconnected = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_NOTRIGGER']"
			[Register ("RESULT_ERR_NOTRIGGER")]
			public const int ResultErrNotrigger = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_PARAMETER']"
			[Register ("RESULT_ERR_PARAMETER")]
			public const int ResultErrParameter = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_PROCESSING_EXMSECTION']"
			[Register ("RESULT_ERR_PROCESSING_EXMSECTION")]
			public const int ResultErrProcessingExmsection = (int) 23;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_SMARTIMAGETOOLARGE']"
			[Register ("RESULT_ERR_SMARTIMAGETOOLARGE")]
			public const int ResultErrSmartimagetoolarge = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_THREAD']"
			[Register ("RESULT_ERR_THREAD")]
			public const int ResultErrThread = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_TOO_MUCH_INTERPOLATION']"
			[Register ("RESULT_ERR_TOO_MUCH_INTERPOLATION")]
			public const int ResultErrTooMuchInterpolation = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_UNSUPPORTED']"
			[Register ("RESULT_ERR_UNSUPPORTED")]
			public const int ResultErrUnsupported = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_UNSUPPORTED_IQ_BARCODE']"
			[Register ("RESULT_ERR_UNSUPPORTED_IQ_BARCODE")]
			public const int ResultErrUnsupportedIqBarcode = (int) 19;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_ERR_WRONGRESULTSTRUCT']"
			[Register ("RESULT_ERR_WRONGRESULTSTRUCT")]
			public const int ResultErrWrongresultstruct = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_INITIALIZE']"
			[Register ("RESULT_INITIALIZE")]
			public const int ResultInitialize = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException.ResultID']/field[@name='RESULT_SUCCESS']"
			[Register ("RESULT_SUCCESS")]
			public const int ResultSuccess = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hsm/barcode/DecoderException$ResultID", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResultID); }
			}

			internal ResultID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/DecoderException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecoderException); }
		}

		protected DecoderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException']/constructor[@name='DecoderException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe DecoderException (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DecoderException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.DecoderException __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.DecoderException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='DecoderException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
				} finally {
				}
			}
		}

	}
}
