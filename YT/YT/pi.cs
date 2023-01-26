public sealed class pi : X509TrustManager
{
  public void checkClientTrusted(X509Certificate[] paramArrayOfX509Certificate, string paramString)
  {
  }

  public void checkServerTrusted(X509Certificate[] paramArrayOfX509Certificate, string paramString)
  {
  }

  public X509Certificate[] AcceptedIssuers
  {
	  get
	  {
		return new X509Certificate[0];
	  }
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\pi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */