using System.Threading;

public class e : ThreadFactory
{
  private static volatile int a = 0;

  public virtual Thread newThread(ThreadStart paramRunnable)
  {
	paramRunnable = new Thread(new fo(paramRunnable));
	a++;
	paramRunnable.setName("Web thread " + a);
	return (Thread)paramRunnable;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\e.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */