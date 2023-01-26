using System;
using System.Collections;
using System.Collections.Generic;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Parcelable = android.os.Parcelable;
using Log = android.util.Log;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class hr : AsyncTask<int, int, string>
{
  private ProgressDialog b;

  private bool c;

  private DateTime d;

  private string e;

  public hr(OrderActivity paramOrderActivity)
  {
  }

  protected internal virtual string a()
  {
	Exception exception;
	List<GeocodeJsonObject> arrayList = new ArrayList();
	arrayList.Add(OrderActivity.g(this.a));
	if (OrderActivity.x(this.a) != null && OrderActivity.x(this.a).getGeoPoint() != null)
	{
	  arrayList.Add(OrderActivity.x(this.a));
	}
	try
	{
	  bool @bool;
	  string str = OrderActivity.s(this.a).getString("client id", "");
	  TaxiClient taxiClient = OrderActivity.e(this.a);
	  string[] arrayOfString = OrderActivity.a(this.a).getExcludeParks();
	  exception = (Exception)OrderActivity.a(this.a).getClasses();
	  if (!OrderActivity.A(this.a))
	  {
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	  SimpleResponse simpleResponse = taxiClient.doOrder(str, arrayOfString, (string[])exception, @bool, OrderActivity.r(this.a), OrderActivity.g(this.a).getComment(), arrayList, OrderActivity.B(this.a).getRushPairs(), null);
	  if (!simpleResponse.Blocked && simpleResponse.Code == 200)
	  {
		string str1 = (string)simpleResponse.Data["orderid"];
		string str2 = str1;
		try
		{
		  OrderActivity.u(this.a).clear();
		  str2 = str1;
		}
		catch (Exception)
		{
		}
	  }
	  else
	  {
		taxiClient = null;
		TaxiClient taxiClient1 = taxiClient;
	  }
	}
	catch (Exception null)
	{
	  exception = null;
	}
	Log.e("OrderActivity", "Fail make order", null);
	return (string)exception;
  }

  protected internal virtual void a(string paramString)
  {
	this.b.dismiss();
	if (!string.ReferenceEquals(paramString, null))
	{
	  OrderActivity.a(this.a, paramString);
	  Intent intent = new Intent((Context)this.a, typeof(SearchTaxiActivity));
	  intent.putExtra("src point", (Parcelable)OrderActivity.g(this.a));
	  intent.putExtra("dest point", (Parcelable)OrderActivity.x(this.a));
	  intent.putExtra("order id", paramString);
	  intent.putExtra("when", OrderActivity.r(this.a));
	  intent.putExtra("server diff time", OrderActivity.C(this.a));
	  this.a.startActivity(intent);
	  return;
	}
	if (this.c)
	{
	  Intent intent = new Intent(this.a.getApplicationContext(), typeof(AuthorizeActivity));
	  intent.putExtra("block", true);
	  intent.putExtra("release date", this.d);
	  intent.putExtra("block type", this.e);
	  this.a.startActivityForResult(intent, 4);
	  return;
	}
	OrderActivity.b(this.a, this.a.getResources().getString(2131296445));
	this.a.showDialog(6);
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296444), true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */