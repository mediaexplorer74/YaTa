using View = android.view.View;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

internal class mj : View.OnClickListener
{
  internal mj(mi parammi, GeocodeJsonObject paramGeocodeJsonObject, int paramInt)
  {
  }

  public virtual void onClick(View paramView)
  {
	SearchStreetActivity.a(this.c.a, this.a, this.b);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */