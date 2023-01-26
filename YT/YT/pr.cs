using JSONObject = org.json.JSONObject;
using ru.yandex.taxi;

public class pr : JSONObject
{
  public pr(System.Collections.IList paramList)
  {
	foreach (Pair pair in this.a)
	{
	  put((string)pair.first, pair.second);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */