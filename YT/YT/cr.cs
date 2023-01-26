using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class cr : JsonDeserializer<InetAddress>, JsonSerializer<InetAddress>
{
  public static InetAddress a(JsonElement paramJsonElement)
  {
	try
	{
	  return InetAddress.getByName(paramJsonElement.AsString);
	}
	catch (UnknownHostException unknownHostException)
	{
	  throw new JsonParseException(unknownHostException);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */