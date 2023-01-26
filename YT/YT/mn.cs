using System.Threading;

using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

internal class mn : ThreadStart
{
  internal mn(mm parammm)
  {
  }

  public virtual void run()
  {
	SearchTaxiActivity.a(this.a.b).setZoomCurrent(SearchTaxiActivity.a(this.a.b).getZoomCurrent() - this.a.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */