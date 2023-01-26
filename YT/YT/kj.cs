using TabHost = android.widget.TabHost;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class kj : TabHost.OnTabChangeListener
{
  public kj(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onTabChanged(string paramString)
  {
	ParkInfoActivity.a(this.a, ParkInfoActivity.a(this.a).getCurrentTab());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */