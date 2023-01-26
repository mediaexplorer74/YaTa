using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class db : JsonSerializer<int>, JsonDeserializer<int>
{
  private db(sbyte paramByte)
  {
  }

  public static int? a(JsonElement paramJsonElement)
  {
	try
	{
	  int i = paramJsonElement.AsInt;
	  return Convert.ToInt32(i);
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
	return typeof(db).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\db.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */