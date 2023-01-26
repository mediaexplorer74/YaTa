using JSONObject = org.json.JSONObject;
using ru.yandex.taxi;
using Requirements = ru.yandex.taxi.data.Requirements;

public class qb : JSONObject
{
  public qb(Requirements paramRequirements)
  {
	foreach (Pair pair in this.a.getRushPairs())
	{
	  put((string)pair.first, pair.second);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\qb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */