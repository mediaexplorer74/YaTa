using JSONArray = org.json.JSONArray;

public class pw : JSONArray
{
  public pw(string[] paramArrayOfString)
  {
	if (this.a != null)
	{
	  if (this.a.length > 0)
	  {
		paramArrayOfString = this.a;
		int i = paramArrayOfString.Length;
		for (sbyte b = 0; b < i; b++)
		{
		  put(paramArrayOfString[b]);
		}
	  }
	}
	else
	{
	  put("econom");
	  put("vip");
	  put("business");
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */