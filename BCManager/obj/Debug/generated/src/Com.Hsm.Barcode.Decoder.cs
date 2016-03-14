using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']"
	[global::Android.Runtime.Register ("com/hsm/barcode/Decoder", DoNotGenerateAcw=true)]
	public partial class Decoder : global::Java.Lang.Object {


		static IntPtr mayContinue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/field[@name='mayContinue']"
		[Register ("mayContinue")]
		public bool MayContinue {
			get {
				if (mayContinue_jfieldId == IntPtr.Zero)
					mayContinue_jfieldId = JNIEnv.GetFieldID (class_ref, "mayContinue", "Z");
				return JNIEnv.GetBooleanField (Handle, mayContinue_jfieldId);
			}
			set {
				if (mayContinue_jfieldId == IntPtr.Zero)
					mayContinue_jfieldId = JNIEnv.GetFieldID (class_ref, "mayContinue", "Z");
				try {
					JNIEnv.SetField (Handle, mayContinue_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Decoder); }
		}

		protected Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/constructor[@name='Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Decoder)) {
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

		static Delegate cb_getAPIRevision;
#pragma warning disable 0169
		static Delegate GetGetAPIRevisionHandler ()
		{
			if (cb_getAPIRevision == null)
				cb_getAPIRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAPIRevision);
			return cb_getAPIRevision;
		}

		static IntPtr n_GetAPIRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.APIRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getAPIRevision;
		public virtual unsafe string APIRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getAPIRevision' and count(parameter)=0]"
			[Register ("getAPIRevision", "()Ljava/lang/String;", "GetGetAPIRevisionHandler")]
			get {
				if (id_getAPIRevision == IntPtr.Zero)
					id_getAPIRevision = JNIEnv.GetMethodID (class_ref, "getAPIRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAPIRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAPIRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAimID;
#pragma warning disable 0169
		static Delegate GetGetAimIDHandler ()
		{
			if (cb_getAimID == null)
				cb_getAimID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAimID);
			return cb_getAimID;
		}

		static sbyte n_GetAimID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AimID;
		}
#pragma warning restore 0169

		static IntPtr id_getAimID;
		public virtual unsafe sbyte AimID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getAimID' and count(parameter)=0]"
			[Register ("getAimID", "()B", "GetGetAimIDHandler")]
			get {
				if (id_getAimID == IntPtr.Zero)
					id_getAimID = JNIEnv.GetMethodID (class_ref, "getAimID", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod  (Handle, id_getAimID);
					else
						return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAimID", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAimModifier;
#pragma warning disable 0169
		static Delegate GetGetAimModifierHandler ()
		{
			if (cb_getAimModifier == null)
				cb_getAimModifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAimModifier);
			return cb_getAimModifier;
		}

		static sbyte n_GetAimModifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AimModifier;
		}
#pragma warning restore 0169

		static IntPtr id_getAimModifier;
		public virtual unsafe sbyte AimModifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getAimModifier' and count(parameter)=0]"
			[Register ("getAimModifier", "()B", "GetGetAimModifierHandler")]
			get {
				if (id_getAimModifier == IntPtr.Zero)
					id_getAimModifier = JNIEnv.GetMethodID (class_ref, "getAimModifier", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod  (Handle, id_getAimModifier);
					else
						return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAimModifier", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_GetBarcodeData;
#pragma warning disable 0169
		static Delegate GetGetBarcodeDataHandler ()
		{
			if (cb_GetBarcodeData == null)
				cb_GetBarcodeData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeData);
			return cb_GetBarcodeData;
		}

		static IntPtr n_GetBarcodeData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BarcodeData);
		}
#pragma warning restore 0169

		static IntPtr id_GetBarcodeData;
		public virtual unsafe string BarcodeData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='GetBarcodeData' and count(parameter)=0]"
			[Register ("GetBarcodeData", "()Ljava/lang/String;", "GetGetBarcodeDataHandler")]
			get {
				if (id_GetBarcodeData == IntPtr.Zero)
					id_GetBarcodeData = JNIEnv.GetMethodID (class_ref, "GetBarcodeData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_GetBarcodeData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "GetBarcodeData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodeID;
#pragma warning disable 0169
		static Delegate GetGetCodeIDHandler ()
		{
			if (cb_getCodeID == null)
				cb_getCodeID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetCodeID);
			return cb_getCodeID;
		}

		static sbyte n_GetCodeID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodeID;
		}
#pragma warning restore 0169

		static IntPtr id_getCodeID;
		public virtual unsafe sbyte CodeID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getCodeID' and count(parameter)=0]"
			[Register ("getCodeID", "()B", "GetGetCodeIDHandler")]
			get {
				if (id_getCodeID == IntPtr.Zero)
					id_getCodeID = JNIEnv.GetMethodID (class_ref, "getCodeID", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod  (Handle, id_getCodeID);
					else
						return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodeID", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getControlLogicRevision;
#pragma warning disable 0169
		static Delegate GetGetControlLogicRevisionHandler ()
		{
			if (cb_getControlLogicRevision == null)
				cb_getControlLogicRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControlLogicRevision);
			return cb_getControlLogicRevision;
		}

		static IntPtr n_GetControlLogicRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ControlLogicRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getControlLogicRevision;
		public virtual unsafe string ControlLogicRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getControlLogicRevision' and count(parameter)=0]"
			[Register ("getControlLogicRevision", "()Ljava/lang/String;", "GetGetControlLogicRevisionHandler")]
			get {
				if (id_getControlLogicRevision == IntPtr.Zero)
					id_getControlLogicRevision = JNIEnv.GetMethodID (class_ref, "getControlLogicRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getControlLogicRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getControlLogicRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDecThreadsRevision;
#pragma warning disable 0169
		static Delegate GetGetDecThreadsRevisionHandler ()
		{
			if (cb_getDecThreadsRevision == null)
				cb_getDecThreadsRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecThreadsRevision);
			return cb_getDecThreadsRevision;
		}

		static IntPtr n_GetDecThreadsRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecThreadsRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getDecThreadsRevision;
		public virtual unsafe string DecThreadsRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecThreadsRevision' and count(parameter)=0]"
			[Register ("getDecThreadsRevision", "()Ljava/lang/String;", "GetGetDecThreadsRevisionHandler")]
			get {
				if (id_getDecThreadsRevision == IntPtr.Zero)
					id_getDecThreadsRevision = JNIEnv.GetMethodID (class_ref, "getDecThreadsRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDecThreadsRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecThreadsRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDecodeData;
#pragma warning disable 0169
		static Delegate GetGetDecodeDataHandler ()
		{
			if (cb_getDecodeData == null)
				cb_getDecodeData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecodeData);
			return cb_getDecodeData;
		}

		static IntPtr n_GetDecodeData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecodeData);
		}
#pragma warning restore 0169

		static IntPtr id_getDecodeData;
		public virtual unsafe string DecodeData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecodeData' and count(parameter)=0]"
			[Register ("getDecodeData", "()Ljava/lang/String;", "GetGetDecodeDataHandler")]
			get {
				if (id_getDecodeData == IntPtr.Zero)
					id_getDecodeData = JNIEnv.GetMethodID (class_ref, "getDecodeData", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDecodeData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecodeData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDecodeWindowMode;
#pragma warning disable 0169
		static Delegate GetGetDecodeWindowModeHandler ()
		{
			if (cb_getDecodeWindowMode == null)
				cb_getDecodeWindowMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDecodeWindowMode);
			return cb_getDecodeWindowMode;
		}

		static int n_GetDecodeWindowMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecodeWindowMode;
		}
#pragma warning restore 0169

		static Delegate cb_setDecodeWindowMode_I;
#pragma warning disable 0169
		static Delegate GetSetDecodeWindowMode_IHandler ()
		{
			if (cb_setDecodeWindowMode_I == null)
				cb_setDecodeWindowMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDecodeWindowMode_I);
			return cb_setDecodeWindowMode_I;
		}

		static void n_SetDecodeWindowMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecodeWindowMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDecodeWindowMode;
		static IntPtr id_setDecodeWindowMode_I;
		public virtual unsafe int DecodeWindowMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecodeWindowMode' and count(parameter)=0]"
			[Register ("getDecodeWindowMode", "()I", "GetGetDecodeWindowModeHandler")]
			get {
				if (id_getDecodeWindowMode == IntPtr.Zero)
					id_getDecodeWindowMode = JNIEnv.GetMethodID (class_ref, "getDecodeWindowMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDecodeWindowMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecodeWindowMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setDecodeWindowMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDecodeWindowMode", "(I)V", "GetSetDecodeWindowMode_IHandler")]
			set {
				if (id_setDecodeWindowMode_I == IntPtr.Zero)
					id_setDecodeWindowMode_I = JNIEnv.GetMethodID (class_ref, "setDecodeWindowMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDecodeWindowMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecodeWindowMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDecoderRevision;
#pragma warning disable 0169
		static Delegate GetGetDecoderRevisionHandler ()
		{
			if (cb_getDecoderRevision == null)
				cb_getDecoderRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecoderRevision);
			return cb_getDecoderRevision;
		}

		static IntPtr n_GetDecoderRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecoderRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getDecoderRevision;
		public virtual unsafe string DecoderRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecoderRevision' and count(parameter)=0]"
			[Register ("getDecoderRevision", "()Ljava/lang/String;", "GetGetDecoderRevisionHandler")]
			get {
				if (id_getDecoderRevision == IntPtr.Zero)
					id_getDecoderRevision = JNIEnv.GetMethodID (class_ref, "getDecoderRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDecoderRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecoderRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEngineID;
#pragma warning disable 0169
		static Delegate GetGetEngineIDHandler ()
		{
			if (cb_getEngineID == null)
				cb_getEngineID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEngineID);
			return cb_getEngineID;
		}

		static int n_GetEngineID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EngineID;
		}
#pragma warning restore 0169

		static IntPtr id_getEngineID;
		public virtual unsafe int EngineID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getEngineID' and count(parameter)=0]"
			[Register ("getEngineID", "()I", "GetGetEngineIDHandler")]
			get {
				if (id_getEngineID == IntPtr.Zero)
					id_getEngineID = JNIEnv.GetMethodID (class_ref, "getEngineID", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEngineID);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEngineID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEngineSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetEngineSerialNumberHandler ()
		{
			if (cb_getEngineSerialNumber == null)
				cb_getEngineSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEngineSerialNumber);
			return cb_getEngineSerialNumber;
		}

		static IntPtr n_GetEngineSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EngineSerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getEngineSerialNumber;
		public virtual unsafe string EngineSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getEngineSerialNumber' and count(parameter)=0]"
			[Register ("getEngineSerialNumber", "()Ljava/lang/String;", "GetGetEngineSerialNumberHandler")]
			get {
				if (id_getEngineSerialNumber == IntPtr.Zero)
					id_getEngineSerialNumber = JNIEnv.GetMethodID (class_ref, "getEngineSerialNumber", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEngineSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEngineSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEngineType;
#pragma warning disable 0169
		static Delegate GetGetEngineTypeHandler ()
		{
			if (cb_getEngineType == null)
				cb_getEngineType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEngineType);
			return cb_getEngineType;
		}

		static int n_GetEngineType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EngineType;
		}
#pragma warning restore 0169

		static IntPtr id_getEngineType;
		public virtual unsafe int EngineType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getEngineType' and count(parameter)=0]"
			[Register ("getEngineType", "()I", "GetGetEngineTypeHandler")]
			get {
				if (id_getEngineType == IntPtr.Zero)
					id_getEngineType = JNIEnv.GetMethodID (class_ref, "getEngineType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEngineType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEngineType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageHeight;
#pragma warning disable 0169
		static Delegate GetGetImageHeightHandler ()
		{
			if (cb_getImageHeight == null)
				cb_getImageHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageHeight);
			return cb_getImageHeight;
		}

		static int n_GetImageHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getImageHeight;
		public virtual unsafe int ImageHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getImageHeight' and count(parameter)=0]"
			[Register ("getImageHeight", "()I", "GetGetImageHeightHandler")]
			get {
				if (id_getImageHeight == IntPtr.Zero)
					id_getImageHeight = JNIEnv.GetMethodID (class_ref, "getImageHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getImageHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageWidth;
#pragma warning disable 0169
		static Delegate GetGetImageWidthHandler ()
		{
			if (cb_getImageWidth == null)
				cb_getImageWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageWidth);
			return cb_getImageWidth;
		}

		static int n_GetImageWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getImageWidth;
		public virtual unsafe int ImageWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getImageWidth' and count(parameter)=0]"
			[Register ("getImageWidth", "()I", "GetGetImageWidthHandler")]
			get {
				if (id_getImageWidth == IntPtr.Zero)
					id_getImageWidth = JNIEnv.GetMethodID (class_ref, "getImageWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getImageWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastDecodeTime;
#pragma warning disable 0169
		static Delegate GetGetLastDecodeTimeHandler ()
		{
			if (cb_getLastDecodeTime == null)
				cb_getLastDecodeTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastDecodeTime);
			return cb_getLastDecodeTime;
		}

		static int n_GetLastDecodeTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastDecodeTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastDecodeTime;
		public virtual unsafe int LastDecodeTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getLastDecodeTime' and count(parameter)=0]"
			[Register ("getLastDecodeTime", "()I", "GetGetLastDecodeTimeHandler")]
			get {
				if (id_getLastDecodeTime == IntPtr.Zero)
					id_getLastDecodeTime = JNIEnv.GetMethodID (class_ref, "getLastDecodeTime", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLastDecodeTime);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastDecodeTime", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static IntPtr id_getLength;
		public virtual unsafe int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLength);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxMessageLength;
#pragma warning disable 0169
		static Delegate GetGetMaxMessageLengthHandler ()
		{
			if (cb_getMaxMessageLength == null)
				cb_getMaxMessageLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxMessageLength);
			return cb_getMaxMessageLength;
		}

		static int n_GetMaxMessageLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxMessageLength;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxMessageLength;
		public virtual unsafe int MaxMessageLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getMaxMessageLength' and count(parameter)=0]"
			[Register ("getMaxMessageLength", "()I", "GetGetMaxMessageLengthHandler")]
			get {
				if (id_getMaxMessageLength == IntPtr.Zero)
					id_getMaxMessageLength = JNIEnv.GetMethodID (class_ref, "getMaxMessageLength", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxMessageLength);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxMessageLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOCRMode;
#pragma warning disable 0169
		static Delegate GetGetOCRModeHandler ()
		{
			if (cb_getOCRMode == null)
				cb_getOCRMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOCRMode);
			return cb_getOCRMode;
		}

		static int n_GetOCRMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OCRMode;
		}
#pragma warning restore 0169

		static Delegate cb_setOCRMode_I;
#pragma warning disable 0169
		static Delegate GetSetOCRMode_IHandler ()
		{
			if (cb_setOCRMode_I == null)
				cb_setOCRMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOCRMode_I);
			return cb_setOCRMode_I;
		}

		static void n_SetOCRMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OCRMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOCRMode;
		static IntPtr id_setOCRMode_I;
		public virtual unsafe int OCRMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getOCRMode' and count(parameter)=0]"
			[Register ("getOCRMode", "()I", "GetGetOCRModeHandler")]
			get {
				if (id_getOCRMode == IntPtr.Zero)
					id_getOCRMode = JNIEnv.GetMethodID (class_ref, "getOCRMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOCRMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOCRMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setOCRMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOCRMode", "(I)V", "GetSetOCRMode_IHandler")]
			set {
				if (id_setOCRMode_I == IntPtr.Zero)
					id_setOCRMode_I = JNIEnv.GetMethodID (class_ref, "setOCRMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOCRMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOCRMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOCRTemplates;
#pragma warning disable 0169
		static Delegate GetGetOCRTemplatesHandler ()
		{
			if (cb_getOCRTemplates == null)
				cb_getOCRTemplates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOCRTemplates);
			return cb_getOCRTemplates;
		}

		static int n_GetOCRTemplates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OCRTemplates;
		}
#pragma warning restore 0169

		static Delegate cb_setOCRTemplates_I;
#pragma warning disable 0169
		static Delegate GetSetOCRTemplates_IHandler ()
		{
			if (cb_setOCRTemplates_I == null)
				cb_setOCRTemplates_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOCRTemplates_I);
			return cb_setOCRTemplates_I;
		}

		static void n_SetOCRTemplates_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OCRTemplates = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOCRTemplates;
		static IntPtr id_setOCRTemplates_I;
		public virtual unsafe int OCRTemplates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getOCRTemplates' and count(parameter)=0]"
			[Register ("getOCRTemplates", "()I", "GetGetOCRTemplatesHandler")]
			get {
				if (id_getOCRTemplates == IntPtr.Zero)
					id_getOCRTemplates = JNIEnv.GetMethodID (class_ref, "getOCRTemplates", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOCRTemplates);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOCRTemplates", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setOCRTemplates' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOCRTemplates", "(I)V", "GetSetOCRTemplates_IHandler")]
			set {
				if (id_setOCRTemplates_I == IntPtr.Zero)
					id_setOCRTemplates_I = JNIEnv.GetMethodID (class_ref, "setOCRTemplates", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOCRTemplates_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOCRTemplates", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPSOCMajorRev;
#pragma warning disable 0169
		static Delegate GetGetPSOCMajorRevHandler ()
		{
			if (cb_getPSOCMajorRev == null)
				cb_getPSOCMajorRev = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPSOCMajorRev);
			return cb_getPSOCMajorRev;
		}

		static int n_GetPSOCMajorRev (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PSOCMajorRev;
		}
#pragma warning restore 0169

		static IntPtr id_getPSOCMajorRev;
		public virtual unsafe int PSOCMajorRev {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getPSOCMajorRev' and count(parameter)=0]"
			[Register ("getPSOCMajorRev", "()I", "GetGetPSOCMajorRevHandler")]
			get {
				if (id_getPSOCMajorRev == IntPtr.Zero)
					id_getPSOCMajorRev = JNIEnv.GetMethodID (class_ref, "getPSOCMajorRev", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPSOCMajorRev);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPSOCMajorRev", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPSOCMinorRev;
#pragma warning disable 0169
		static Delegate GetGetPSOCMinorRevHandler ()
		{
			if (cb_getPSOCMinorRev == null)
				cb_getPSOCMinorRev = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPSOCMinorRev);
			return cb_getPSOCMinorRev;
		}

		static int n_GetPSOCMinorRev (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PSOCMinorRev;
		}
#pragma warning restore 0169

		static IntPtr id_getPSOCMinorRev;
		public virtual unsafe int PSOCMinorRev {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getPSOCMinorRev' and count(parameter)=0]"
			[Register ("getPSOCMinorRev", "()I", "GetGetPSOCMinorRevHandler")]
			get {
				if (id_getPSOCMinorRev == IntPtr.Zero)
					id_getPSOCMinorRev = JNIEnv.GetMethodID (class_ref, "getPSOCMinorRev", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPSOCMinorRev);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPSOCMinorRev", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getScanDriverRevision;
#pragma warning disable 0169
		static Delegate GetGetScanDriverRevisionHandler ()
		{
			if (cb_getScanDriverRevision == null)
				cb_getScanDriverRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScanDriverRevision);
			return cb_getScanDriverRevision;
		}

		static IntPtr n_GetScanDriverRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScanDriverRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getScanDriverRevision;
		public virtual unsafe string ScanDriverRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getScanDriverRevision' and count(parameter)=0]"
			[Register ("getScanDriverRevision", "()Ljava/lang/String;", "GetGetScanDriverRevisionHandler")]
			get {
				if (id_getScanDriverRevision == IntPtr.Zero)
					id_getScanDriverRevision = JNIEnv.GetMethodID (class_ref, "getScanDriverRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScanDriverRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScanDriverRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecondaryDecoderRevision;
#pragma warning disable 0169
		static Delegate GetGetSecondaryDecoderRevisionHandler ()
		{
			if (cb_getSecondaryDecoderRevision == null)
				cb_getSecondaryDecoderRevision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondaryDecoderRevision);
			return cb_getSecondaryDecoderRevision;
		}

		static IntPtr n_GetSecondaryDecoderRevision (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondaryDecoderRevision);
		}
#pragma warning restore 0169

		static IntPtr id_getSecondaryDecoderRevision;
		public virtual unsafe string SecondaryDecoderRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSecondaryDecoderRevision' and count(parameter)=0]"
			[Register ("getSecondaryDecoderRevision", "()Ljava/lang/String;", "GetGetSecondaryDecoderRevisionHandler")]
			get {
				if (id_getSecondaryDecoderRevision == IntPtr.Zero)
					id_getSecondaryDecoderRevision = JNIEnv.GetMethodID (class_ref, "getSecondaryDecoderRevision", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSecondaryDecoderRevision), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecondaryDecoderRevision", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShowDecodeWindow;
#pragma warning disable 0169
		static Delegate GetGetShowDecodeWindowHandler ()
		{
			if (cb_getShowDecodeWindow == null)
				cb_getShowDecodeWindow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShowDecodeWindow);
			return cb_getShowDecodeWindow;
		}

		static int n_GetShowDecodeWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowDecodeWindow;
		}
#pragma warning restore 0169

		static Delegate cb_setShowDecodeWindow_I;
#pragma warning disable 0169
		static Delegate GetSetShowDecodeWindow_IHandler ()
		{
			if (cb_setShowDecodeWindow_I == null)
				cb_setShowDecodeWindow_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShowDecodeWindow_I);
			return cb_setShowDecodeWindow_I;
		}

		static void n_SetShowDecodeWindow_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDecodeWindow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowDecodeWindow;
		static IntPtr id_setShowDecodeWindow_I;
		public virtual unsafe int ShowDecodeWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getShowDecodeWindow' and count(parameter)=0]"
			[Register ("getShowDecodeWindow", "()I", "GetGetShowDecodeWindowHandler")]
			get {
				if (id_getShowDecodeWindow == IntPtr.Zero)
					id_getShowDecodeWindow = JNIEnv.GetMethodID (class_ref, "getShowDecodeWindow", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getShowDecodeWindow);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowDecodeWindow", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setShowDecodeWindow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShowDecodeWindow", "(I)V", "GetSetShowDecodeWindow_IHandler")]
			set {
				if (id_setShowDecodeWindow_I == IntPtr.Zero)
					id_setShowDecodeWindow_I = JNIEnv.GetMethodID (class_ref, "setShowDecodeWindow", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setShowDecodeWindow_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowDecodeWindow", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_cancelDecode;
#pragma warning disable 0169
		static Delegate GetCancelDecodeHandler ()
		{
			if (cb_cancelDecode == null)
				cb_cancelDecode = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelDecode);
			return cb_cancelDecode;
		}

		static void n_CancelDecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDecode ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelDecode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='cancelDecode' and count(parameter)=0]"
		[Register ("cancelDecode", "()V", "GetCancelDecodeHandler")]
		public virtual unsafe void CancelDecode ()
		{
			if (id_cancelDecode == IntPtr.Zero)
				id_cancelDecode = JNIEnv.GetMethodID (class_ref, "cancelDecode", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelDecode);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDecode", "()V"));
			} finally {
			}
		}

		static Delegate cb_connectToDecoder;
#pragma warning disable 0169
		static Delegate GetConnectToDecoderHandler ()
		{
			if (cb_connectToDecoder == null)
				cb_connectToDecoder = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectToDecoder);
			return cb_connectToDecoder;
		}

		static void n_ConnectToDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectToDecoder ();
		}
#pragma warning restore 0169

		static IntPtr id_connectToDecoder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='connectToDecoder' and count(parameter)=0]"
		[Register ("connectToDecoder", "()V", "GetConnectToDecoderHandler")]
		public virtual unsafe void ConnectToDecoder ()
		{
			if (id_connectToDecoder == IntPtr.Zero)
				id_connectToDecoder = JNIEnv.GetMethodID (class_ref, "connectToDecoder", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connectToDecoder);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectToDecoder", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableSymbology_I;
#pragma warning disable 0169
		static Delegate GetDisableSymbology_IHandler ()
		{
			if (cb_disableSymbology_I == null)
				cb_disableSymbology_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DisableSymbology_I);
			return cb_disableSymbology_I;
		}

		static void n_DisableSymbology_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableSymbology (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disableSymbology_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='disableSymbology' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disableSymbology", "(I)V", "GetDisableSymbology_IHandler")]
		public virtual unsafe void DisableSymbology (int p0)
		{
			if (id_disableSymbology_I == IntPtr.Zero)
				id_disableSymbology_I = JNIEnv.GetMethodID (class_ref, "disableSymbology", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableSymbology_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableSymbology", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnectFromDecoder;
#pragma warning disable 0169
		static Delegate GetDisconnectFromDecoderHandler ()
		{
			if (cb_disconnectFromDecoder == null)
				cb_disconnectFromDecoder = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectFromDecoder);
			return cb_disconnectFromDecoder;
		}

		static void n_DisconnectFromDecoder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectFromDecoder ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectFromDecoder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='disconnectFromDecoder' and count(parameter)=0]"
		[Register ("disconnectFromDecoder", "()V", "GetDisconnectFromDecoderHandler")]
		public virtual unsafe void DisconnectFromDecoder ()
		{
			if (id_disconnectFromDecoder == IntPtr.Zero)
				id_disconnectFromDecoder = JNIEnv.GetMethodID (class_ref, "disconnectFromDecoder", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disconnectFromDecoder);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectFromDecoder", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSymbology_I;
#pragma warning disable 0169
		static Delegate GetEnableSymbology_IHandler ()
		{
			if (cb_enableSymbology_I == null)
				cb_enableSymbology_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnableSymbology_I);
			return cb_enableSymbology_I;
		}

		static void n_EnableSymbology_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSymbology (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableSymbology_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='enableSymbology' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("enableSymbology", "(I)V", "GetEnableSymbology_IHandler")]
		public virtual unsafe void EnableSymbology (int p0)
		{
			if (id_enableSymbology_I == IntPtr.Zero)
				id_enableSymbology_I = JNIEnv.GetMethodID (class_ref, "enableSymbology", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableSymbology_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSymbology", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBarcodeByteData;
#pragma warning disable 0169
		static Delegate GetGetBarcodeByteDataHandler ()
		{
			if (cb_getBarcodeByteData == null)
				cb_getBarcodeByteData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeByteData);
			return cb_getBarcodeByteData;
		}

		static IntPtr n_GetBarcodeByteData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBarcodeByteData ());
		}
#pragma warning restore 0169

		static IntPtr id_getBarcodeByteData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getBarcodeByteData' and count(parameter)=0]"
		[Register ("getBarcodeByteData", "()[B", "GetGetBarcodeByteDataHandler")]
		public virtual unsafe byte[] GetBarcodeByteData ()
		{
			if (id_getBarcodeByteData == IntPtr.Zero)
				id_getBarcodeByteData = JNIEnv.GetMethodID (class_ref, "getBarcodeByteData", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBarcodeByteData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarcodeByteData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
#pragma warning disable 0169
		static Delegate GetGetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_Handler ()
		{
			if (cb_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ == null)
				cb_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_);
			return cb_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
		}

		static void n_GetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDecodeWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecodeWindow' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.DecodeWindowing.DecodeWindow']]"
		[Register ("getDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V", "GetGetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_Handler")]
		public virtual unsafe void GetDecodeWindow (global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow p0)
		{
			if (id_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ == IntPtr.Zero)
				id_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ = JNIEnv.GetMethodID (class_ref, "getDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_;
#pragma warning disable 0169
		static Delegate GetGetDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_Handler ()
		{
			if (cb_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_ == null)
				cb_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_);
			return cb_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_;
		}

		static void n_GetDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindowLimits p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindowLimits> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDecodeWindowLimits (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getDecodeWindowLimits' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.DecodeWindowing.DecodeWindowLimits']]"
		[Register ("getDecodeWindowLimits", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindowLimits;)V", "GetGetDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_Handler")]
		public virtual unsafe void GetDecodeWindowLimits (global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindowLimits p0)
		{
			if (id_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_ == IntPtr.Zero)
				id_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_ = JNIEnv.GetMethodID (class_ref, "getDecodeWindowLimits", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindowLimits;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getDecodeWindowLimits_Lcom_hsm_barcode_DecodeWindowing_DecodeWindowLimits_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecodeWindowLimits", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindowLimits;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getErrorMessage_I;
#pragma warning disable 0169
		static Delegate GetGetErrorMessage_IHandler ()
		{
			if (cb_getErrorMessage_I == null)
				cb_getErrorMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetErrorMessage_I);
			return cb_getErrorMessage_I;
		}

		static IntPtr n_GetErrorMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetErrorMessage (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getErrorMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getErrorMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorMessage", "(I)Ljava/lang/String;", "GetGetErrorMessage_IHandler")]
		public virtual unsafe string GetErrorMessage (int p0)
		{
			if (id_getErrorMessage_I == IntPtr.Zero)
				id_getErrorMessage_I = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorMessage_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorMessage", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getExposureSettings_arrayI;
#pragma warning disable 0169
		static Delegate GetGetExposureSettings_arrayIHandler ()
		{
			if (cb_getExposureSettings_arrayI == null)
				cb_getExposureSettings_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetExposureSettings_arrayI);
			return cb_getExposureSettings_arrayI;
		}

		static void n_GetExposureSettings_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.GetExposureSettings (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_getExposureSettings_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getExposureSettings' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getExposureSettings", "([I)V", "GetGetExposureSettings_arrayIHandler")]
		public virtual unsafe void GetExposureSettings (int[] p0)
		{
			if (id_getExposureSettings_arrayI == IntPtr.Zero)
				id_getExposureSettings_arrayI = JNIEnv.GetMethodID (class_ref, "getExposureSettings", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getExposureSettings_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExposureSettings", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_ == null)
				cb_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_);
			return cb_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_;
		}

		static void n_GetIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.IQImagingProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.IQImagingProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetIQImage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getIQImage' and count(parameter)=2 and parameter[1][@type='com.hsm.barcode.IQImagingProperties'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("getIQImage", "(Lcom/hsm/barcode/IQImagingProperties;Landroid/graphics/Bitmap;)V", "GetGetIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void GetIQImage (global::Com.Hsm.Barcode.IQImagingProperties p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getIQImage", "(Lcom/hsm/barcode/IQImagingProperties;Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getIQImage_Lcom_hsm_barcode_IQImagingProperties_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIQImage", "(Lcom/hsm/barcode/IQImagingProperties;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_;
#pragma warning disable 0169
		static Delegate GetGetImagerProperties_Lcom_hsm_barcode_ImagerProperties_Handler ()
		{
			if (cb_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_ == null)
				cb_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetImagerProperties_Lcom_hsm_barcode_ImagerProperties_);
			return cb_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_;
		}

		static void n_GetImagerProperties_Lcom_hsm_barcode_ImagerProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.ImagerProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.ImagerProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetImagerProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getImagerProperties' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.ImagerProperties']]"
		[Register ("getImagerProperties", "(Lcom/hsm/barcode/ImagerProperties;)V", "GetGetImagerProperties_Lcom_hsm_barcode_ImagerProperties_Handler")]
		public virtual unsafe void GetImagerProperties (global::Com.Hsm.Barcode.ImagerProperties p0)
		{
			if (id_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_ == IntPtr.Zero)
				id_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_ = JNIEnv.GetMethodID (class_ref, "getImagerProperties", "(Lcom/hsm/barcode/ImagerProperties;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getImagerProperties_Lcom_hsm_barcode_ImagerProperties_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImagerProperties", "(Lcom/hsm/barcode/ImagerProperties;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getLastImage_Lcom_hsm_barcode_ImageAttributes_;
#pragma warning disable 0169
		static Delegate GetGetLastImage_Lcom_hsm_barcode_ImageAttributes_Handler ()
		{
			if (cb_getLastImage_Lcom_hsm_barcode_ImageAttributes_ == null)
				cb_getLastImage_Lcom_hsm_barcode_ImageAttributes_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLastImage_Lcom_hsm_barcode_ImageAttributes_);
			return cb_getLastImage_Lcom_hsm_barcode_ImageAttributes_;
		}

		static IntPtr n_GetLastImage_Lcom_hsm_barcode_ImageAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.ImageAttributes p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.ImageAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetLastImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLastImage_Lcom_hsm_barcode_ImageAttributes_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getLastImage' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.ImageAttributes']]"
		[Register ("getLastImage", "(Lcom/hsm/barcode/ImageAttributes;)[B", "GetGetLastImage_Lcom_hsm_barcode_ImageAttributes_Handler")]
		public virtual unsafe byte[] GetLastImage (global::Com.Hsm.Barcode.ImageAttributes p0)
		{
			if (id_getLastImage_Lcom_hsm_barcode_ImageAttributes_ == IntPtr.Zero)
				id_getLastImage_Lcom_hsm_barcode_ImageAttributes_ = JNIEnv.GetMethodID (class_ref, "getLastImage", "(Lcom/hsm/barcode/ImageAttributes;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getLastImage_Lcom_hsm_barcode_ImageAttributes_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastImage", "(Lcom/hsm/barcode/ImageAttributes;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getOCRUserTemplate;
#pragma warning disable 0169
		static Delegate GetGetOCRUserTemplateHandler ()
		{
			if (cb_getOCRUserTemplate == null)
				cb_getOCRUserTemplate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOCRUserTemplate);
			return cb_getOCRUserTemplate;
		}

		static IntPtr n_GetOCRUserTemplate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOCRUserTemplate ());
		}
#pragma warning restore 0169

		static IntPtr id_getOCRUserTemplate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getOCRUserTemplate' and count(parameter)=0]"
		[Register ("getOCRUserTemplate", "()[B", "GetGetOCRUserTemplateHandler")]
		public virtual unsafe byte[] GetOCRUserTemplate ()
		{
			if (id_getOCRUserTemplate == IntPtr.Zero)
				id_getOCRUserTemplate = JNIEnv.GetMethodID (class_ref, "getOCRUserTemplate", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getOCRUserTemplate), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOCRUserTemplate", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPreviewFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetPreviewFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getPreviewFrame_Landroid_graphics_Bitmap_ == null)
				cb_getPreviewFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetPreviewFrame_Landroid_graphics_Bitmap_);
			return cb_getPreviewFrame_Landroid_graphics_Bitmap_;
		}

		static void n_GetPreviewFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetPreviewFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPreviewFrame_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getPreviewFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getPreviewFrame", "(Landroid/graphics/Bitmap;)V", "GetGetPreviewFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void GetPreviewFrame (global::Android.Graphics.Bitmap p0)
		{
			if (id_getPreviewFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getPreviewFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getPreviewFrame", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getPreviewFrame_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviewFrame", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSingleFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetSingleFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getSingleFrame_Landroid_graphics_Bitmap_ == null)
				cb_getSingleFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSingleFrame_Landroid_graphics_Bitmap_);
			return cb_getSingleFrame_Landroid_graphics_Bitmap_;
		}

		static void n_GetSingleFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSingleFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSingleFrame_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSingleFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getSingleFrame", "(Landroid/graphics/Bitmap;)V", "GetGetSingleFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void GetSingleFrame (global::Android.Graphics.Bitmap p0)
		{
			if (id_getSingleFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getSingleFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getSingleFrame", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getSingleFrame_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSingleFrame", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
#pragma warning disable 0169
		static Delegate GetGetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_Handler ()
		{
			if (cb_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ == null)
				cb_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_);
			return cb_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
		}

		static void n_GetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.SymbologyConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.SymbologyConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSymbologyConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSymbologyConfig' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.SymbologyConfig']]"
		[Register ("getSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V", "GetGetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_Handler")]
		public virtual unsafe void GetSymbologyConfig (global::Com.Hsm.Barcode.SymbologyConfig p0)
		{
			if (id_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ == IntPtr.Zero)
				id_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ = JNIEnv.GetMethodID (class_ref, "getSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_;
#pragma warning disable 0169
		static Delegate GetGetSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_Handler ()
		{
			if (cb_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_ == null)
				cb_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_);
			return cb_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_;
		}

		static void n_GetSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.SymbologyConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.SymbologyConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSymbologyConfigDefaults (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSymbologyConfigDefaults' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.SymbologyConfig']]"
		[Register ("getSymbologyConfigDefaults", "(Lcom/hsm/barcode/SymbologyConfig;)V", "GetGetSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_Handler")]
		public virtual unsafe void GetSymbologyConfigDefaults (global::Com.Hsm.Barcode.SymbologyConfig p0)
		{
			if (id_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_ == IntPtr.Zero)
				id_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_ = JNIEnv.GetMethodID (class_ref, "getSymbologyConfigDefaults", "(Lcom/hsm/barcode/SymbologyConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_getSymbologyConfigDefaults_Lcom_hsm_barcode_SymbologyConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSymbologyConfigDefaults", "(Lcom/hsm/barcode/SymbologyConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSymbologyMaxRange_I;
#pragma warning disable 0169
		static Delegate GetGetSymbologyMaxRange_IHandler ()
		{
			if (cb_getSymbologyMaxRange_I == null)
				cb_getSymbologyMaxRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSymbologyMaxRange_I);
			return cb_getSymbologyMaxRange_I;
		}

		static int n_GetSymbologyMaxRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSymbologyMaxRange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSymbologyMaxRange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSymbologyMaxRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSymbologyMaxRange", "(I)I", "GetGetSymbologyMaxRange_IHandler")]
		public virtual unsafe int GetSymbologyMaxRange (int p0)
		{
			if (id_getSymbologyMaxRange_I == IntPtr.Zero)
				id_getSymbologyMaxRange_I = JNIEnv.GetMethodID (class_ref, "getSymbologyMaxRange", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSymbologyMaxRange_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSymbologyMaxRange", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getSymbologyMinRange_I;
#pragma warning disable 0169
		static Delegate GetGetSymbologyMinRange_IHandler ()
		{
			if (cb_getSymbologyMinRange_I == null)
				cb_getSymbologyMinRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSymbologyMinRange_I);
			return cb_getSymbologyMinRange_I;
		}

		static int n_GetSymbologyMinRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSymbologyMinRange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSymbologyMinRange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='getSymbologyMinRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSymbologyMinRange", "(I)I", "GetGetSymbologyMinRange_IHandler")]
		public virtual unsafe int GetSymbologyMinRange (int p0)
		{
			if (id_getSymbologyMinRange_I == IntPtr.Zero)
				id_getSymbologyMinRange_I = JNIEnv.GetMethodID (class_ref, "getSymbologyMinRange", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSymbologyMinRange_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSymbologyMinRange", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setDecodeAttemptLimit_I;
#pragma warning disable 0169
		static Delegate GetSetDecodeAttemptLimit_IHandler ()
		{
			if (cb_setDecodeAttemptLimit_I == null)
				cb_setDecodeAttemptLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDecodeAttemptLimit_I);
			return cb_setDecodeAttemptLimit_I;
		}

		static void n_SetDecodeAttemptLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDecodeAttemptLimit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDecodeAttemptLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setDecodeAttemptLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDecodeAttemptLimit", "(I)V", "GetSetDecodeAttemptLimit_IHandler")]
		public virtual unsafe void SetDecodeAttemptLimit (int p0)
		{
			if (id_setDecodeAttemptLimit_I == IntPtr.Zero)
				id_setDecodeAttemptLimit_I = JNIEnv.GetMethodID (class_ref, "setDecodeAttemptLimit", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDecodeAttemptLimit_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecodeAttemptLimit", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
#pragma warning disable 0169
		static Delegate GetSetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_Handler ()
		{
			if (cb_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ == null)
				cb_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_);
			return cb_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
		}

		static void n_SetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDecodeWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setDecodeWindow' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.DecodeWindowing.DecodeWindow']]"
		[Register ("setDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V", "GetSetDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_Handler")]
		public virtual unsafe void SetDecodeWindow (global::Com.Hsm.Barcode.DecodeWindowing.DecodeWindow p0)
		{
			if (id_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ == IntPtr.Zero)
				id_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_ = JNIEnv.GetMethodID (class_ref, "setDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDecodeWindow_Lcom_hsm_barcode_DecodeWindowing_DecodeWindow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecodeWindow", "(Lcom/hsm/barcode/DecodeWindowing$DecodeWindow;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExposureMode_I;
#pragma warning disable 0169
		static Delegate GetSetExposureMode_IHandler ()
		{
			if (cb_setExposureMode_I == null)
				cb_setExposureMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetExposureMode_I);
			return cb_setExposureMode_I;
		}

		static void n_SetExposureMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExposureMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExposureMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setExposureMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setExposureMode", "(I)V", "GetSetExposureMode_IHandler")]
		public virtual unsafe void SetExposureMode (int p0)
		{
			if (id_setExposureMode_I == IntPtr.Zero)
				id_setExposureMode_I = JNIEnv.GetMethodID (class_ref, "setExposureMode", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExposureMode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureMode", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setExposureSettings_arrayI;
#pragma warning disable 0169
		static Delegate GetSetExposureSettings_arrayIHandler ()
		{
			if (cb_setExposureSettings_arrayI == null)
				cb_setExposureSettings_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExposureSettings_arrayI);
			return cb_setExposureSettings_arrayI;
		}

		static void n_SetExposureSettings_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetExposureSettings (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExposureSettings_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setExposureSettings' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setExposureSettings", "([I)V", "GetSetExposureSettings_arrayIHandler")]
		public virtual unsafe void SetExposureSettings (int[] p0)
		{
			if (id_setExposureSettings_arrayI == IntPtr.Zero)
				id_setExposureSettings_arrayI = JNIEnv.GetMethodID (class_ref, "setExposureSettings", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExposureSettings_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureSettings", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setLightsMode_I;
#pragma warning disable 0169
		static Delegate GetSetLightsMode_IHandler ()
		{
			if (cb_setLightsMode_I == null)
				cb_setLightsMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLightsMode_I);
			return cb_setLightsMode_I;
		}

		static void n_SetLightsMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLightsMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLightsMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setLightsMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLightsMode", "(I)V", "GetSetLightsMode_IHandler")]
		public virtual unsafe void SetLightsMode (int p0)
		{
			if (id_setLightsMode_I == IntPtr.Zero)
				id_setLightsMode_I = JNIEnv.GetMethodID (class_ref, "setLightsMode", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLightsMode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLightsMode", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOCRUserTemplate_arrayB;
#pragma warning disable 0169
		static Delegate GetSetOCRUserTemplate_arrayBHandler ()
		{
			if (cb_setOCRUserTemplate_arrayB == null)
				cb_setOCRUserTemplate_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOCRUserTemplate_arrayB);
			return cb_setOCRUserTemplate_arrayB;
		}

		static void n_SetOCRUserTemplate_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetOCRUserTemplate (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOCRUserTemplate_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setOCRUserTemplate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setOCRUserTemplate", "([B)V", "GetSetOCRUserTemplate_arrayBHandler")]
		public virtual unsafe void SetOCRUserTemplate (byte[] p0)
		{
			if (id_setOCRUserTemplate_arrayB == IntPtr.Zero)
				id_setOCRUserTemplate_arrayB = JNIEnv.GetMethodID (class_ref, "setOCRUserTemplate", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOCRUserTemplate_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOCRUserTemplate", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
#pragma warning disable 0169
		static Delegate GetSetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_Handler ()
		{
			if (cb_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ == null)
				cb_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_);
			return cb_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
		}

		static void n_SetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.SymbologyConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.SymbologyConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSymbologyConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setSymbologyConfig' and count(parameter)=1 and parameter[1][@type='com.hsm.barcode.SymbologyConfig']]"
		[Register ("setSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V", "GetSetSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_Handler")]
		public virtual unsafe void SetSymbologyConfig (global::Com.Hsm.Barcode.SymbologyConfig p0)
		{
			if (id_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ == IntPtr.Zero)
				id_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_ = JNIEnv.GetMethodID (class_ref, "setSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSymbologyConfig_Lcom_hsm_barcode_SymbologyConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSymbologyConfig", "(Lcom/hsm/barcode/SymbologyConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSymbologyDefaults_I;
#pragma warning disable 0169
		static Delegate GetSetSymbologyDefaults_IHandler ()
		{
			if (cb_setSymbologyDefaults_I == null)
				cb_setSymbologyDefaults_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSymbologyDefaults_I);
			return cb_setSymbologyDefaults_I;
		}

		static void n_SetSymbologyDefaults_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSymbologyDefaults (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSymbologyDefaults_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='setSymbologyDefaults' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSymbologyDefaults", "(I)V", "GetSetSymbologyDefaults_IHandler")]
		public virtual unsafe void SetSymbologyDefaults (int p0)
		{
			if (id_setSymbologyDefaults_I == IntPtr.Zero)
				id_setSymbologyDefaults_I = JNIEnv.GetMethodID (class_ref, "setSymbologyDefaults", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSymbologyDefaults_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSymbologyDefaults", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startScanning;
#pragma warning disable 0169
		static Delegate GetStartScanningHandler ()
		{
			if (cb_startScanning == null)
				cb_startScanning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartScanning);
			return cb_startScanning;
		}

		static void n_StartScanning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartScanning ();
		}
#pragma warning restore 0169

		static IntPtr id_startScanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='startScanning' and count(parameter)=0]"
		[Register ("startScanning", "()V", "GetStartScanningHandler")]
		public virtual unsafe void StartScanning ()
		{
			if (id_startScanning == IntPtr.Zero)
				id_startScanning = JNIEnv.GetMethodID (class_ref, "startScanning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startScanning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startScanning", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopScanning;
#pragma warning disable 0169
		static Delegate GetStopScanningHandler ()
		{
			if (cb_stopScanning == null)
				cb_stopScanning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopScanning);
			return cb_stopScanning;
		}

		static void n_StopScanning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScanning ();
		}
#pragma warning restore 0169

		static IntPtr id_stopScanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='stopScanning' and count(parameter)=0]"
		[Register ("stopScanning", "()V", "GetStopScanningHandler")]
		public virtual unsafe void StopScanning ()
		{
			if (id_stopScanning == IntPtr.Zero)
				id_stopScanning = JNIEnv.GetMethodID (class_ref, "stopScanning", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopScanning);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopScanning", "()V"));
			} finally {
			}
		}

		static Delegate cb_waitForDecode_I;
#pragma warning disable 0169
		static Delegate GetWaitForDecode_IHandler ()
		{
			if (cb_waitForDecode_I == null)
				cb_waitForDecode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WaitForDecode_I);
			return cb_waitForDecode_I;
		}

		static void n_WaitForDecode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaitForDecode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_waitForDecode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='waitForDecode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("waitForDecode", "(I)V", "GetWaitForDecode_IHandler")]
		public virtual unsafe void WaitForDecode (int p0)
		{
			if (id_waitForDecode_I == IntPtr.Zero)
				id_waitForDecode_I = JNIEnv.GetMethodID (class_ref, "waitForDecode", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitForDecode_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForDecode", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_;
#pragma warning disable 0169
		static Delegate GetWaitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_Handler ()
		{
			if (cb_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_ == null)
				cb_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_WaitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_);
			return cb_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_;
		}

		static void n_WaitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Hsm.Barcode.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hsm.Barcode.DecodeResult p1 = global::Java.Lang.Object.GetObject<global::Com.Hsm.Barcode.DecodeResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WaitForDecodeTwo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hsm.barcode']/class[@name='Decoder']/method[@name='waitForDecodeTwo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.hsm.barcode.DecodeResult']]"
		[Register ("waitForDecodeTwo", "(ILcom/hsm/barcode/DecodeResult;)V", "GetWaitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_Handler")]
		public virtual unsafe void WaitForDecodeTwo (int p0, global::Com.Hsm.Barcode.DecodeResult p1)
		{
			if (id_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_ == IntPtr.Zero)
				id_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_ = JNIEnv.GetMethodID (class_ref, "waitForDecodeTwo", "(ILcom/hsm/barcode/DecodeResult;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_waitForDecodeTwo_ILcom_hsm_barcode_DecodeResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForDecodeTwo", "(ILcom/hsm/barcode/DecodeResult;)V"), __args);
			} finally {
			}
		}

	}
}
