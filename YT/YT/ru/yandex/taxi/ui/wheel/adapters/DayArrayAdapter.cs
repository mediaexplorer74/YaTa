using System;

namespace ru.yandex.taxi.ui.wheel.adapters
{
	using Context = android.content.Context;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using TextView = android.widget.TextView;
	using Utils = ru.yandex.taxi.Utils;

	public class DayArrayAdapter : AbstractWheelTextAdapter
	{
	  private Locale a;

	  private DateTime b;

	  public DayArrayAdapter(Context paramContext, DateTime paramCalendar) : base(paramContext, 2130903042, 0)
	  {
		this.b = paramCalendar;
		this.a = Utils.CurrentLocale;
		ItemTextResource = 2131558410;
	  }

	  public override View getItem(int paramInt, View paramView, ViewGroup paramViewGroup)
	  {
		int i = -1;
		DateTime calendar = (DateTime)this.b.clone();
		calendar = calendar.AddDays(paramInt);
		paramView = base.getItem(paramInt, paramView, paramViewGroup);
		TextView textView = (TextView)paramView.findViewById(2131558409);
		if (paramInt == 0)
		{
		  textView.setText("");
		}
		else
		{
		  textView.setText((new SimpleDateFormat("EEE", this.a)).format(calendar));
		}
		textView = (TextView)paramView.findViewById(2131558410);
		if (paramInt == 0)
		{
		  textView.setText(2131296401);
		  if (paramInt < this.minDisabledItemsBorder || this.maxDisabledItemsBorder < paramInt)
		  {
			paramInt = -7829368;
		  }
		  else
		  {
			paramInt = -1;
		  }
		  textView.setTextColor(paramInt);
		  return paramView;
		}
		textView.setText((new SimpleDateFormat("d MMM", this.a)).format(calendar));
		if (paramInt < this.minDisabledItemsBorder || this.maxDisabledItemsBorder < paramInt)
		{
		  i = -7829368;
		}
		textView.setTextColor(i);
		return paramView;
	  }

	  protected internal override CharSequence getItemText(int paramInt)
	  {
		return "";
	  }

	  public override int ItemsCount
	  {
		  get
		  {
			return 8;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\wheel\adapters\DayArrayAdapter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}