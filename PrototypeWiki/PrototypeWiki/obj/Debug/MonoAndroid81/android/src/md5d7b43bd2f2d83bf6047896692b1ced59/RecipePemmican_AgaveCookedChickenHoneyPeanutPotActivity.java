package md5d7b43bd2f2d83bf6047896692b1ced59;


public class RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity
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
		mono.android.Runtime.register ("PrototypeWiki.RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity, PrototypeWiki", RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity.class, __md_methods);
	}


	public RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity ()
	{
		super ();
		if (getClass () == RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity.class)
			mono.android.TypeManager.Activate ("PrototypeWiki.RecipePemmican_AgaveCookedChickenHoneyPeanutPotActivity, PrototypeWiki", "", this, new java.lang.Object[] {  });
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
