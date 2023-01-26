using Context = android.content.Context;
using ListAdapter = android.widget.ListAdapter;
using SearchResultsActivity = ru.yandex.taxi.activity.SearchResultsActivity;
using GeocodeResponse = ru.yandex.taxi.client.response.GeocodeResponse;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
using EndlessAdapter = ru.yandex.taxi.ui.wheel.adapters.EndlessAdapter;

public class lv : EndlessAdapter
{
  private GeocodeJsonObject c;

  private int d = 0;

  public lv(SearchResultsActivity paramSearchResultsActivity, Context paramContext, ListAdapter paramListAdapter, int paramInt, ly paramly) : base(paramContext, paramListAdapter, paramInt)
  {
  }

  protected internal override void appendCachedData()
  {
	this.a.a(this.c);
	this.c = null;
  }

  protected internal override bool cacheInBackground()
  {
	sbyte b;
	string str;
	int i;
	bool bool1 = false;
	this.d += 20;
	if (SearchResultsActivity.a(this.b).getCurrentTab() == 0)
	{
	  b = this.d;
	  str = "address";
	  i = 0;
	}
	else
	{
	  i = this.d;
	  str = "organization";
	  b = 0;
	}
	GeocodeResponse geocodeResponse = SearchResultsActivity.d(this.b).doGeosearch(SearchResultsActivity.b(this.b), SearchResultsActivity.c(this.b), b, i);
	this.c = new GeocodeJsonObject();
	if (geocodeResponse.Code == 200)
	{
	  GeocodeJsonObject geocodeJsonObject = geocodeResponse.GeocodeObject;
	  for (b = 0; b < geocodeJsonObject.Count; b++)
	  {
		GeocodeJsonObject geocodeJsonObject1 = geocodeJsonObject.getObject(b);
		if (str.Equals(geocodeJsonObject1.Type))
		{
		  this.c.addGeoObjects(geocodeJsonObject1);
		}
	  }
	}
	bool bool2 = bool1;
	if (this.c != null)
	{
	  bool2 = bool1;
	  if (this.c.Count > 0)
	  {
		bool2 = true;
	  }
	}
	return bool2;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */