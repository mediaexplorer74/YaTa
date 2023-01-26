using View = android.view.View;
using AdapterView = android.widget.AdapterView;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;

public class kd : AdapterView.OnItemSelectedListener
{
  public kd(ParkInfoActivity paramParkInfoActivity)
  {
  }

  public virtual void onItemSelected<T1>(AdapterView<T1> paramAdapterView, View paramView, int paramInt, long paramLong)
  {
	ParkInfoActivity.a(this.a, ParkInfoActivity.a(this.a).getCurrentTab());
  }

  public virtual void onNothingSelected<T1>(AdapterView<T1> paramAdapterView)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */