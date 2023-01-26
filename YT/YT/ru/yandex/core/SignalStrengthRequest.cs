using System.Runtime.InteropServices;
using System.Threading;

namespace ru.yandex.core
{
	using Handler = android.os.Handler;
	using i;

	public sealed class SignalStrengthRequest
	{
	  private bool cancelled = false;

	  private long nativeHandle;

	  public SignalStrengthRequest(long paramLong)
	  {
		this.nativeHandle = paramLong;
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signal(long paramLong, bool paramBoolean, int paramInt);

	  internal void cancel()
	  {
		this.cancelled = true;
	  }

	  internal void start()
	  {
		(new Handler()).post((ThreadStart)new i(this, CoreApplication.applicationContext));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\SignalStrengthRequest.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}