using System;

using Handler = android.os.Handler;
using Message = android.os.Message;

internal sealed class rh : Handler
{
  private readonly w a;

  internal rh(w paramw)
  {
	this.a = paramw;
  }

  public void handleMessage(Message paramMessage)
  {
	try
	{
	  switch (paramMessage.what)
	  {
		default:
		  return;
		case 0:
		  this.a.e();
			goto case 1;
		case 1:
		  break;
	  }
	}
	catch (Exception)
	{
	}
	this.a.f();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */