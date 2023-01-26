using System;

using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class jr : AsyncTask<int, int, GeoPoint>
{
  private GeocodeJsonObject b;

  private int c;

  private bool d;

  public jr(OrderActivity paramOrderActivity, GeocodeJsonObject paramGeocodeJsonObject, int paramInt)
  {
	this.b = paramGeocodeJsonObject;
	this.c = paramInt;
  }

  protected internal virtual GeoPoint a()
  {
	GeoPoint geoPoint4;
	GeoPoint geoPoint1 = null;
	GeoPoint geoPoint2 = null;
	GeoPoint geoPoint3 = geoPoint1;
	try
	{
	  GeocodeResponse geocodeResponse = OrderActivity.e(this.a).doGeocode(this.b.Text);
	  geoPoint4 = geoPoint2;
	  geoPoint3 = geoPoint1;
	  if (!geocodeResponse.Blocked)
	  {
		geoPoint4 = geoPoint2;
		geoPoint3 = geoPoint1;
		if (geocodeResponse.Code == 200)
		{
		  geoPoint3 = geoPoint1;
		  geoPoint4 = geocodeResponse.GeocodeObject.GeoPoint;
		  geoPoint3 = geoPoint4;
		  this.d = geocodeResponse.GeocodeObject.Exact;
		}
	  }
	}
	catch (Exception exception)
	{
	  Log.e("OrderActivity", "Fail get real point from geocode", exception);
	  geoPoint4 = geoPoint3;
	}
	return geoPoint4;
  }

  protected internal virtual void a(GeoPoint paramGeoPoint)
  {
	if (this.c == 0)
	{
	  OrderActivity.b(this.a).setVisibility(8);
	}
	if (paramGeoPoint != null && ((this.c == 0 && OrderActivity.g(this.a) != null && this.b.Text.Equals(OrderActivity.g(this.a).getText())) || (this.c == 1 && OrderActivity.x(this.a) != null && this.b.Text.Equals(OrderActivity.x(this.a).getText()))))
	{
	  bool @bool;
	  this.b.GeoPoint = paramGeoPoint;
	  GeocodeJsonObject geocodeJsonObject = this.b;
	  if (this.b.Exact || this.d)
	  {
		@bool = true;
	  }
	  else
	  {
		@bool = false;
	  }
	  geocodeJsonObject.Exact = @bool;
	  OrderActivity.i(this.a);
	  (new jy(this.a)).execute((object[])new int?[] {Convert.ToInt32(0)});
	}
	if (this.c == 0)
	{
	  OrderActivity.a(this.a, this.b, "last address", "last address date");
	}
	else
	{
	  OrderActivity.a(this.a, this.b, "last dest address", "last dest address date");
	}
	OrderActivity.j(this.a, false);
	if (OrderActivity.S(this.a) != null)
	{
	  OrderActivity.S(this.a).dismiss();
	  OrderActivity.a(this.a, null);
	  OrderActivity.T(this.a);
	}
  }

  protected internal virtual void onPreExecute()
  {
	if (this.c == 0)
	{
	  OrderActivity.b(this.a).setVisibility(0);
	  OrderActivity.c(this.a).setText(2131296430);
	  OrderActivity.d(this.a).setVisibility(8);
	  OrderActivity.d(this.a).setCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */