namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$CityTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/city");

	  public const string DEFAULT_SORT_ORDER = "name ASC";

	  public const string ID = "_id";

	  public const string NAME = "name";

	  public const string SEARCH_NAME = "search_name";

	  public const string TABLE = "city";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$CityTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}