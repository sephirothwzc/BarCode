package md5ce052bb043cc9648ddd3ca4cf4bbfd4e;


public class MainActivity
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.FormsApplicationActivity
	implements
		mono.android.IGCUserPeer,
		android.hardware.bcreader.BCRListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onOpened:(Z)V:GetOnOpened_ZHandler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCRManager_xamarin\n" +
			"n_onScanFinished:(ILjava/lang/String;)V:GetOnScanFinished_ILjava_lang_String_Handler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCRManager_xamarin\n" +
			"";
		mono.android.Runtime.register ("BarCode.Droid.MainActivity, BarCode.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("BarCode.Droid.MainActivity, BarCode.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onOpened (boolean p0)
	{
		n_onOpened (p0);
	}

	private native void n_onOpened (boolean p0);


	public void onScanFinished (int p0, java.lang.String p1)
	{
		n_onScanFinished (p0, p1);
	}

	private native void n_onScanFinished (int p0, java.lang.String p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
