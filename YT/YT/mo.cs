using System.Threading;

using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

internal class mo : ThreadStart
{
  internal mo(mm parammm)
  {
  }

  public virtual void run()
  {
	this.a.b.mMap.showZoomButtons(true);
	SearchTaxiActivity.a(this.a.b).setZoomCurrent(this.a.b.mOptimZoom);
	SearchTaxiActivity.a(this.a.b).setEnabled(true);
	SearchTaxiActivity.a(this.a.b).notifyRepaint();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */