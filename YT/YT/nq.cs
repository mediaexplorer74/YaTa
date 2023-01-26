using System;
using System.Collections.Generic;

using LayoutInflater = android.view.LayoutInflater;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using BaseAdapter = android.widget.BaseAdapter;
using CheckBox = android.widget.CheckBox;
using TextView = android.widget.TextView;
using TariffListActivity = ru.yandex.taxi.activity.TariffListActivity;
using Park = ru.yandex.taxi.data.Park;

public class nq : BaseAdapter
{
  private List<Park> b = new List<Park>();

  private List<Park> c = new List<Park>();

  private int d = -1;

  private int e = -1;

  private int f;

  private LayoutInflater g;

  private Pattern h = Pattern.compile("^\\d+.*");

  public nq(TariffListActivity paramTariffListActivity, List<Park> paramArrayList)
  {
	foreach (Park park in paramArrayList)
	{
	  if ("taxipark".Equals(park.Type))
	  {
		this.b.Add(park);
		continue;
	  }
	  this.c.Add(park);
	}
	if (this.b.Count > 0)
	{
	  j = 0;
	}
	else
	{
	  j = -1;
	}
	this.d = j;
	int j = b;
	if (this.c.Count > 0)
	{
	  if (this.b.Count > 0)
	  {
		j = this.b.Count + 1;
	  }
	  else
	  {
		j = 0;
	  }
	}
	this.e = j;
	if (this.b.Count > 0)
	{
	  j = this.b.Count + 1;
	}
	else
	{
	  j = 0;
	}
	if (this.c.Count > 0)
	{
	  i = this.c.Count + 1;
	}
	this.f = j + i;
	TariffListActivity.a(paramTariffListActivity, new bool[paramArrayList.Count]);
	this.g = (LayoutInflater)paramTariffListActivity.getSystemService("layout_inflater");
  }

  public virtual Park a()
  {
	return null;
  }

  public virtual int Count
  {
	  get
	  {
		return this.f;
	  }
  }

  public virtual long getItemId(int paramInt)
  {
	return paramInt;
  }

  public virtual int getItemViewType(int paramInt)
  {
	return (paramInt == this.d || paramInt == this.e) ? 0 : 1;
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	CheckBox checkBox;
	string str1;
	nu nu;
	Park park;
	bool @bool;
	int i;
	int j;
	string str2;
	switch (getItemViewType(paramInt))
	{
	  default:
		return paramView;
	  case 1:
		view2 = paramView;
		if (paramView == null)
		{
		  view2 = this.g.inflate(2130903068, null);
		  nu nu1 = new nu();
		  nu1.b = (CheckBox)view2.findViewById(2131558492);
		  nu1.c = (TextView)view2.findViewById(2131558403);
		  nu1.d = (TextView)view2.findViewById(2131558493);
		  nu1.e = (TextView)view2.findViewById(2131558494);
		  view2.setTag(nu1);
		  view2.setClickable(true);
		  view2.setOnClickListener(new nr(this, nu1));
		}
		nu = (nu)view2.getTag();
		if (this.b.Count > 0 && paramInt < this.b.Count + 1)
		{
		  park = this.b[--paramInt];
		}
		else
		{
		  sbyte b;
		  int k = this.b.Count;
		  if (this.b.Count > 0)
		  {
			b = 1;
		  }
		  else
		  {
			b = 0;
		  }
		  paramInt = paramInt - 1 - k - b;
		  park = this.c[paramInt];
		  paramInt += this.b.Count;
		}
		nu.a = park.ParkId;
		nu.c.setText(park.Name);
		nu.b.setOnCheckedChangeListener(null);
		checkBox = nu.b;
		if (!TariffListActivity.a(this.a).checkExcludePark(park.ParkId))
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		checkBox.setChecked(@bool);
		str1 = "";
		i = park.getMinPrice(TariffListActivity.j(this.a), TariffListActivity.a(this.a));
		j = park.getMaxPrice(TariffListActivity.j(this.a), TariffListActivity.a(this.a));
		if (i != 0)
		{
		  string str4;
		  if (i == j)
		  {
			str2 = i + " " + park.Currency;
		  }
		  else
		  {
			str2 = i + " - " + j + " " + park.Currency;
		  }
		  str1 = park.getMinInclude(TariffListActivity.j(this.a), TariffListActivity.a(this.a)).Trim();
		  string str3 = park.getMaxInclude(TariffListActivity.j(this.a), TariffListActivity.a(this.a)).Trim();
		  if (str1.Equals(str3))
		  {
			str4 = str1;
		  }
		  else
		  {
			i = str1.IndexOf(" ", StringComparison.Ordinal);
			str4 = str1;
			if (i > 0)
			{
			  string str5 = str1.Substring(i);
			  string str6 = str3.Substring(str3.IndexOf(" ", StringComparison.Ordinal));
			  str4 = str1;
			  if (i > 0)
			  {
				str4 = str1;
				if (str5.Equals(str6))
				{
				  str4 = str1.Substring(0, i);
				}
			  }
			}
			string str = str4 + " - " + str3;
			str1 = str4;
			str4 = str;
		  }
		  Matcher matcher = this.h.matcher(str3.Trim());
		  if (this.h.matcher(str1.Trim()).matches())
		  {
			if (!matcher.matches())
			{
			  str1 = str3;
			}
			else
			{
			  str1 = "за " + str4;
			}
		  }
		  TariffListActivity.k(this.a)[paramInt] = nu.b.isChecked();
		  nu.b.setOnCheckedChangeListener(new ns(this, paramInt, park));
		  paramInt = -16777216;
		  nu.b.setEnabled(true);
		  nu.e.setVisibility(0);
		  view2.setClickable(true);
		}
		else
		{
		  TariffListActivity.k(this.a)[paramInt] = false;
		  str2 = this.a.getResources().getString(2131296536);
		  paramInt = this.a.getResources().getColor(2131230720);
		  nu.b.setEnabled(false);
		  nu.e.setVisibility(8);
		  view2.setClickable(false);
		}
		nu.c.setTextColor(paramInt);
		nu.d.setText(str2);
		nu.e.setText(str1);
		view1 = view2;
		  goto case 0;
	  case 0:
		break;
	}
	View view2 = view1;
	if (view1 == null)
	{
	  view2 = this.g.inflate(2130903072, null);
	  nt nt = new nt();
	  nt.a = (TextView)view2.findViewById(2131558403);
	  view2.setTag(nt);
	}
	if (paramInt == this.d)
	{
	  paramInt = 2131296537;
	}
	else
	{
	  paramInt = 2131296538;
	}
	((nt)view2.getTag()).a.setText(paramInt);
	View view1 = view2;
  }

  public virtual int ViewTypeCount
  {
	  get
	  {
		return 2;
	  }
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */