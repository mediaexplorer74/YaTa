namespace com.google.android.c2dm
{
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;

	public class C2DMBroadcastReceiver : BroadcastReceiver
	{
	  public void onReceive(Context paramContext, Intent paramIntent)
	  {
		C2DMBaseReceiver.a(paramContext, paramIntent);
		setResult(-1, null, null);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\android\c2dm\C2DMBroadcastReceiver.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}