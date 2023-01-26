using System.Threading;

namespace ru.yandex.core
{
	using Handler = android.os.Handler;

	public class CoreApplication$KDTimer : ThreadStart
	{
	  internal Thread callerThread = Thread.CurrentThread;

	  internal long callerThreadId;

	  internal long delayTimeNs;

	  internal long eventuserptr;

	  internal Handler handler;

	  internal bool isCancelled;

	  internal bool isPeriodic;

	  internal long startTimeNs;

	  internal CoreApplication$KDTimer(bool paramBoolean, long paramLong1, long paramLong2, long paramLong3)
	  {
		this.callerThreadId = paramLong3;
		this.isPeriodic = paramBoolean;
		this.delayTimeNs = paramLong1;
		this.handler = new Handler();
		this.eventuserptr = paramLong2;
		this.isCancelled = false;
		this.startTimeNs = CoreApplication.access$100();
		shoot();
	  }

	  internal virtual void cancel()
	  {
		this.isCancelled = true;
	  }

	  public virtual void run()
	  {
		if (!this.isCancelled)
		{
		  CoreApplication.access$200(this.eventuserptr, this.callerThreadId);
		  if (this.isPeriodic)
		  {
			shoot();
		  }
		}
	  }

	  internal virtual void shoot()
	  {
		this.startTimeNs += this.delayTimeNs;
		long l1 = this.startTimeNs;
		long l2 = CoreApplication.access$100();
		this.handler.postDelayed(this, (l1 - l2) / 1000000L);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\CoreApplication$KDTimer.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}