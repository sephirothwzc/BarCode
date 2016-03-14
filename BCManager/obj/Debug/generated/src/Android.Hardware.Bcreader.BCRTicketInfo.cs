using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRTicketInfo']"
	[global::Android.Runtime.Register ("android/hardware/bcreader/BCRTicketInfo", DoNotGenerateAcw=true)]
	public partial class BCRTicketInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/hardware/bcreader/BCRTicketInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCRTicketInfo); }
		}

		protected BCRTicketInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRTicketInfo']/constructor[@name='BCRTicketInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BCRTicketInfo (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (BCRTicketInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRTicketInfo']/constructor[@name='BCRTicketInfo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe BCRTicketInfo (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (BCRTicketInfo)) {
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

		static Delegate cb_getTicketType;
#pragma warning disable 0169
		static Delegate GetGetTicketTypeHandler ()
		{
			if (cb_getTicketType == null)
				cb_getTicketType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTicketType);
			return cb_getTicketType;
		}

		static int n_GetTicketType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRTicketInfo __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRTicketInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TicketType;
		}
#pragma warning restore 0169

		static IntPtr id_getTicketType;
		public virtual unsafe int TicketType {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRTicketInfo']/method[@name='getTicketType' and count(parameter)=0]"
			[Register ("getTicketType", "()I", "GetGetTicketTypeHandler")]
			get {
				if (id_getTicketType == IntPtr.Zero)
					id_getTicketType = JNIEnv.GetMethodID (class_ref, "getTicketType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTicketType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTicketType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTicketValue;
#pragma warning disable 0169
		static Delegate GetGetTicketValueHandler ()
		{
			if (cb_getTicketValue == null)
				cb_getTicketValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTicketValue);
			return cb_getTicketValue;
		}

		static IntPtr n_GetTicketValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRTicketInfo __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRTicketInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TicketValue);
		}
#pragma warning restore 0169

		static IntPtr id_getTicketValue;
		public virtual unsafe string TicketValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRTicketInfo']/method[@name='getTicketValue' and count(parameter)=0]"
			[Register ("getTicketValue", "()Ljava/lang/String;", "GetGetTicketValueHandler")]
			get {
				if (id_getTicketValue == IntPtr.Zero)
					id_getTicketValue = JNIEnv.GetMethodID (class_ref, "getTicketValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTicketValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTicketValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
