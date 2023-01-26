using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class dg : JsonSerializer<short>, JsonDeserializer<short>
{
  private dg(sbyte paramByte)
  {
  }

  public static short? a(JsonElement paramJsonElement)
  {
	try
	{
	  short s = paramJsonElement.AsShort;
	  return Convert.ToInt16(s);
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
	return typeof(dg).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */