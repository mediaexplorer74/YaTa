using JsonElement = com.google.gson.JsonElement;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using LongSerializationPolicy = com.google.gson.LongSerializationPolicy;

internal sealed class de : JsonSerializer<long>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly LongSerializationPolicy a_Conflict;

  private de(LongSerializationPolicy paramLongSerializationPolicy, sbyte paramByte)
  {
	this.a_Conflict = paramLongSerializationPolicy;
  }

  public JsonElement a(long? paramLong)
  {
	return this.a_Conflict.serialize(paramLong);
  }

  public override string ToString()
  {
	return typeof(de).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\de.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */