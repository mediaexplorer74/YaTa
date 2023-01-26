using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class dd : JsonDeserializer<long>
{
  private dd(sbyte paramByte)
  {
  }

  public static long? a(JsonElement paramJsonElement)
  {
	try
	{
	  long l = paramJsonElement.AsLong;
	  return Convert.ToInt64(l);
	}
	catch (System.FormatException numberFormatException)
	{
	  throw new JsonSyntaxException(numberFormatException);
	}
	catch (System.NotSupportedException unsupportedOperationException)
	{
	  throw new JsonSyntaxException(unsupportedOperationException);
	}
	catch (System.InvalidOperationException illegalStateException)
	{
	  throw new JsonSyntaxException(illegalStateException);
	}
  }

  public override string ToString()
  {
	return typeof(dd).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */