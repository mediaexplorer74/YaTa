using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class ct : JsonSerializer<Time>, JsonDeserializer<Time>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly DateFormat a_Conflict = new SimpleDateFormat("hh:mm:ss a");

  public JsonElement a(Time paramTime)
  {
	lock (this.a_Conflict)
	{
	  string str = this.a_Conflict.format(paramTime);
	  JsonPrimitive jsonPrimitive = new JsonPrimitive();
	  this(str);
	  return (JsonElement)jsonPrimitive;
	}
  }

  public Time a(JsonElement paramJsonElement)
  {
	if (!(paramJsonElement is JsonPrimitive))
	{
	  throw new JsonParseException("The date should be a string value");
	}
	try
	{
	  lock (this.a_Conflict)
	  {
		DateTime date = this.a_Conflict.parse(paramJsonElement.AsString);
		Time time = new Time();
		this(date.Ticks);
		return time;
	  }
	}
	catch (ParseException parseException)
	{
	  throw new JsonSyntaxException(parseException);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ct.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */