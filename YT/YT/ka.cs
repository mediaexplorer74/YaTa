using System.Threading;

using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

internal class ka : ThreadStart
{
  internal ka(jz paramjz)
  {
  }

  public virtual void run()
  {
	OrderActivity.c(this.a.a).setText(2131296431);
	OrderActivity.b(this.a.a).setVisibility(0);
	OrderActivity.d(this.a.a).setVisibility(8);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ka.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */