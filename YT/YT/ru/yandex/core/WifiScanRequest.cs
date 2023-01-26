using System.Runtime.InteropServices;
using System.Threading;

namespace ru.yandex.core
{
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using IntentFilter = android.content.IntentFilter;
	using WifiManager = android.net.wifi.WifiManager;
	using Handler = android.os.Handler;
	using m;
	using n;

	public sealed class WifiScanRequest : BroadcastReceiver
	{
	  private bool cancelled = false;

	  private Context ctx;

	  private Handler h;

	  private long nativeHandle;

	  public WifiScanRequest(long paramLong)
	  {
		this.nativeHandle = paramLong;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signal(long paramLong, string[] paramArrayOfString1, string[] paramArrayOfString2, int[] paramArrayOfint);

	  internal void cancel()
	  {
		this.cancelled = true;
	  }

	  public void onReceive(Context paramContext, Intent paramIntent)
	  {
		this.ctx.unregisterReceiver(this);
		System.Collections.IList list = ((WifiManager)paramContext.getSystemService("wifi")).getScanResults();
		this.h.post((ThreadStart)new n(this, list));
	  }

	  internal void start()
	  {
		this.ctx = CoreApplication.applicationContext;
		this.h = new Handler();
		WifiManager wifiManager = (WifiManager)this.ctx.getSystemService("wifi");
		this.ctx.registerReceiver(this, new IntentFilter("android.net.wifi.SCAN_RESULTS"));
		if (!wifiManager.startScan())
		{
		  this.h.post((ThreadStart)new m(this));
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\WifiScanRequest.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}