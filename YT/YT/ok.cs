using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;

internal class ok : AsyncTask<int, int, bool>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private ProgressDialog b_Conflict;

  internal ok(oj paramoj)
  {
  }

  protected internal virtual void a()
  {
	this.b_Conflict.dismiss();
	this.a.a.setResult(1);
	this.a.a.finish();
  }

  protected internal virtual bool? b()
  {
	bool @bool = false;
	try
	{
	  int i = this.a.a.mTaxiClient.doTaxiOnTheWay(this.a.a.mClientId, this.a.a.mOrderId, "user").getCode();
	  if (i != 500)
	  {
		@bool = true;
	  }
	}
	catch (Exception exception)
	{
	  Log.e("TaxiOnTheWayToSourceActivity", "Fail request break taxi search", exception);
	}
	return Convert.ToBoolean(@bool);
  }

  protected internal virtual void onPreExecute()
  {
	this.a.a.mInterrupt = true;
	this.b_Conflict = ProgressDialog.show((Context)this.a.a, "", this.a.a.getResources().getString(2131296303), true, true);
	this.b_Conflict.setOnCancelListener(new ol(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ok.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */