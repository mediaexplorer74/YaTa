using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class dm : JsonSerializer<System.Guid>, JsonDeserializer<System.Guid>
{
  private dm(sbyte paramByte)
  {
  }

  public override string ToString()
  {
	return typeof(dm).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dm.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */