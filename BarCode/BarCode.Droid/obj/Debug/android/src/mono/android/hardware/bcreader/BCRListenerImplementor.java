package mono.android.hardware.bcreader;


public class BCRListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.hardware.bcreader.BCRListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onOpened:(Z)V:GetOnOpened_ZHandler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCRManager_xamarin\n" +
			"n_onScanFinished:(ILjava/lang/String;)V:GetOnScanFinished_ILjava_lang_String_Handler:Android.Hardware.Bcreader.IBCRListenerInvoker, BCRManager_xamarin\n" +
			"";
		mono.android.Runtime.register ("Android.Hardware.Bcreader.IBCRListenerImplementor, BCRManager_xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BCRListenerImplementor.class, __md_methods);
	}


	public BCRListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BCRListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Hardware.Bcreader.IBCRListenerImplementor, BCRManager_xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


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

	java.util.ArrayList refList;
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
