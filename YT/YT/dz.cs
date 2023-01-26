using System;
using System.Text;

using FieldAttributes = com.google.gson.FieldAttributes;
using JsonArray = com.google.gson.JsonArray;
using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using ObjectNavigator = com.google.gson.ObjectNavigator;

internal sealed class dz<T> : dx<T>
{
//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: dz(com.google.gson.JsonElement paramJsonElement, java.lang.reflect.Type paramType, com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<com.google.gson.JsonDeserializer<?>> paramer, com.google.gson.JsonDeserializationContext paramJsonDeserializationContext)
  internal dz(JsonElement paramJsonElement, Type paramType, ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<T1> paramer, JsonDeserializationContext paramJsonDeserializationContext) : base(paramJsonElement, paramType, paramObjectNavigator, paramdr, parameo, paramer, paramJsonDeserializationContext)
  {
  }

  private string a(FieldAttributes paramFieldAttributes)
  {
	return this.b.a(paramFieldAttributes);
  }

  protected internal override T a()
  {
	return this.c.a(this.g);
  }

  public void startVisitingObject(object paramObject)
  {
  }

  public void visitArray(object paramObject, Type paramType)
  {
	throw new JsonParseException("Expecting object but found array: " + paramObject);
  }

  public void visitArrayField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	StringBuilder stringBuilder;
	try
	{
	  if (!this.f.JsonObject)
	  {
		JsonParseException jsonParseException = new JsonParseException();
		stringBuilder = new StringBuilder();
		this();
		this(stringBuilder.Append("Expecting object found: ").Append(this.f).ToString());
		throw jsonParseException;
	  }
	}
	catch (IllegalAccessException illegalAccessException)
	{
	  throw new Exception(illegalAccessException);
	}
	JsonArray jsonArray = (JsonArray)this.f.AsJsonObject.get(a((FieldAttributes)illegalAccessException));
	if (jsonArray != null)
	{
	  illegalAccessException.a(paramObject, a((Type)stringBuilder, jsonArray));
	  return;
	}
	illegalAccessException.a(paramObject, null);
  }

  public bool visitFieldUsingCustomHandler(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	bool @bool = true;
	try
	{
	  str = a(paramFieldAttributes);
	  if (!this.f.JsonObject)
	  {
		jsonParseException = new JsonParseException();
		StringBuilder stringBuilder = new StringBuilder();
		this();
		this(stringBuilder.Append("Expecting object found: ").Append(this.f).ToString());
		throw jsonParseException;
	  }
	}
	catch (IllegalAccessException)
	{
	  throw new Exception();
	}
	JsonElement jsonElement = this.f.AsJsonObject.get(str);
	bool bool1 = es.a((Type)jsonParseException);
	if (jsonElement == null)
	{
	  return @bool;
	}
	if (jsonElement.JsonNull)
	{
	  bool bool2 = @bool;
	  if (!bool1)
	  {
		illegalAccessException.a(paramObject, null);
		bool2 = @bool;
	  }
	  return bool2;
	}
	ep ep = new ep();
	this(null, (Type)jsonParseException, false);
	JsonParseException jsonParseException;
	string str;
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: eq<com.google.gson.JsonDeserializer<?>, ep> eq = ep.a(this.d);
	eq<JsonDeserializer<object>, ep> eq = ep.a(this.d);
	if (eq == null)
	{
	  return false;
	}
	object @object = a(jsonElement, eq);
	if (@object == null)
	{
	  bool bool2 = @bool;
	  if (!bool1)
	  {
		illegalAccessException.a(paramObject, @object);
		return @bool;
	  }
	  return bool2;
	}
	illegalAccessException.a(paramObject, @object);
	return @bool;
  }

  public void visitObjectField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	JsonParseException jsonParseException;
	try
	{
	  if (!this.f.JsonObject)
	  {
		jsonParseException = new JsonParseException();
		StringBuilder stringBuilder = new StringBuilder();
		this();
		this(stringBuilder.Append("Expecting object found: ").Append(this.f).ToString());
		throw jsonParseException;
	  }
	}
	catch (IllegalAccessException illegalAccessException)
	{
	  throw new Exception(illegalAccessException);
	}
	JsonElement jsonElement = this.f.AsJsonObject.get(a((FieldAttributes)illegalAccessException));
	if (jsonElement != null)
	{
	  illegalAccessException.a(paramObject, a((Type)jsonParseException, jsonElement));
	  return;
	}
	illegalAccessException.a(paramObject, null);
  }

  public void visitPrimitive(object paramObject)
  {
	if (!this.f.JsonPrimitive)
	{
	  throw new JsonParseException("Type information is unavailable, and the target object is not a primitive: " + this.f);
	}
	this.e = (T)this.f.AsJsonPrimitive.a();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dz.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */