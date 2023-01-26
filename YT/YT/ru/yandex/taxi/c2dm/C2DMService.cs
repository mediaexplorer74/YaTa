using System.Threading;

namespace ru.yandex.taxi.c2dm
{
	using Service = android.app.Service;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using IBinder = android.os.IBinder;
	using PreferenceManager = android.preference.PreferenceManager;
	using pg;
	using Analytics = ru.yandex.taxi.analytics.Analytics;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class C2DMService : Service
	{
	  public const string CMD_SEND_DEVICE_TOKEN = "send device token";

	  public const string DEVICE_TOKEN = "device token";

	  public const string PREF_DEVICE_TOKEN_LENGTH = "device token size";

	  private void a(Intent paramIntent)
	  {
		if (paramIntent != null)
		{
		  string str1 = paramIntent.getAction();
		  TaxiClient taxiClient = new TaxiClient(getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
		  SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences((Context)this);
		  string str2 = sharedPreferences.getString("client id", null);
		  if ("send device token".Equals(str1) && !string.ReferenceEquals(str2, null) && !"".Equals(str2))
		  {
			(new Thread((ThreadStart)new pg(taxiClient, str2, paramIntent, sharedPreferences))).Start();
		  }
		}
	  }

	  public virtual IBinder onBind(Intent paramIntent)
	  {
		return null;
	  }

	  public virtual void onCreate()
	  {
		base.onCreate();
		Analytics.initExceptionHandler(getApplicationContext(), "C2DMService");
	  }

	  public virtual void onStart(Intent paramIntent, int paramInt)
	  {
		a(paramIntent);
	  }

	  public virtual int onStartCommand(Intent paramIntent, int paramInt1, int paramInt2)
	  {
		a(paramIntent);
		return 1;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\c2dm\C2DMService.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}