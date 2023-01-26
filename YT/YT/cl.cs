using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class cl : JsonSerializer<bool>, JsonDeserializer<bool>
{
  private cl(sbyte paramByte)
  {
  }

  public static bool? a(JsonElement paramJsonElement)
  {
	try
	{
	  bool @bool = paramJsonElement.AsBoolean;
	  return Convert.ToBoolean(@bool);
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
	return typeof(cl).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */