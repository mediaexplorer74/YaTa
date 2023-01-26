using Html = android.text.Html;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ArrayAdapter = android.widget.ArrayAdapter;
using TextView = android.widget.TextView;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;
using Tariff = ru.yandex.taxi.data.Tariff;

public class kx : ArrayAdapter
{
  public kx(ParkInfoActivity paramParkInfoActivity) : base(paramParkInfoActivity.getApplicationContext(), 2130903074, 2131558403)
  {
  }

  public virtual int Count
  {
	  get
	  {
		return ParkInfoActivity.f(this.a).getTariffsCount();
	  }
  }

  public virtual object getItem(int paramInt)
  {
	return ParkInfoActivity.f(this.a).getTariff(paramInt).getName();
  }

  public virtual long getItemId(int paramInt)
  {
	return paramInt;
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	bool @bool;
	View view = base.getView(paramInt, paramView, paramViewGroup);
	ky ky2 = (ky)view.getTag();
	ky ky1 = ky2;
	if (ky2 == null)
	{
	  ky1 = new ky();
	  ky1.a = (TextView)view.findViewById(2131558403);
	  view.setTag(ky1);
	}
	Tariff tariff = ParkInfoActivity.f(this.a).getTariff(paramInt);
	if (ParkInfoActivity.l(this.a) != null)
	{
	  @bool = ParkInfoActivity.l(this.a).checkClass(tariff.Clazz);
	}
	else
	{
	  @bool = false;
	}
	TextView textView = ky1.a;
	if (@bool)
	{
	  string str1 = string.Format("<b>{0}</b>", new object[] {tariff.Name});
	  textView.setText((CharSequence)Html.fromHtml(str1));
	  return view;
	}
	string str = tariff.Name;
	textView.setText((CharSequence)Html.fromHtml(str));
	return view;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\kx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */