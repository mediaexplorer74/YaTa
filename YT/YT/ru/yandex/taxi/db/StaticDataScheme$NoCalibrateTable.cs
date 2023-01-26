namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$NoCalibrateTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/no_calibrate");

	  public const string DEFAULT_SORT_ORDER = "order_id ASC";

	  public const string DUE = "due";

	  public const string ID = "_id";

	  public const string ORDER_ID = "order_id";

	  public const string TABLE = "no_calibrate";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$NoCalibrateTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}