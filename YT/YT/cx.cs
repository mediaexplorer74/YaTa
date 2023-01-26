using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class cx<T> : JsonSerializer<T>, JsonDeserializer<T> where T : Enum<T>
{
  private cx(sbyte paramByte)
  {
  }

  public override string ToString()
  {
	return typeof(cx).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */