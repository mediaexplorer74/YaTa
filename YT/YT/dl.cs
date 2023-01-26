using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class dl : JsonSerializer<URL>, JsonDeserializer<URL>
{
  private dl(sbyte paramByte)
  {
  }

  public static URL a(JsonElement paramJsonElement)
  {
	try
	{
	  return new URL(paramJsonElement.AsString);
	}
	catch (MalformedURLException malformedURLException)
	{
	  throw new JsonSyntaxException(malformedURLException);
	}
  }

  public override string ToString()
  {
	return typeof(dl).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dl.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */