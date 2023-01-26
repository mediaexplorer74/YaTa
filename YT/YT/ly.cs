using System;

using Context = android.content.Context;
using LayoutInflater = android.view.LayoutInflater;
using View = android.view.View;
using ViewGroup = android.view.ViewGroup;
using ArrayAdapter = android.widget.ArrayAdapter;
using TextView = android.widget.TextView;
using SearchResultsActivity = ru.yandex.taxi.activity.SearchResultsActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class ly : ArrayAdapter<string>
{
  private int b;

  private GeocodeJsonObject c;

  private LayoutInflater d;

  private string e;

  private string f;

  public ly(SearchResultsActivity paramSearchResultsActivity, Context paramContext, int paramInt1, int paramInt2, GeocodeJsonObject paramGeocodeJsonObject) : base(paramContext, paramInt1, paramInt2)
  {
	this.b = paramInt1;
	this.c = paramGeocodeJsonObject;
	this.d = (LayoutInflater)paramSearchResultsActivity.getSystemService("layout_inflater");
	this.e = paramSearchResultsActivity.getResources().getString(2131296348);
	this.f = paramSearchResultsActivity.getResources().getString(2131296349);
	paramGeocodeJsonObject.Type;
  }

  private static void a(View paramView)
  {
	lz lz = new lz();
	lz.a = (TextView)paramView.findViewById(2131558473);
	lz.b = (TextView)paramView.findViewById(2131558475);
	lz.c = (TextView)paramView.findViewById(2131558474);
	paramView.setTag(lz);
  }

  public virtual string a(int paramInt)
  {
	return this.c.getText(paramInt);
  }

  public virtual GeocodeJsonObject a()
  {
	return this.c;
  }

  public virtual void a(GeocodeJsonObject paramGeocodeJsonObject)
  {
	this.c.addGeoObjects(paramGeocodeJsonObject);
  }

  public virtual int Count
  {
	  get
	  {
		return this.c.Count;
	  }
  }

  public virtual View getView(int paramInt, View paramView, ViewGroup paramViewGroup)
  {
	string str1;
	View view = paramView;
	if (paramView == null)
	{
	  view = this.d.inflate(this.b, null);
	  a(view);
	}
	lz lz = (lz)view.getTag();
	if (lz == null)
	{
	  a(view);
	}
	string str2 = this.c.getName(paramInt);
	lz.a.setText(str2);
	string str3 = this.c.getText(paramInt);
	if (!string.ReferenceEquals(str3, null))
	{
	  int i = str3.IndexOf(str2, StringComparison.Ordinal);
	  int j = i;
	  if (i == -1)
	  {
		j = str3.LastIndexOf(",", StringComparison.Ordinal);
	  }
	  str1 = str3;
	  if (j >= 0)
	  {
		if (j == 0 && str3.Length > str2.Length + 2)
		{
		  str1 = str3.Substring(str2.Length + 2);
		}
		else
		{
		  str1 = str3;
		  if (j > 2)
		  {
			str1 = str3.Substring(0, j - 2);
		  }
		}
	  }
	}
	else
	{
	  str1 = "";
	}
	lz.b.setText(str1);
	if (SearchResultsActivity.c(this.a) != null)
	{
	  paramInt = this.c.getDistance(SearchResultsActivity.c(this.a), paramInt);
	  if (paramInt > 1000)
	  {
		str1 = String.format(this.e, new object[] {Convert.ToInt32(paramInt / 1000)});
	  }
	  else
	  {
		str1 = String.format(this.f, new object[] {(paramInt / 100) + "00"});
	  }
	  lz.c.setText(str1);
	}
	return view;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ly.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */