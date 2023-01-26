namespace ru.yandex.core
{
	public class MotionEventProxyOld : MotionEventProxy
	{
	  internal override long getHistoricalEventTime(int paramInt)
	  {
		throw new System.InvalidOperationException();
	  }

	  internal override float getHistoricalX(int paramInt1, int paramInt2)
	  {
		throw new System.InvalidOperationException();
	  }

	  internal override float getHistoricalY(int paramInt1, int paramInt2)
	  {
		throw new System.InvalidOperationException();
	  }

	  internal override int HistorySize
	  {
		  get
		  {
			return 0;
		  }
	  }

	  internal override int PointerCount
	  {
		  get
		  {
			return 1;
		  }
	  }

	  internal override float getX(int paramInt)
	  {
		return this.ev.getX();
	  }

	  internal override float getY(int paramInt)
	  {
		return this.ev.getY();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\MotionEventProxyOld.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}