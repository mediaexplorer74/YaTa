namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$TaxiTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/taxi");

	  public const string DEFAULT_SORT_ORDER = "locality_name ASC, name ASC";

	  public const string ID = "_id";

	  public const string LOCALITY_NAME = "locality_name";

	  public const string NAME = "name";

	  public const string PHONE = "phone";

	  public const string TABLE = "taxi";

	  public const string TAXI_ID = "taxi_id";

	  public const string URL = "url";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$TaxiTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}