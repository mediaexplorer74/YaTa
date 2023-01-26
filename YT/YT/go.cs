using System.Threading;

using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;

public class go : ThreadStart
{
  public go(ConfirmActivity.SmsReceiver paramSmsReceiver, string paramString)
  {
  }

  public virtual void run()
  {
	int i = this.a.IndexOf(": ") + ": ".Length;
	if (i >= 0)
	{
	  ConfirmActivity.c(this.b.a).setText(this.a.Substring(i));
	  this.b.a.showDialog(0);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\go.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */