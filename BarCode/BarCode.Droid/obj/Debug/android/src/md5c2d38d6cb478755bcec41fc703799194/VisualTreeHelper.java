package md5c2d38d6cb478755bcec41fc703799194;


public class VisualTreeHelper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.ViewGroup.OnHierarchyChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onChildViewAdded:(Landroid/view/View;Landroid/view/View;)V:GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler:Android.Views.ViewGroup/IOnHierarchyChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onChildViewRemoved:(Landroid/view/View;Landroid/view/View;)V:GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler:Android.Views.ViewGroup/IOnHierarchyChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.VisualTreeHelper, DevExpress.Mobile.Grid.Android.v15.2, Version=15.2.4.1, Culture=neutral, PublicKeyToken=null", VisualTreeHelper.class, __md_methods);
	}


	public VisualTreeHelper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == VisualTreeHelper.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.VisualTreeHelper, DevExpress.Mobile.Grid.Android.v15.2, Version=15.2.4.1, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onChildViewAdded (android.view.View p0, android.view.View p1)
	{
		n_onChildViewAdded (p0, p1);
	}

	private native void n_onChildViewAdded (android.view.View p0, android.view.View p1);


	public void onChildViewRemoved (android.view.View p0, android.view.View p1)
	{
		n_onChildViewRemoved (p0, p1);
	}

	private native void n_onChildViewRemoved (android.view.View p0, android.view.View p1);

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
