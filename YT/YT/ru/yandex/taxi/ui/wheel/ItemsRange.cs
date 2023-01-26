namespace ru.yandex.taxi.ui.wheel
{
	public class ItemsRange
	{
	  private int a;

	  private int b;

	  public ItemsRange() : this(0, 0)
	  {
	  }

	  public ItemsRange(int paramInt1, int paramInt2)
	  {
		this.a = paramInt1;
		this.b = paramInt2;
	  }

	  public virtual bool contains(int paramInt)
	  {
		return (paramInt >= First && paramInt <= Last);
	  }

	  public virtual int Count
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual int First
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  public virtual int Last
	  {
		  get
		  {
			return First + Count - 1;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\ItemsRange.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}