using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using TextView = android.widget.TextView;
using RateActivity = ru.yandex.taxi.activity.RateActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;

public class lf : AsyncTask<string, int, string>
{
  private ProgressDialog b;

  private bool c = true;

  private lf(RateActivity paramRateActivity, sbyte paramByte)
  {
  }

  protected internal virtual string a(params string[] paramVarArgs)
  {
	Exception exception2 = null;
	try
	{
	  TaxiClient taxiClient = new TaxiClient();
	  Context context = this.a.getApplicationContext();
	  HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
	  this();
	  this(context, (HttpUtils)httpUrlConnectionUtils);
	  string str = taxiClient.doParkDetails(paramVarArgs[0], null).Name;
	}
	catch (Exception exception1)
	{
	  Log.e("RateActivity", "Fail get park details", exception1);
	  this.c = false;
	  exception1 = exception2;
	}
	return (string)exception1;
  }

  protected internal virtual void a(string paramString)
  {
	this.b.dismiss();
	if (!string.ReferenceEquals(paramString, null) && this.c)
	{
	  RateActivity.a(this.a, paramString);
	  ((TextView)this.a.findViewById(2131558467)).setText("«" + RateActivity.e(this.a) + "»");
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296547), true, true);
	this.b.setOnCancelListener(new lg(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */