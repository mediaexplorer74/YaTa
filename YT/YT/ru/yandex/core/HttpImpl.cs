using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ru.yandex.core
{
	using Log = android.util.Log;
	using g;

	public sealed class HttpImpl
	{
	  private static string LOG_TAG = "yandex.HttpImpl";

	  private static int READ_SIZE = 1024;

	  private ArrayList headers = new ArrayList();

	  private string httpAddress;

	  private string httpPath;

	  private ArrayList intParams;

	  private long nativePtr;

	  private ArrayList @params = new ArrayList();

	  private ArrayList strParams;

	  private void addHeaders(HttpURLConnection paramHttpURLConnection)
	  {
		if (this.headers != null)
		{
		  IEnumerator<string> iterator = this.headers.GetEnumerator();
		  while (iterator.MoveNext())
		  {
			string[] arrayOfString = ((string)iterator.Current).Split(":", true);
			paramHttpURLConnection.setRequestProperty(arrayOfString[0], arrayOfString[1]);
		  }
		}
	  }

	  private string PathWithParams
	  {
		  get
		  {
			if (string.ReferenceEquals(this.httpPath, null))
			{
			  this.httpPath = "/";
			}
			StringBuilder stringBuilder = new StringBuilder(this.httpPath);
			try
			{
			  if (this.@params.Count > 0)
			  {
				if (this.httpPath[this.httpPath.Length - 1] != '/')
				{
				  stringBuilder.Append("/");
				}
				stringBuilder.Append("?");
			  }
			  IEnumerator<string> iterator = this.@params.GetEnumerator();
	//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
			  if (iterator.hasNext())
			  {
	//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
				stringBuilder.Append(iterator.next());
			  }
			  while (iterator.MoveNext())
			  {
				stringBuilder.Append("&");
				stringBuilder.Append(iterator.Current);
			  }
			}
			catch (Exception exception)
			{
			  Log.e(LOG_TAG, exception.ToString());
			}
			return stringBuilder.ToString();
		  }
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int readOutputStream(long paramLong, sbyte[] paramArrayOfbyte, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void setHttpStatus(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void setLastError(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int writeInputStream(long paramLong, sbyte[] paramArrayOfbyte, int paramInt);

	  internal bool get(long paramLong)
	  {
		bool @bool;
		this.nativePtr = paramLong;
		try
		{
		  URL uRL = new URL();
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  this(stringBuilder.Append(this.httpAddress).Append("/").Append(PathWithParams).ToString());
		  HttpURLConnection httpURLConnection = (HttpURLConnection)uRL.openConnection();
		  httpURLConnection.setRequestMethod("GET");
		  httpURLConnection.setAllowUserInteraction(false);
		  httpURLConnection.setDoOutput(false);
		  httpURLConnection.setDoInput(true);
		  sbyte[] arrayOfByte = new sbyte[READ_SIZE];
		  addHeaders(httpURLConnection);
		  httpURLConnection.connect();
		  int i = httpURLConnection.getResponseCode();
		  setHttpStatus(this.nativePtr, i);
		  Stream inputStream = httpURLConnection.getInputStream();
		  i = 0;
		  while (true)
		  {
			int j = inputStream.Read(arrayOfByte, 0, READ_SIZE);
			int k = i;
			if (j != -1)
			{
			  k = writeInputStream(this.nativePtr, arrayOfByte, j);
			}
			if (j != -1)
			{
			  i = k;
			  if (k == 0)
			  {
				break;
			  }
			  continue;
			}
			break;
		  }
		  inputStream.Close();
		  @bool = true;
		}
		catch (MalformedURLException malformedURLException)
		{
		  Log.e(LOG_TAG, malformedURLException.ToString());
		  @bool = false;
		}
		catch (UnknownServiceException unknownServiceException)
		{
		  Log.e(LOG_TAG, unknownServiceException.ToString());
		  @bool = false;
		}
		catch (IOException iOException)
		{
		  Log.e(LOG_TAG, iOException.ToString());
		  @bool = false;
		}
		catch (Exception exception)
		{
		  Log.e(LOG_TAG, exception.ToString());
		  @bool = false;
		}
		return @bool;
	  }

	  internal bool post(long paramLong)
	  {
		bool @bool;
		this.nativePtr = paramLong;
		try
		{
		  URL uRL = new URL();
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  this(stringBuilder.Append(this.httpAddress).Append("/").Append(PathWithParams).ToString());
		  HttpURLConnection httpURLConnection = (HttpURLConnection)uRL.openConnection();
		  httpURLConnection.setRequestMethod("POST");
		  httpURLConnection.setAllowUserInteraction(false);
		  httpURLConnection.setDoOutput(true);
		  httpURLConnection.setDoInput(true);
		  addHeaders(httpURLConnection);
		  httpURLConnection.connect();
		  sbyte[] arrayOfByte = new sbyte[READ_SIZE];
		  Stream outputStream = httpURLConnection.getOutputStream();
		  while (true)
		  {
			int i = readOutputStream(this.nativePtr, arrayOfByte, READ_SIZE);
			if (i > 0)
			{
			  outputStream.Write(arrayOfByte, 0, i);
			}
			if (i <= 0)
			{
			  outputStream.Flush();
			  outputStream.Close();
			  i = httpURLConnection.getResponseCode();
			  setHttpStatus(this.nativePtr, i);
			  Stream inputStream = httpURLConnection.getInputStream();
			  int j = 0;
			  while (true)
			  {
				int k = inputStream.Read(arrayOfByte, 0, READ_SIZE);
				i = j;
				if (k != -1)
				{
				  i = writeInputStream(this.nativePtr, arrayOfByte, k);
				}
				if (k != -1)
				{
				  j = i;
				  if (i == 0)
				  {
					break;
				  }
				  continue;
				}
				break;
			  }
			  inputStream.Close();
			  return true;
			}
		  }
		}
		catch (MalformedURLException malformedURLException)
		{
		  Log.e(LOG_TAG, malformedURLException.ToString());
		  @bool = false;
		}
		catch (UnknownServiceException unknownServiceException)
		{
		  Log.e(LOG_TAG, unknownServiceException.ToString());
		  @bool = false;
		}
		catch (IOException iOException)
		{
		  Log.e(LOG_TAG, iOException.ToString());
		  @bool = false;
		}
		catch (Exception exception)
		{
		  Log.e(LOG_TAG, exception.ToString());
		  @bool = false;
		}
		return @bool;
	  }

	  public string[] GetParams
	  {
		  set
		  {
			for (sbyte b = 0; b < value.Length; b++)
			{
			  this.@params.Add(value[b]);
			}
		  }
	  }

	  public string[] Headers
	  {
		  set
		  {
			for (sbyte b = 0; b < value.Length; b++)
			{
			  this.headers.Add(value[b]);
			}
		  }
	  }

	  public void setIntParams(int[] paramArrayOfint1, int[] paramArrayOfint2)
	  {
		for (sbyte b = 0; b < paramArrayOfint1.Length; b++)
		{
		  g g = g.a(Convert.ToInt32(paramArrayOfint1[b]), Convert.ToInt32(paramArrayOfint2[b]));
		  this.intParams.Add(g);
		}
	  }

	  public void setStrParams(int[] paramArrayOfint, string[] paramArrayOfString)
	  {
		for (sbyte b = 0; b < paramArrayOfint.Length; b++)
		{
		  g g = g.a(Convert.ToInt32(paramArrayOfint[b]), paramArrayOfString[b]);
		  this.strParams.Add(g);
		}
	  }

	  public void setUrl(string paramString1, string paramString2)
	  {
		this.httpAddress = paramString1;
		this.httpPath = paramString2;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\HttpImpl.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}