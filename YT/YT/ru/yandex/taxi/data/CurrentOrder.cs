using System;

namespace ru.yandex.taxi.data
{
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class CurrentOrder
	{
	  public const string CANCELLED = "cancelled";

	  public const string DRIVING = "driving";

	  public const string FAILED = "failed";

	  public const string PENDING = "pending";

	  public const string SEARCH = "search";

	  public const string TRANSPORTING = "transporting";

	  public const string WAITING = "waiting";

	  public DateTime due;

	  public string orderId;

	  public string status;

	  public CurrentOrder(string paramString1, string paramString2, string paramString3)
	  {
		this.orderId = paramString1;
		this.status = paramString2;
		this.due = TaxiClient.DATE_FORMAT.parse(paramString3);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\CurrentOrder.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}