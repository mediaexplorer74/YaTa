using System;
using System.Collections;
using System.Collections.Generic;

using ProgressDialog = android.app.ProgressDialog;
using ContentResolver = android.content.ContentResolver;
using Context = android.content.Context;
using Cursor = android.database.Cursor;
using Uri = android.net.Uri;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using ListAdapter = android.widget.ListAdapter;
using TaxiListActivity = ru.yandex.taxi.activity.TaxiListActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using Park = ru.yandex.taxi.data.Park;
using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;

public class nx : AsyncTask<int, int, List<Park>>
{
  private ProgressDialog b;

  private TaxiClient c;

  private bool d;

  private nx(TaxiListActivity paramTaxiListActivity, sbyte paramByte)
  {
  }

  protected internal virtual List<Park> a()
  {
	List<Park> arrayList = new ArrayList();
	if (TaxiListActivity.d(this.a))
	{
	  try
	  {
		List<Park> arrayList1 = this.c.doTaxiSearchLater(TaxiListActivity.e(this.a), TaxiListActivity.f(this.a));
		arrayList = arrayList1;
	  }
	  catch (Exception exception)
	  {
		Log.e("TaxiListActivity", "Fail get taxi list for " + TaxiListActivity.e(this.a), exception);
	  }
	  return arrayList;
	}
	ContentResolver contentResolver = this.a.getContentResolver();
	Uri uri = StaticDataScheme.TaxiTable.CONTENT_URI;
	string str = TaxiListActivity.e(this.a);
	Cursor cursor = contentResolver.query(uri, new string[] {"taxi_id", "name", "phone"}, "locality_name = ?", new string[] {str}, null);
	if (cursor.getCount() > 0)
	{
	  cursor.moveToFirst();
	  while (!cursor.isAfterLast())
	  {
		Park park = new Park();
		park.Name = cursor.getString(1);
		park.Type = "taxipark";
		string str1 = cursor.getString(2);
		if (!string.ReferenceEquals(str1, null) && str1.Length > 4)
		{
		  park.Phone = str1;
		}
		arrayList.Add(park);
		cursor.moveToNext();
	  }
	}
	cursor.close();
	return arrayList;
  }

  protected internal virtual void a(List<Park> paramArrayList)
  {
	if (!this.d)
	{
	  TaxiListActivity.a(this.a, paramArrayList);
	  nz nz = new nz(this.a, paramArrayList);
	  TaxiListActivity.a(this.a).setAdapter((ListAdapter)nz);
	  if (TaxiListActivity.b(this.a))
	  {
		this.b.dismiss();
	  }
	}
	if (TaxiListActivity.b(this.a) && (TaxiListActivity.c(this.a) == null || TaxiListActivity.c(this.a).size() == 0))
	{
	  this.a.showDialog(2);
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.c = new TaxiClient(this.a.getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296528), true, true);
	this.b.setOnCancelListener(new ny(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */