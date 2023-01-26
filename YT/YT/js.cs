using System.Threading;

using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using AllCarsResponse = ru.yandex.taxi.client.response.AllCarsResponse;

public class js : ThreadStart
{
  private AllCarsResponse b;

  private js(OrderActivity paramOrderActivity, sbyte paramByte)
  {
  }

  public virtual void run()
  {
	if (!OrderActivity.U(this.a).booleanValue() || !OrderActivity.Y(this.a))
	{
	  (new jt(this)).execute((object[])new int?[0]);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\js.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */