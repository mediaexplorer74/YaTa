using System;
using System.Collections;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using SharedPreferences = android.content.SharedPreferences;
using AsyncTask = android.os.AsyncTask;
using Parcelable = android.os.Parcelable;
using PreferenceManager = android.preference.PreferenceManager;
using Log = android.util.Log;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using DelayOrderActivity = ru.yandex.taxi.activity.DelayOrderActivity;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class kf : AsyncTask<int, int, string>
{
  private ProgressDialog b;

  private bool c;

  private DateTime d;

  private string e;

  public kf(ParkInfoActivity paramParkInfoActivity)
  {
  }

  protected internal virtual string a()
  {
	null = new ArrayList();
	null.add(ParkInfoActivity.d(this.a));
	if (ParkInfoActivity.e(this.a) != null && ParkInfoActivity.e(this.a).getGeoPoint() != null)
	{
	  null.add(ParkInfoActivity.e(this.a));
	}
	SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(this.a.getApplicationContext());
	try
	{
	  TaxiClient taxiClient = ParkInfoActivity.i(this.a);
	  string str1 = sharedPreferences.getString("client id", "");
	  string str2 = ParkInfoActivity.f(this.a).getParkId();
	  DateTime date = ParkInfoActivity.g(this.a);
	  string str3 = ParkInfoActivity.d(this.a).getComment();
	  System.Collections.IList list = ParkInfoActivity.h(this.a).getPairs();
	  string str4 = ParkInfoActivity.f(this.a).getTariff(ParkInfoActivity.b(this.a).getSelectedItemPosition()).getId();
	  SimpleResponse simpleResponse = taxiClient.doOrder(str1, new string[] {str2}, new string[0], true, date, str3, null, list, str4);
	  this.c = simpleResponse.Blocked;
	  this.d = simpleResponse.BlockDate;
	  this.e = simpleResponse.BlockType;
	  if (!this.c && simpleResponse.Code == 200)
	  {
		return (string)simpleResponse.Data["orderid"];
	  }
	}
	catch (Exception exception)
	{
	  Log.e("ParkInfoActivity", "Fail make order", exception);
	}
	return null;
  }

  protected internal virtual void a(string paramString)
  {
	this.b.dismiss();
	if (!string.ReferenceEquals(paramString, null))
	{
	  Intent intent = new Intent((Context)this.a, typeof(DelayOrderActivity));
	  intent.putExtra("src point", (Parcelable)ParkInfoActivity.d(this.a));
	  intent.putExtra("dest point", (Parcelable)ParkInfoActivity.e(this.a));
	  intent.putExtra("order id", paramString);
	  intent.putExtra("when", ParkInfoActivity.g(this.a));
	  intent.putExtra("park name", ParkInfoActivity.f(this.a).getName());
	  intent.putExtra("park phone", ParkInfoActivity.f(this.a).getPhone());
	  intent.putExtra("park id", ParkInfoActivity.f(this.a).getParkId());
	  intent.putExtra("park logo url", ParkInfoActivity.f(this.a).getLogoUrl());
	  intent.putExtra("tariff id", ParkInfoActivity.f(this.a).getTariff(ParkInfoActivity.b(this.a).getSelectedItemPosition()).getId());
	  intent.putExtra("init", true);
	  ParkInfoActivity.a(this.a, paramString);
	  this.a.startActivityForResult(intent, 1);
	  return;
	}
	if (this.c)
	{
	  Intent intent = new Intent(this.a.getApplicationContext(), typeof(AuthorizeActivity));
	  intent.putExtra("block", true);
	  intent.putExtra("release date", this.d);
	  intent.putExtra("block type", this.e);
	  this.a.startActivityForResult(intent, 0);
	  return;
	}
	ParkInfoActivity.b(this.a, 2131296445);
	this.a.showDialog(1);
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296444), true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */