using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ru.yandex.taxi.client
{
	using TaxiResponse = ru.yandex.taxi.client.response.TaxiResponse;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class HttpUrlOfflineUtils : HttpUtils
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int a_Conflict;

	  private GeoPoint b;

	  private List<string> c = new List<string>();

	  private int d = 0;

	  private bool e = true;

	  public HttpUrlOfflineUtils(GeoPoint paramGeoPoint)
	  {
		this.b = paramGeoPoint;
		GeoPoint geoPoint = new GeoPoint(paramGeoPoint.Lat + 0.01D, paramGeoPoint.Lon);
		while (b < 5)
		{
		  this.c.Add("[" + geoPoint.Lon + "," + geoPoint.Lat + "]");
		  geoPoint.Lat = geoPoint.Lat - 0.002D;
		  b++;
		}
		this.c.Add("[" + paramGeoPoint.Lon + "," + paramGeoPoint.Lat + "]");
	  }

	  private string a(Random paramRandom, int paramInt)
	  {
		StringBuilder stringBuilder = new StringBuilder();
		for (sbyte b = 0; b < paramInt; b++)
		{
		  stringBuilder.Append("[" + (this.b.Lon + (paramRandom.Next(10000) % 20 - 10) / 5000.0D) + ", " + (this.b.Lat + (paramRandom.Next(10000) % 20 - 10) / 5000.0D) + "],");
		}
		stringBuilder.Length = stringBuilder.Length - 1;
		return stringBuilder.ToString();
	  }

	  public virtual bool BeforeSource
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2)
	  {
		StringBuilder stringBuilder;
		string str;
		TaxiResponse taxiResponse;
		Thread.Sleep(1000L);
		paramMap = null;
		Random random = new Random();
		if (paramString1.Contains("taxisearch"))
		{
		  int i = random.Next(10000);
		  int j = random.Next(10000);
		  this.a_Conflict++;
		  stringBuilder = (new StringBuilder()).Append("{\"source\":[").Append(this.b.Lon).Append(", ").Append(this.b.Lat).Append("], ").Append("\"free-cars\": [").Append(a(random, i % 15 + 1)).Append("], ").Append("\"busy-cars\": [").Append(a(random, j % 15 + 1)).Append("], ").Append("\"found\": \"");
		  if (this.a_Conflict == 2)
		  {
			j = 1;
		  }
		  else
		  {
			j = 0;
		  }
		  return new TaxiResponse(200, stringBuilder.Append(j).Append("\"}").ToString());
		}
		if (stringBuilder.contains("taxiontheway") && this.e)
		{
		  stringBuilder = (new StringBuilder()).Append("{\"taxi\": {\"parkid\": \"5\",\"name\":\"Ололо такси\",\"logo\":\"http://yandex.st/lego/_/X31pO5JJJKEifJ7sfvuf3mGeD_8.png\",\"phone\":\"+78123456435\"},\"cancelled\": \"0\",\"source\": [").Append(this.b.Lon).Append(", ").Append(this.b.Lat).Append("],").Append("\"car\": ");
		  List<string> arrayList = this.c;
		  int i = this.d;
		  this.d = i + 1;
		  StringBuilder stringBuilder1 = stringBuilder.Append(arrayList[i]).Append(",").Append("\"lastupdate\": \"2011-06-17T15:44:35\",").Append("\"tariff\": {\"tariffid\": \"568\",").Append("\"name\": \"Справедливый\"},").Append("\"arrived\": \"");
		  if (this.d == this.c.Count)
		  {
			str = "1";
		  }
		  else
		  {
			str = "0";
		  }
		  return new TaxiResponse(200, stringBuilder1.Append(str).Append("\"").Append("}").ToString());
		}
		if (str.Contains("taxiontheway") && !this.e)
		{
		  StringBuilder stringBuilder1 = (new StringBuilder()).Append("{\"taxi\": {\"parkid\": \"5\",\"name\":\"Ололо такси\",\"logo\":\"http://yandex.st/lego/_/X31pO5JJJKEifJ7sfvuf3mGeD_8.png\",\"phone\":\"+78123456435\"},\"cancelled\": \"0\",\"destinations\": [[").Append(this.b.Lon).Append(", ").Append(this.b.Lat).Append("]],").Append("\"user\": ");
		  List<string> arrayList = this.c;
		  int i = this.d;
		  this.d = i + 1;
		  StringBuilder stringBuilder2 = stringBuilder1.Append(arrayList[i]).Append(",").Append("\"lastupdate\": \"2011-06-17T15:44:35\",").Append("\"tariff\": {\"tariffid\": \"568\",").Append("\"name\": \"Справедливый\"},").Append("\"finished\": \"");
		  if (this.d == this.c.Count)
		  {
			str = "1";
		  }
		  else
		  {
			str = "0";
		  }
		  return new TaxiResponse(200, stringBuilder2.Append(str).Append("\"").Append("}").ToString());
		}
		if (str.Contains("pricecat"))
		{
		  return new TaxiResponse(200, "[{\"parkid\": \"1\", \"name\": \"Жёлтое такси\", \"tariffs\": [{\"class\":\"econom\", \"minimal\":\"150\", \"currency\":\"руб\", \"included\":\"10км\", \"other\":\"Делаем трололо\"},{\"class\":\"business\", \"minimal\":\"180\", \"currency\":\"руб\", \"included\":\"10км\", \"other\":\"Делаем трололо и тут\"}]}, {\"parkid\": \"2\", \"name\": \"Зелёное такси\", \"tariffs\": [{\"class\":\"norm\", \"minimal\":\"100\", \"currency\":\"руб\", \"included\":\"30 мин\", \"other\":\"Делаем трололо\"},{\"class\":\"business\", \"minimal\":\"230\", \"currency\":\"руб\", \"included\":\"30 мин\", \"other\":\"Делаем трололо и тут\"}]}, {\"parkid\": \"2\", \"name\": \"Голубое такси\", \"tariffs\": [{\"class\":\"norm\", \"minimal\":\"160\", \"currency\":\"руб\", \"included\":\"5 км\", \"other\":\"Делаем трололо\"},{\"class\":\"econom\", \"minimal\":\"30\", \"currency\":\"руб\", \"included\":\"5 км\", \"other\":\"Делаем трололо и тут\"}]}]");
		}
		if (str.Contains("parkdetails"))
		{
		  taxiResponse = new TaxiResponse(200, "{\"id\": \"park_id_1\",\"name\": \"Жёлтое такси\",\"logo\": \"http://yandex.st/lego/_/X31pO5JJJKEifJ7sfvuf3mGeD_8.png\",\"phone\": \"8(921)2345425\",\"car\": \"ВАЗ Vedor\",\"tariffs\": [{\"id\": \"tariff_1\",\"name\": \"Экономный\",\"class\": \"econom\",\"description\": {\"day\": {\"city\": [{\"name\": \"Параметр1\", \"value\": \"100 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"250 руб.\"}],\"region\": [{\"name\": \"Параметр1\", \"value\": \"100 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"250 руб.\"}],\"transfers\": [{\"name\": \"Внуково\", \"options\": [{\"name\": \"Параметр1\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"300 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"400 руб.\"}]},{\"name\": \"Домодедово\", \"options\": [{\"name\": \"ДПараметр1\", \"value\": \"200 руб.\"}, {\"name\": \"ДПараметр2\", \"value\": \"300 руб.\"}, {\"name\": \"ДПараметр3\", \"value\": \"400 руб.\"}]}],\"comment\": \"Дневной коментарий\"},\"night\": {\"city\": [{\"name\": \"НПараметр1\", \"value\": \"100 руб.\"}, {\"name\": \"НПараметр2\", \"value\": \"200 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"250 руб.\"}],\"region\": [{\"name\": \"НПараметр1\", \"value\": \"100 руб.\"}, {\"name\": \"НПараметр2\", \"value\": \"200 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"250 руб.\"}],\"transfers\": [{\"name\": \"НВнуково\", \"options\": [{\"name\": \"Параметр1\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"300 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"400 руб.\"}]},{\"name\": \"НДомодедово\", \"options\": [{\"name\": \"ДПараметр1\", \"value\": \"200 руб.\"}, {\"name\": \"ДПараметр2\", \"value\": \"300 руб.\"}, {\"name\": \"ДПараметр3\", \"value\": \"400 руб.\"}]}],\"comment\": \"Ночной коментарий\"},}},{\"id\": \"tariff_1\",\"name\": \"Неуёмный\",\"class\": \"business\",\"description\": {\"day\": {\"city\": [{\"name\": \"Параметр1\", \"value\": \"100 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"250 руб.\"}],\"region\": [{\"name\": \"Параметр1\", \"value\": \"100 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"250 руб.\"}],\"transfers\": [{\"name\": \"Внуково\", \"options\": [{\"name\": \"Параметр1\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"300 руб.\"}, {\"name\": \"Параметр3\", \"value\": \"400 руб.\"}]},{\"name\": \"Домодедово\", \"options\": [{\"name\": \"ДПараметр1\", \"value\": \"200 руб.\"}, {\"name\": \"ДПараметр2\", \"value\": \"300 руб.\"}, {\"name\": \"ДПараметр3\", \"value\": \"400 руб.\"}]}],\"comment\": \"Дневной коментарий\"},\"night\": {\"city\": [{\"name\": \"НПараметр1\", \"value\": \"100 руб.\"}, {\"name\": \"НПараметр2\", \"value\": \"200 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"250 руб.\"}],\"region\": [{\"name\": \"НПараметр1\", \"value\": \"100 руб.\"}, {\"name\": \"НПараметр2\", \"value\": \"200 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"250 руб.\"}],\"transfers\": [{\"name\": \"НВнуково\", \"options\": [{\"name\": \"Параметр1\", \"value\": \"200 руб.\"}, {\"name\": \"Параметр2\", \"value\": \"300 руб.\"}, {\"name\": \"НПараметр3\", \"value\": \"400 руб.\"}]},{\"name\": \"НДомодедово\", \"options\": [{\"name\": \"ДПараметр1\", \"value\": \"200 руб.\"}, {\"name\": \"ДПараметр2\", \"value\": \"300 руб.\"}, {\"name\": \"ДПараметр3\", \"value\": \"400 руб.\"}]}],\"comment\": \"Ночной коментарий\"},}}]}");
		}
		return taxiResponse;
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2, bool paramBoolean)
	  {
		return post(paramString1, paramMap, paramString2, false);
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\HttpUrlOfflineUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}