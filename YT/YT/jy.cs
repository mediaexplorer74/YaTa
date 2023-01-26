using System;
using System.Threading;

using AsyncTask = android.os.AsyncTask;
using Html = android.text.Html;
using Spanned = android.text.Spanned;
using Log = android.util.Log;
using TextView = android.widget.TextView;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using MapUtils = ru.yandex.taxi.map.MapUtils;

public class jy : AsyncTask<int, int, CharSequence>
{
  private jy(OrderActivity paramOrderActivity, sbyte paramByte)
  {
  }

  public virtual CharSequence a()
  {
	GeocodeJsonObject geocodeJsonObject2;
	SimpleResponse simpleResponse1 = null;
	GeocodeJsonObject geocodeJsonObject1 = null;
	if (OrderActivity.g(this.a) == null)
	{
	  geocodeJsonObject2 = MapUtils.getUserLocation(this.a.getApplicationContext());
	  if (geocodeJsonObject2 == null)
	  {
		geocodeJsonObject2 = null;
	  }
	}
	else
	{
	  geocodeJsonObject2 = OrderActivity.g(this.a);
	}
	OrderActivity.g(this.a, false);
	if (OrderActivity.K(this.a) != null)
	{
	  OrderActivity.K(this.a).interrupt();
	}
	OrderActivity.a(this.a, new Thread(new jz(this.a, geocodeJsonObject2.GeoPoint)));
	OrderActivity.K(this.a).start();
	SimpleResponse simpleResponse2 = simpleResponse1;
	if (geocodeJsonObject2 != null)
	{
	  simpleResponse2 = simpleResponse1;
	  if (geocodeJsonObject2.Exact)
	  {
		simpleResponse2 = simpleResponse1;
		if (OrderActivity.x(this.a) != null)
		{
		  simpleResponse2 = simpleResponse1;
		  if (OrderActivity.x(this.a).getExact())
		  {
			try
			{
			  Spanned spanned;
			  OrderActivity.h(this.a, true);
			  simpleResponse2 = OrderActivity.e(this.a).doRouteStats(geocodeJsonObject2.GeoPoint, OrderActivity.x(this.a).getGeoPoint());
			  geocodeJsonObject2 = geocodeJsonObject1;
			  if (simpleResponse2.Code == 200)
			  {
				geocodeJsonObject2 = geocodeJsonObject1;
				if (!simpleResponse2.Blocked)
				{
				  double d = int.Parse((string)simpleResponse2.Data["distance"]) / 1000.0D;
				  int i = int.Parse((string)simpleResponse2.Data["time"]);
				  geocodeJsonObject2 = geocodeJsonObject1;
				  if (i > 0)
				  {
//JAVA TO C# CONVERTER TODO TASK: The following line has a Java format specifier which cannot be directly translated to .NET:
					string str = string.Format("%,.2f", new object[] {Convert.ToDouble(d)});
					spanned = Html.fromHtml(String.format(this.a.getResources().getString(2131296428), new object[] {String.format(OrderActivity.L(this.a), new object[] {str}), String.format(OrderActivity.L(this.a), new object[] {Convert.ToInt32(i / 60)})}));
				  }
				}
			  }
			  return (CharSequence)spanned;
			}
			catch (Exception exception)
			{
			  Log.e("OrderActivity", "Fail get route statistics", exception);
			  return (CharSequence)simpleResponse1;
			}
			finally
			{
			  OrderActivity.h(this.a, false);
			}
		  }
		}
	  }
	}
	return (CharSequence)simpleResponse2;
  }

  protected internal virtual void a(CharSequence paramCharSequence)
  {
	sbyte b = 8;
	if (paramCharSequence != null)
	{
	  OrderActivity.M(this.a).setText(paramCharSequence);
	}
	if (OrderActivity.N(this.a))
	{
	  OrderActivity.i(this.a, false);
	  OrderActivity.b(this.a).setVisibility(8);
	  OrderActivity.d(this.a).setVisibility(0);
	  if (paramCharSequence != null && !OrderActivity.O(this.a))
	  {
		TextView textView = OrderActivity.M(this.a);
		if (!OrderActivity.O(this.a))
		{
		  b = 0;
		}
		textView.setVisibility(b);
	  }
	}
  }

  protected internal virtual void onPreExecute()
  {
	OrderActivity.M(this.a).setVisibility(8);
	OrderActivity.M(this.a).setText("");
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */