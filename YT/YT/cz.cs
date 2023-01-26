using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class cz : JsonSerializer<float>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly bool a_Conflict;

  internal cz(bool paramBoolean)
  {
	this.a_Conflict = paramBoolean;
  }

  public JsonElement a(float? paramFloat)
  {
	if (!this.a_Conflict && (float.IsNaN(paramFloat.Value) || float.IsInfinity(paramFloat.Value)))
	{
	  throw new System.ArgumentException(paramFloat + " is not a valid float value as per JSON specification. To override this" + " behavior, use GsonBuilder.serializeSpecialFloatingPointValues() method.");
	}
	return (JsonElement)new JsonPrimitive(paramFloat);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */