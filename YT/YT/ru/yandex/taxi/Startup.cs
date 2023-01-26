using System.Text;
using System.Threading;

namespace ru.yandex.taxi
{
	using Context = android.content.Context;
	using Build = android.os.Build;
	using PreferenceManager = android.preference.PreferenceManager;

	public class Startup
	{
	  public const string STARTUP_UID = "startup uid";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly Context a_Conflict;

	  static Startup()
	  {
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
		typeof(Thread).FullName;
	  }

	  public Startup(Context paramContext)
	  {
		this.a_Conflict = paramContext;
	  }

	  private string a()
	  {
		// Byte code:
		//   0: new java/lang/StringBuilder
		//   3: dup
		//   4: ldc ''
		//   6: invokespecial <init> : (Ljava/lang/String;)V
		//   9: astore_1
		//   10: aload_0
		//   11: getfield a : Landroid/content/Context;
		//   14: invokevirtual getPackageManager : ()Landroid/content/pm/PackageManager;
		//   17: aload_0
		//   18: getfield a : Landroid/content/Context;
		//   21: invokevirtual getPackageName : ()Ljava/lang/String;
		//   24: iconst_0
		//   25: invokevirtual getPackageInfo : (Ljava/lang/String;I)Landroid/content/pm/PackageInfo;
		//   28: astore_2
		//   29: new java/lang/StringBuilder
		//   32: astore_3
		//   33: aload_3
		//   34: aload_2
		//   35: getfield versionName : Ljava/lang/String;
		//   38: invokespecial <init> : (Ljava/lang/String;)V
		//   41: aload_3
		//   42: astore_1
		//   43: iconst_0
		//   44: istore #4
		//   46: iload #4
		//   48: aload_1
		//   49: invokevirtual length : ()I
		//   52: if_icmpge -> 105
		//   55: iload #4
		//   57: istore #5
		//   59: aload_1
		//   60: astore_3
		//   61: aload_1
		//   62: iload #4
		//   64: invokevirtual charAt : (I)C
		//   67: invokestatic isDigit : (C)Z
		//   70: ifne -> 90
		//   73: aload_1
		//   74: iload #4
		//   76: iload #4
		//   78: iconst_1
		//   79: iadd
		//   80: invokevirtual delete : (II)Ljava/lang/StringBuilder;
		//   83: astore_3
		//   84: iload #4
		//   86: iconst_1
		//   87: isub
		//   88: istore #5
		//   90: iload #5
		//   92: iconst_1
		//   93: iadd
		//   94: istore #4
		//   96: aload_3
		//   97: astore_1
		//   98: goto -> 46
		//   101: astore_3
		//   102: goto -> 43
		//   105: aload_1
		//   106: invokevirtual length : ()I
		//   109: iconst_3
		//   110: if_icmpge -> 124
		//   113: aload_1
		//   114: iconst_0
		//   115: ldc '0'
		//   117: invokevirtual insert : (ILjava/lang/String;)Ljava/lang/StringBuilder;
		//   120: pop
		//   121: goto -> 105
		//   124: aload_1
		//   125: invokevirtual toString : ()Ljava/lang/String;
		//   128: areturn
		// Exception table:
		//   from	to	target	type
		//   10	41	101	android/content/pm/PackageManager$NameNotFoundException
	  }

	  private static string a(string paramString)
	  {
		if (string.ReferenceEquals(paramString, null))
		{
		  return "";
		}
		try
		{
		  string str = URLEncoder.encode(paramString, "cp1251");
		  paramString = str;
		}
		catch (UnsupportedEncodingException)
		{
		}
		return paramString;
	  }

	  public virtual string StartupParameters
	  {
		  get
		  {
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("?app_version=");
			stringBuilder.Append(a());
			stringBuilder.Append("&clid=1");
			stringBuilder.Append("&app_platform=android&screen_w=");
			stringBuilder.Append((this.a_Conflict.getResources().getDisplayMetrics()).widthPixels);
			stringBuilder.Append("&screen_h=");
			stringBuilder.Append((this.a_Conflict.getResources().getDisplayMetrics()).heightPixels);
			string str = PreferenceManager.getDefaultSharedPreferences(this.a_Conflict).getString("startup uid", null);
			if (!string.ReferenceEquals(str, null))
			{
			  stringBuilder.Append("&uuid=");
			  stringBuilder.Append(str);
			}
			stringBuilder.Append("&manufacturer=");
			stringBuilder.Append(a(Build.MANUFACTURER));
			stringBuilder.Append("&model=");
			stringBuilder.Append(a(Build.MODEL));
			stringBuilder.Append("&os_version=");
			stringBuilder.Append(a(Build.VERSION.RELEASE));
			return stringBuilder.ToString();
		  }
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\Startup.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}