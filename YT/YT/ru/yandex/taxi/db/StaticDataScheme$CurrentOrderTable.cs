namespace ru.yandex.taxi.db
{
	using Uri = android.net.Uri;

	public sealed class StaticDataScheme$CurrentOrderTable
	{
	  public static readonly Uri CONTENT_URI = Uri.parse("content://ru.yandex.taxi/delay_order");

	  public const string DEFAULT_SORT_ORDER = "order_id ASC";

	  public const string FROM = "src";

	  public const string ID = "_id";

	  public const string ORDER_ID = "order_id";

	  public const string PARK_ID = "park_id";

	  public const string PARK_LOGO = "park_logo";

	  public const string PARK_NAME = "park_name";

	  public const string PARK_PHONE = "park_phone";

	  public const string TABLE = "delay_order";

	  public const string TARIFF_ID = "tariff_id";

	  public const string TO = "desc";
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\db\StaticDataScheme$CurrentOrderTable.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}