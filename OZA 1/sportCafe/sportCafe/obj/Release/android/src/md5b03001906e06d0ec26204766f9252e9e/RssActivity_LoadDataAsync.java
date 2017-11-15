package md5b03001906e06d0ec26204766f9252e9e;


public class RssActivity_LoadDataAsync
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("sportCafe.RssActivity+LoadDataAsync, sportCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RssActivity_LoadDataAsync.class, __md_methods);
	}


	public RssActivity_LoadDataAsync () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RssActivity_LoadDataAsync.class)
			mono.android.TypeManager.Activate ("sportCafe.RssActivity+LoadDataAsync, sportCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public RssActivity_LoadDataAsync (md5b03001906e06d0ec26204766f9252e9e.RssActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == RssActivity_LoadDataAsync.class)
			mono.android.TypeManager.Activate ("sportCafe.RssActivity+LoadDataAsync, sportCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "sportCafe.RssActivity, sportCafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);

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
