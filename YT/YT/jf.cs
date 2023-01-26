using System;

using TextView = android.widget.TextView;
using OrderActivity = ru.yandex.taxi.activity.OrderActivity;
using OnWheelScrollListener = ru.yandex.taxi.ui.wheel.OnWheelScrollListener;
using WheelView = ru.yandex.taxi.ui.wheel.WheelView;

public sealed class jf : OnWheelScrollListener
{
  public jf(DateTime paramCalendar1, DateTime paramCalendar2, WheelView paramWheelView1, WheelView paramWheelView2, string[] paramArrayOfString, WheelView paramWheelView3, DateTime paramDate1, DateTime paramCalendar3, bool paramBoolean, DateTime paramDate2, DateTime paramCalendar4, SimpleDateFormat paramSimpleDateFormat1, SimpleDateFormat paramSimpleDateFormat2, TextView paramTextView, string paramString1, string paramString2, int paramInt)
  {
  }

  public void onScrollingFinished(WheelView paramWheelView)
  {
	SimpleDateFormat simpleDateFormat;
	this.a.setTime(this.b.getTime());
	this.a.add(6, this.c.getCurrentItem());
	this.a.set(11, this.d.getCurrentItem());
	this.a.set(12, int.Parse(this.e[this.f.getCurrentItem()]));
	if (this.g.after(this.a.getTime()))
	{
	  this.a.setTime(this.g);
	  if (this.h.get(5) != this.b.get(5) && this.c.getCurrentItem() == 0)
	  {
		this.c.setCurrentItem(1);
	  }
	  this.d.setCurrentItem(this.a.get(11));
	  this.f.setCurrentItem(this.a.get(12) / 5);
	}
	if (this.i && this.j.before(this.a.getTime()))
	{
	  this.a.setTime(this.j);
	  if (this.k.get(5) != this.b.get(5))
	  {
		this.c.setCurrentItem(1);
	  }
	  else
	  {
		this.c.setCurrentItem(0);
	  }
	  this.d.setCurrentItem(this.a.get(11));
	  this.f.setCurrentItem(this.a.get(12) / 5);
	}
	OrderActivity.a(this.a);
	DateTime date = this.a.getTime();
	OrderActivity.a(this.h, this.a, this.d, this.g, this.f, this.k, this.i);
	if (this.a.get(5) != this.b.get(5))
	{
	  simpleDateFormat = this.l;
	}
	else
	{
	  simpleDateFormat = this.m;
	}
	OrderActivity.a(date, this.n, this.o, this.p, this.m, simpleDateFormat, this.q);
  }

  public void onScrollingStarted(WheelView paramWheelView)
  {
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\jf.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */