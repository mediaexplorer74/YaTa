namespace ru.yandex.core
{
	public class MotionEventProxyNew : MotionEventProxy
	{
	  internal override long getHistoricalEventTime(int paramInt)
	  {
		return this.ev.getHistoricalEventTime(paramInt);
	  }

	  internal override float getHistoricalX(int paramInt1, int paramInt2)
	  {
		return this.ev.getHistoricalX(paramInt1, paramInt2);
	  }

	  internal override float getHistoricalY(int paramInt1, int paramInt2)
	  {
		return this.ev.getHistoricalY(paramInt1, paramInt2);
	  }

	  internal override int HistorySize
	  {
		  get
		  {
			return this.ev.getHistorySize();
		  }
	  }

	  internal override int PointerCount
	  {
		  get
		  {
			return this.ev.getPointerCount();
		  }
	  }

	  internal override float getX(int paramInt)
	  {
		return this.ev.getX(paramInt);
	  }

	  internal override float getY(int paramInt)
	  {
		return this.ev.getY(paramInt);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\MotionEventProxyNew.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}