using System;
using System.Collections.Generic;

using Context = android.content.Context;
using Resources = android.content.res.Resources;
using Cursor = android.database.Cursor;
using LayoutInflater = android.view.LayoutInflater;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ImageView = android.widget.ImageView;
using SimpleCursorAdapter = android.widget.SimpleCursorAdapter;
using TextView = android.widget.TextView;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class mi : SimpleCursorAdapter
{
  private string b;

  private string c;

  private string d;

  private string e;

  private string f;

  private string[] g;

  private List<string> h = new List<string>();

  private int i;

  private int j;

  private int k;

  private int l;

  private int m;

  private LayoutInflater n;

  private int o;

  public mi(SearchStreetActivity paramSearchStreetActivity, Context paramContext, int paramInt, Cursor paramCursor, string[] paramArrayOfString, int[] paramArrayOfint) : base(paramContext, paramInt, paramCursor, paramArrayOfString, paramArrayOfint)
  {
	this.g = paramArrayOfString;
	Resources resources = paramSearchStreetActivity.getResources();
	this.b = resources.getString(2131296353);
	this.c = resources.getString(2131296347);
	this.d = resources.getString(2131296346);
	this.e = resources.getString(2131296348);
	this.f = resources.getString(2131296349);
	if (SearchStreetActivity.d(paramSearchStreetActivity) == 0)
	{
	  paramInt = 2130837583;
	}
	else
	{
	  paramInt = 2130837584;
	}
	this.m = paramInt;
	this.n = (LayoutInflater)paramSearchStreetActivity.getSystemService("layout_inflater");
	this.o = base.getCount();
	if (!SearchStreetActivity.b(paramSearchStreetActivity))
	{
	  if (SearchStreetActivity.l(paramSearchStreetActivity).getCount() > 0)
	  {
		paramInt = 2;
	  }
	  else
	  {
		paramInt = 0;
	  }
	  this.j = paramInt;
	  if (SearchStreetActivity.m(paramSearchStreetActivity).size() > 0)
	  {
		paramInt = b1;
		if (this.j > 0)
		{
		  paramInt = this.j + SearchStreetActivity.l(paramSearchStreetActivity).getCount() + 1;
		}
		this.l = paramInt;
	  }
	  if (paramCursor.getCount() > 0)
	  {
		if (this.l > 0)
		{
		  this.k = this.l + SearchStreetActivity.m(paramSearchStreetActivity).size() + 1;
		}
		else
		{
		  if (this.j > 0)
		  {
			paramInt = 1;
		  }
		  else
		  {
			paramInt = 0;
		  }
		  this.k = paramInt + 2 + SearchStreetActivity.l(paramSearchStreetActivity).getCount();
		}
	  }
	  if (this.k > 0)
	  {
		paramInt = 1;
	  }
	  else
	  {
		paramInt = 0;
	  }
	  if (this.j > 0)
	  {
		b1 = 1;
	  }
	  else
	  {
		b1 = 0;
	  }
	  if (this.l <= 0)
	  {
		b2 = 0;
	  }
	  this.i = paramInt + b1 + b2;
	  this.o += this.i + 2 + SearchStreetActivity.l(paramSearchStreetActivity).getCount() + SearchStreetActivity.m(paramSearchStreetActivity).size();
	}
  }

  public virtual int Count
  {
	  get
	  {
		return SearchStreetActivity.b(this.a) ? ((base.getCount() > 0) ? base.getCount() : 1) : this.o;
	  }
  }

  public virtual object getItem(int paramInt)
  {
	return SearchStreetActivity.b(this.a) ? ((getCursor().getCount() > 0) ? this.h[paramInt] : this.b) : base.getItem(paramInt);
  }

  public virtual long getItemId(int paramInt)
  {
	// Byte code:
	//   0: lconst_0
	//   1: lstore_2
	//   2: iload_1
	//   3: aload_0
	//   4: getfield k : I
	//   7: if_icmple -> 34
	//   10: aload_0
	//   11: getfield k : I
	//   14: ifle -> 34
	//   17: aload_0
	//   18: iload_1
	//   19: aload_0
	//   20: getfield k : I
	//   23: isub
	//   24: iconst_1
	//   25: isub
	//   26: invokespecial getItemId : (I)J
	//   29: lstore #4
	//   31: lload #4
	//   33: lreturn
	//   34: lload_2
	//   35: lstore #4
	//   37: aload_0
	//   38: getfield j : I
	//   41: ifle -> 31
	//   44: lload_2
	//   45: lstore #4
	//   47: iload_1
	//   48: aload_0
	//   49: getfield j : I
	//   52: if_icmple -> 31
	//   55: iload_1
	//   56: aload_0
	//   57: getfield k : I
	//   60: if_icmplt -> 73
	//   63: lload_2
	//   64: lstore #4
	//   66: aload_0
	//   67: getfield k : I
	//   70: ifne -> 31
	//   73: iload_1
	//   74: aload_0
	//   75: getfield l : I
	//   78: if_icmplt -> 91
	//   81: lload_2
	//   82: lstore #4
	//   84: aload_0
	//   85: getfield l : I
	//   88: ifne -> 31
	//   91: aload_0
	//   92: getfield a : Lru/yandex/taxi/activity/SearchStreetActivity;
	//   95: invokestatic l : (Lru/yandex/taxi/activity/SearchStreetActivity;)Landroid/database/Cursor;
	//   98: iload_1
	//   99: aload_0
	//   100: getfield j : I
	//   103: isub
	//   104: iconst_1
	//   105: isub
	//   106: invokeinterface moveToPosition : (I)Z
	//   111: pop
	//   112: aload_0
	//   113: getfield a : Lru/yandex/taxi/activity/SearchStreetActivity;
	//   116: invokestatic l : (Lru/yandex/taxi/activity/SearchStreetActivity;)Landroid/database/Cursor;
	//   119: iconst_0
	//   120: invokeinterface getLong : (I)J
	//   125: lstore #4
	//   127: goto -> 31
  }

  public virtual int getItemViewType(int paramInt)
  {
	sbyte b = 1;
	if (!SearchStreetActivity.b(this.a))
	{
	  if (paramInt < 2)
	  {
		return 0;
	  }
	  if (paramInt == this.k || paramInt == this.j || paramInt == this.l)
	  {
		return 2;
	  }
	  sbyte b1 = b;
	  if (SearchStreetActivity.m(this.a).size() > 0)
	  {
		b1 = b;
		if (paramInt > this.l)
		{
		  if (paramInt >= this.k)
		  {
			b1 = b;
			return (this.k == 0) ? 4 : b1;
		  }
		}
		else
		{
		  return b1;
		}
	  }
	  else
	  {
		return b1;
	  }
	}
	else
	{
	  if (getCursor() != null)
	  {
		sbyte b2 = b;
		if (getCursor().getCount() == 0)
		{
		  b2 = 3;
		}
		return b2;
	  }
	  sbyte b1 = 3;
	}
	return 4;
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	mk mk2;
	string str;
	View view1;
	View view4;
	mk mk4;
	View view3;
	View view2;
	int i;
	mk mk6;
	GeocodeJsonObject geocodeJsonObject = null;
	switch (getItemViewType(paramInt))
	{
	  default:
		return null;
	  case 0:
		view4 = paramView;
		if (paramView == null)
		{
		  view4 = this.n.inflate(2130903064, null);
		}
		mk2 = (mk)view4.getTag();
		mk5 = mk2;
		if (mk2 == null)
		{
		  mk5 = new mk();
		  mk5.a = (TextView)view4.findViewById(2131558473);
		  view4.setTag(mk5);
		}
		str = this.c;
		i = this.m;
		switch (paramInt)
		{
		  default:
			paramInt = i;
			mk5.a.setText(str);
			mk5.a.setCompoundDrawablesWithIntrinsicBounds(paramInt, 0, 0, 0);
			return view4;
		  case 0:
			str = this.d;
			paramInt = 2130837580;
			mk5.a.setText(str);
			mk5.a.setCompoundDrawablesWithIntrinsicBounds(paramInt, 0, 0, 0);
			return view4;
		  case 1:
			break;
		}
		str = this.c;
		paramInt = this.m;
		mk5.a.setText(str);
		mk5.a.setCompoundDrawablesWithIntrinsicBounds(paramInt, 0, 0, 0);
		return view4;
	  case 1:
		if (SearchStreetActivity.b(this.a))
		{
		  string str1 = str;
		  if (string.ReferenceEquals(str, null))
		  {
			view3 = this.n.inflate(2130903064, null);
		  }
		}
		else
		{
		  string str1 = str;
		  if (string.ReferenceEquals(str, null))
		  {
			view4 = this.n.inflate(2130903065, null);
		  }
		}
		mk6 = (mk)view4.getTag();
		if (mk6 == null)
		{
		  mk6 = new mk();
		  mk6.a = (TextView)view4.findViewById(2131558473);
		  mk6.b = (TextView)view4.findViewById(2131558474);
		  mk6.c = (ImageView)view4.findViewById(2131558402);
		  view4.setTag(mk6);
		}
		if (SearchStreetActivity.b(this.a) || (getCursor().getCount() > 0 && paramInt > this.k))
		{
		  Cursor cursor = getCursor();
		  if (SearchStreetActivity.b(this.a))
		  {
			this.h.Clear();
			cursor.moveToFirst();
			while (!cursor.isAfterLast())
			{
			  this.h.Add(cursor.getString(cursor.getColumnIndex(this.g[0])));
			  cursor.moveToNext();
			}
			this.h.Sort();
			cursor.moveToPosition(paramInt);
		  }
		  else
		  {
			int j = paramInt - this.k - 1;
			i = j;
			if (j >= cursor.getCount())
			{
			  i = cursor.getCount() - 1;
			}
			cursor.moveToPosition(i);
			geocodeJsonObject = new GeocodeJsonObject(cursor.getString(cursor.getColumnIndex("value")));
		  }
		}
		else if (SearchStreetActivity.l(this.a).getCount() > 0)
		{
		  Cursor cursor = SearchStreetActivity.l(this.a);
		  int j = paramInt - this.j - 1;
		  i = j;
		  if (j > cursor.getCount())
		  {
			i = cursor.getCount() - 1;
		  }
		  cursor.moveToPosition(i);
		  geocodeJsonObject = new GeocodeJsonObject(SearchStreetActivity.l(this.a).getString(SearchStreetActivity.l(this.a).getColumnIndex("value")));
		}
		else
		{
		  mk5 = null;
		}
		view1 = view4;
		if (mk5 != null)
		{
		  if (SearchStreetActivity.b(this.a))
		  {
			List<string> arrayList = this.h;
			i = paramInt;
			if (paramInt >= this.h.Count)
			{
			  i = this.h.Count - 1;
			}
			string str2 = arrayList[i];
			mk6.a.setText(str2.replaceAll("--", ","));
			return view4;
		  }
		  string str1 = mk5.getString(mk5.getColumnIndex(this.g[0]));
		  paramInt = mk5.getInt(mk5.getColumnIndex("_id"));
		  mk6.a.setText(str1);
		  mk6.c.setVisibility(0);
		  mk6.c.setOnClickListener(new mj(this, geocodeJsonObject, paramInt));
		  View view = view4;
		  if (SearchStreetActivity.e(this.a) != null)
		  {
			string str2 = mk5.getString(mk5.getColumnIndex(this.g[1]));
			view = view4;
			if (!"0--0".Equals(str2))
			{
			  string str3;
			  string[] arrayOfString = str2.Split("--", true);
			  paramInt = (int)CoordConversion.getDistance(new GeoPoint(Convert.ToDouble(arrayOfString[0]), Convert.ToDouble(arrayOfString[1])), SearchStreetActivity.e(this.a));
			  if (paramInt > 1000)
			  {
				str3 = String.format(this.e, new object[] {Convert.ToInt32(paramInt / 1000)});
			  }
			  else
			  {
				str3 = String.format(this.f, new object[] {Convert.ToInt32(paramInt / 100 * 100)});
			  }
			  mk6.b.setText(str3);
			  view1 = view4;
			}
		  }
		}
		return view1;
	  case 2:
		view4 = view1;
		if (view1 == null)
		{
		  view4 = this.n.inflate(2130903072, null);
		}
		mk5 = (mk)view4.getTag();
		mk1 = mk5;
		if (mk5 == null)
		{
		  mk1 = new mk();
		  mk1.a = (TextView)view4.findViewById(2131558403);
		  view4.setTag(mk1);
		}
		if (paramInt == this.k)
		{
		  i = 2131296350;
		  paramInt = 2130837577;
		}
		else if (paramInt == this.j)
		{
		  i = 2131296351;
		  paramInt = 2130837575;
		}
		else
		{
		  i = 2131296352;
		  paramInt = 2130837565;
		}
		mk1.a.setText(i);
		mk1.a.setCompoundDrawablesWithIntrinsicBounds(paramInt, 0, 0, 0);
		return view4;
	  case 3:
		mk4 = mk1;
		if (mk1 == null)
		{
		  view3 = this.n.inflate(2130903064, null);
		}
		mk5 = (mk)view3.getTag();
		mk1 = mk5;
		if (mk5 == null)
		{
		  view3.setBackgroundColor(-1);
		  view3.setClickable(false);
		  mk1 = new mk();
		  mk1.a = (TextView)view3.findViewById(2131558473);
		  mk1.a.setSingleLine(false);
		  view3.setTag(mk1);
		}
		mk1.a.setText(this.b);
		return view3;
	  case 4:
		break;
	}
	mk mk3 = mk1;
	if (mk1 == null)
	{
	  view2 = this.n.inflate(2130903064, null);
	}
	mk mk5 = (mk)view2.getTag();
	mk mk1 = mk5;
	if (mk5 == null)
	{
	  mk1 = new mk();
	  mk1.a = (TextView)view2.findViewById(2131558473);
	  mk1.a.setSingleLine(false);
	  view2.setTag(mk1);
	}
	mk1.a.setText(((GeocodeJsonObject)SearchStreetActivity.m(this.a).get(paramInt - this.l - 1)).Name);
	return view2;
  }

  public virtual int ViewTypeCount
  {
	  get
	  {
		return 5;
	  }
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\mi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */