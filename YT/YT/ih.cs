using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ih : AsyncTask<int, int, bool>
{
  private ProgressDialog c;

  public ih(OrderActivity paramOrderActivity, string paramString)
  {
  }

  protected internal virtual void a()
  {
	this.c.dismiss();
  }

  protected internal virtual bool? b()
  {
	bool @bool = false;
	try
	{
	  int i = OrderActivity.e(this.b).doTaxiOnTheWay(OrderActivity.s(this.b).getString("client id", ""), this.a, "user").getCode();
	  if (i != 500)
	  {
		@bool = true;
	  }
	}
	catch (Exception exception)
	{
	  Log.e("OrderActivity", "Fail request break taxi search", exception);
	}
	return Convert.ToBoolean(@bool);
  }

  protected internal virtual void onPreExecute()
  {
	this.c = ProgressDialog.show((Context)this.b, "", this.b.getResources().getString(2131296303), true, true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ih.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */