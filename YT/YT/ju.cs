using System;
using System.Threading;

using Log = android.util.Log;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;

public class ju : Thread
{
  private ju(OrderActivity paramOrderActivity, sbyte paramByte)
  {
  }

  public virtual void run()
  {
	try
	{
	  js js = new js();
	  this(this.a);
	  while (!OrderActivity.U(this.a).booleanValue() || !OrderActivity.Y(this.a))
	  {
		Log.d("OrderActivity", "Update all taxi: thread");
		OrderActivity.a(this.a, js);
		Thread.Sleep(60000L);
	  }
	}
	catch (Exception exception)
	{
	  Log.e("OrderActivity", "Fail update taxi cars data", exception);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ju.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */