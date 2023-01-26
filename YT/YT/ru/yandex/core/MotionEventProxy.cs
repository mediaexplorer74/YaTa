namespace ru.yandex.core
{
	using MotionEvent = android.view.MotionEvent;

	public abstract class MotionEventProxy
	{
	  internal MotionEvent ev;

	  internal static MotionEventProxy create()
	  {
		return (MotionEventProxy)((CoreApplication.SDK_INT >= 5) 
				? new MotionEventProxyNew() : new MotionEventProxyOld());
	  }

	  internal abstract long getHistoricalEventTime(int paramInt);

	  internal abstract float getHistoricalX(int paramInt1, int paramInt2);

	  internal abstract float getHistoricalY(int paramInt1, int paramInt2);

	  internal abstract int HistorySize {get;}

	  internal abstract int PointerCount {get;}

	  internal abstract float getX(int paramInt);

	  internal abstract float getY(int paramInt);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\MotionEventProxy.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}