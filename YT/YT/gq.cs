using System.Threading;

using DelayOrderActivity = ru.yandex.taxi.activity.DelayOrderActivity;

internal class gq : ThreadStart
{
  internal gq(gp paramgp)
  {
  }

  public virtual void run()
  {
	DelayOrderActivity.b(this.a.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */