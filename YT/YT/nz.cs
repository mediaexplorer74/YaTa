using System.Collections.Generic;

using LayoutInflater = android.view.LayoutInflater;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ArrayAdapter = android.widget.ArrayAdapter;
using RatingBar = android.widget.RatingBar;
using TextView = android.widget.TextView;
using TaxiListActivity = ru.yandex.taxi.activity.TaxiListActivity;
using Park = ru.yandex.taxi.data.Park;

public class nz : ArrayAdapter<Park>
{
  private List<Park> b = new List<Park>();

  private List<Park> c = new List<Park>();

  private int d = -1;

  private int e = -1;

  private int f;

  private LayoutInflater g;

  public nz(TaxiListActivity paramTaxiListActivity, List<Park> paramArrayList) : base(paramTaxiListActivity.getApplicationContext(), 2130903078, 2131558403)
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
	this.g = (LayoutInflater)paramTaxiListActivity.getSystemService("layout_inflater");
  }

  public virtual Park a(int paramInt)
  {
	sbyte b;
	if (paramInt == this.e || paramInt == this.d)
	{
	  return null;
	}
	if (this.b.Count > 0 && paramInt < this.b.Count + 1)
	{
	  return this.b[paramInt - 1];
	}
	int i = this.b.Count;
	if (this.b.Count > 0)
	{
	  b = 1;
	}
	else
	{
	  b = 0;
	}
	return this.c[paramInt - 1 - i - b];
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
	Park park;
	oc oc;
	bool @bool = true;
	switch (getItemViewType(paramInt))
	{
	  default:
		return paramView;
	  case 1:
		view2 = paramView;
		if (paramView == null)
		{
		  view2 = this.g.inflate(2130903078, null);
		  oc oc1 = new oc();
		  oc1.a = (TextView)view2.findViewById(2131558403);
		  oc1.d = (TextView)view2.findViewById(2131558496);
		  oc1.b = (RatingBar)view2.findViewById(2131558468);
		  oc1.c = view2.findViewById(2131558497);
		  oc1.b.setOnTouchListener(new oa());
		  view2.setTag(oc1);
		}
		oc = (oc)view2.getTag();
		if (this.b.Count > 0 && paramInt < this.b.Count + 1)
		{
		  park = this.b[paramInt - 1];
		}
		else
		{
		  sbyte b;
		  int i = this.b.Count;
		  if (this.b.Count > 0)
		  {
			b = 1;
		  }
		  else
		  {
			b = 0;
		  }
		  park = this.c[paramInt - 1 - i - b];
		}
		oc.a.setText(park.Name);
		if (!string.ReferenceEquals(park.Phone, null) && !"null".Equals(park.Phone))
		{
		  paramInt = @bool;
		}
		else
		{
		  paramInt = 0;
		}
		if (paramInt != 0)
		{
		  if (TaxiListActivity.d(this.a))
		  {
			oc.d.setText(this.a.getResources().getString(2131296339));
		  }
		  else
		  {
			oc.d.setText(park.Phone);
		  }
		}
		else
		{
		  oc.d.setText("");
		}
		if (park.Rating != 0.0D)
		{
		  oc.b.setRating((float)park.Rating);
		  oc.c.setVisibility(0);
		  oc.d.setVisibility(8);
		}
		else
		{
		  oc.c.setVisibility(8);
		  oc.d.setVisibility(0);
		}
		if (park.OrderAllowed || paramInt != 0)
		{
		  view2.setBackgroundResource(2130837511);
		}
		else
		{
		  view2.setBackgroundColor(-1);
		}
		view2.setPadding(10, 15, 10, 15);
		view1 = view2;
		  goto case 0;
	  case 0:
		break;
	}
	View view2 = view1;
	if (view1 == null)
	{
	  view2 = this.g.inflate(2130903072, null);
	  ob ob = new ob();
	  ob.a = (TextView)view2.findViewById(2131558403);
	  view2.setTag(ob);
	}
	if (paramInt == this.d)
	{
	  paramInt = 2131296537;
	}
	else
	{
	  paramInt = 2131296538;
	}
	((ob)view2.getTag()).a.setText(paramInt);
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


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\nz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */