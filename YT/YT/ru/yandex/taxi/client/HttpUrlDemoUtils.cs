using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ru.yandex.taxi.client
{
	using pj;
	using pk;
	using TaxiResponse = ru.yandex.taxi.client.response.TaxiResponse;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class HttpUrlDemoUtils : HttpUtils
	{
	  public static readonly GeocodeJsonObject DEST_ADDRESS;

	  public const string ORDER_ID = "123";

	  public const long REQUEST_DELAY = 1000L;

	  public static readonly GeocodeJsonObject SRC_ADDRESS;

	  private int a;

	  private List<string> b = (List<string>)new pj();

	  private List<string> c = (List<string>)new pk();

	  private string d = "[37.579165,55.725967],[37.56011,55.722673],[37.582083,55.74069],[37.607832,55.715697],[37.597189,55.765474],[37.571611,55.736215],[37.574873,55.699588],[37.654181,55.763324],[37.518911,55.788093],[37.678556,55.74435]";

	  private string e = "[37.585087,55.690595],[37.606373,55.757638],[37.543201,55.752604],[37.632637,55.743212],[37.617016,55.735174],[37.586117,55.769349]";

	  private int f = 0;

	  private int g = 0;

	  static HttpUrlDemoUtils()
	  {
		GeocodeJsonObject geocodeJsonObject = new GeocodeJsonObject();
		SRC_ADDRESS = geocodeJsonObject;
		geocodeJsonObject.GeoPoint = new GeoPoint(55.734288D, 37.589164D);
		geocodeJsonObject = new GeocodeJsonObject();
		DEST_ADDRESS = geocodeJsonObject;
		geocodeJsonObject.GeoPoint = new GeoPoint(55.757461D, 37.608606D);
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2)
	  {
		bool @bool = true;
		Thread.Sleep(1000L);
		if (paramString1.Contains("taxisearch"))
		{
		  this.a++;
		  StringBuilder stringBuilder = (new StringBuilder()).Append("{\"source\":[").Append(SRC_ADDRESS.GeoPoint.Lon).Append(", ").Append(SRC_ADDRESS.GeoPoint.Lat).Append("], ").Append("\"freecars\": [").Append(this.d).Append("], ").Append("\"busycars\": [").Append(this.e).Append("], ").Append("\"calibrate\": \"0\", ").Append("\"found\": \"");
		  if (this.a != 6)
		  {
			@bool = false;
		  }
		  return new TaxiResponse(200, stringBuilder.Append(@bool).Append("\"}").ToString());
		}
		if (paramString1.Contains("taxiontheway") && paramString2.Contains("break"))
		{
		  this.f++;
		  StringBuilder stringBuilder = (new StringBuilder()).Append("{\"taxi\": {\"parkid\": \"5\",\"name\":\"Taxi SMS\",\"logo\":\"2130837552\",\"phone\":\"+74955188555\"},\"cancelled\": \"0\",\"source\": [").Append(SRC_ADDRESS.GeoPoint.Lon).Append(", ").Append(SRC_ADDRESS.GeoPoint.Lat).Append("],").Append("\"car\": ").Append(this.b[this.f - 1]).Append(",").Append("\"lastupdate\": \"2011-06-17T15:44:35\",").Append("\"tariff\": {\"tariffid\": \"568\",").Append("\"name\": \"Справедливый\"},").Append("\"arrived\": \"");
		  if (this.f == this.b.Count)
		  {
			paramString1 = "1";
		  }
		  else
		  {
			paramString1 = "0";
		  }
		  return new TaxiResponse(200, stringBuilder.Append(paramString1).Append("\"").Append("}").ToString());
		}
		if (paramString1.Contains("taxiontheway"))
		{
		  this.f++;
		  StringBuilder stringBuilder = (new StringBuilder()).Append("{\"taxi\": {\"parkid\": \"5\",\"name\":\"Taxi SMS\",\"logo\":\"2130837552\",\"phone\":\"+74955188555\"},\"cancelled\": \"0\",\"destinations\": [[").Append(DEST_ADDRESS.GeoPoint.Lon).Append(", ").Append(DEST_ADDRESS.GeoPoint.Lat).Append("]],").Append("\"user\": ").Append(this.c[this.f - 1]).Append(",").Append("\"lastupdate\": \"2011-06-17T15:44:35\",").Append("\"tariff\": {\"tariffid\": \"568\",").Append("\"name\": \"Справедливый\"},").Append("\"finished\": \"");
		  if (this.f == this.b.Count)
		  {
			paramString1 = "1";
		  }
		  else
		  {
			paramString1 = "0";
		  }
		  return new TaxiResponse(200, stringBuilder.Append(paramString1).Append("\"").Append("}").ToString());
		}
		if (paramString1.Contains("taxiarrived"))
		{
		  this.g++;
		  StringBuilder stringBuilder = (new StringBuilder()).Append("{\"taxi\": {\"parkid\": \"5\",\"name\":\"Ололо такси\"},\"car\": \"Форд Мустанг\",\"color\": \"зелёный\",\"carplates\": \"ср812в\",\"driver\": \"Пётр Алексеевич\",\"driverphone\": \"+74955188555\",\"tariff\": {\"tariffid\": \"568\",\"name\": \"Справедливый\"},\"ontheway\": \"");
		  if (this.g > 1)
		  {
			paramString1 = "1";
		  }
		  else
		  {
			paramString1 = "0";
		  }
		  return new TaxiResponse(200, stringBuilder.Append(paramString1).Append("\",").Append("\"cancelled\": \"0\"").Append("}").ToString());
		}
		return null;
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2, bool paramBoolean)
	  {
		return post(paramString1, paramMap, paramString2, false);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\HttpUrlDemoUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}