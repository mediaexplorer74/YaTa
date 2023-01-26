using System.Runtime.InteropServices;
using System.Threading;

namespace ru.yandex.core
{
	using Handler = android.os.Handler;
	using k;

	public sealed class TelephonyNetworkInfoRequest
	{
	  private bool cancelled = false;

	  private long nativeHandle;

	  public TelephonyNetworkInfoRequest(long paramLong)
	  {
		this.nativeHandle = paramLong;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signal(long paramLong, bool paramBoolean, int paramInt1, int paramInt2, string paramString1, string paramString2);

	  public void cancel()
	  {
		this.cancelled = true;
	  }

	  public void start()
	  {
		(new Handler()).post((ThreadStart)new k(this, CoreApplication.applicationContext));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\TelephonyNetworkInfoRequest.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}