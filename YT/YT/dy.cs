using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using  = com.google.gson.@internal.;

public sealed class dy<T> : JsonDeserializer<T>
{
  private readonly JsonDeserializer<T> a;

  public dy(JsonDeserializer<T> paramJsonDeserializer)
  {
	this.a = (JsonDeserializer<T>).Gson.Preconditions.checkNotNull(paramJsonDeserializer);
  }

  public T deserialize(JsonElement paramJsonElement, Type paramType, JsonDeserializationContext paramJsonDeserializationContext)
  {
	try
	{
	  return (T)this.a.deserialize(paramJsonElement, paramType, paramJsonDeserializationContext);
	}
	catch (JsonParseException jsonParseException)
	{
	  throw jsonParseException;
	}
	catch (Exception exception)
	{
	  throw new JsonParseException("The JsonDeserializer " + this.a + " failed to deserialize json object " + jsonParseException + " given the type " + paramType, exception);
	}
  }

  public override string ToString()
  {
	return this.a.ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */