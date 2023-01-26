using System;
using System.Threading;

using Intent = android.content.Intent;
using SharedPreferences = android.content.SharedPreferences;
using Log = android.util.Log;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using LaunchResponse = ru.yandex.taxi.client.response.LaunchResponse;

public class pg : ThreadStart
{
  public pg(TaxiClient paramTaxiClient, string paramString, Intent paramIntent, SharedPreferences paramSharedPreferences)
  {
  }

  public virtual void run()
  {
	try
	{
	  LaunchResponse launchResponse = this.a.doLaunch(this.b, this.c.getExtras().getString("device token"));
	  if (launchResponse != null && launchResponse.Code == 200)
	  {
		this.d.edit().putInt("device token size", this.b.length()).commit();
	  }
	}
	catch (Exception exception)
	{
	  Log.e("C2DMService", "Get client in service error", exception);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */