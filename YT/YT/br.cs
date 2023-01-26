using System;

public sealed class br
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static string a_Conflict = "http://api.mobile.maps.yandex.net/mapkit";

  public static string a()
  {
	if ("100".StartsWith("$", StringComparison.Ordinal))
	{
		;
	}
	return "100";
  }

  public static string b()
  {
	return "${startup.server}".StartsWith("$", StringComparison.Ordinal) ? a_Conflict : "${startup.server}";
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\br.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */