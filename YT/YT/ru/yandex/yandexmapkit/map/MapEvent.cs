namespace ru.yandex.yandexmapkit.map
{
	public class MapEvent
	{
	  public const int MSG_EMPTY = 0;

	  public const int MSG_LONG_PRESS = 10;

	  public const int MSG_SCALE_BEGIN = 7;

	  public const int MSG_SCALE_END = 9;

	  public const int MSG_SCALE_MOVE = 8;

	  public const int MSG_SCROLL_BEGIN = 1;

	  public const int MSG_SCROLL_END = 3;

	  public const int MSG_SCROLL_MOVE = 2;

	  public const int MSG_ZOOM_BEGIN = 4;

	  public const int MSG_ZOOM_END = 6;

	  public const int MSG_ZOOM_MOVE = 5;

	  private int a;

	  private readonly float b;

	  private readonly float c;

	  public MapEvent(int paramInt) : this(paramInt, 0.0F, 0.0F)
	  {
	  }

	  public MapEvent(int paramInt, float paramFloat1, float paramFloat2)
	  {
		this.a = paramInt;
		this.b = paramFloat1;
		this.c = paramFloat2;
	  }

	  public virtual int Msg
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  public virtual float X
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual float Y
	  {
		  get
		  {
			return this.c;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\map\MapEvent.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}