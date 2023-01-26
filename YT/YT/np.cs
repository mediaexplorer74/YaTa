using ColorStateList = android.content.res.ColorStateList;
using View = android.view.View;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;

public class np : View.OnClickListener
{
  public np(TariffListActivity paramTariffListActivity, ColorStateList paramColorStateList1, ColorStateList paramColorStateList2)
  {
  }

  public virtual void onClick(View paramView)
  {
	ColorStateList colorStateList1;
	int j;
	int i = 2130837522;
	ColorStateList colorStateList2 = this.a;
	if (TariffListActivity.a(this.c).isBusiness())
	{
	  colorStateList1 = colorStateList2;
	  j = i;
	  if (TariffListActivity.b(this.c) > 1)
	  {
		TariffListActivity.a(this.c).removeClass("vip");
		TariffListActivity.c(this.c);
		j = 2130837521;
		colorStateList1 = this.b;
	  }
	}
	else
	{
	  TariffListActivity.a(this.c).addClass("vip");
	  TariffListActivity.d(this.c);
	  colorStateList1 = colorStateList2;
	  j = i;
	  if (TariffListActivity.a(this.c).isEconom())
	  {
		colorStateList1 = colorStateList2;
		j = i;
		if (!TariffListActivity.a(this.c).isNorm())
		{
		  TariffListActivity.e(this.c).performClick();
		  colorStateList1 = colorStateList2;
		  j = i;
		}
	  }
	}
	TariffListActivity.h(this.c).setBackgroundResource(j);
	TariffListActivity.h(this.c).setTextColor(colorStateList1);
	TariffListActivity.g(this.c).invalidateViews();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\np.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */