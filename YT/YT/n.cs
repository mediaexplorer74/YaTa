using System.Collections.Generic;
using System.Threading;

using ScanResult = android.net.wifi.ScanResult;
using WifiScanRequest = ru.yandex.core.WifiScanRequest;

public class n : ThreadStart
{
  public n(WifiScanRequest paramWifiScanRequest, System.Collections.IList paramList)
  {
  }

  public virtual void run()
  {
	if (!WifiScanRequest.access$000(this.b))
	{
	  string[] arrayOfString1 = new string[this.a.size()];
	  string[] arrayOfString2 = new string[this.a.size()];
	  int[] arrayOfInt = new int[this.a.size()];
	  IEnumerator<ScanResult> iterator = this.a.GetEnumerator();
	  for (sbyte b = 0; iterator.MoveNext(); b++)
	  {
		ScanResult scanResult = iterator.Current;
		arrayOfString1[b] = scanResult.BSSID;
		arrayOfString2[b] = scanResult.SSID;
		arrayOfInt[b] = scanResult.level;
	  }
	  WifiScanRequest.access$200(WifiScanRequest.access$100(this.b), arrayOfString1, arrayOfString2, arrayOfInt);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\n.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */