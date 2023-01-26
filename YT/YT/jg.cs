using System;

using View = android.view.View;

public sealed class jg : View.OnClickListener
{
  public jg(DateTime paramDate, DateTime paramCalendar, View.OnClickListener paramOnClickListener)
  {
  }

  public void onClick(View paramView)
  {
	this.a.setTime(this.b.getTimeInMillis());
	this.c.onClick(paramView);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */