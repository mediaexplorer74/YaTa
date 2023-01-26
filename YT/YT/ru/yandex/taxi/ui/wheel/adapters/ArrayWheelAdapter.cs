namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;

	public class ArrayWheelAdapter<T> : AbstractWheelTextAdapter
	{
	  private T[] a;

	  public ArrayWheelAdapter(Context paramContext, T[] paramArrayOfT) : base(paramContext)
	  {
		this.a = paramArrayOfT;
	  }

	  public override CharSequence getItemText(int paramInt)
	  {
		if (paramInt >= 0 && paramInt < this.a.Length)
		{
		  T t = this.a[paramInt];
		  return (t is CharSequence) ? (CharSequence)t : t.toString();
		}
		return null;
	  }

	  public override int ItemsCount
	  {
		  get
		  {
			return this.a.Length;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\ArrayWheelAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}