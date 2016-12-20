package md57c0e4b039253ffa28c8ffc49673ac55d;


public class Drawer_Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("A01.Drawer_Activity, A01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Drawer_Activity.class, __md_methods);
	}


	public Drawer_Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Drawer_Activity.class)
			mono.android.TypeManager.Activate ("A01.Drawer_Activity, A01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
