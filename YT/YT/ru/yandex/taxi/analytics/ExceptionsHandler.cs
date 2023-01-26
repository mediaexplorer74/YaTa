using System;
using System.IO;
using System.Text;
using System.Threading;

namespace ru.yandex.taxi.analytics
{
	using Context = android.content.Context;
	using Build = android.os.Build;
	using Log = android.util.Log;
	using JSONObject = org.json.JSONObject;

	public sealed class ExceptionsHandler : Thread.UncaughtExceptionHandler
	{
	  private static AtomicReference<ExceptionsHandler> a = new AtomicReference<ExceptionsHandler>();

	  private readonly Context b;

	  private readonly Thread.UncaughtExceptionHandler c;

	  private readonly string d;

	  private ExceptionsHandler(Context paramContext, string paramString)
	  {
		this.b = paramContext;
		this.d = paramString;
		this.c = Thread.getDefaultUncaughtExceptionHandler();
	  }

	  public static void start(Context paramContext, string paramString)
	  {
		ExceptionsHandler exceptionsHandler = null;
		if (a.get() == null)
		{
		  FileStream fileInputStream;
		  ExceptionsHandler exceptionsHandler1 = new ExceptionsHandler(paramContext, paramString);
		  if (a.compareAndSet(null, exceptionsHandler1))
		  {
			Thread.setDefaultUncaughtExceptionHandler(exceptionsHandler1);
		  }
		  exceptionsHandler1 = exceptionsHandler;
		  try
		  {
			FileStream fileInputStream1 = paramContext.openFileInput("stack.trace");
			fileInputStream = fileInputStream1;
			JSONObject jSONObject1 = new JSONObject();
			fileInputStream = fileInputStream1;
			string str = "";
			fileInputStream = fileInputStream1;
			this(Tools.readAll(fileInputStream1), "UTF-8");
			fileInputStream = fileInputStream1;
			this(str);
			fileInputStream = fileInputStream1;
			Log.e("UNCAUGHT EXCEPTION", jSONObject1.toString(4));
			fileInputStream = fileInputStream1;
			ClientHttpRequest clientHttpRequest = new ClientHttpRequest();
			fileInputStream = fileInputStream1;
			URL uRL = new URL();
			fileInputStream = fileInputStream1;
			this("http://dmitriyap.dyndns.org:9091/rest/jconnect/latest/issue/create?project=YANDEXTAXI");
			fileInputStream = fileInputStream1;
			this(uRL);
			fileInputStream = fileInputStream1;
			StringBuilder stringBuilder = new StringBuilder();
			fileInputStream = fileInputStream1;
			this();
			fileInputStream = fileInputStream1;
			stringBuilder.Append("TRACE:\n");
			fileInputStream = fileInputStream1;
			stringBuilder.Append(jSONObject1.getString("trace"));
			fileInputStream = fileInputStream1;
			stringBuilder.Append("\n\nCAUSE:\n");
			fileInputStream = fileInputStream1;
			if (!jSONObject1.isNull("cause"))
			{
			  fileInputStream = fileInputStream1;
			  stringBuilder.Append(jSONObject1.getString("cause"));
			}
			fileInputStream = fileInputStream1;
			if (jSONObject1.has("processName"))
			{
			  fileInputStream = fileInputStream1;
			  stringBuilder.Append("\n\nPROCESS:\n");
			  fileInputStream = fileInputStream1;
			  stringBuilder.Append(jSONObject1.getString("processName"));
			}
			fileInputStream = fileInputStream1;
			if (jSONObject1.has("threadName"))
			{
			  fileInputStream = fileInputStream1;
			  stringBuilder.Append("\n\nTHREAD:\n");
			  fileInputStream = fileInputStream1;
			  stringBuilder.Append(jSONObject1.getString("threadName"));
			}
			fileInputStream = fileInputStream1;
			JSONObject jSONObject2 = new JSONObject();
			fileInputStream = fileInputStream1;
			this();
			fileInputStream = fileInputStream1;
			jSONObject2.put("description", stringBuilder.ToString());
			fileInputStream = fileInputStream1;
			jSONObject2.put("model", Build.MODEL);
			fileInputStream = fileInputStream1;
			jSONObject2.put("uuid", UUID.randomUUID());
			fileInputStream = fileInputStream1;
			jSONObject2.put("devName", Global.Manufacturer);
			fileInputStream = fileInputStream1;
			jSONObject2.put("systemName", "Android");
			fileInputStream = fileInputStream1;
			jSONObject2.put("component", "Android");
			fileInputStream = fileInputStream1;
			stringBuilder = new StringBuilder();
			fileInputStream = fileInputStream1;
			this();
			fileInputStream = fileInputStream1;
			jSONObject2.put("appVersion", stringBuilder.Append(jSONObject1.getString("appVersion")).Append(".").Append(jSONObject1.getString("appBuild")).ToString());
			fileInputStream = fileInputStream1;
			jSONObject2.put("appName", "Яндекс.Такси");
			fileInputStream = fileInputStream1;
			jSONObject2.put("summary", jSONObject1.getString("exception"));
			fileInputStream = fileInputStream1;
			jSONObject2.put("appId", "ru.yandex.taxi");
			fileInputStream = fileInputStream1;
			jSONObject2.put("udid", "A0C34711-6803-5FA8-8C17-88642F1BD371");
			fileInputStream = fileInputStream1;
			jSONObject2.put("systemVersion", Build.VERSION.SDK);
			fileInputStream = fileInputStream1;
			MemoryStream byteArrayInputStream = new MemoryStream();
			fileInputStream = fileInputStream1;
			this(jSONObject2.ToString().GetBytes());
			fileInputStream = fileInputStream1;
			clientHttpRequest.setParameter("issue", "issue.json", byteArrayInputStream, "application/json");
			fileInputStream = fileInputStream1;
			sbyte[] arrayOfByte = Tools.readAll(clientHttpRequest.post());
			fileInputStream = fileInputStream1;
			PrintStream printStream = System.out;
			fileInputStream = fileInputStream1;
			fileInputStream = fileInputStream1;
			paramContext.deleteFile("stack.trace");
			return;
		  }
		  finally
		  {
			if (fileInputStream != null)
			{
			  fileInputStream.Close();
			}
		  }
		}
	  }

	  public void uncaughtException(Thread paramThread, Exception paramThrowable)
	  {
		if (paramThrowable != null)
		{
		  Log.e("FATAL MAIL ERROR", "", paramThrowable);
		  try
		  {
			JSONObject jSONObject = new JSONObject();
			this();
			jSONObject.put("exception", paramThrowable.ToString());
			StringWriter stringWriter = new StringWriter();
			this();
			PrintWriter printWriter = new PrintWriter();
			this(stringWriter);
			paramThrowable.printStackTrace(printWriter);
			jSONObject.put("trace", stringWriter.ToString());
			jSONObject.put("cause", paramThrowable.InnerException);
			if (!string.ReferenceEquals(this.d, null) && this.d.Length > 0)
			{
			  jSONObject.put("processName", this.d);
			}
			if (paramThread != null && paramThread.getName() != null)
			{
			  jSONObject.put("threadName", paramThread.getName());
			}
			jSONObject.put("appVersion", Global.APP_VERSION);
			jSONObject.put("appBuild", Global.BUILD_NUMBER);
			FileStream fileOutputStream = this.b.openFileOutput("stack.trace", 0);
			fileOutputStream.WriteByte(jSONObject.ToString().GetBytes(Encoding.UTF8));
			fileOutputStream.Close();
			if (this.c != null)
			{
			  this.c.uncaughtException(paramThread, paramThrowable);
			  return;
			}
		  }
		  catch (Exception throwable)
		  {
			Log.i("UNCAUGHT EXCEPTION", "failed to save the report", throwable);
			if (this.c != null)
			{
			  this.c.uncaughtException(paramThread, paramThrowable);
			  return;
			}
		  }
		  Environment.Exit(1);
		  return;
		}
		if (this.c != null)
		{
		  this.c.uncaughtException(paramThread, paramThrowable);
		  return;
		}
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\analytics\ExceptionsHandler.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}