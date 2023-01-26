using System;
using System.Collections;
using System.Collections.Generic;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using Tariff = ru.yandex.taxi.data.Tariff;

public class kq : AsyncTask<int, int, bool>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private ProgressDialog b_Conflict;

  private TaxiClient c;

  private kq(ParkInfoActivity paramParkInfoActivity, sbyte paramByte)
  {
  }

  protected internal virtual bool? a()
  {
	bool @bool = true;
	try
	{
	  ParkInfoActivity.a(this.a, this.c.doParkDetails(ParkInfoActivity.j(this.a), ParkInfoActivity.k(this.a)));
	  List<Tariff> arrayList = new ArrayList();
	  this();
	  for (sbyte b = 0; b < ParkInfoActivity.f(this.a).getTariffsCount(); b++)
	  {
		Tariff tariff = ParkInfoActivity.f(this.a).getTariff(b);
		if (ParkInfoActivity.l(this.a) == null || ParkInfoActivity.l(this.a).checkClass(tariff.Clazz))
		{
		  arrayList.Add(tariff);
		}
	  }
	  ParkInfoActivity.f(this.a).clearTariffList();
	  ParkInfoActivity.f(this.a).setTariffList(arrayList);
	}
	catch (Exception exception)
	{
	  Log.e("ParkInfoActivity", "Fail get park details", exception);
	  @bool = false;
	}
	return Convert.ToBoolean(@bool);
  }

  protected internal virtual void b()
  {
	try
	{
	  ParkInfoActivity.m(this.a);
	  this.b_Conflict.dismiss();
	}
	catch (Exception exception)
	{
	  Log.e("ParkInfoActivity", "Fail init park data " + exception);
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b_Conflict = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296547), true, true);
	this.b_Conflict.setOnCancelListener(new kr(this));
	this.c = new TaxiClient(this.a.getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */