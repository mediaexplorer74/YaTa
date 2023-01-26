using System;
using System.Threading;

using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class jz : ThreadStart
{
  private GeoPoint b;

  public jz(OrderActivity paramOrderActivity, GeoPoint paramGeoPoint)
  {
	this.b = paramGeoPoint;
  }

  public virtual void run()
  {
	while (true)
	{
	  try
	  {
		if (!OrderActivity.P(this.a))
		{
		  bool bool1;
		  bool bool2;
		  if (this.b != null && OrderActivity.g(this.a) != null && OrderActivity.g(this.a).getExact())
		  {
			bool1 = true;
		  }
		  else
		  {
			bool1 = false;
		  }
		  if (OrderActivity.A(this.a) && OrderActivity.y(this.a))
		  {
			bool2 = true;
		  }
		  else
		  {
			bool2 = false;
		  }
		  if (bool1 && bool2)
		  {
			OrderActivity orderActivity = this.a;
			ka ka = new ka();
			this(this);
			orderActivity.runOnUiThread(ka);
		  }
		  string str = OrderActivity.s(this.a).getString("client id", "");
		  bool @bool = "".Equals(str);
		  if (!@bool)
		  {
			try
			{
			  GeoPoint geoPoint;
			  TaxiClient taxiClient = OrderActivity.e(this.a);
			  string[] arrayOfString1 = OrderActivity.a(this.a).getExcludeParks();
			  string[] arrayOfString2 = OrderActivity.a(this.a).getClasses();
			  System.Collections.IList list = OrderActivity.B(this.a).getRushPairs();
			  DateTime date = OrderActivity.r(this.a);
			  if (bool1)
			  {
				geoPoint = this.b;
			  }
			  else
			  {
				geoPoint = null;
			  }
			  if (OrderActivity.g(this.a) != null)
			  {
				@bool = OrderActivity.g(this.a).getAirport().booleanValue();
			  }
			  else
			  {
				@bool = false;
			  }
			  SimpleResponse simpleResponse = taxiClient.doTaxiCount(str, arrayOfString1, arrayOfString2, list, date, geoPoint, @bool);
			  OrderActivity orderActivity = this.a;
			  kb kb = new kb();
			  this(this, simpleResponse, bool2, bool1);
			  orderActivity.runOnUiThread(kb);
			}
			catch (Exception)
			{
			}
		  }
		  else
		  {
			Thread.Sleep(10000L);
			continue;
		  }
		}
		else
		{
		  return;
		}
		Thread.Sleep(60000L);
		continue;
	  }
	  catch (Exception exception)
	  {
		Log.d("OrderActivity", "Fail process taxi count response", exception);
	  }
	  return;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */