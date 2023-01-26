using System;

using View = android.view.View;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using SearchTaxiActivity = ru.yandex.taxi.activity.SearchTaxiActivity;

public class mq : View.OnClickListener
{
  public mq(SearchTaxiActivity paramSearchTaxiActivity, DateTime paramDate)
  {
  }

  public virtual void onClick(View paramView)
  {
	this.a.setSeconds(0);
	int i = (int)((this.a.getTime() - this.b.mWhen.getTime()) / 60L / 1000L);
	if (i != 0)
	{
	  if (i > 0)
	  {
		i = (int)Math.Ceiling(i / 5.0D) * 5;
	  }
	  else
	  {
		i = (int)Math.Floor(i / 5.0D) * 5;
	  }
	  string str = String.format(this.b.getResources().getString(2131296422), new object[] {OrderActivity.getDateString(this.b.getResources(), this.a, SearchTaxiActivity.h(this.b))});
	  (new nb(this.b, i, 2131296291, str, null, null)).execute((object[])new int?[0]);
	}
	this.b.removeDialog(4);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */