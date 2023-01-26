using System;

namespace com.google.gson
{
	public class JsonParseException : Exception
	{
	  internal const long serialVersionUID = -4086729973971783390L;

	  public JsonParseException(string paramString) : base(paramString)
	  {
	  }

	  public JsonParseException(string paramString, Exception paramThrowable) : base(paramString, paramThrowable)
	  {
	  }

	  public JsonParseException(Exception paramThrowable) : base(paramThrowable)
	  {
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonParseException.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}