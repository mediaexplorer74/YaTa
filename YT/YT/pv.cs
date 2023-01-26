using System.Collections.Generic;

public class pv : Dictionary<string, string>
{
  public pv(bool paramBoolean)
  {
	this["Content-Type"] = "application/json";
	this["Content-Encoding"] = "UTF-8";
	this["User-Agent"] = "android/340, build/\"${version.date}\"";
	if (this.a)
	{
	  this["Accept-Encoding"] = "gzip,deflate";
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */