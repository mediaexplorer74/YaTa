using System.Threading;

using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

internal class ni : ThreadStart
{
  internal ni(ne paramne)
  {
  }

  public virtual void run()
  {
	if ("break".Equals(SearchTaxiActivity.y(this.a.a)))
	{
	  this.a.a.showDialog(0);
	  return;
	}
	this.a.a.showDialog(3);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ni.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */