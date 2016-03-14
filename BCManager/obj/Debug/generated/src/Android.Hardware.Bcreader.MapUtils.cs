using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='MapUtils']"
	[global::Android.Runtime.Register ("android/hardware/bcreader/MapUtils", DoNotGenerateAcw=true)]
	public partial class MapUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='MapUtils.ResultCode']"
		[global::Android.Runtime.Register ("android/hardware/bcreader/MapUtils$ResultCode", DoNotGenerateAcw=true)]
		public partial class ResultCode : global::Java.Lang.Object {

			protected ResultCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/hardware/bcreader/MapUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapUtils); }
		}

		protected MapUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='MapUtils']/constructor[@name='MapUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MapUtils)) {
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

		static IntPtr id_ConvertExtToMine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='MapUtils']/method[@name='ConvertExtToMine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ConvertExtToMine", "(Ljava/lang/String;)I", "")]
		public static unsafe int ConvertExtToMine (string p0)
		{
			if (id_ConvertExtToMine_Ljava_lang_String_ == IntPtr.Zero)
				id_ConvertExtToMine_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "ConvertExtToMine", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ConvertExtToMine_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ConvertMineToExt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='MapUtils']/method[@name='ConvertMineToExt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ConvertMineToExt", "(I)I", "")]
		public static unsafe int ConvertMineToExt (int p0)
		{
			if (id_ConvertMineToExt_I == IntPtr.Zero)
				id_ConvertMineToExt_I = JNIEnv.GetStaticMethodID (class_ref, "ConvertMineToExt", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ConvertMineToExt_I, __args);
			} finally {
			}
		}

	}
}
