using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using SearchResponse = ru.yandex.taxi.client.response.SearchResponse;

internal class mx : AsyncTask<int, int, SearchResponse>
{
  private ProgressDialog b;

  internal mx(mw parammw)
  {
  }

  protected internal virtual SearchResponse a()
  {
	SearchResponse searchResponse = null;
	try
	{
	  SearchResponse searchResponse1 = this.a.b.mTaxiClient.doTaxiSearch(this.a.b.mClientId, this.a.b.mOrderId, "user");
	  searchResponse = searchResponse1;
	}
	catch (Exception exception)
	{
	  Log.e("SearchTaxiActivity", "Fail request break taxi search", exception);
	}
	return searchResponse;
  }

  protected internal virtual void a(SearchResponse paramSearchResponse)
  {
	if (this.a.b.mScreenVisible)
	{
	  this.b.dismiss();
	}
	if (paramSearchResponse != null && paramSearchResponse.Code != 500 && !paramSearchResponse.Found)
	{
	  this.a.b.setResult(1);
	  this.a.b.finish();
	  return;
	}
	if (paramSearchResponse != null && paramSearchResponse.Found)
	{
	  Toast.makeText((Context)this.a.b, 2131296456, 0).show();
	  try
	  {
		SearchTaxiActivity searchTaxiActivity = this.a.b;
		TaxiClient taxiClient = this.a.b.mTaxiClient;
		SearchTaxiActivity.f(searchTaxiActivity);
	  }
	  catch (Exception exception)
	  {
		Log.e("SearchTaxiActivity", "Fail go to taxi on the way to source screen", exception);
		Toast.makeText((Context)this.a.b, 2131296442, 0).show();
		SearchTaxiActivity.a(this.a.b, this.a.a);
	  }
	  return;
	}
	Toast.makeText((Context)this.a.b, 2131296442, 0).show();
	SearchTaxiActivity.a(this.a.b, this.a.a);
  }

  protected internal virtual void onPreExecute()
  {
	this.a.b.mInterrupt = true;
	this.b = ProgressDialog.show((Context)this.a.b, "", this.a.b.getResources().getString(2131296303), true, true);
	this.b.setOnCancelListener(new my(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */