using System.Threading;

using WifiScanRequest = ru.yandex.core.WifiScanRequest;

public class m : ThreadStart
{
  public m(WifiScanRequest paramWifiScanRequest)
  {
  }

  public virtual void run()
  {
	if (!WifiScanRequest.access$000(this.a))
	{
	  WifiScanRequest.access$200(WifiScanRequest.access$100(this.a), new string[0], new string[0], new int[0]);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\m.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */