using System;

using Handler = android.os.Handler;
using Message = android.os.Message;
using MyLocationOverlay = ru.yandex.yandexmapkit.overlay.location.MyLocationOverlay;

public sealed class bm : Handler
{
  private readonly MyLocationOverlay a;

  public bm(MyLocationOverlay paramMyLocationOverlay)
  {
	this.a = paramMyLocationOverlay;
  }

  public void handleMessage(Message paramMessage)
  {
	try
	{
	  switch (paramMessage.what)
	  {
		default:
		  return;
		case 1:
		  this.a.a();
		  removeMessages(1);
		  sendEmptyMessageDelayed(1, 10000L);
			goto case 2;
		case 2:
		  this.a.b();
			goto case 3;
		case 3:
		  this.a.c();
			goto case 4;
		case 4:
		  break;
	  }
	}
	catch (Exception)
	{
	}
	this.a.d();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */