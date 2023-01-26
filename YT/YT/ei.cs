using System.Collections.Generic;

using JsonArray = com.google.gson.JsonArray;
using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonObject = com.google.gson.JsonObject;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

public sealed class ei : bd, JsonSerializer<IDictionary<JavaToDotNetGenericWildcard, JavaToDotNetGenericWildcard>>, JsonDeserializer<IDictionary<JavaToDotNetGenericWildcard, JavaToDotNetGenericWildcard>>
{
  private static void a(object paramObject1, int paramInt1, object paramObject2, int paramInt2)
  {
	if (paramInt1 != paramInt2)
	{
	  throw new JsonSyntaxException("Input size " + paramInt1 + " != output size " + paramInt2 + " for input " + paramObject1 + " and output " + paramObject2);
	}
  }

  private static Type[] a(Type paramType)
  {
	Type[] arrayOfType;
	if (paramType is ParameterizedType)
	{
	  Type[] arrayOfType1 = ((ParameterizedType)paramType).getActualTypeArguments();
	  arrayOfType = arrayOfType1;
	  if (arrayOfType1.Length != 2)
	  {
		throw new System.ArgumentException("MapAsArrayTypeAdapter cannot handle " + paramType);
	  }
	}
	else
	{
	  arrayOfType = new Type[2];
	  arrayOfType[0] = typeof(object);
	  arrayOfType[1] = typeof(object);
	}
	return arrayOfType;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ei.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */