using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class hg : AsyncTask<int, int, GeocodeResponse>
{
  private ProgressDialog b;

  private GeocodeJsonObject c = new GeocodeJsonObject();

  private hg(EditAddressActivity paramEditAddressActivity, sbyte paramByte)
  {
  }

  protected internal virtual GeocodeResponse a()
  {
	GeocodeResponse geocodeResponse = null;
	try
	{
	  GeocodeResponse geocodeResponse1 = EditAddressActivity.s(this.a).doGeocode(this.c.Text);
	  geocodeResponse = geocodeResponse1;
	}
	catch (Exception exception)
	{
	  Log.e("EditAddressActivity", "Fail get real point from geocode", exception);
	}
	return geocodeResponse;
  }

  protected internal virtual void a(GeocodeResponse paramGeocodeResponse)
  {
	if (paramGeocodeResponse != null && paramGeocodeResponse.Code == 200)
	{
	  EditAddressActivity.b(this.a, paramGeocodeResponse.GeocodeObject.GeoPoint);
	  EditAddressActivity.a(this.a, paramGeocodeResponse.GeocodeObject.Exact);
	  if (EditAddressActivity.m(this.a) || EditAddressActivity.a(this.a) == 1)
	  {
		EditAddressActivity.n(this.a);
		this.a.finish();
	  }
	  else
	  {
		this.a.showDialog(0);
	  }
	}
	else if (EditAddressActivity.a(this.a) == 0)
	{
	  Toast.makeText((Context)this.a, 2131296284, 0).show();
	}
	else
	{
	  EditAddressActivity.n(this.a);
	  this.a.finish();
	}
	this.b.dismiss();
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296367), true, true);
	this.b.setOnCancelListener(new hh(this));
	EditAddressActivity.a(this.a, this.c);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */