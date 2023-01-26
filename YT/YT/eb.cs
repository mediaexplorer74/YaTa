using System;

using FieldAttributes = com.google.gson.FieldAttributes;
using JsonArray = com.google.gson.JsonArray;
using JsonElement = com.google.gson.JsonElement;
using JsonNull = com.google.gson.JsonNull;
using JsonObject = com.google.gson.JsonObject;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using ObjectNavigator = com.google.gson.ObjectNavigator;
using  = com.google.gson.@internal.;

internal sealed class eb : ObjectNavigator.Visitor
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly ObjectNavigator a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly dr b_Conflict;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<com.google.gson.JsonSerializer<?>> c;
  private readonly er<JsonSerializer<object>> c;

  private readonly bool d;

  private readonly JsonSerializationContext e;

  private readonly el f;

  private JsonElement g;

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: eb(com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, boolean paramBoolean, er<com.google.gson.JsonSerializer<?>> paramer, com.google.gson.JsonSerializationContext paramJsonSerializationContext, el paramel)
  internal eb(ObjectNavigator paramObjectNavigator, dr paramdr, bool paramBoolean, er<T1> paramer, JsonSerializationContext paramJsonSerializationContext, el paramel)
  {
	this.a_Conflict = paramObjectNavigator;
	this.b_Conflict = paramdr;
	this.d = paramBoolean;
	this.c = paramer;
	this.e = paramJsonSerializationContext;
	this.f = paramel;
  }

  private JsonElement a(ep paramep)
  {
	eb eb1 = new eb(this.a_Conflict, this.b_Conflict, this.d, this.c, this.e, this.f);
	this.a_Conflict.a(paramep, eb1);
	return eb1.a();
  }

  private void a(FieldAttributes paramFieldAttributes, JsonElement paramJsonElement)
  {
	this.g.AsJsonObject.add(this.b_Conflict.a(paramFieldAttributes), paramJsonElement);
  }

  private void a(FieldAttributes paramFieldAttributes, ep paramep)
  {
	a(paramFieldAttributes, a(paramep));
  }

  private void a(JsonElement paramJsonElement)
  {
	this.g = (JsonElement).Gson.Preconditions.checkNotNull(paramJsonElement);
  }

  private static bool a(FieldAttributes paramFieldAttributes, object paramObject)
  {
	return (b(paramFieldAttributes, paramObject) == null);
  }

  private JsonElement b(ep paramep)
  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: eq<com.google.gson.JsonSerializer<?>, ep> eq = paramep.a(this.c);
	eq<JsonSerializer<object>, ep> eq = paramep.a(this.c);
	if (eq == null)
	{
	  return null;
	}
	null = (JsonSerializer)eq.a_Conflict;
	ep ep1 = (ep)eq.b;
	start(ep1);
	try
	{
	  JsonElement jsonElement2 = null.serialize(ep1.a(), ep1.b(), this.e);
	  JsonElement jsonElement1 = jsonElement2;
	  if (jsonElement2 == null)
	  {
		JsonNull jsonNull = JsonNull.c();
	  }
	}
	finally
	{
	  end(ep1);
	}
	return (JsonElement)paramep;
  }

  private static object b(FieldAttributes paramFieldAttributes, object paramObject)
  {
	try
	{
	  return paramFieldAttributes.a(paramObject);
	}
	catch (IllegalAccessException illegalAccessException)
	{
	  throw new Exception(illegalAccessException);
	}
  }

  public JsonElement a()
  {
	return this.g;
  }

  public void end(ep paramep)
  {
	if (paramep != null)
	{
	  this.f.a();
	}
  }

  public object Target
  {
	  get
	  {
		return null;
	  }
  }

  public void start(ep paramep)
  {
	if (paramep != null)
	{
	  if (this.f.b(paramep))
	  {
		throw new cb(paramep);
	  }
	  this.f.a(paramep);
	}
  }

  public void startVisitingObject(object paramObject)
  {
	a((JsonElement)new JsonObject());
  }

  public void visitArray(object paramObject, Type paramType)
  {
	a((JsonElement)new JsonArray());
	int i = Array.getLength(paramObject);
	paramType = .Gson.Types.getArrayComponentType(paramType);
	for (sbyte b = 0; b < i; b++)
	{
	  ep ep = new ep(Array.get(paramObject, b), paramType, false);
	  if (ep.a() == null)
	  {
		this.g.AsJsonArray.add((JsonElement)JsonNull.c());
	  }
	  else
	  {
		JsonElement jsonElement = a(ep);
		this.g.AsJsonArray.add(jsonElement);
	  }
	}
  }

  public void visitArrayField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	try
	{
	  if (a(paramFieldAttributes, paramObject))
	  {
		if (this.d)
		{
		  a(paramFieldAttributes, (JsonElement)JsonNull.c());
		}
		return;
	  }
	  object @object = b(paramFieldAttributes, paramObject);
	  paramObject = new ep();
	  base(@object, paramType, false);
	  a(paramFieldAttributes, (ep)paramObject);
	  return;
	}
	catch (cb cb)
	{
	  throw cb.a(paramFieldAttributes);
	}
  }

  public bool visitFieldUsingCustomHandler(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	bool @bool = true;
	try
	{
	  .Gson.Preconditions.checkState(this.g.JsonObject);
	  object @object = paramFieldAttributes.a(paramObject);
	  if (@object == null)
	  {
		bool bool1 = @bool;
		if (this.d)
		{
		  a(paramFieldAttributes, (JsonElement)JsonNull.c());
		  bool1 = @bool;
		}
		return bool1;
	  }
	  paramObject = new ep();
	  base(@object, paramType, false);
	  JsonElement jsonElement = b((ep)paramObject);
	  if (jsonElement != null)
	  {
		a(paramFieldAttributes, jsonElement);
		return @bool;
	  }
	  return false;
	}
	catch (IllegalAccessException)
	{
	  throw new Exception();
	}
	catch (cb cb)
	{
	  throw cb.a(illegalAccessException);
	}
  }

  public void visitObjectField(FieldAttributes paramFieldAttributes, Type paramType, object paramObject)
  {
	try
	{
	  if (a(paramFieldAttributes, paramObject))
	  {
		if (this.d)
		{
		  a(paramFieldAttributes, (JsonElement)JsonNull.c());
		}
		return;
	  }
	  object @object = b(paramFieldAttributes, paramObject);
	  paramObject = new ep();
	  base(@object, paramType, false);
	  a(paramFieldAttributes, (ep)paramObject);
	  return;
	}
	catch (cb cb)
	{
	  throw cb.a(paramFieldAttributes);
	}
  }

  public void visitPrimitive(object paramObject)
  {
	if (paramObject == null)
	{
	  paramObject = JsonNull.c();
	}
	else
	{
	  paramObject = new JsonPrimitive(paramObject);
	}
	a((JsonElement)paramObject);
  }

  public bool visitUsingCustomHandler(ep paramep)
  {
	bool @bool = true;
	try
	{
	  if (paramep.a() == null)
	  {
		bool bool1 = @bool;
		if (this.d)
		{
		  a((JsonElement)JsonNull.c());
		  bool1 = @bool;
		}
		return bool1;
	  }
	  JsonElement jsonElement = b(paramep);
	  if (jsonElement != null)
	  {
		a(jsonElement);
		return @bool;
	  }
	}
	catch (cb cb)
	{
	  throw cb.a(null);
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\eb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */