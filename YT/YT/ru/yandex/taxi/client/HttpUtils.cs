namespace ru.yandex.taxi.client
{
	using TaxiResponse = ru.yandex.taxi.client.response.TaxiResponse;

	public interface HttpUtils
	{
	  TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2);

	  TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2, bool paramBoolean);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\HttpUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}