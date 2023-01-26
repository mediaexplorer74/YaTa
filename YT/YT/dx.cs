using JsonArray = com.google.gson.JsonArray;
using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using ObjectNavigator = com.google.gson.ObjectNavigator;
using  = com.google.gson.@internal.;

internal abstract class dx<T> : ObjectNavigator.Visitor
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  protected internal readonly ObjectNavigator a_Conflict;

  protected internal readonly dr b;

  protected internal readonly eo c;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: protected final er<com.google.gson.JsonDeserializer<?>> d;
  protected internal readonly er<JsonDeserializer<object>> d;

  protected internal T e;

  protected internal readonly JsonElement f;

  protected internal readonly Type g;

  protected internal readonly JsonDeserializationContext h;

  protected internal bool i;

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: dx(com.google.gson.JsonElement paramJsonElement, java.lang.reflect.Type paramType, com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<com.google.gson.JsonDeserializer<?>> paramer, com.google.gson.JsonDeserializationContext paramJsonDeserializationContext)
  internal dx(JsonElement paramJsonElement, Type paramType, ObjectNavigator paramObjectNavigator, dr paramdr, eo parameo, er<T1> paramer, JsonDeserializationContext paramJsonDeserializationContext)
  {
	this.g = paramType;
	this.a_Conflict = paramObjectNavigator;
	this.b = paramdr;
	this.c = parameo;
	this.d = paramer;
	this.f = (JsonElement).Gson.Preconditions.checkNotNull(paramJsonElement);
	this.h = paramJsonDeserializationContext;
	this.i = false;
  }

  private object a<T1>(Type paramType, dx<T1> paramdx)
  {
	this.a_Conflict.a(new ep(null, paramType, false), paramdx);
	return paramdx.Target;
  }

  protected internal abstract T a();

  protected internal virtual object a<T1>(JsonElement paramJsonElement, eq<T1> parameq)
  {
	if (paramJsonElement == null || paramJsonElement.JsonNull)
	{
	  return null;
	}
	Type type = ((ep)parameq.b).a_Conflict;
	return ((JsonDeserializer)parameq.a_Conflict).deserialize(paramJsonElement, type, this.h);
  }

  internal object a(Type paramType, JsonArray paramJsonArray)
  {
	return a(paramType, new dv(paramJsonArray.AsJsonArray, paramType, this.a_Conflict, this.b, this.c, this.d, this.h));
  }

  internal object a(Type paramType, JsonElement paramJsonElement)
  {
	return a(paramType, new dz(paramJsonElement, paramType, this.a_Conflict, this.b, this.c, this.d, this.h));
  }

  public virtual void end(ep paramep)
  {
  }

  public virtual T Target
  {
	  get
	  {
		if (!this.i)
		{
		  this.e = a();
		  this.i = true;
		}
		return this.e;
	  }
  }

  public virtual void start(ep paramep)
  {
  }

  public bool visitUsingCustomHandler(ep paramep)
  {
	bool @bool = true;
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: eq<com.google.gson.JsonDeserializer<?>, ep> eq = paramep.a(this.d);
	eq<JsonDeserializer<object>, ep> eq = paramep.a(this.d);
	if (eq == null)
	{
	  return false;
	}
	this.e = (T)a(this.f, eq);
	this.i = true;
	return @bool;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dx.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */