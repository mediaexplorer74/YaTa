using System;

namespace com.google.gson
{
	public sealed class JsonSyntaxException : JsonParseException
	{
	  private new const long serialVersionUID = 1L;

	  public JsonSyntaxException(string paramString) : base(paramString)
	  {
	  }

	  public JsonSyntaxException(string paramString, Exception paramThrowable) : base(paramString, paramThrowable)
	  {
	  }

	  public JsonSyntaxException(Exception paramThrowable) : base(paramThrowable)
	  {
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonSyntaxException.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}