using System;

using Handler = android.os.Handler;
using Message = android.os.Message;
using WheelScroller = ru.yandex.taxi.ui.wheel.WheelScroller;

public class qz : Handler
{
  public qz(WheelScroller paramWheelScroller)
  {
  }

  public virtual void handleMessage(Message paramMessage)
  {
	WheelScroller.b(this.a).computeScrollOffset();
	int i = WheelScroller.b(this.a).getCurrY();
	int j = WheelScroller.a(this.a) - i;
	WheelScroller.a(this.a, i);
	if (j != 0)
	{
	  WheelScroller.c(this.a).onScroll(j);
	}
	if (Math.Abs(i - WheelScroller.b(this.a).getFinalY()) <= 0)
	{
	  WheelScroller.b(this.a).getFinalY();
	  WheelScroller.b(this.a).forceFinished(true);
	}
	if (!WheelScroller.b(this.a).isFinished())
	{
	  WheelScroller.d(this.a).sendEmptyMessage(paramMessage.what);
	  return;
	}
	if (paramMessage.what == 0)
	{
	  WheelScroller.e(this.a);
	  return;
	}
	this.a.a();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */