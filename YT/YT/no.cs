using ColorStateList = android.content.res.ColorStateList;
using View = android.view.View;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;

public class no : View.OnClickListener
{
  public no(TariffListActivity paramTariffListActivity, ColorStateList paramColorStateList1, ColorStateList paramColorStateList2)
  {
  }

  public virtual void onClick(View paramView)
  {
	int i = 2130837522;
	ColorStateList colorStateList = this.a;
	if (TariffListActivity.a(this.c).isNorm())
	{
	  if (TariffListActivity.b(this.c) > 1)
	  {
		TariffListActivity.a(this.c).removeClass("business");
		TariffListActivity.c(this.c);
		int j = 2130837521;
		ColorStateList colorStateList1 = this.b;
		colorStateList = colorStateList1;
		i = j;
		if (TariffListActivity.a(this.c).isBusiness())
		{
		  colorStateList = colorStateList1;
		  i = j;
		  if (TariffListActivity.a(this.c).isEconom())
		  {
			TariffListActivity.h(this.c).performClick();
			i = j;
			colorStateList = colorStateList1;
		  }
		}
	  }
	}
	else
	{
	  TariffListActivity.a(this.c).addClass("business");
	  TariffListActivity.d(this.c);
	}
	TariffListActivity.e(this.c).setBackgroundResource(i);
	TariffListActivity.e(this.c).setTextColor(colorStateList);
	TariffListActivity.g(this.c).invalidateViews();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\no.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */