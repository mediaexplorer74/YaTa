using System;

namespace ru.yandex.taxi.analytics
{
	using Build = android.os.Build;

	public sealed class Global
	{
	  public static readonly string APP_VERSION;

	  public static readonly string BUILD_CLID;

	  public static readonly string BUILD_NUMBER;

	  public const long FOLDER_FLAG_DENY_NOTIFICATIONS = 1L;

	  public static readonly string UUID_VERSION;

	  public static readonly string VERSION_DATE;

	  private static string a;

	  static Global()
	  {
		string str;
		if ("${version.app}".StartsWith("$", StringComparison.Ordinal))
		{
		  str = "0.11";
		}
		else
		{
		  str = "${version.app}";
		}
		APP_VERSION = str;
		if ("340".StartsWith("$", StringComparison.Ordinal))
		{
		  str = "9876";
		}
		else
		{
		  str = "340";
		}
		BUILD_NUMBER = str;
		if ("${version.date}".StartsWith("$", StringComparison.Ordinal))
		{
		  str = "32 мартобря 3001";
		}
		else
		{
		  str = "${version.date}";
		}
		VERSION_DATE = str;
		if ("1".StartsWith("$", StringComparison.Ordinal) || "1".Trim().Length == 0)
		{
		  str = null;
		}
		else
		{
		  str = "1";
		}
		BUILD_CLID = str;
		UUID_VERSION = "" + (int)(Convert.ToSingle(APP_VERSION) * 100.0F);
	  }

	  public static string Manufacturer
	  {
		  get
		  {
			if (string.ReferenceEquals(a, null))
			{
			  try
			  {
				System.Reflection.FieldInfo field = typeof(Build).GetField("MANUFACTURER");
				Build build = new Build();
				this();
				a = (string)field.get(build);
			  }
			  catch (Exception)
			  {
				a = "Unknown";
			  }
			}
			return a;
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\analytics\Global.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}