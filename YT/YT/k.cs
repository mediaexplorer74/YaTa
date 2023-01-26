using System.Threading;

using Context = android.content.Context;
using TelephonyNetworkInfoRequest = ru.yandex.core.TelephonyNetworkInfoRequest;

public class k : ThreadStart
{
  public k(TelephonyNetworkInfoRequest paramTelephonyNetworkInfoRequest, Context paramContext)
  {
  }

  public virtual void run()
  {
	if (!TelephonyNetworkInfoRequest.access$000(this.b))
	{
	  j j = j.a(this.a);
	  TelephonyNetworkInfoRequest.access$200(TelephonyNetworkInfoRequest.access$100(this.b), j.a_Conflict, j.b, j.c, j.d, j.e);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\k.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */