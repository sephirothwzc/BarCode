using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hsm.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']"
	[global::Android.Runtime.Register ("com/hsm/barcode/SymbologyConfig", DoNotGenerateAcw=true)]
	public partial class SymbologyConfig : global::Java.Lang.Object {


		static IntPtr Flags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/field[@name='Flags']"
		[Register ("Flags")]
		public int Flags {
			get {
				if (Flags_jfieldId == IntPtr.Zero)
					Flags_jfieldId = JNIEnv.GetFieldID (class_ref, "Flags", "I");
				return JNIEnv.GetIntField (Handle, Flags_jfieldId);
			}
			set {
				if (Flags_jfieldId == IntPtr.Zero)
					Flags_jfieldId = JNIEnv.GetFieldID (class_ref, "Flags", "I");
				try {
					JNIEnv.SetField (Handle, Flags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Mask_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/field[@name='Mask']"
		[Register ("Mask")]
		public int Mask {
			get {
				if (Mask_jfieldId == IntPtr.Zero)
					Mask_jfieldId = JNIEnv.GetFieldID (class_ref, "Mask", "I");
				return JNIEnv.GetIntField (Handle, Mask_jfieldId);
			}
			set {
				if (Mask_jfieldId == IntPtr.Zero)
					Mask_jfieldId = JNIEnv.GetFieldID (class_ref, "Mask", "I");
				try {
					JNIEnv.SetField (Handle, Mask_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MaxLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/field[@name='MaxLength']"
		[Register ("MaxLength")]
		public int MaxLength {
			get {
				if (MaxLength_jfieldId == IntPtr.Zero)
					MaxLength_jfieldId = JNIEnv.GetFieldID (class_ref, "MaxLength", "I");
				return JNIEnv.GetIntField (Handle, MaxLength_jfieldId);
			}
			set {
				if (MaxLength_jfieldId == IntPtr.Zero)
					MaxLength_jfieldId = JNIEnv.GetFieldID (class_ref, "MaxLength", "I");
				try {
					JNIEnv.SetField (Handle, MaxLength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MinLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/field[@name='MinLength']"
		[Register ("MinLength")]
		public int MinLength {
			get {
				if (MinLength_jfieldId == IntPtr.Zero)
					MinLength_jfieldId = JNIEnv.GetFieldID (class_ref, "MinLength", "I");
				return JNIEnv.GetIntField (Handle, MinLength_jfieldId);
			}
			set {
				if (MinLength_jfieldId == IntPtr.Zero)
					MinLength_jfieldId = JNIEnv.GetFieldID (class_ref, "MinLength", "I");
				try {
					JNIEnv.SetField (Handle, MinLength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr symID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/field[@name='symID']"
		[Register ("symID")]
		public int SymID {
			get {
				if (symID_jfieldId == IntPtr.Zero)
					symID_jfieldId = JNIEnv.GetFieldID (class_ref, "symID", "I");
				return JNIEnv.GetIntField (Handle, symID_jfieldId);
			}
			set {
				if (symID_jfieldId == IntPtr.Zero)
					symID_jfieldId = JNIEnv.GetFieldID (class_ref, "symID", "I");
				try {
					JNIEnv.SetField (Handle, symID_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hsm/barcode/SymbologyConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SymbologyConfig); }
		}

		protected SymbologyConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hsm.barcode']/class[@name='SymbologyConfig']/constructor[@name='SymbologyConfig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SymbologyConfig (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SymbologyConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

	}
}
