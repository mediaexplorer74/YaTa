using Context = android.content.Context;
using Intent = android.content.Intent;
using Parcelable = android.os.Parcelable;
using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class hn : View.OnClickListener
{
  public hn(OrderActivity paramOrderActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	GeoPoint geoPoint;
	Intent intent = new Intent((Context)this.a, typeof(SearchStreetActivity));
	if (OrderActivity.g(this.a) == null)
	{
	  str = "Москва";
	}
	else
	{
	  str = OrderActivity.g(this.a).getCity();
	}
	intent.putExtra("city name", str);
	intent.putExtra("type", 1);
	string str = null;
	if (OrderActivity.x(this.a) != null)
	{
	  geoPoint = OrderActivity.x(this.a).getGeoPoint();
	}
	else if (OrderActivity.g(this.a) != null)
	{
	  geoPoint = OrderActivity.g(this.a).getGeoPoint();
	}
	intent.putExtra("init location", (Parcelable)geoPoint);
	this.a.startActivityForResult(intent, 2);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\hn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */