using Activity = android.app.Activity;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using ru.yandex.taxi;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using MapUtils = ru.yandex.taxi.map.MapUtils;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

public class it : AsyncTask<ScreenPoint, int, GeocodeJsonObject>
{
  private bool c = true;

  public it(OrderActivity paramOrderActivity, bool paramBoolean)
  {
  }

  private GeocodeJsonObject a(Pair<GeoPoint, bool> paramPair)
  {
	if (paramPair != null)
	{
	  GeoPoint geoPoint;
	  if (paramPair == null)
	  {
		geoPoint = MapUtils.getLastKnownMyLocationPoint(this.b.getApplicationContext());
	  }
	  else
	  {
		geoPoint = (GeoPoint)paramPair.first;
	  }
	  if (geoPoint != null)
	  {
		OrderActivity orderActivity = this.b;
		OrderActivity.a(geoPoint);
		GeocodeJsonObject geocodeJsonObject = OrderActivity.e(this.b).getGeoObject(geoPoint);
		if (!((bool?)paramPair.second).Value && geocodeJsonObject != null)
		{
		  this.c = false;
		}
		return geocodeJsonObject;
	  }
	}
	return null;
  }

  protected internal virtual GeocodeJsonObject a()
  {
	Pair<GeoPoint, bool> pair = new Pair();
	try
	{
	  OrderActivity orderActivity = this.b;
	  iu iu = new iu();
	  this(this);
	  Pair<GeoPoint, bool> pair1 = MapUtils.getLbsLocation((Activity)orderActivity, iu, true);
	  pair = pair1;
	}
	catch (IOException iOException)
	{
	  Log.e("OrderActivity", "Fail get user location", iOException);
	}
	return a(pair);
  }

  protected internal virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	if (paramGeocodeJsonObject != null && (!OrderActivity.f(this.b) || OrderActivity.g(this.b) == null))
	{
	  OrderActivity.a(this.b, true);
	  if (!this.c)
	  {
		paramGeocodeJsonObject.House = "";
		paramGeocodeJsonObject.Exact = false;
		paramGeocodeJsonObject.Street = "";
		paramGeocodeJsonObject.Name = paramGeocodeJsonObject.City;
		paramGeocodeJsonObject.Text = paramGeocodeJsonObject.Country + ", " + paramGeocodeJsonObject.City;
	  }
	  OrderActivity.a(this.b, paramGeocodeJsonObject);
	  OrderActivity.b(this.b, OrderActivity.h(this.b));
	  OrderActivity.i(this.b);
	  OrderActivity.j(this.b);
	}
	OrderActivity.b(this.b).setVisibility(8);
  }

  protected internal virtual void onPreExecute()
  {
	if (!this.a)
	{
	  OrderActivity.b(this.b).setVisibility(0);
	  OrderActivity.c(this.b).setText(2131296430);
	  OrderActivity.d(this.b).setText("");
	  OrderActivity.d(this.b).setCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\it.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */