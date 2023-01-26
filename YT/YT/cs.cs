using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class cs : JsonSerializer<DateTime>, JsonDeserializer<DateTime>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly DateFormat a_Conflict = new SimpleDateFormat("MMM d, yyyy");

  public JsonElement a(Date paramDate)
  {
	lock (this.a_Conflict)
	{
	  string str = this.a_Conflict.format(paramDate);
	  JsonPrimitive jsonPrimitive = new JsonPrimitive();
	  this(str);
	  return (JsonElement)jsonPrimitive;
	}
  }

  public Date a(JsonElement paramJsonElement)
  {
	if (!(paramJsonElement is JsonPrimitive))
	{
	  throw new JsonParseException("The date should be a string value");
	}
	try
	{
	  lock (this.a_Conflict)
	  {
		Date date1 = this.a_Conflict.parse(paramJsonElement.AsString);
		Date date = new Date();
		this(date1.getTime());
		return date;
	  }
	}
	catch (ParseException parseException)
	{
	  throw new JsonSyntaxException(parseException);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */