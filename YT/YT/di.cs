using System.Text;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class di : JsonSerializer<StringBuilder>, JsonDeserializer<StringBuilder>
{
  private di(sbyte paramByte)
  {
  }

  public override string ToString()
  {
	return typeof(di).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\di.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */