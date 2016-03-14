using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']"
	[global::Android.Runtime.Register ("android/hardware/bcreader/BCRManager", DoNotGenerateAcw=true)]
	public partial class BCRManager : global::Java.Lang.Object, global::Android.Hardware.Bcreader.IBCRInterface {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/field[@name='SCAN_MODE_CONTINUE']"
		[Register ("SCAN_MODE_CONTINUE")]
		public const int ScanModeContinue = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/field[@name='SCAN_MODE_ONESHOT']"
		[Register ("SCAN_MODE_ONESHOT")]
		public const int ScanModeOneshot = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/field[@name='SCAN_TYPE_DOUBLE']"
		[Register ("SCAN_TYPE_DOUBLE")]
		public const int ScanTypeDouble = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/field[@name='SCAN_TYPE_SINGLE']"
		[Register ("SCAN_TYPE_SINGLE")]
		public const int ScanTypeSingle = (int) 1;

		public static class InterfaceConsts {

			// The following are fields from: android.hardware.bcreader.BCRInterface

			// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/field[@name='NOTSUPPORTED']"
			[Register ("NOTSUPPORTED")]
			public const int Notsupported = (int) -100;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.LightRunnable']"
		[global::Android.Runtime.Register ("android/hardware/bcreader/BCRManager$LightRunnable", DoNotGenerateAcw=true)]
		public partial class LightRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/hardware/bcreader/BCRManager$LightRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LightRunnable); }
			}

			protected LightRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_disable;
#pragma warning disable 0169
			static Delegate GetDisableHandler ()
			{
				if (cb_disable == null)
					cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
				return cb_disable;
			}

			static void n_Disable (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.LightRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.LightRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Disable ();
			}
#pragma warning restore 0169

			static IntPtr id_disable;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.LightRunnable']/method[@name='disable' and count(parameter)=0]"
			[Register ("disable", "()V", "GetDisableHandler")]
			public virtual unsafe void Disable ()
			{
				if (id_disable == IntPtr.Zero)
					id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_disable);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
				} finally {
				}
			}

			static Delegate cb_enable;
#pragma warning disable 0169
			static Delegate GetEnableHandler ()
			{
				if (cb_enable == null)
					cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
				return cb_enable;
			}

			static void n_Enable (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.LightRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.LightRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Enable ();
			}
#pragma warning restore 0169

			static IntPtr id_enable;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.LightRunnable']/method[@name='enable' and count(parameter)=0]"
			[Register ("enable", "()V", "GetEnableHandler")]
			public virtual unsafe void Enable ()
			{
				if (id_enable == IntPtr.Zero)
					id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_enable);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.LightRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.LightRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.LightRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.ScanRunnable']"
		[global::Android.Runtime.Register ("android/hardware/bcreader/BCRManager$ScanRunnable", DoNotGenerateAcw=true)]
		public partial class ScanRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/hardware/bcreader/BCRManager$ScanRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScanRunnable); }
			}

			protected ScanRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_disable;
#pragma warning disable 0169
			static Delegate GetDisableHandler ()
			{
				if (cb_disable == null)
					cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
				return cb_disable;
			}

			static void n_Disable (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.ScanRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.ScanRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Disable ();
			}
#pragma warning restore 0169

			static IntPtr id_disable;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.ScanRunnable']/method[@name='disable' and count(parameter)=0]"
			[Register ("disable", "()V", "GetDisableHandler")]
			public virtual unsafe void Disable ()
			{
				if (id_disable == IntPtr.Zero)
					id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_disable);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
				} finally {
				}
			}

			static Delegate cb_enable;
#pragma warning disable 0169
			static Delegate GetEnableHandler ()
			{
				if (cb_enable == null)
					cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
				return cb_enable;
			}

			static void n_Enable (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.ScanRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.ScanRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Enable ();
			}
#pragma warning restore 0169

			static IntPtr id_enable;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.ScanRunnable']/method[@name='enable' and count(parameter)=0]"
			[Register ("enable", "()V", "GetEnableHandler")]
			public virtual unsafe void Enable ()
			{
				if (id_enable == IntPtr.Zero)
					id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_enable);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Hardware.Bcreader.BCRManager.ScanRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.ScanRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.ScanRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

			static Delegate cb_setSingleOrDoubleCode_I;
#pragma warning disable 0169
			static Delegate GetSetSingleOrDoubleCode_IHandler ()
			{
				if (cb_setSingleOrDoubleCode_I == null)
					cb_setSingleOrDoubleCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSingleOrDoubleCode_I);
				return cb_setSingleOrDoubleCode_I;
			}

			static void n_SetSingleOrDoubleCode_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Hardware.Bcreader.BCRManager.ScanRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager.ScanRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSingleOrDoubleCode (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setSingleOrDoubleCode_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager.ScanRunnable']/method[@name='setSingleOrDoubleCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSingleOrDoubleCode", "(I)V", "GetSetSingleOrDoubleCode_IHandler")]
			public virtual unsafe void SetSingleOrDoubleCode (int p0)
			{
				if (id_setSingleOrDoubleCode_I == IntPtr.Zero)
					id_setSingleOrDoubleCode_I = JNIEnv.GetMethodID (class_ref, "setSingleOrDoubleCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSingleOrDoubleCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleOrDoubleCode", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/hardware/bcreader/BCRManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCRManager); }
		}

		protected BCRManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHWInformation;
#pragma warning disable 0169
		static Delegate GetGetHWInformationHandler ()
		{
			if (cb_getHWInformation == null)
				cb_getHWInformation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHWInformation);
			return cb_getHWInformation;
		}

		static IntPtr n_GetHWInformation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HWInformation);
		}
#pragma warning restore 0169

		static IntPtr id_getHWInformation;
		public virtual unsafe string HWInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getHWInformation' and count(parameter)=0]"
			[Register ("getHWInformation", "()Ljava/lang/String;", "GetGetHWInformationHandler")]
			get {
				if (id_getHWInformation == IntPtr.Zero)
					id_getHWInformation = JNIEnv.GetMethodID (class_ref, "getHWInformation", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHWInformation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHWInformation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		public virtual unsafe global::Android.Graphics.Bitmap Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/Bitmap;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/Bitmap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Android.Hardware.Bcreader.BCRManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Landroid/hardware/bcreader/BCRManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Landroid/hardware/bcreader/BCRManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTopspeedSupported;
#pragma warning disable 0169
		static Delegate GetIsTopspeedSupportedHandler ()
		{
			if (cb_isTopspeedSupported == null)
				cb_isTopspeedSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTopspeedSupported);
			return cb_isTopspeedSupported;
		}

		static bool n_IsTopspeedSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTopspeedSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isTopspeedSupported;
		public virtual unsafe bool IsTopspeedSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='isTopspeedSupported' and count(parameter)=0]"
			[Register ("isTopspeedSupported", "()Z", "GetIsTopspeedSupportedHandler")]
			get {
				if (id_isTopspeedSupported == IntPtr.Zero)
					id_isTopspeedSupported = JNIEnv.GetMethodID (class_ref, "isTopspeedSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTopspeedSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTopspeedSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSWVersion;
#pragma warning disable 0169
		static Delegate GetGetSWVersionHandler ()
		{
			if (cb_getSWVersion == null)
				cb_getSWVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSWVersion);
			return cb_getSWVersion;
		}

		static IntPtr n_GetSWVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SWVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSWVersion;
		public virtual unsafe string SWVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getSWVersion' and count(parameter)=0]"
			[Register ("getSWVersion", "()Ljava/lang/String;", "GetGetSWVersionHandler")]
			get {
				if (id_getSWVersion == IntPtr.Zero)
					id_getSWVersion = JNIEnv.GetMethodID (class_ref, "getSWVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSWVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSWVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTopspeed;
#pragma warning disable 0169
		static Delegate GetGetTopspeedHandler ()
		{
			if (cb_getTopspeed == null)
				cb_getTopspeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTopspeed);
			return cb_getTopspeed;
		}

		static bool n_GetTopspeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Topspeed;
		}
#pragma warning restore 0169

		static Delegate cb_setTopspeed_Z;
#pragma warning disable 0169
		static Delegate GetSetTopspeed_ZHandler ()
		{
			if (cb_setTopspeed_Z == null)
				cb_setTopspeed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTopspeed_Z);
			return cb_setTopspeed_Z;
		}

		static void n_SetTopspeed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Topspeed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopspeed;
		static IntPtr id_setTopspeed_Z;
		public virtual unsafe bool Topspeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getTopspeed' and count(parameter)=0]"
			[Register ("getTopspeed", "()Z", "GetGetTopspeedHandler")]
			get {
				if (id_getTopspeed == IntPtr.Zero)
					id_getTopspeed = JNIEnv.GetMethodID (class_ref, "getTopspeed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getTopspeed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopspeed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='setTopspeed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTopspeed", "(Z)V", "GetSetTopspeed_ZHandler")]
			set {
				if (id_setTopspeed_Z == IntPtr.Zero)
					id_setTopspeed_Z = JNIEnv.GetMethodID (class_ref, "setTopspeed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTopspeed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopspeed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableBeep;
#pragma warning disable 0169
		static Delegate GetDisableBeepHandler ()
		{
			if (cb_disableBeep == null)
				cb_disableBeep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DisableBeep);
			return cb_disableBeep;
		}

		static int n_DisableBeep (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableBeep ();
		}
#pragma warning restore 0169

		static IntPtr id_disableBeep;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='disableBeep' and count(parameter)=0]"
		[Register ("disableBeep", "()I", "GetDisableBeepHandler")]
		public virtual unsafe int DisableBeep ()
		{
			if (id_disableBeep == IntPtr.Zero)
				id_disableBeep = JNIEnv.GetMethodID (class_ref, "disableBeep", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_disableBeep);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableBeep", "()I"));
			} finally {
			}
		}

		static Delegate cb_disableCode_I;
#pragma warning disable 0169
		static Delegate GetDisableCode_IHandler ()
		{
			if (cb_disableCode_I == null)
				cb_disableCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_DisableCode_I);
			return cb_disableCode_I;
		}

		static bool n_DisableCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disableCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='disableCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disableCode", "(I)Z", "GetDisableCode_IHandler")]
		public virtual unsafe bool DisableCode (int p0)
		{
			if (id_disableCode_I == IntPtr.Zero)
				id_disableCode_I = JNIEnv.GetMethodID (class_ref, "disableCode", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_disableCode_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableCode", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_enableBeep;
#pragma warning disable 0169
		static Delegate GetEnableBeepHandler ()
		{
			if (cb_enableBeep == null)
				cb_enableBeep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EnableBeep);
			return cb_enableBeep;
		}

		static int n_EnableBeep (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableBeep ();
		}
#pragma warning restore 0169

		static IntPtr id_enableBeep;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='enableBeep' and count(parameter)=0]"
		[Register ("enableBeep", "()I", "GetEnableBeepHandler")]
		public virtual unsafe int EnableBeep ()
		{
			if (id_enableBeep == IntPtr.Zero)
				id_enableBeep = JNIEnv.GetMethodID (class_ref, "enableBeep", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_enableBeep);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableBeep", "()I"));
			} finally {
			}
		}

		static Delegate cb_enableCode_I;
#pragma warning disable 0169
		static Delegate GetEnableCode_IHandler ()
		{
			if (cb_enableCode_I == null)
				cb_enableCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_EnableCode_I);
			return cb_enableCode_I;
		}

		static bool n_EnableCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableCode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='enableCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableCode", "(I)Z", "GetEnableCode_IHandler")]
		public virtual unsafe bool EnableCode (int p0)
		{
			if (id_enableCode_I == IntPtr.Zero)
				id_enableCode_I = JNIEnv.GetMethodID (class_ref, "enableCode", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_enableCode_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableCode", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_flashLightOff;
#pragma warning disable 0169
		static Delegate GetFlashLightOffHandler ()
		{
			if (cb_flashLightOff == null)
				cb_flashLightOff = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlashLightOff);
			return cb_flashLightOff;
		}

		static void n_FlashLightOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlashLightOff ();
		}
#pragma warning restore 0169

		static IntPtr id_flashLightOff;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='flashLightOff' and count(parameter)=0]"
		[Register ("flashLightOff", "()V", "GetFlashLightOffHandler")]
		public virtual unsafe void FlashLightOff ()
		{
			if (id_flashLightOff == IntPtr.Zero)
				id_flashLightOff = JNIEnv.GetMethodID (class_ref, "flashLightOff", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_flashLightOff);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flashLightOff", "()V"));
			} finally {
			}
		}

		static Delegate cb_flashLightOn;
#pragma warning disable 0169
		static Delegate GetFlashLightOnHandler ()
		{
			if (cb_flashLightOn == null)
				cb_flashLightOn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlashLightOn);
			return cb_flashLightOn;
		}

		static void n_FlashLightOn (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlashLightOn ();
		}
#pragma warning restore 0169

		static IntPtr id_flashLightOn;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='flashLightOn' and count(parameter)=0]"
		[Register ("flashLightOn", "()V", "GetFlashLightOnHandler")]
		public virtual unsafe void FlashLightOn ()
		{
			if (id_flashLightOn == IntPtr.Zero)
				id_flashLightOn = JNIEnv.GetMethodID (class_ref, "flashLightOn", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_flashLightOn);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flashLightOn", "()V"));
			} finally {
			}
		}

		static Delegate cb_getTicketInfo;
#pragma warning disable 0169
		static Delegate GetGetTicketInfoHandler ()
		{
			if (cb_getTicketInfo == null)
				cb_getTicketInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTicketInfo);
			return cb_getTicketInfo;
		}

		static IntPtr n_GetTicketInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTicketInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getTicketInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='getTicketInfo' and count(parameter)=0]"
		[Register ("getTicketInfo", "()[Landroid/hardware/bcreader/BCRTicketInfo;", "GetGetTicketInfoHandler")]
		public virtual unsafe global::Android.Hardware.Bcreader.BCRTicketInfo[] GetTicketInfo ()
		{
			if (id_getTicketInfo == IntPtr.Zero)
				id_getTicketInfo = JNIEnv.GetMethodID (class_ref, "getTicketInfo", "()[Landroid/hardware/bcreader/BCRTicketInfo;");
			try {

				if (GetType () == ThresholdType)
					return (global::Android.Hardware.Bcreader.BCRTicketInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTicketInfo), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Hardware.Bcreader.BCRTicketInfo));
				else
					return (global::Android.Hardware.Bcreader.BCRTicketInfo[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTicketInfo", "()[Landroid/hardware/bcreader/BCRTicketInfo;")), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Hardware.Bcreader.BCRTicketInfo));
			} finally {
			}
		}

		static Delegate cb_open_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOpen_Landroid_content_Context_Handler ()
		{
			if (cb_open_Landroid_content_Context_ == null)
				cb_open_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Landroid_content_Context_);
			return cb_open_Landroid_content_Context_;
		}

		static void n_Open_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='open' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("open", "(Landroid/content/Context;)V", "GetOpen_Landroid_content_Context_Handler")]
		public virtual unsafe void Open (global::Android.Content.Context p0)
		{
			if (id_open_Landroid_content_Context_ == IntPtr.Zero)
				id_open_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_open_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerListener_Landroid_hardware_bcreader_BCRListener_;
#pragma warning disable 0169
		static Delegate GetRegisterListener_Landroid_hardware_bcreader_BCRListener_Handler ()
		{
			if (cb_registerListener_Landroid_hardware_bcreader_BCRListener_ == null)
				cb_registerListener_Landroid_hardware_bcreader_BCRListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListener_Landroid_hardware_bcreader_BCRListener_);
			return cb_registerListener_Landroid_hardware_bcreader_BCRListener_;
		}

		static void n_RegisterListener_Landroid_hardware_bcreader_BCRListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Bcreader.IBCRListener p0 = (global::Android.Hardware.Bcreader.IBCRListener)global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerListener_Landroid_hardware_bcreader_BCRListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='android.hardware.bcreader.BCRListener']]"
		[Register ("registerListener", "(Landroid/hardware/bcreader/BCRListener;)V", "GetRegisterListener_Landroid_hardware_bcreader_BCRListener_Handler")]
		public virtual unsafe void RegisterListener (global::Android.Hardware.Bcreader.IBCRListener p0)
		{
			if (id_registerListener_Landroid_hardware_bcreader_BCRListener_ == IntPtr.Zero)
				id_registerListener_Landroid_hardware_bcreader_BCRListener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Landroid/hardware/bcreader/BCRListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_registerListener_Landroid_hardware_bcreader_BCRListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerListener", "(Landroid/hardware/bcreader/BCRListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAim_Z;
#pragma warning disable 0169
		static Delegate GetSetAim_ZHandler ()
		{
			if (cb_setAim_Z == null)
				cb_setAim_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetAim_Z);
			return cb_setAim_Z;
		}

		static bool n_SetAim_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAim (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAim_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='setAim' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAim", "(Z)Z", "GetSetAim_ZHandler")]
		public virtual unsafe bool SetAim (bool p0)
		{
			if (id_setAim_Z == IntPtr.Zero)
				id_setAim_Z = JNIEnv.GetMethodID (class_ref, "setAim", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_setAim_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAim", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setParam_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetParam_Ljava_util_HashMap_Handler ()
		{
			if (cb_setParam_Ljava_util_HashMap_ == null)
				cb_setParam_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetParam_Ljava_util_HashMap_);
			return cb_setParam_Ljava_util_HashMap_;
		}

		static int n_SetParam_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParam (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setParam_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='setParam' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setParam", "(Ljava/util/HashMap;)I", "GetSetParam_Ljava_util_HashMap_Handler")]
		public virtual unsafe int SetParam (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setParam_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setParam_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setParam", "(Ljava/util/HashMap;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_setParam_Ljava_util_HashMap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParam", "(Ljava/util/HashMap;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		public virtual unsafe void SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTimeout_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserLED_Z;
#pragma warning disable 0169
		static Delegate GetSetUserLED_ZHandler ()
		{
			if (cb_setUserLED_Z == null)
				cb_setUserLED_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetUserLED_Z);
			return cb_setUserLED_Z;
		}

		static bool n_SetUserLED_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUserLED (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserLED_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='setUserLED' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserLED", "(Z)Z", "GetSetUserLED_ZHandler")]
		public virtual unsafe bool SetUserLED (bool p0)
		{
			if (id_setUserLED_Z == IntPtr.Zero)
				id_setUserLED_Z = JNIEnv.GetMethodID (class_ref, "setUserLED", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_setUserLED_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserLED", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_sleep_I;
#pragma warning disable 0169
		static Delegate GetSleep_IHandler ()
		{
			if (cb_sleep_I == null)
				cb_sleep_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Sleep_I);
			return cb_sleep_I;
		}

		static int n_Sleep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sleep (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sleep_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sleep", "(I)I", "GetSleep_IHandler")]
		public virtual unsafe int Sleep (int p0)
		{
			if (id_sleep_I == IntPtr.Zero)
				id_sleep_I = JNIEnv.GetMethodID (class_ref, "sleep", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_sleep_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sleep", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_startScan_II;
#pragma warning disable 0169
		static Delegate GetStartScan_IIHandler ()
		{
			if (cb_startScan_II == null)
				cb_startScan_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_StartScan_II);
			return cb_startScan_II;
		}

		static bool n_StartScan_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartScan (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startScan_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startScan", "(II)Z", "GetStartScan_IIHandler")]
		public virtual unsafe bool StartScan (int p0, int p1)
		{
			if (id_startScan_II == IntPtr.Zero)
				id_startScan_II = JNIEnv.GetMethodID (class_ref, "startScan", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_startScan_II, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startScan", "(II)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_stopScan;
#pragma warning disable 0169
		static Delegate GetStopScanHandler ()
		{
			if (cb_stopScan == null)
				cb_stopScan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopScan);
			return cb_stopScan;
		}

		static bool n_StopScan (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopScan ();
		}
#pragma warning restore 0169

		static IntPtr id_stopScan;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='stopScan' and count(parameter)=0]"
		[Register ("stopScan", "()Z", "GetStopScanHandler")]
		public virtual unsafe bool StopScan ()
		{
			if (id_stopScan == IntPtr.Zero)
				id_stopScan = JNIEnv.GetMethodID (class_ref, "stopScan", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_stopScan);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopScan", "()Z"));
			} finally {
			}
		}

		static Delegate cb_wakeup;
#pragma warning disable 0169
		static Delegate GetWakeupHandler ()
		{
			if (cb_wakeup == null)
				cb_wakeup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Wakeup);
			return cb_wakeup;
		}

		static int n_Wakeup (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Hardware.Bcreader.BCRManager __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.BCRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Wakeup ();
		}
#pragma warning restore 0169

		static IntPtr id_wakeup;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/class[@name='BCRManager']/method[@name='wakeup' and count(parameter)=0]"
		[Register ("wakeup", "()I", "GetWakeupHandler")]
		public virtual unsafe int Wakeup ()
		{
			if (id_wakeup == IntPtr.Zero)
				id_wakeup = JNIEnv.GetMethodID (class_ref, "wakeup", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_wakeup);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wakeup", "()I"));
			} finally {
			}
		}

	}
}
