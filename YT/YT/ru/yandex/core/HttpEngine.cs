using System.Threading;

namespace ru.yandex.core
{
	using e;

	public class HttpEngine
	{
	  internal static ThreadPoolExecutor executor = null;

	  public static void init()
	  {
		executor = new ThreadPoolExecutor(4, 2147483647, 20L, TimeUnit.SECONDS, 
			new SynchronousQueue<ThreadStart>(), (ThreadFactory)new e());
	  }

	  public static void start(HttpNativeExcange paramHttpNativeExcange)
	  {
		executor.execute(paramHttpNativeExcange);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\HttpEngine.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}