using System;
using System.Text;

using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using Button = android.widget.Button;
using SelectPointActivity = ru.yandex.taxi.activity.SelectPointActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using ErrorUtils = ru.yandex.taxi.error.ErrorUtils;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class nl : AsyncTask<GeoPoint, int, int>
{
  private nl(SelectPointActivity paramSelectPointActivity, sbyte paramByte)
  {
  }

  protected internal virtual int? a(params GeoPoint[] paramVarArgs)
  {
	bool @bool = false;
	GeoPoint geoPoint = paramVarArgs[0];
	try
	{
	  TaxiClient taxiClient = SelectPointActivity.g(this.a);
	  StringBuilder stringBuilder = new StringBuilder();
	  this();
	  GeocodeResponse geocodeResponse = taxiClient.doGeocode(stringBuilder.Append(geoPoint.Lon).Append(",").Append(geoPoint.Lat).ToString());
	  if (!geocodeResponse.Blocked && geocodeResponse.Code == 200)
	  {
		SelectPointActivity.a(this.a, geocodeResponse.GeocodeObject);
		SelectPointActivity.a(this.a).setGeoPoint(geoPoint);
		return Convert.ToInt32(@bool);
	  }
	}
	catch (Exception exception)
	{
	  Log.e("SelectPointActivity", "Fail get geocode response", exception);
	}
	@bool = true;
	return Convert.ToInt32(@bool);
  }

  protected internal virtual void a(int? paramInteger)
  {
	bool @bool;
	if (paramInteger.Value == 0)
	{
	  SelectPointActivity.d(this.a).setText(SelectPointActivity.a(this.a).getName());
	}
	else
	{
	  ErrorUtils.showErrorMessage(this.a.getApplicationContext(), this.a.getResources().getString(2131296284));
	}
	SelectPointActivity.e(this.a).setVisibility(8);
	Button button = SelectPointActivity.f(this.a);
	if (SelectPointActivity.a(this.a) != null)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	button.setEnabled(@bool);
  }

  protected internal virtual void onPreExecute()
  {
	SelectPointActivity.e(this.a).setVisibility(0);
	SelectPointActivity.f(this.a).setEnabled(false);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */