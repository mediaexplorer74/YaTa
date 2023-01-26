using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Parcelable = android.os.Parcelable;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using SearchResultsActivity = ru.yandex.taxi.activity.SearchResultsActivity;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class md : AsyncTask<string, int, GeocodeJsonObject>
{
  private ProgressDialog b;

  private bool c;

  public md(SearchStreetActivity paramSearchStreetActivity)
  {
  }

  protected internal virtual GeocodeJsonObject a()
  {
	Context context2;
	Context context1 = null;
	try
	{
	  TaxiClient taxiClient = new TaxiClient();
	  context2 = this.a.getApplicationContext();
	  HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
	  this();
	  this(context2, (HttpUtils)httpUrlConnectionUtils);
	  GeocodeResponse geocodeResponse = taxiClient.doGeosearch(SearchStreetActivity.c(this.a).getText().ToString(), SearchStreetActivity.e(this.a));
	  context2 = context1;
	  if (geocodeResponse.Code == 200)
	  {
		GeocodeJsonObject geocodeJsonObject = geocodeResponse.GeocodeObject;
	  }
	}
	catch (Exception exception)
	{
	  Log.e("SearchStreetActivity", "Fail get search result", exception);
	  context2 = context1;
	}
	return (GeocodeJsonObject)context2;
  }

  protected internal virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	sbyte b = 0;
	this.b.dismiss();
	if (!this.c)
	{
	  if (paramGeocodeJsonObject != null && paramGeocodeJsonObject.Count > 0)
	  {
		if (paramGeocodeJsonObject.Count == 1)
		{
		  (new me(this)).execute((object[])new GeocodeJsonObject[] {paramGeocodeJsonObject});
		  return;
		}
		Intent intent = new Intent((Context)this.a, typeof(SearchResultsActivity));
		GeocodeJsonObject geocodeJsonObject1 = new GeocodeJsonObject();
		GeocodeJsonObject geocodeJsonObject2 = new GeocodeJsonObject();
		while (b < paramGeocodeJsonObject.Count)
		{
		  GeocodeJsonObject geocodeJsonObject = paramGeocodeJsonObject.getObject(b);
		  if ("address".Equals(geocodeJsonObject.Type))
		  {
			geocodeJsonObject1.addGeoObjects(geocodeJsonObject);
		  }
		  else
		  {
			geocodeJsonObject2.addGeoObjects(geocodeJsonObject);
		  }
		  b++;
		}
		intent.putExtra("addresses", (Parcelable)geocodeJsonObject1);
		intent.putExtra("organizations", (Parcelable)geocodeJsonObject2);
		intent.putExtra("user point", (Parcelable)SearchStreetActivity.e(this.a));
		intent.putExtra("query", SearchStreetActivity.c(this.a).getText().ToString());
		intent.putExtra("type", SearchStreetActivity.d(this.a));
		intent.putExtra("default view", paramGeocodeJsonObject.DefaultView);
		this.a.startActivityForResult(intent, 1);
		return;
	  }
	  Toast.makeText((Context)this.a, 2131296378, 0).show();
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296380), true, true);
	this.b.setOnCancelListener(new mf(this));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\md.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */