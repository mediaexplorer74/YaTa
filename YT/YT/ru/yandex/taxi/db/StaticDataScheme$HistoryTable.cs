namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$HistoryTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/history");

	  public const string DEFAULT_SORT_ORDER = "last_use DESC";

	  public const string ID = "_id";

	  public const string LAST_USE = "last_use";

	  public const string NAME = "name";

	  public const string POINT = "point";

	  public const string TABLE = "history";

	  public const string TYPE = "type";

	  public const int TYPE_CITY_FROM = 0;

	  public const int TYPE_CITY_TO = 2;

	  public const int TYPE_FAVORITE = 4;

	  public const int TYPE_STREET_FROM = 1;

	  public const int TYPE_STREET_TO = 3;

	  public const string VALUE = "value";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$HistoryTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}