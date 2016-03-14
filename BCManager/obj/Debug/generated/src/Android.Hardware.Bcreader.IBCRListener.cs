using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Hardware.Bcreader {

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRListener']"
	[Register ("android/hardware/bcreader/BCRListener", "", "Android.Hardware.Bcreader.IBCRListenerInvoker")]
	public partial interface IBCRListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRListener']/method[@name='onOpened' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onOpened", "(Z)V", "GetOnOpened_ZHandler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCManager")]
		void OnOpened (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.hardware.bcreader']/interface[@name='BCRListener']/method[@name='onScanFinished' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onScanFinished", "(ILjava/lang/String;)V", "GetOnScanFinished_ILjava_lang_String_Handler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCManager")]
		void OnScanFinished (int p0, string p1);

	}

	[global::Android.Runtime.Register ("android/hardware/bcreader/BCRListener", DoNotGenerateAcw=true)]
	internal class IBCRListenerInvoker : global::Java.Lang.Object, IBCRListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/hardware/bcreader/BCRListener");
		IntPtr class_ref;

		public static IBCRListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCRListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.hardware.bcreader.BCRListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCRListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCRListenerInvoker); }
		}

		static Delegate cb_onOpened_Z;
#pragma warning disable 0169
		static Delegate GetOnOpened_ZHandler ()
		{
			if (cb_onOpened_Z == null)
				cb_onOpened_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnOpened_Z);
			return cb_onOpened_Z;
		}

		static void n_OnOpened_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Hardware.Bcreader.IBCRListener __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOpened (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOpened_Z;
		public unsafe void OnOpened (bool p0)
		{
			if (id_onOpened_Z == IntPtr.Zero)
				id_onOpened_Z = JNIEnv.GetMethodID (class_ref, "onOpened", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOpened_Z, __args);
		}

		static Delegate cb_onScanFinished_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnScanFinished_ILjava_lang_String_Handler ()
		{
			if (cb_onScanFinished_ILjava_lang_String_ == null)
				cb_onScanFinished_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnScanFinished_ILjava_lang_String_);
			return cb_onScanFinished_ILjava_lang_String_;
		}

		static void n_OnScanFinished_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Hardware.Bcreader.IBCRListener __this = global::Java.Lang.Object.GetObject<global::Android.Hardware.Bcreader.IBCRListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnScanFinished (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScanFinished_ILjava_lang_String_;
		public unsafe void OnScanFinished (int p0, string p1)
		{
			if (id_onScanFinished_ILjava_lang_String_ == IntPtr.Zero)
				id_onScanFinished_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onScanFinished", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onScanFinished_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class OpenedEventArgs : global::System.EventArgs {

		public OpenedEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	public partial class ScanFinishedEventArgs : global::System.EventArgs {

		public ScanFinishedEventArgs (int p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/android/hardware/bcreader/BCRListenerImplementor")]
	internal sealed partial class IBCRListenerImplementor : global::Java.Lang.Object, IBCRListener {

		object sender;

		public IBCRListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/hardware/bcreader/BCRListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<OpenedEventArgs> OnOpenedHandler;
#pragma warning restore 0649

		public void OnOpened (bool p0)
		{
			var __h = OnOpenedHandler;
			if (__h != null)
				__h (sender, new OpenedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ScanFinishedEventArgs> OnScanFinishedHandler;
#pragma warning restore 0649

		public void OnScanFinished (int p0, string p1)
		{
			var __h = OnScanFinishedHandler;
			if (__h != null)
				__h (sender, new ScanFinishedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBCRListenerImplementor value)
		{
			return value.OnOpenedHandler == null && value.OnScanFinishedHandler == null;
		}
	}

}
