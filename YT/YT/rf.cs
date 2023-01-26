using System;

using Handler = android.os.Handler;
using Message = android.os.Message;

internal sealed class rf : Handler
{
  private readonly t a;

  internal rf(t paramt)
  {
	this.a = paramt;
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
		  break;
	  }
	  this.a.invalidate();
	}
	catch (Exception)
	{
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\rf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */