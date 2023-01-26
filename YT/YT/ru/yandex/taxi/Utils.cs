using System.Collections.Generic;

namespace ru.yandex.taxi
{
	using Activity = android.app.Activity;
	using Context = android.content.Context;
	using Build = android.os.Build;
	using Settings = android.provider.Settings;
	using TelephonyManager = android.telephony.TelephonyManager;
	using fp;

	public class Utils
	{
	  private static Locale a;

	  private static readonly List<string> b = (List<string>)new fp();

	  public static Locale CurrentLocale
	  {
		  get
		  {
			if (a == null)
			{
			  a = new Locale("ru");
			}
			return a;
		  }
	  }

	  public static string getDeviceId(Context paramContext)
	  {
		TelephonyManager telephonyManager = (TelephonyManager)paramContext.getSystemService("phone");
		string str = "" + telephonyManager.getDeviceId();
		return (new System.Guid(("" + Settings.Secure.getString(paramContext.getContentResolver(), "android_id")).GetHashCode(), str.GetHashCode() << 32L | "null".GetHashCode())).ToString().replaceAll("-", "");
	  }

	  public static string getFormatedPhoneNumber(string paramString)
	  {
		string str = paramString.replaceAll("\\+", "");
		paramString = "+" + str.Substring(0, 1);
		int i = (str.Length - 1) / 3;
		int j = i;
		if ((str.Length - 1) % 3 == 1)
		{
		  j = i - 1;
		}
		for (i = 0; i < j; i++)
		{
		  paramString = paramString + " " + str.Substring(i * 3 + 1, (i * 3 + 4) - (i * 3 + 1));
		}
		if (j * 3 + 1 != str.Length)
		{
		  paramString = paramString + " " + str.Substring(j * 3 + 1, str.Length - (j * 3 + 1));
		}
		return paramString;
	  }

	  public static string getPureNumber(string paramString)
	  {
		string str = "";
		if (!string.ReferenceEquals(paramString, null))
		{
		  str = paramString.replaceAll("\\+", "").replaceAll(" ", "");
		}
		return str;
	  }

	  public static string getWord(string[] paramArrayOfString, int paramInt)
	  {
		sbyte b = 1;
		int i = paramInt % 20;
		if (i == 0 || (i > 4 && i < 20))
		{
		  b = 2;
		  return paramInt + " " + paramArrayOfString[b];
		}
		if (i == 1)
		{
		  b = 0;
		}
		return paramInt + " " + paramArrayOfString[b];
	  }

	  public static bool isVideoCompatible(Activity paramActivity)
	  {
		return (Build.VERSION.SDK_INT >= 8 && paramActivity.getResources().getBoolean(2131427328) && !b.Contains(Build.MODEL));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\Utils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}