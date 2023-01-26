using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class dk : JsonSerializer<URI>, JsonDeserializer<URI>
{
  private dk(sbyte paramByte)
  {
  }

  public static URI a(JsonElement paramJsonElement)
  {
	try
	{
	  return new URI(paramJsonElement.AsString);
	}
	catch (URISyntaxException uRISyntaxException)
	{
	  throw new JsonSyntaxException(uRISyntaxException);
	}
  }

  public override string ToString()
  {
	return typeof(dk).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */