using JSONArray = org.json.JSONArray;

public class pm : JSONArray
{
  public pm(string[] paramArrayOfString)
  {
	if (this.a != null)
	{
	  paramArrayOfString = this.a;
	  int i = paramArrayOfString.Length;
	  for (sbyte b = 0; b < i; b++)
	  {
		put(paramArrayOfString[b]);
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */