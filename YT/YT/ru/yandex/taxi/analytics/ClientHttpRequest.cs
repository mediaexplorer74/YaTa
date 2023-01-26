using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ru.yandex.taxi.analytics
{

	public class ClientHttpRequest
	{
	  private static Random e = new Random();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal URLConnection a_Conflict;

	  internal Stream b = null;

	  internal System.Collections.IDictionary c = new Dictionary<object, object>();

	  internal string d = "---------------------------" + randomString() + randomString() + randomString();

	  public ClientHttpRequest(string paramString) : this(new URL(paramString))
	  {
	  }

	  public ClientHttpRequest(URL paramURL) : this(paramURL.openConnection())
	  {
	  }

	  public ClientHttpRequest(URLConnection paramURLConnection)
	  {
		this.a_Conflict = paramURLConnection;
		paramURLConnection.setDoOutput(true);
		paramURLConnection.setRequestProperty("Content-Type", "multipart/form-data; boundary=" + this.d);
	  }

	  private void a()
	  {
		write("--");
		write(this.d);
	  }

	  private static void a(Stream paramInputStream, Stream paramOutputStream)
	  {
		lock (new sbyte[500000])
		{
		  while (true)
		  {
			int i = paramInputStream.Read(null, 0, null.length);
			if (i >= 0)
			{
			  paramOutputStream.Write(null, 0, i);
			  continue;
			}
			/* monitor exit ClassFileLocalVariableReferenceExpression{type=ObjectType{java/io/InputStream}, name=paramInputStream} */
			paramOutputStream.Flush();
			return;
		  }
		}
	  }

	  private void a(string paramString)
	  {
		newline();
		write("Content-Disposition: form-data; name=\"");
		write(paramString);
		write('"');
	  }

	  public static Stream post(URL paramURL, string paramString, object paramObject)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramString, paramObject);
	  }

	  public static Stream post(URL paramURL, string paramString1, object paramObject1, string paramString2, object paramObject2)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramString1, paramObject1, paramString2, paramObject2);
	  }

	  public static Stream post(URL paramURL, string paramString1, object paramObject1, string paramString2, object paramObject2, string paramString3, object paramObject3)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramString1, paramObject1, paramString2, paramObject2, paramString3, paramObject3);
	  }

	  public static Stream post(URL paramURL, string paramString1, object paramObject1, string paramString2, object paramObject2, string paramString3, object paramObject3, string paramString4, object paramObject4)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramString1, paramObject1, paramString2, paramObject2, paramString3, paramObject3, paramString4, paramObject4);
	  }

	  public static Stream post(URL paramURL, System.Collections.IDictionary paramMap)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramMap);
	  }

	  public static Stream post(URL paramURL, System.Collections.IDictionary paramMap1, System.Collections.IDictionary paramMap2)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramMap1, paramMap2);
	  }

	  public static Stream post(URL paramURL, object[] paramArrayOfObject)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramArrayOfObject);
	  }

	  public static Stream post(URL paramURL, string[] paramArrayOfString, object[] paramArrayOfObject)
	  {
		return (new ClientHttpRequest(paramURL)).post(paramArrayOfString, paramArrayOfObject);
	  }

	  protected internal static string randomString()
	  {
		return Convert.ToString(e.nextLong(), 36);
	  }

	  protected internal virtual void connect()
	  {
		if (this.b == null)
		{
		  this.b = this.a_Conflict.getOutputStream();
		}
	  }

	  protected internal virtual void newline()
	  {
		connect();
		write("\r\n");
	  }

	  public virtual Stream post()
	  {
		a();
		writeln("--");
		this.b.Close();
		return this.a_Conflict.getInputStream();
	  }

	  public virtual Stream post(string paramString, object paramObject)
	  {
		setParameter(paramString, paramObject);
		return post();
	  }

	  public virtual Stream post(string paramString1, object paramObject1, string paramString2, object paramObject2)
	  {
		setParameter(paramString1, paramObject1);
		return post(paramString2, paramObject2);
	  }

	  public virtual Stream post(string paramString1, object paramObject1, string paramString2, object paramObject2, string paramString3, object paramObject3)
	  {
		setParameter(paramString1, paramObject1);
		return post(paramString2, paramObject2, paramString3, paramObject3);
	  }

	  public virtual Stream post(string paramString1, object paramObject1, string paramString2, object paramObject2, string paramString3, object paramObject3, string paramString4, object paramObject4)
	  {
		setParameter(paramString1, paramObject1);
		return post(paramString2, paramObject2, paramString3, paramObject3, paramString4, paramObject4);
	  }

	  public virtual Stream post(System.Collections.IDictionary paramMap)
	  {
		setParameters(paramMap);
		return post();
	  }

	  public virtual Stream post(System.Collections.IDictionary paramMap1, System.Collections.IDictionary paramMap2)
	  {
		setCookies(paramMap1);
		setParameters(paramMap2);
		return post();
	  }

	  public virtual Stream post(object[] paramArrayOfObject)
	  {
		setParameters(paramArrayOfObject);
		return post();
	  }

	  public virtual Stream post(string[] paramArrayOfString, object[] paramArrayOfObject)
	  {
		setCookies(paramArrayOfString);
		setParameters(paramArrayOfObject);
		return post();
	  }

	  public virtual void setCookie(string paramString1, string paramString2)
	  {
		this.c[paramString1] = paramString2;
	  }

	  public virtual System.Collections.IDictionary Cookies
	  {
		  set
		  {
			if (value != null)
			{
			  this.c.PutAll(value);
			}
		  }
	  }

	  public virtual string[] Cookies
	  {
		  set
		  {
			if (value != null)
			{
			  sbyte b = 0;
			  while (true)
			  {
				if (b < value.Length - 1)
				{
				  setCookie(value[b], value[b + 1]);
				  b += 2;
				  continue;
				}
				return;
			  }
			}
		  }
	  }

	  public virtual void setParameter(string paramString, File paramFile)
	  {
		setParameter(paramString, paramFile.getPath(), new FileStream(paramFile, FileMode.Open, FileAccess.Read));
	  }

	  public virtual void setParameter(string paramString, object paramObject)
	  {
		if (paramObject is File)
		{
		  setParameter(paramString, (File)paramObject);
		  return;
		}
		setParameter(paramString, paramObject.ToString());
	  }

	  public virtual void setParameter(string paramString1, string paramString2)
	  {
		a();
		a(paramString1);
		newline();
		newline();
		writeln(paramString2);
	  }

	  public virtual void setParameter(string paramString1, string paramString2, Stream paramInputStream)
	  {
		a();
		a(paramString1);
		write("; filename=\"");
		write(paramString2);
		write('"');
		newline();
		write("Content-Type: ");
		URLConnection uRLConnection = this.a_Conflict;
		paramString2 = URLConnection.guessContentTypeFromName(paramString2);
		string str = paramString2;
		if (string.ReferenceEquals(paramString2, null))
		{
		  str = "application/octet-stream";
		}
		writeln(str);
		newline();
		a(paramInputStream, this.b);
		newline();
	  }

	  public virtual void setParameter(string paramString1, string paramString2, Stream paramInputStream, string paramString3)
	  {
		a();
		a(paramString1);
		write("; filename=\"");
		write(paramString2);
		write('"');
		newline();
		write("Content-Type: ");
		paramString1 = paramString3;
		if (string.ReferenceEquals(paramString3, null))
		{
		  paramString1 = "application/octet-stream";
		}
		writeln(paramString1);
		newline();
		a(paramInputStream, this.b);
		newline();
	  }

	  public virtual System.Collections.IDictionary Parameters
	  {
		  set
		  {
			if (value != null)
			{
			  IEnumerator<DictionaryEntry> iterator = value.SetOfKeyValuePairs().GetEnumerator();
			  while (true)
			  {
	//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
				if (iterator.hasNext())
				{
	//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
				  DictionaryEntry entry = iterator.next();
				  setParameter(entry.Key.ToString(), entry.Value);
				  continue;
				}
				return;
			  }
			}
		  }
	  }

	  public virtual object[] Parameters
	  {
		  set
		  {
			if (value != null)
			{
			  sbyte b = 0;
			  while (true)
			  {
				if (b < value.Length - 1)
				{
				  setParameter(value[b].ToString(), value[b + 1]);
				  b += 2;
				  continue;
				}
				return;
			  }
			}
		  }
	  }

	  protected internal virtual void write(char paramChar)
	  {
		connect();
		this.b.WriteByte(paramChar);
	  }

	  protected internal virtual void write(string paramString)
	  {
		connect();
		this.b.WriteByte(paramString.GetBytes());
	  }

	  protected internal virtual void writeln(string paramString)
	  {
		connect();
		write(paramString);
		newline();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\analytics\ClientHttpRequest.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}