using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.data
{
	using ru.yandex.taxi;

	[Serializable]
	public class Tariff$Transfer
	{
	  public string comment;

	  public string name;

	  public List<Pair<string, string>> price = new List<Pair<string, string>>();
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\data\Tariff$Transfer.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}