using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using ObjectNavigator = com.google.gson.ObjectNavigator;

public sealed class dw : JsonDeserializationContext
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly ObjectNavigator a_Conflict;

  private readonly dr b;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<com.google.gson.JsonDeserializer<?>> c;
  private readonly er<JsonDeserializer<object>> c;

  private readonly ek d;

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: public dw(com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, er<com.google.gson.JsonDeserializer<?>> paramer, ek paramek)
  public dw(ObjectNavigator paramObjectNavigator, dr paramdr, er<T1> paramer, ek paramek)
  {
	this.a_Conflict = paramObjectNavigator;
	this.b = paramdr;
	this.c = paramer;
	this.d = paramek;
  }

  internal eo a()
  {
	return this.d;
  }

  public T deserialize<T>(JsonElement paramJsonElement, Type paramType)
  {
	if (paramJsonElement == null || paramJsonElement.JsonNull)
	{
	  return default(T);
	}
	if (paramJsonElement.JsonArray)
	{
	  null = new dv(paramJsonElement.AsJsonArray, paramType, this.a_Conflict, this.b, this.d, this.c, this);
	  this.a_Conflict.a(new ep(null, paramType, true), null);
	  return (T)null.getTarget();
	}
	if (paramJsonElement.JsonObject)
	{
	  null = new dz((JsonElement)paramJsonElement.AsJsonObject, paramType, this.a_Conflict, this.b, this.d, this.c, this);
	  this.a_Conflict.a(new ep(null, paramType, true), null);
	  return (T)null.getTarget();
	}
	if (paramJsonElement.JsonPrimitive)
	{
	  JsonPrimitive jsonPrimitive = paramJsonElement.AsJsonPrimitive;
	  null = new dz((JsonElement)jsonPrimitive, paramType, this.a_Conflict, this.b, this.d, this.c, this);
	  this.a_Conflict.a(new ep(jsonPrimitive.a(), paramType, true), null);
	  return (T)null.getTarget();
	}
	throw new JsonParseException("Failed parsing JSON source: " + paramJsonElement + " to Json");
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dw.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */