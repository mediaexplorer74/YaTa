namespace ru.yandex.yandexmapkit.utils
{
	public class ScreenPoint
	{
	  private float a;

	  private float b;

	  public ScreenPoint()
	  {
	  }

	  public ScreenPoint(float paramFloat1, float paramFloat2)
	  {
		this.a = paramFloat1;
		this.b = paramFloat2;
	  }

	  public virtual float X
	  {
		  get
		  {
			return this.a;
		  }
		  set
		  {
			this.a = value;
		  }
	  }

	  public virtual float Y
	  {
		  get
		  {
			return this.b;
		  }
		  set
		  {
			this.b = value;
		  }
	  }


	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapki\\utils\ScreenPoint.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}