using System.Collections.Generic;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

internal abstract class bd : JsonSerializer<IDictionary<JavaToDotNetGenericWildcard, JavaToDotNetGenericWildcard>>, JsonDeserializer<IDictionary<JavaToDotNetGenericWildcard, JavaToDotNetGenericWildcard>>
{
	public abstract T deserialize(JsonElement paramJsonElement, Type paramType, JsonDeserializationContext paramJsonDeserializationContext);
	public abstract JsonElement serialize(T paramT, Type paramType, JsonSerializationContext paramJsonSerializationContext);
  protected internal static JsonElement a(JsonSerializationContext paramJsonSerializationContext, object paramObject, Type paramType)
  {
	return ((ea)paramJsonSerializationContext).a(paramObject, paramType, false);
  }

  protected internal static IDictionary<object, object> a(Type paramType, JsonDeserializationContext paramJsonDeserializationContext)
  {
	return ((dw)paramJsonDeserializationContext).a().a<IDictionary<object, object>>(paramType);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */