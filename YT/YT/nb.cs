using System;
using System.Collections;
using System.Collections.Generic;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
using Requirements = ru.yandex.taxi.data.Requirements;
using TariffLimits = ru.yandex.taxi.data.TariffLimits;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class nb : AsyncTask<int, int, bool>
{
  private bool b;

  private ProgressDialog c;

  private int d;

  private int e;

  private string f;

  private Requirements g;

  private TariffLimits h;

  public nb(SearchTaxiActivity paramSearchTaxiActivity, int paramInt1, int paramInt2, string paramString, Requirements paramRequirements, TariffLimits paramTariffLimits)
  {
	this.d = paramInt1;
	this.e = paramInt2;
	this.g = paramRequirements;
	this.h = paramTariffLimits;
	this.f = paramString;
  }

  protected internal virtual bool? a()
  {
	bool @bool;
	DateTime date = this.a.mWhen;
	try
	{
	  List<GeocodeJsonObject> arrayList = new ArrayList();
	  this();
	  arrayList.Add(this.a.mSrcAddress);
	  if (this.a.mDestAddress != null && this.a.mDestAddress.getGeoPoint() != null)
	  {
		arrayList.Add(this.a.mDestAddress);
	  }
	  DateTime calendar = new DateTime();
	  calendar = new DateTime(this.a.mWhen);
	  calendar = calendar.AddMinutes(this.d);
	  this.a.mWhen = calendar;
	  SimpleResponse simpleResponse = this.a.mTaxiClient.doReorder(SearchTaxiActivity.u(this.a).getString("client id", ""), this.a.mOrderId, this.a.mWhen, this.h, this.g);
	  if (!this.b && !simpleResponse.Blocked && simpleResponse.Code == 200 && !"1".Equals(simpleResponse.Data["found"]))
	  {
		this.a.mOrderId = (string)simpleResponse.Data["orderid"];
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	}
	catch (Exception exception)
	{
	  Log.e("SearchTaxiActivity", "Fail calibrate taxi search", exception);
	  @bool = false;
	}
	if (!@bool)
	{
	  this.a.mWhen = date;
	}
	return Convert.ToBoolean(@bool);
  }

  protected internal virtual void a(bool? paramBoolean)
  {
	bool @bool;
	this.c.dismiss();
	SearchTaxiActivity searchTaxiActivity = this.a;
	if (!this.b)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	SearchTaxiActivity.a(searchTaxiActivity, @bool);
	if (!paramBoolean.Value)
	{
	  Toast.makeText((Context)this.a, 2131296292, 0).show();
	  return;
	}
	SearchTaxiActivity.t(this.a);
	Toast.makeText((Context)this.a, this.f, 0).show();
  }

  protected internal virtual void onPreExecute()
  {
	this.c = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(this.e), true, true);
	this.c.setOnCancelListener(new nc(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */