using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;

public class ee : ed
{
  private ee(sbyte paramByte)
  {
  }

  public virtual JsonElement a(long? paramLong)
  {
	return (JsonElement)new JsonPrimitive(paramLong.ToString());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ee.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */