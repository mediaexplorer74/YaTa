using System;
using System.Collections.Generic;

using Context = android.content.Context;
using Intent = android.content.Intent;
using Resources = android.content.res.Resources;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using BaseAdapter = android.widget.BaseAdapter;
using TextView = android.widget.TextView;
using ru.yandex.taxi;
using ParkInfoActivity = ru.yandex.taxi.activity.ParkInfoActivity;
using TransferActivity = ru.yandex.taxi.activity.TransferActivity;
using TransferListActivity = ru.yandex.taxi.activity.TransferListActivity;
using Tariff = ru.yandex.taxi.data.Tariff;

public class ks : BaseAdapter
{
  public string a;

  public string b;

  public string c;

  public string d;

  public string e;

  public List<string> f;

  private Tariff h;

  private Tariff.TariffDescription i;

  private int j;

  private List<int> k = new List<int>();

  private int l;

  public ks(ParkInfoActivity paramParkInfoActivity, Tariff paramTariff, int paramInt)
  {
	this.h = paramTariff;
	this.i = paramTariff.getInterval(paramInt);
	if (this.i.special == null)
	{
	  paramInt = 0;
	}
	else
	{
	  paramInt = 1;
	}
	this.j = paramInt;
	Resources resources = paramParkInfoActivity.getResources();
	this.f = new List<string>();
	this.a = resources.getString(2131296554);
	this.b = resources.getString(2131296555);
	this.c = resources.getString(2131296556);
	this.d = resources.getString(2131296557);
	this.e = resources.getString(2131296546);
	if (this.i.toAirport.size() > 0)
	{
	  this.f.Add(this.a);
	}
	if (this.i.fromAirport.size() > 0)
	{
	  this.f.Add(this.b);
	}
	if (this.i.airportToAirport.size() > 0)
	{
	  this.f.Add(this.c);
	}
	if (this.i.other.size() > 0)
	{
	  this.f.Add(this.d);
	}
	if (this.i.transferComments.size() > 0)
	{
	  this.f.Add(this.e);
	}
	this.l = this.i.city.size() + 4 + this.i.region.size() + this.f.Count + this.i.overprice.size() + this.j;
	this.k.Add(Convert.ToInt32(this.j));
	this.k.Add(Convert.ToInt32(((int?)this.k[0]).Value + this.i.city.size() + 1));
	this.k.Add(Convert.ToInt32(((int?)this.k[1]).Value + this.i.region.size() + 1));
	this.k.Add(Convert.ToInt32(((int?)this.k[2]).Value + this.f.Count + 1));
  }

  public virtual int Count
  {
	  get
	  {
		return this.l;
	  }
  }

  public virtual object getItem(int paramInt)
  {
	return null;
  }

  public virtual long getItemId(int paramInt)
  {
	return 0L;
  }

  public virtual int getItemViewType(int paramInt)
  {
	return this.k.Contains(Convert.ToInt32(paramInt)) ? 0 : ((paramInt == 0 && this.j == 1) ? 3 : ((paramInt < ((int?)this.k[2]).Value || paramInt > ((int?)this.k[3]).Value) ? 1 : 2));
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	ku ku1;
	Pair pair1;
	kv kv1;
	Intent intent;
	View view3;
	ku ku2;
	View view2;
	Pair pair2;
	ku ku3;
	View view4;
	paramViewGroup = null;
	switch (getItemViewType(paramInt))
	{
	  default:
		return paramView;
	  case 3:
		view3 = paramView;
		if (paramView == null)
		{
		  view3 = ParkInfoActivity.n(this.g).inflate(2130903070, null);
		  ku1 = new ku();
		  ku1.a = (TextView)view3.findViewById(2131558403);
		  view3.setTag(ku1);
		}
		((ku)view3.getTag()).a.setText(this.i.special);
		return view3;
	  case 1:
		ku2 = ku1;
		if (ku1 == null)
		{
		  view2 = ParkInfoActivity.n(this.g).inflate(2130903069, null);
		  ku1 = new ku();
		  ku1.a = (TextView)view2.findViewById(2131558403);
		  ku1.b = (TextView)view2.findViewById(2131558457);
		  view2.setTag(ku1);
		}
		if (paramInt < ((int?)this.k[1]).Value)
		{
		  pair1 = this.i.city.get(paramInt - ((int?)this.k[0]).Value - 1);
		}
		else if (paramInt < ((int?)this.k[2]).Value)
		{
		  pair1 = this.i.region.get(paramInt - ((int?)this.k[1]).Value - 1);
		}
		else
		{
		  pair1 = this.i.overprice.get(paramInt - ((int?)this.k[3]).Value - 1);
		}
		ku3 = (ku)view2.getTag();
		ku3.a.setText((CharSequence)pair1.first);
		ku3.b.setText((CharSequence)pair1.second);
		return view2;
	  case 0:
		pair2 = pair1;
		if (pair1 == null)
		{
		  view1 = ParkInfoActivity.n(this.g).inflate(2130903072, null);
		  kv1 = new kv();
		  kv1.a = (TextView)view1.findViewById(2131558403);
		  view1.setTag(kv1);
		}
		if (paramInt == ((int?)this.k[0]).Value)
		{
		  paramInt = 2131296542;
		}
		else if (paramInt == ((int?)this.k[1]).Value)
		{
		  paramInt = 2131296543;
		}
		else if (paramInt == ((int?)this.k[2]).Value)
		{
		  paramInt = 2131296544;
		}
		else
		{
		  paramInt = 2131296545;
		}
		((kv)view1.getTag()).a.setText(paramInt);
		return view1;
	  case 2:
		break;
	}
	kv kv2 = kv1;
	if (kv1 == null)
	{
	  view4 = ParkInfoActivity.n(this.g).inflate(2130903071, null);
	  kw kw = new kw();
	  kw.a = (TextView)view4.findViewById(2131558403);
	  view4.setTag(kw);
	}
	int i = ((int?)this.k[2]).Value;
	string str = this.f[paramInt - i - 1];
	if (this.a.Equals(str))
	{
	  intent = new Intent((Context)this.g, typeof(TransferListActivity));
	  intent.putExtra("transfers", this.i.toAirport);
	}
	else if (this.d.Equals(str))
	{
	  intent = new Intent((Context)this.g, typeof(TransferActivity));
	  intent.putExtra("transfers", this.i.other);
	}
	else if (this.b.Equals(str))
	{
	  intent = new Intent((Context)this.g, typeof(TransferListActivity));
	  intent.putExtra("transfers", this.i.fromAirport);
	}
	else if (this.c.Equals(str))
	{
	  intent = new Intent((Context)this.g, typeof(TransferActivity));
	  intent.putExtra("transfers", this.i.airportToAirport);
	}
	else
	{
	  View view = view1;
	  if (this.e.Equals(str))
	  {
		intent = new Intent((Context)this.g, typeof(TransferActivity));
		intent.putExtra("transfers", this.i.transferComments);
	  }
	}
	View view1 = view4;
	if (intent != null)
	{
	  intent.putExtra("name", str);
	  intent.putExtra("currency", this.h.Currency);
	  view4.setOnClickListener(new kt(this, intent));
	  ((kw)view4.getTag()).a.setText(str);
	  view1 = view4;
	}
	return view1;
  }

  public virtual int ViewTypeCount
  {
	  get
	  {
		return 4;
	  }
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ks.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */