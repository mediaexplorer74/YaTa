namespace com.google.android.c2dm
{
	using PendingIntent = android.app.PendingIntent;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using Parcelable = android.os.Parcelable;

	public class C2DMessaging
	{
	  public const string BACKOFF = "backoff";

	  public const string EXTRA_APPLICATION_PENDING_INTENT = "app";

	  public const string EXTRA_SENDER = "sender";

	  public const string GSF_PACKAGE = "com.google.android.gsf";

	  public const string LAST_REGISTRATION_CHANGE = "last_registration_change";

	  public const string REQUEST_REGISTRATION_INTENT = "com.google.android.c2dm.intent.REGISTER";

	  public const string REQUEST_UNREGISTRATION_INTENT = "com.google.android.c2dm.intent.UNREGISTER";

	  internal static long a(Context paramContext)
	  {
		return paramContext.getSharedPreferences("com.google.android.c2dm", 0).getLong("backoff", 30000L);
	  }

	  internal static void a(Context paramContext, long paramLong)
	  {
		SharedPreferences.Editor editor = paramContext.getSharedPreferences("com.google.android.c2dm", 0).edit();
		editor.putLong("backoff", paramLong);
		editor.commit();
	  }

	  internal static void a(Context paramContext, string paramString)
	  {
		SharedPreferences.Editor editor = paramContext.getSharedPreferences("com.google.android.c2dm", 0).edit();
		editor.putString("dm_registration", paramString);
		editor.commit();
	  }

	  internal static void b(Context paramContext)
	  {
		SharedPreferences.Editor editor = paramContext.getSharedPreferences("com.google.android.c2dm", 0).edit();
		editor.putString("dm_registration", "");
		editor.putLong("last_registration_change", DateTimeHelper.CurrentUnixTimeMillis());
		editor.commit();
	  }

	  public static long getLastRegistrationChange(Context paramContext)
	  {
		return paramContext.getSharedPreferences("com.google.android.c2dm", 0).getLong("last_registration_change", 0L);
	  }

	  public static string getRegistrationId(Context paramContext)
	  {
		return paramContext.getSharedPreferences("com.google.android.c2dm", 0).getString("dm_registration", "");
	  }

	  public static void register(Context paramContext, string paramString)
	  {
		Intent intent = new Intent("com.google.android.c2dm.intent.REGISTER");
		intent.setPackage("com.google.android.gsf");
		intent.putExtra("app", (Parcelable)PendingIntent.getBroadcast(paramContext, 0, new Intent(), 0));
		intent.putExtra("sender", paramString);
		paramContext.startService(intent);
	  }

	  public static void unregister(Context paramContext)
	  {
		Intent intent = new Intent("com.google.android.c2dm.intent.UNREGISTER");
		intent.setPackage("com.google.android.gsf");
		intent.putExtra("app", (Parcelable)PendingIntent.getBroadcast(paramContext, 0, new Intent(), 0));
		paramContext.startService(intent);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\android\c2dm\C2DMessaging.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}