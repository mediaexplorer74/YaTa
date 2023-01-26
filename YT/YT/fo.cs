using System.Threading;

using CoreApplication = ru.yandex.core.CoreApplication;

internal class fo : ThreadStart
{
  internal fo(ThreadStart paramRunnable)
  {
  }

  public virtual void run()
  {
	CoreApplication.registerCurrentThread();
	this.a.run();
	CoreApplication.unregisterCurrentThread();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fo.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */