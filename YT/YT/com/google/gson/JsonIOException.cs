using System;

namespace com.google.gson
{
	public sealed class JsonIOException : JsonParseException
	{
	  private new const long serialVersionUID = 1L;

	  public JsonIOException(string paramString) : base(paramString)
	  {
	  }

	  public JsonIOException(string paramString, Exception paramThrowable) : base(paramString, paramThrowable)
	  {
	  }

	  public JsonIOException(Exception paramThrowable) : base(paramThrowable)
	  {
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonIOException.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}