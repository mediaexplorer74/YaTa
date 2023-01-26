using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonObject = com.google.gson.JsonObject;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class da : JsonSerializer<GregorianCalendar>, JsonDeserializer<GregorianCalendar>
{
  private da(sbyte paramByte)
  {
  }

  public override string ToString()
  {
	return typeof(da).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\da.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */