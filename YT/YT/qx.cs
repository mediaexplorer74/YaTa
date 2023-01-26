using Handler = android.os.Handler;
using Message = android.os.Message;
using SlidingDrawer = ru.yandex.taxi.ui.slider.SlidingDrawer;

public class qx : Handler
{
  private qx(SlidingDrawer paramSlidingDrawer, sbyte paramByte)
  {
  }

  public virtual void handleMessage(Message paramMessage)
  {
	switch (paramMessage.what)
	{
	  default:
		return;
	  case 1000:
		break;
	}
	SlidingDrawer.c(this.a);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */