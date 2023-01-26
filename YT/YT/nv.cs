using System;
using System.Collections;
using System.Collections.Generic;

using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using ListAdapter = android.widget.ListAdapter;
using Toast = android.widget.Toast;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;
using Park = ru.yandex.taxi.data.Park;

public class nv : AsyncTask<int, int, List<Park>>
{
  private nv(TariffListActivity paramTariffListActivity, sbyte paramByte)
  {
  }

  protected internal virtual List<Park> a()
  {
	List<Park> arrayList = new ArrayList();
	try
	{
	  List<Park> arrayList1 = TariffListActivity.l(this.a).doPriceCat();
	  arrayList = arrayList1;
	}
	catch (Exception exception)
	{
	  Log.e("TariffListActivity", "Fail get tariff list from server", exception);
	}
	return arrayList;
  }

  protected internal virtual void a(List<Park> paramArrayList)
  {
	nq nq = new nq(this.a, paramArrayList);
	this.a.getListView().setAdapter((ListAdapter)nq);
	TariffListActivity.m(this.a).setVisibility(8);
	if (paramArrayList == null || paramArrayList.Count == 0)
	{
	  Toast.makeText((Context)this.a, 2131296442, 0).show();
	}
  }

  protected internal virtual void onPreExecute()
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */