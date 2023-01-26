namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$CacheRequestTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/cache_request");

	  public const string DATE = "request_date";

	  public const string DEFAULT_SORT_ORDER = "request ASC";

	  public const string ID = "_id";

	  public const string REQUEST = "request";

	  public const string RESPONSE = "response";

	  public const string TABLE = "cache_request";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$CacheRequestTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}