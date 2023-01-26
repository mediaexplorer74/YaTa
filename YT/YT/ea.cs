using JsonElement = com.google.gson.JsonElement;
using JsonNull = com.google.gson.JsonNull;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using ObjectNavigator = com.google.gson.ObjectNavigator;

public sealed class ea : JsonSerializationContext
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly ObjectNavigator a_Conflict;

  private readonly dr b;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<com.google.gson.JsonSerializer<?>> c;
  private readonly er<JsonSerializer<object>> c;

  private readonly bool d;

  private readonly el e;

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: public ea(com.google.gson.ObjectNavigator paramObjectNavigator, dr paramdr, boolean paramBoolean, er<com.google.gson.JsonSerializer<?>> paramer)
  public ea(ObjectNavigator paramObjectNavigator, dr paramdr, bool paramBoolean, er<T1> paramer)
  {
	this.a_Conflict = paramObjectNavigator;
	this.b = paramdr;
	this.d = paramBoolean;
	this.c = paramer;
	this.e = new el();
  }

  internal JsonElement a(object paramObject, Type paramType, bool paramBoolean)
  {
	if (paramObject == null)
	{
	  return (JsonElement)JsonNull.c();
	}
	eb eb = new eb(this.a_Conflict, this.b, this.d, this.c, this, this.e);
	this.a_Conflict.a(new ep(paramObject, paramType, paramBoolean), eb);
	return eb.a();
  }

  public JsonElement serialize(object paramObject)
  {
	return (JsonElement)((paramObject == null) ? JsonNull.c() : a(paramObject, paramObject.GetType(), false));
  }

  public JsonElement serialize(object paramObject, Type paramType)
  {
	return a(paramObject, paramType, true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ea.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */