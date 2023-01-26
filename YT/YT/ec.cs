using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;

public class ec : ed
{
  private ec(sbyte paramByte)
  {
  }

  public virtual JsonElement a(long? paramLong)
  {
	return (JsonElement)new JsonPrimitive(paramLong);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ec.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */