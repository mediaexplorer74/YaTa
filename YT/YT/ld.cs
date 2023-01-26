using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using PreferenceManager = android.preference.PreferenceManager;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using RateActivity = ru.yandex.taxi.activity.RateActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;

internal class ld : AsyncTask<string, int, bool>
{
  private ProgressDialog b;

  private bool c;

  internal ld(lc paramlc)
  {
  }

  protected internal virtual bool? a()
  {
	bool @bool;
	try
	{
	  PreferenceManager.getDefaultSharedPreferences(this.a.c.getApplicationContext()).getString("client id", "");
	  TaxiClient taxiClient = new TaxiClient();
	  Context context = this.a.c.getApplicationContext();
	  HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
	  this();
	  this(context, (HttpUtils)httpUrlConnectionUtils);
	  @bool = taxiClient.doFeedback(RateActivity.c(this.a.c), this.a.a.getText().ToString(), RateActivity.d(this.a.c), ((int)this.a.b.getRating()).ToString());
	}
	catch (Exception exception)
	{
	  Log.e("RateActivity", "Fail send feedback", exception);
	  @bool = false;
	}
	return Convert.ToBoolean(@bool);
  }

  protected internal virtual void a(bool? paramBoolean)
  {
	if (!this.c)
	{
	  if (paramBoolean.Value)
	  {
		Toast.makeText((Context)this.a.c, 2131296482, 0).show();
	  }
	  else
	  {
		Toast.makeText((Context)this.a.c, 2131296483, 0).show();
	  }
	  this.a.c.finish();
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a.c, "", this.a.c.getResources().getString(2131296484), true, true);
	this.b.setOnCancelListener(new le(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ld.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */