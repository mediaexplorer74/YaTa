using View = android.view.View;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class kh : View.OnClickListener
{
  public kh(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onClick(View paramView)
  {
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */