using System.Threading;

using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;
using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

public class mu : ThreadStart
{
  public mu(SearchTaxiActivity paramSearchTaxiActivity)
  {
  }

  public virtual void run()
  {
	SearchTaxiActivity.a(this.a, SearchTaxiActivity.a(this.a).getZoomCurrent());
	SearchTaxiActivity.a(this.a, SearchTaxiActivity.a(this.a).getGeoPoint(new ScreenPoint((this.a.mMap.getWidth() / 2), (this.a.mMap.getHeight() / 2))));
	SearchTaxiActivity.b(this.a, SearchTaxiActivity.a(this.a).getGeoPoint(new ScreenPoint(0.0F, 0.0F)));
	if (this.a.mSrcAddress != null)
	{
	  SearchTaxiActivity.d(this.a);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */