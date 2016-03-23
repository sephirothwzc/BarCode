package md5c2d38d6cb478755bcec41fc703799194;


public class DroidDisplayService
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.DroidDisplayService, DevExpress.Mobile.Grid.Android.v15.2, Version=15.2.4.1, Culture=neutral, PublicKeyToken=null", DroidDisplayService.class, __md_methods);
	}


	public DroidDisplayService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DroidDisplayService.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidDisplayService, DevExpress.Mobile.Grid.Android.v15.2, Version=15.2.4.1, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
