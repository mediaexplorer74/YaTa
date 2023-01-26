using Cursor = android.database.Cursor;
using DatabaseUtils = android.database.DatabaseUtils;
using FilterQueryProvider = android.widget.FilterQueryProvider;
using SearchCityActivity = ru.yandex.taxi.activity.SearchCityActivity;
using StaticDataScheme = ru.yandex.taxi.db.StaticDataScheme;

public class lu : FilterQueryProvider
{
  private lu(SearchCityActivity paramSearchCityActivity, sbyte paramByte)
  {
  }

  public virtual Cursor runQuery(CharSequence paramCharSequence)
  {
	if (paramCharSequence != null)
	{
	  paramCharSequence = "search_name LIKE " + DatabaseUtils.sqlEscapeString(paramCharSequence.ToString().ToLower() + "%");
	  return this.a.managedQuery(StaticDataScheme.CityTable.CONTENT_URI, SearchCityActivity.e(this.a), (string)paramCharSequence, null, "name ASC");
	}
	paramCharSequence = null;
	return this.a.managedQuery(StaticDataScheme.CityTable.CONTENT_URI, SearchCityActivity.e(this.a), (string)paramCharSequence, null, "name ASC");
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */