using Cursor = android.database.Cursor;
using FilterQueryProvider = android.widget.FilterQueryProvider;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using YandexSuggestProvider = ru.yandex.taxi.suggest.YandexSuggestProvider;

public class ml : FilterQueryProvider
{
  private ml(SearchStreetActivity paramSearchStreetActivity, sbyte paramByte)
  {
  }

  public virtual Cursor runQuery(CharSequence paramCharSequence)
  {
	return this.a.managedQuery(YandexSuggestProvider.CONTENT_URI, SearchStreetActivity.k(this.a), null, new string[] {paramCharSequence.ToString()}, "suggest_text_1 ASC");
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ml.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */