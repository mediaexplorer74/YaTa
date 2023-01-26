using System;
using System.Collections;

using JsonArray = com.google.gson.JsonArray;
using JsonElement = com.google.gson.JsonElement;
using JsonIOException = com.google.gson.JsonIOException;
using JsonNull = com.google.gson.JsonNull;
using JsonObject = com.google.gson.JsonObject;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;
using JsonReader = com.google.gson.stream.JsonReader;
using JsonWriter = com.google.gson.stream.JsonWriter;
using MalformedJsonException = com.google.gson.stream.MalformedJsonException;

public sealed class ew
{
  public static JsonElement a(JsonReader paramJsonReader)
  {
	bool @bool = true;
	try
	{
	  paramJsonReader.peek();
	  @bool = false;
	  return b(paramJsonReader);
	}
	catch (EOFException eOFException)
	{
	  if (@bool)
	  {
		return (JsonElement)JsonNull.c();
	  }
	  throw new JsonIOException(eOFException);
	}
	catch (MalformedJsonException malformedJsonException)
	{
	  throw new JsonSyntaxException(malformedJsonException);
	}
	catch (IOException iOException)
	{
	  throw new JsonIOException(iOException);
	}
	catch (System.FormatException numberFormatException)
	{
	  throw new JsonSyntaxException(numberFormatException);
	}
  }

  public static void a(JsonElement paramJsonElement, bool paramBoolean, JsonWriter paramJsonWriter)
  {
	JsonPrimitive jsonPrimitive;
	JsonElement jsonElement;
	if (paramJsonElement == null || paramJsonElement.JsonNull)
	{
	  if (paramBoolean)
	  {
		paramJsonWriter.nullValue();
	  }
	  return;
	}
	if (paramJsonElement.JsonPrimitive)
	{
	  jsonPrimitive = paramJsonElement.AsJsonPrimitive;
	  if (jsonPrimitive.Number)
	  {
		paramJsonWriter.value(jsonPrimitive.AsNumber);
		return;
	  }
	  if (jsonPrimitive.Boolean)
	  {
		paramJsonWriter.value(jsonPrimitive.AsBoolean);
		return;
	  }
	  paramJsonWriter.value(jsonPrimitive.AsString);
	  return;
	}
	if (jsonPrimitive.JsonArray)
	{
	  paramJsonWriter.beginArray();
	  foreach (JsonElement jsonElement1 in jsonPrimitive.AsJsonArray)
	  {
		if (jsonElement1.JsonNull)
		{
		  paramJsonWriter.nullValue();
		  continue;
		}
		a(jsonElement1, paramBoolean, paramJsonWriter);
	  }
	  paramJsonWriter.endArray();
	  return;
	}
	if (jsonPrimitive.JsonObject)
	{
	  paramJsonWriter.beginObject();
	  foreach (DictionaryEntry entry in jsonPrimitive.AsJsonObject.entrySet())
	  {
		jsonElement = (JsonElement)entry.Value;
		if (paramBoolean || !jsonElement.JsonNull)
		{
		  paramJsonWriter.name((string)entry.Key);
		  a(jsonElement, paramBoolean, paramJsonWriter);
		}
	  }
	  paramJsonWriter.endObject();
	  return;
	}
	throw new System.ArgumentException("Couldn't write " + jsonElement.GetType());
  }

  private static JsonElement b(JsonReader paramJsonReader)
  {
	JsonArray jsonArray;
	switch (ex.a[paramJsonReader.peek().ordinal()])
	{
	  default:
		throw new System.ArgumentException();
	  case 1:
		return (JsonElement)new JsonPrimitive(paramJsonReader.nextString());
	  case 2:
		return (JsonElement)new JsonPrimitive(JsonPrimitive.a(paramJsonReader.nextString()));
	  case 3:
		return (JsonElement)new JsonPrimitive(Convert.ToBoolean(paramJsonReader.nextBoolean()));
	  case 4:
		paramJsonReader.nextNull();
		return (JsonElement)JsonNull.c();
	  case 5:
		jsonArray = new JsonArray();
		paramJsonReader.beginArray();
		while (paramJsonReader.hasNext())
		{
		  jsonArray.add(b(paramJsonReader));
		}
		paramJsonReader.endArray();
		return (JsonElement)jsonArray;
	  case 6:
		break;
	}
	JsonObject jsonObject = new JsonObject();
	paramJsonReader.beginObject();
	while (paramJsonReader.hasNext())
	{
	  jsonObject.add(paramJsonReader.nextName(), b(paramJsonReader));
	}
	paramJsonReader.endObject();
	return (JsonElement)jsonObject;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ew.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */