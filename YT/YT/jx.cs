using System;
using System.Threading;

using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class jx : Thread
{
  private jx(OrderActivity paramOrderActivity, sbyte paramByte)
  {
  }

  public virtual void run()
  {
	string[] arrayOfString = null;
	try
	{
	  string[] arrayOfString1;
	  jv jv = new jv();
	  this(this.a);
	  if (OrderActivity.a(this.a) != null)
	  {
		arrayOfString = OrderActivity.a(this.a).getClasses();
		arrayOfString1 = OrderActivity.a(this.a).getExcludeParks();
	  }
	  else
	  {
		arrayOfString1 = null;
	  }
	  while (!OrderActivity.U(this.a).booleanValue() || !OrderActivity.V(this.a))
	  {
		OrderActivity.a(this.a, jv, arrayOfString1, arrayOfString);
		Thread.Sleep(60000L);
	  }
	}
	catch (Exception exception)
	{
	  Log.e("OrderActivity", "Fail update taxi cars data", exception);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */