using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.data
{
	using ru.yandex.taxi;

	[Serializable]
	public class Tariff$TariffDescription
	{
	  public List<Pair<string, string>> airportToAirport = new List<Pair<string, string>>();

	  public List<Pair<string, string>> city = new List<Pair<string, string>>();

	  public string comment;

	  public List<Tariff$Transfer> fromAirport = new List<Tariff$Transfer>();

	  public List<Tariff$Transfer> other = new List<Tariff$Transfer>();

	  public List<Pair<string, string>> overprice = new List<Pair<string, string>>();

	  public List<Pair<string, string>> region = new List<Pair<string, string>>();

	  public List<Tariff$Schedule> schedules = new List<Tariff$Schedule>();

	  public string special;

	  public List<Tariff$Transfer> toAirport = new List<Tariff$Transfer>();

	  public List<Pair<string, string>> transferComments = new List<Pair<string, string>>();
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\Tariff$TariffDescription.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}