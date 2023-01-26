using JSONArray = org.json.JSONArray;
using TariffLimits = ru.yandex.taxi.data.TariffLimits;

public class qa : JSONArray
{
  public qa(TariffLimits paramTariffLimits)
  {
	string[] arrayOfString = this.a.getExcludeParks();
	int i = arrayOfString.Length;
	for (sbyte b = 0; b < i; b++)
	{
	  put(arrayOfString[b]);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qa.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */