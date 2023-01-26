using JSONObject = org.json.JSONObject;

public class pu : JSONObject
{
  public pu(string[] paramArrayOfString1, string[] paramArrayOfString2)
  {
	for (sbyte b = 0; b < this.a.length; b++)
	{
	  if (this.b[b] != null && !"".Equals(this.b[b]))
	  {
		put(this.a[b], this.b[b]);
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */