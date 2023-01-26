using System;

using FieldAttributes = com.google.gson.FieldAttributes;
using JsonArray = com.google.gson.JsonArray;
using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using ObjectNavigator = com.google.gson.ObjectNavigator;
using  = com.google.gson.@internal.;

internal sealed class dv<T> : dx<T>
{
//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: dv(com.google.gson.JsonArray paramJsonArray, java.lang.reflect.Type paramType, com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<com.google.gson.JsonDeserializer<?>> paramer, com.google.gson.JsonDeserializationContext paramJsonDeserializationContext)
  internal dv(JsonArray paramJsonArray, Type paramType, ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<T1> paramer, JsonDeserializationContext paramJsonDeserializationContext) : base((JsonElement)paramJsonArray, paramType, paramObjectNavigator, paramdr, parameo, paramer, paramJsonDeserializationContext)
  {
  }

  protected internal override T a()
  {
	if (!this.f.JsonArray)
	{
	  throw new JsonParseException("Expecting array found: " + this.f);
	}
	null = this.f.AsJsonArray;
	return (T)(.Gson.Types.isArray(this.g) ? this.c.a(.Gson.Types.getArrayComponentType(this.g), null.size()) : this.c.a(.Gson.Types.getRawType(this.g)));
  }

  public void startVisitingObject(object paramObject)
  {
	throw new JsonParseException("Expecting array but found object: " + paramObject);
  }

  public void visitArray(object paramObject, Type paramType)
  {
	if (!this.f.JsonArray)
	{
	  throw new JsonParseException("Expecting array found: " + this.f);
	}
	JsonArray jsonArray = this.f.AsJsonArray;
	for (sbyte b = 0; b < jsonArray.size(); b++)
	{
	  object @object = jsonArray.get(b);
	  if (@object == null || @object.isJsonNull())
	  {
		@object = null;
	  }
	  else if (@object is com.google.gson.JsonObject)
	  {
		@object = a(.Gson.Types.getArrayComponentType(paramType), (JsonElement)@object);
	  }
	  else if (@object is JsonArray)
	  {
		@object = a(.Gson.Types.getArrayComponentType(paramType), @object.getAsJsonArray());
	  }
	  else if (@object is com.google.gson.JsonPrimitive)
	  {
		@object = a(.Gson.Types.getArrayComponentType(paramType), (JsonElement)@object.getAsJsonPrimitive());
	  }
	  else
	  {
		throw new System.InvalidOperationException();
	  }
	  ((Array)paramObject).SetValue(@object, b);
	}
  }

  public void visitArrayField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	throw new JsonParseException("Expecting array but found array field " + paramFieldAttributes.Name + ": " + paramObject);
  }

  public bool visitFieldUsingCustomHandler(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	throw new JsonParseException("Expecting array but found field " + paramFieldAttributes.Name + ": " + paramObject);
  }

  public void visitObjectField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	throw new JsonParseException("Expecting array but found object field " + paramFieldAttributes.Name + ": " + paramObject);
  }

  public void visitPrimitive(object paramObject)
  {
	throw new JsonParseException("Type information is unavailable, and the target is not a primitive: " + this.f);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */