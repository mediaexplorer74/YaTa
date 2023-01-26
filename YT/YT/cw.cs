using JsonElement = com.google.gson.JsonElement;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal sealed class cw : JsonSerializer<double>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly bool a_Conflict;

  internal cw(bool paramBoolean)
  {
	this.a_Conflict = paramBoolean;
  }

  public JsonElement a(double? paramDouble)
  {
	if (!this.a_Conflict && (double.IsNaN(paramDouble.Value) || double.IsInfinity(paramDouble.Value)))
	{
	  throw new System.ArgumentException(paramDouble + " is not a valid double value as per JSON specification. To override this" + " behavior, use GsonBuilder.serializeSpecialDoubleValues() method.");
	}
	return (JsonElement)new JsonPrimitive(paramDouble);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */