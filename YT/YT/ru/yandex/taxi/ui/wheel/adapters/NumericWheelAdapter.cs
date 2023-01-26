using System;

namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;

	public class NumericWheelAdapter : AbstractWheelTextAdapter
	{
	  public const int DEFAULT_MAX_VALUE = 9;

	  private int a;

	  private int b;

	  private string c;

	  public NumericWheelAdapter(Context paramContext) : this(paramContext, 0, 9)
	  {
	  }

	  public NumericWheelAdapter(Context paramContext, int paramInt1, int paramInt2) : this(paramContext, paramInt1, paramInt2, null)
	  {
	  }

	  public NumericWheelAdapter(Context paramContext, int paramInt1, int paramInt2, string paramString) : base(paramContext)
	  {
		this.a = paramInt1;
		this.b = paramInt2;
		this.c = paramString;
	  }

	  public override CharSequence getItemText(int paramInt)
	  {
		if (paramInt >= 0 && paramInt < ItemsCount)
		{
		  paramInt = this.a + paramInt;
		  return (!string.ReferenceEquals(this.c, null)) ? String.format(this.c, new object[] {Convert.ToInt32(paramInt)}) : Convert.ToString(paramInt);
		}
		return null;
	  }

	  public override int ItemsCount
	  {
		  get
		  {
			return this.b - this.a + 1;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\NumericWheelAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}