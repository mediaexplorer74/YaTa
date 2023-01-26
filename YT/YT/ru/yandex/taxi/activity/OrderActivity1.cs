using System;

namespace ru.yandex.taxi.activity
{
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using ConnectivityManager = android.net.ConnectivityManager;
	using NetworkInfo = android.net.NetworkInfo;
	using jq;
	using jy;

	public class OrderActivity$1 : BroadcastReceiver
	{
	  internal OrderActivity$1(OrderActivity paramOrderActivity)
	  {
	  }

	  public virtual void onReceive(Context paramContext, Intent paramIntent)
	  {
		NetworkInfo networkInfo = ((ConnectivityManager)this.a.getApplicationContext().getSystemService("connectivity")).getActiveNetworkInfo();
		if (networkInfo != null && networkInfo.isConnected() && networkInfo.isAvailable())
		{
		  (new jq(this.a)).execute((object[])new int?[0]);
		  (new jy(this.a)).execute((object[])new int?[] {Convert.ToInt32(0)});
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\OrderActivity$1.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}