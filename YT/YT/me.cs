using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Parcelable = android.os.Parcelable;
using Log = android.util.Log;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
using HttpUtils = ru.yandex.taxi.client.HttpUtils;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

internal class me : AsyncTask<GeocodeJsonObject, int, GeocodeJsonObject>
{
  private ProgressDialog b;

  internal me(md parammd)
  {
  }

  protected internal virtual GeocodeJsonObject a(params GeocodeJsonObject[] paramVarArgs)
  {
	GeocodeJsonObject geocodeJsonObject = paramVarArgs[0];
	try
	{
	  TaxiClient taxiClient = new TaxiClient();
	  Context context = this.a.a.getApplicationContext();
	  HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
	  this();
	  this(context, (HttpUtils)httpUrlConnectionUtils);
	  GeocodeResponse geocodeResponse = taxiClient.doGeocode(geocodeJsonObject.Text);
	  if (geocodeResponse.Code == 200 && !geocodeResponse.Blocked)
	  {
		GeocodeJsonObject geocodeJsonObject1 = geocodeResponse.GeocodeObject;
		if ("organization".Equals(geocodeJsonObject.Type))
		{
		  geocodeJsonObject1.Comment = geocodeJsonObject.Street;
		}
		geocodeJsonObject1.GeoPoint = geocodeJsonObject.GeoPoint;
		geocodeJsonObject = geocodeJsonObject1;
	  }
	}
	catch (Exception exception)
	{
	  Log.e("SearchStreetActivity", "Fail get exact address for selected geo object", exception);
	}
	return geocodeJsonObject;
  }

  protected internal virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	if (!isCancelled())
	{
	  this.b.dismiss();
	  Intent intent = new Intent((Context)this.a.a, typeof(EditAddressActivity));
	  intent.putExtra("address", (Parcelable)paramGeocodeJsonObject);
	  intent.putExtra("type", SearchStreetActivity.d(this.a.a));
	  intent.putExtra("from city", paramGeocodeJsonObject.City);
	  this.a.a.startActivityForResult(intent, 2);
	}
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a.a, "", this.a.a.getResources().getString(2131296366), true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\me.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */