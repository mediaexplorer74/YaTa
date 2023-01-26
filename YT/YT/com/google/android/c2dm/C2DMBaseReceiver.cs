using System.Text;

namespace com.google.android.c2dm
{
	using AlarmManager = android.app.AlarmManager;
	using IntentService = android.app.IntentService;
	using PendingIntent = android.app.PendingIntent;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using PowerManager = android.os.PowerManager;
	using Log = android.util.Log;

	public abstract class C2DMBaseReceiver : IntentService
	{
	  public const string ERR_ACCOUNT_MISSING = "ACCOUNT_MISSING";

	  public const string ERR_AUTHENTICATION_FAILED = "AUTHENTICATION_FAILED";

	  public const string ERR_INVALID_PARAMETERS = "INVALID_PARAMETERS";

	  public const string ERR_INVALID_SENDER = "INVALID_SENDER";

	  public const string ERR_PHONE_REGISTRATION_ERROR = "PHONE_REGISTRATION_ERROR";

	  public const string ERR_SERVICE_NOT_AVAILABLE = "SERVICE_NOT_AVAILABLE";

	  public const string ERR_TOO_MANY_REGISTRATIONS = "TOO_MANY_REGISTRATIONS";

	  public const string EXTRA_ERROR = "error";

	  public const string EXTRA_REGISTRATION_ID = "registration_id";

	  public const string EXTRA_UNREGISTERED = "unregistered";

	  public const string REGISTRATION_CALLBACK_INTENT = "com.google.android.c2dm.intent.REGISTRATION";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static PowerManager.WakeLock a_Conflict;

	  private readonly string b;

	  public C2DMBaseReceiver(string paramString) : base(paramString)
	  {
		this.b = paramString;
	  }

	  internal static void a(Context paramContext, Intent paramIntent)
	  {
		if (a_Conflict == null)
		{
		  a_Conflict = ((PowerManager)paramContext.getSystemService("power")).newWakeLock(1, "C2DM_LIB");
		}
		a_Conflict.acquire();
		paramIntent.setClassName(paramContext, paramContext.getPackageName() + ".C2DMReceiver");
		paramContext.startService(paramIntent);
	  }

	  public abstract void onError(Context paramContext, string paramString);

	  public void onHandleIntent(Intent paramIntent)
	  {
		try
		{
		  Context context = getApplicationContext();
		  if (paramIntent.getAction().Equals("com.google.android.c2dm.intent.REGISTRATION"))
		  {
			string str1 = paramIntent.getStringExtra("registration_id");
			string str2 = paramIntent.getStringExtra("error");
			string str3 = paramIntent.getStringExtra("unregistered");
			if (Log.isLoggable("C2DM", 3))
			{
			  StringBuilder stringBuilder = new StringBuilder();
			  this();
			  Log.d("C2DM", stringBuilder.Append("dmControl: registrationId = ").Append(str1).Append(", error = ").Append(str2).Append(", removed = ").Append(str3).ToString());
			}
			if (!string.ReferenceEquals(str3, null))
			{
			  C2DMessaging.b(context);
			  onUnregistered(context);
			}
			else if (!string.ReferenceEquals(str2, null))
			{
			  C2DMessaging.b(context);
			  StringBuilder stringBuilder = new StringBuilder();
			  this();
			  Log.e("C2DM", stringBuilder.Append("Registration error ").Append(str2).ToString());
			  onError(context, str2);
			  if ("SERVICE_NOT_AVAILABLE".Equals(str2))
			  {
				long l = C2DMessaging.a(context);
				stringBuilder = new StringBuilder();
				this();
				Log.d("C2DM", stringBuilder.Append("Scheduling registration retry, backoff = ").Append(l).ToString());
				Intent intent = new Intent();
				this("com.google.android.c2dm.intent.RETRY");
				PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, intent, 0);
				((AlarmManager)context.getSystemService("alarm")).set(3, l, pendingIntent);
				C2DMessaging.a(context, l << 1L);
			  }
			}
			else
			{
			  try
			  {
				onRegistered(context, str1);
				C2DMessaging.a(context, str1);
			  }
			  catch (IOException)
			  {
			  }
			}
		  }
		  else if (iOException.getAction().Equals("com.google.android.c2dm.intent.RECEIVE"))
		  {
			onMessage(context, (Intent)iOException);
		  }
		  else if (iOException.getAction().Equals("com.google.android.c2dm.intent.RETRY"))
		  {
			C2DMessaging.register(context, this.b);
		  }
		  return;
		}
		finally
		{
		  a_Conflict.release();
		}
	  }

	  protected internal abstract void onMessage(Context paramContext, Intent paramIntent);

	  public virtual void onRegistered(Context paramContext, string paramString)
	  {
	  }

	  public virtual void onUnregistered(Context paramContext)
	  {
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\android\c2dm\C2DMBaseReceiver.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}