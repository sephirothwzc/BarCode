using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	[Register ("android/hardware/bcreader/BCRInterface")]
	public abstract class BCRInterface {

		internal BCRInterface ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/field[@name='NOTSUPPORTED']"
		[Register ("NOTSUPPORTED")]
		public const int Notsupported = (int) -100;
	}

	[global::System.Obsolete ("Use the 'BCRInterface' type. This type will be removed in a future release.")]
	public abstract class BCRInterfaceConsts : BCRInterface {

		private BCRInterfaceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']"
	[Register ("android/hardware/bcreader/BCRInterface", "", "Android.Hardware.Bcreader.IBCRInterfaceInvoker")]
	public partial interface IBCRInterface : IJavaObject {

		string HWInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='getHWInformation' and count(parameter)=0]"
			[Register ("getHWInformation", "()Ljava/lang/String;", "GetGetHWInformationHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")] get;
		}

		global::Android.Graphics.Bitmap Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/Bitmap;", "GetGetImageHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")] get;
		}

		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")] get;
		}

		string SWVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='getSWVersion' and count(parameter)=0]"
			[Register ("getSWVersion", "()Ljava/lang/String;", "GetGetSWVersionHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='disableBeep' and count(parameter)=0]"
		[Register ("disableBeep", "()I", "GetDisableBeepHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		int DisableBeep ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='disableCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disableCode", "(I)Z", "GetDisableCode_IHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool DisableCode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='enableBeep' and count(parameter)=0]"
		[Register ("enableBeep", "()I", "GetEnableBeepHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		int EnableBeep ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='enableCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableCode", "(I)Z", "GetEnableCode_IHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool EnableCode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='getTicketInfo' and count(parameter)=0]"
		[Register ("getTicketInfo", "()[Landroid/hardware/bcreader/BCRTicketInfo;", "GetGetTicketInfoHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		global::Android.Hardware.Bcreader.BCRTicketInfo[] GetTicketInfo ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='open' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("open", "(Landroid/content/Context;)V", "GetOpen_Landroid_content_Context_Handler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		void Open (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='registerListener' and count(parameter)=1 and parameter[1][@type='android.hardware.bcreader.BCRListener']]"
		[Register ("registerListener", "(Landroid/hardware/bcreader/BCRListener;)V", "GetRegisterListener_Landroid_hardware_bcreader_BCRListener_Handler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		void RegisterListener (global::Android.Hardware.Bcreader.IBCRListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='setAim' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAim", "(Z)Z", "GetSetAim_ZHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool SetAim (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='setParam' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setParam", "(Ljava/util/HashMap;)I", "GetSetParam_Ljava_util_HashMap_Handler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		int SetParam (global::System.Collections.Generic.IDictionary<string, string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='setUserLED' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserLED", "(Z)Z", "GetSetUserLED_ZHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool SetUserLED (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sleep", "(I)I", "GetSleep_IHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		int Sleep (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='startScan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startScan", "(II)Z", "GetStartScan_IIHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool StartScan (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='stopScan' and count(parameter)=0]"
		[Register ("stopScan", "()Z", "GetStopScanHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		bool StopScan ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRInterface']/method[@name='wakeup' and count(parameter)=0]"
		[Register ("wakeup", "()I", "GetWakeupHandler:Android.Hardware.Bcreader.IBCRInterfaceInvoker, BCManager")]
		int Wakeup ();

	}

	[global::Android.Runtime.Register ("android/hardware/bcreader/BCRInterface", DoNotGenerateAcw=true)]
	internal class IBCRInterfaceInvoker : global::Java.Lang.Object, IBCRInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/hardware/bcreader/BCRInterface");
		IntPtr class_ref;

		public static IBCRInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCRInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.hardware.bcreader.BCRInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCRInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCRInterfaceInvoker); }
		}

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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HWInformation);
		}
#pragma warning restore 0169

		IntPtr id_getHWInformation;
		public unsafe string HWInformation {
			get {
				if (id_getHWInformation == IntPtr.Zero)
					id_getHWInformation = JNIEnv.GetMethodID (class_ref, "getHWInformation", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHWInformation), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		IntPtr id_getImage;
		public unsafe global::Android.Graphics.Bitmap Image {
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public unsafe bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isReady);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SWVersion);
		}
#pragma warning restore 0169

		IntPtr id_getSWVersion;
		public unsafe string SWVersion {
			get {
				if (id_getSWVersion == IntPtr.Zero)
					id_getSWVersion = JNIEnv.GetMethodID (class_ref, "getSWVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSWVersion), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableBeep ();
		}
#pragma warning restore 0169

		IntPtr id_disableBeep;
		public unsafe int DisableBeep ()
		{
			if (id_disableBeep == IntPtr.Zero)
				id_disableBeep = JNIEnv.GetMethodID (class_ref, "disableBeep", "()I");
			return JNIEnv.CallIntMethod (Handle, id_disableBeep);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_disableCode_I;
		public unsafe bool DisableCode (int p0)
		{
			if (id_disableCode_I == IntPtr.Zero)
				id_disableCode_I = JNIEnv.GetMethodID (class_ref, "disableCode", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (Handle, id_disableCode_I, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableBeep ();
		}
#pragma warning restore 0169

		IntPtr id_enableBeep;
		public unsafe int EnableBeep ()
		{
			if (id_enableBeep == IntPtr.Zero)
				id_enableBeep = JNIEnv.GetMethodID (class_ref, "enableBeep", "()I");
			return JNIEnv.CallIntMethod (Handle, id_enableBeep);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_enableCode_I;
		public unsafe bool EnableCode (int p0)
		{
			if (id_enableCode_I == IntPtr.Zero)
				id_enableCode_I = JNIEnv.GetMethodID (class_ref, "enableCode", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (Handle, id_enableCode_I, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTicketInfo ());
		}
#pragma warning restore 0169

		IntPtr id_getTicketInfo;
		public unsafe global::Android.Hardware.Bcreader.BCRTicketInfo[] GetTicketInfo ()
		{
			if (id_getTicketInfo == IntPtr.Zero)
				id_getTicketInfo = JNIEnv.GetMethodID (class_ref, "getTicketInfo", "()[Landroid/hardware/bcreader/BCRTicketInfo;");
			return (global::Android.Hardware.Bcreader.BCRTicketInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (Handle, id_getTicketInfo), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Hardware.Bcreader.BCRTicketInfo));
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		IntPtr id_open_Landroid_content_Context_;
		public unsafe void Open (global::Android.Content.Context p0)
		{
			if (id_open_Landroid_content_Context_ == IntPtr.Zero)
				id_open_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "open", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_open_Landroid_content_Context_, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Bcreader.IBCRListener p0 = (global::Android.Hardware.Bcreader.IBCRListener)global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerListener_Landroid_hardware_bcreader_BCRListener_;
		public unsafe void RegisterListener (global::Android.Hardware.Bcreader.IBCRListener p0)
		{
			if (id_registerListener_Landroid_hardware_bcreader_BCRListener_ == IntPtr.Zero)
				id_registerListener_Landroid_hardware_bcreader_BCRListener_ = JNIEnv.GetMethodID (class_ref, "registerListener", "(Landroid/hardware/bcreader/BCRListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_registerListener_Landroid_hardware_bcreader_BCRListener_, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAim (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAim_Z;
		public unsafe bool SetAim (bool p0)
		{
			if (id_setAim_Z == IntPtr.Zero)
				id_setAim_Z = JNIEnv.GetMethodID (class_ref, "setAim", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (Handle, id_setAim_Z, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParam (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setParam_Ljava_util_HashMap_;
		public unsafe int SetParam (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setParam_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setParam_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setParam", "(Ljava/util/HashMap;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (Handle, id_setParam_Ljava_util_HashMap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetUserLED (p0);
		}
#pragma warning restore 0169

		IntPtr id_setUserLED_Z;
		public unsafe bool SetUserLED (bool p0)
		{
			if (id_setUserLED_Z == IntPtr.Zero)
				id_setUserLED_Z = JNIEnv.GetMethodID (class_ref, "setUserLED", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (Handle, id_setUserLED_Z, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sleep (p0);
		}
#pragma warning restore 0169

		IntPtr id_sleep_I;
		public unsafe int Sleep (int p0)
		{
			if (id_sleep_I == IntPtr.Zero)
				id_sleep_I = JNIEnv.GetMethodID (class_ref, "sleep", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (Handle, id_sleep_I, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartScan (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startScan_II;
		public unsafe bool StartScan (int p0, int p1)
		{
			if (id_startScan_II == IntPtr.Zero)
				id_startScan_II = JNIEnv.GetMethodID (class_ref, "startScan", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (Handle, id_startScan_II, __args);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopScan ();
		}
#pragma warning restore 0169

		IntPtr id_stopScan;
		public unsafe bool StopScan ()
		{
			if (id_stopScan == IntPtr.Zero)
				id_stopScan = JNIEnv.GetMethodID (class_ref, "stopScan", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_stopScan);
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
			global::Android.Hardware.Bcreader.IBCRInterface __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Wakeup ();
		}
#pragma warning restore 0169

		IntPtr id_wakeup;
		public unsafe int Wakeup ()
		{
			if (id_wakeup == IntPtr.Zero)
				id_wakeup = JNIEnv.GetMethodID (class_ref, "wakeup", "()I");
			return JNIEnv.CallIntMethod (Handle, id_wakeup);
		}

	}

}
