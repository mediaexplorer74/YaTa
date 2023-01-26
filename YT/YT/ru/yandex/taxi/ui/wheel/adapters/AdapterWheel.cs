namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;
	using WheelAdapter = ru.yandex.taxi.ui.wheel.WheelAdapter;

	public class AdapterWheel : AbstractWheelTextAdapter
	{
	  private WheelAdapter a;

	  public AdapterWheel(Context paramContext, WheelAdapter paramWheelAdapter) : base(paramContext)
	  {
		this.a = paramWheelAdapter;
	  }

	  public virtual WheelAdapter Adapter
	  {
		  get
		  {
			return this.a;
		  }
	  }

	  protected internal override CharSequence getItemText(int paramInt)
	  {
		return this.a.getItem(paramInt);
	  }

	  public override int ItemsCount
	  {
		  get
		  {
			return this.a.ItemsCount;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\AdapterWheel.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}