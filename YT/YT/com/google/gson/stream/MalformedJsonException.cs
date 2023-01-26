using System;

namespace com.google.gson.stream
{

	public sealed class MalformedJsonException : IOException
	{
	  private const long serialVersionUID = 1L;

	  public MalformedJsonException(string paramString) : base(paramString)
	  {
	  }

	  public MalformedJsonException(string paramString, Exception paramThrowable) : base(paramString)
	  {
		initCause(paramThrowable);
	  }

	  public MalformedJsonException(Exception paramThrowable)
	  {
		initCause(paramThrowable);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\stream\MalformedJsonException.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}