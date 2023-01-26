using System.IO;

namespace ru.yandex.taxi.client
{
	using Log = android.util.Log;
	using ph;
	using pi;
	using TaxiResponse = ru.yandex.taxi.client.response.TaxiResponse;

	public class HttpUrlConnectionUtils : HttpUtils
	{
	  private static HttpsURLConnection a(string paramString1, string paramString2, System.Collections.IDictionary paramMap, string paramString3)
	  {
		URL uRL = new URL(paramString1);
		System.setProperty("http.keepAlive", "false");
		HttpsURLConnection httpsURLConnection = (HttpsURLConnection)uRL.openConnection();
		httpsURLConnection.setRequestProperty("connection", "close");
		httpsURLConnection.setConnectTimeout(30000);
		httpsURLConnection.setReadTimeout(30000);
		httpsURLConnection.setRequestMethod(paramString2);
		httpsURLConnection.setDoInput(true);
		httpsURLConnection.setDoOutput(true);
		if (paramMap != null)
		{
		  foreach (string paramString2 in paramMap.Keys)
		  {
			httpsURLConnection.setRequestProperty(paramString2, (string)paramMap[paramString2]);
		  }
		}
		try
		{
		  DataOutputStream dataOutputStream = new DataOutputStream();
		  this(httpsURLConnection.getOutputStream());
		}
		finally
		{
		  paramString2 = null;
		}
		if (uRL != null)
		{
		  uRL.flush();
		  uRL.close();
		}
		throw paramString2;
	  }

	  private static void a()
	  {
		HttpsURLConnection.setDefaultHostnameVerifier((HostnameVerifier)new ph());
		SSLContext sSLContext = SSLContext.getInstance("TLS");
		pi pi = new pi();
		SecureRandom secureRandom = new SecureRandom();
		sSLContext.init(null, (TrustManager[])new X509TrustManager[] {(X509TrustManager)pi}, secureRandom);
		HttpsURLConnection.setDefaultSSLSocketFactory(sSLContext.getSocketFactory());
	  }

	  public static Stream get(string paramString, bool paramBoolean, System.Collections.IDictionary paramMap)
	  {
		GZIPInputStream gZIPInputStream;
		string str = null;
		a();
		HttpsURLConnection httpsURLConnection = a(paramString, "GET", paramMap, null);
		int i = httpsURLConnection.getResponseCode();
		new TaxiResponse(i);
		paramString = str;
		if (i == 200)
		{
		  if (paramBoolean)
		  {
			gZIPInputStream = new GZIPInputStream(httpsURLConnection.getInputStream());
			httpsURLConnection.disconnect();
			return gZIPInputStream;
		  }
		}
		else
		{
		  httpsURLConnection.disconnect();
		  return gZIPInputStream;
		}
		Stream inputStream = httpsURLConnection.getInputStream();
		httpsURLConnection.disconnect();
		return inputStream;
	  }

	  public static sbyte[] getBytes(Stream paramInputStream)
	  {
		MemoryStream byteArrayOutputStream = new MemoryStream();
		sbyte[] arrayOfByte = new sbyte[1024];
		while (true)
		{
		  int i = paramInputStream.Read(arrayOfByte, 0, 1024);
		  if (i != -1)
		  {
			byteArrayOutputStream.Write(arrayOfByte, 0, i);
			continue;
		  }
		  return byteArrayOutputStream.toByteArray();
		}
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2)
	  {
		return post(paramString1, paramMap, paramString2, false);
	  }

	  public virtual TaxiResponse post(string paramString1, System.Collections.IDictionary paramMap, string paramString2, bool paramBoolean)
	  {
		Stream inputStream;
		a();
		HttpsURLConnection httpsURLConnection = a(paramString1, "POST", paramMap, paramString2);
		int i = httpsURLConnection.getResponseCode();
		TaxiResponse taxiResponse = new TaxiResponse(i);
		if (i == 200)
		{
		  if (paramBoolean)
		  {
			inputStream = new GZIPInputStream(httpsURLConnection.getInputStream());
		  }
		  else
		  {
			inputStream = httpsURLConnection.getInputStream();
		  }
		  taxiResponse.RowData = StringHelper.NewString(getBytes(inputStream), "UTF-8");
		  httpsURLConnection.disconnect();
		  return taxiResponse;
		}
		if (403 == i)
		{
		  taxiResponse.RowData = StringHelper.NewString(getBytes(httpsURLConnection.getErrorStream()), "UTF-8");
		  httpsURLConnection.disconnect();
		  return taxiResponse;
		}
		if (i == 400)
		{
		  taxiResponse.RowData = StringHelper.NewString(getBytes(httpsURLConnection.getErrorStream()), "UTF-8");
		  Log.e("HttpUrlConnectionUtils", "Bad request '" + taxiResponse.RowData + "' to " + inputStream + " with content " + paramString2);
		  httpsURLConnection.disconnect();
		  return taxiResponse;
		}
		if (i == 500)
		{
		  Log.e("HttpUrlConnectionUtils", "Internal server error on " + inputStream + " with content " + paramString2);
		}
		httpsURLConnection.disconnect();
		return taxiResponse;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\client\HttpUrlConnectionUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}