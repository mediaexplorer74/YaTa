using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class cj : JsonSerializer<decimal>, JsonDeserializer<decimal>
{
  private cj(sbyte paramByte)
  {
  }

  public static decimal a(JsonElement paramJsonElement)
  {
	try
	{
	  return paramJsonElement.AsBigDecimal;
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
	return typeof(cj).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */