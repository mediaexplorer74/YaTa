using System.Threading;

using CoreApplication = ru.yandex.core.CoreApplication;

public class l : ThreadStart
{
  public static l b;

  public bool a = false;

  public virtual void run()
  {
	if (!this.a)
	{
	  CoreApplication.sendEvent(new int[] {106});
	  CoreApplication.View.postDelayed(this, 16L);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\l.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */