package md5d7b43bd2f2d83bf6047896692b1ced59;


public class Item_HoneyActivity
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
		mono.android.Runtime.register ("PrototypeWiki.Item_HoneyActivity, PrototypeWiki", Item_HoneyActivity.class, __md_methods);
	}


	public Item_HoneyActivity ()
	{
		super ();
		if (getClass () == Item_HoneyActivity.class)
			mono.android.TypeManager.Activate ("PrototypeWiki.Item_HoneyActivity, PrototypeWiki", "", this, new java.lang.Object[] {  });
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
