using System.Threading;

using CoreApplication = ru.yandex.core.CoreApplication;

public sealed class c : ThreadStart
{
  public void run()
  {
	CoreApplication.access$000();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\c.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */