using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class dc : JsonSerializer<Locale>, JsonDeserializer<Locale>
{
  private dc(sbyte paramByte)
  {
  }

  public override string ToString()
  {
	return typeof(dc).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */