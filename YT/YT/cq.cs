using System;
using System.Text;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonParseException = com.google.gson.JsonParseException;
using JsonPrimitive = com.google.gson.JsonPrimitive;
using JsonSerializationContext = com.google.gson.JsonSerializationContext;
using com.google.gson;

public sealed class cq : JsonSerializer<DateTime>, JsonDeserializer<DateTime>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly DateFormat a_Conflict;

  private readonly DateFormat b;

  private readonly DateFormat c;

  internal cq() : this(DateFormat.getDateTimeInstance(2, 2, Locale.US), DateFormat.getDateTimeInstance(2, 2))
  {
  }

  public cq(int paramInt1, int paramInt2) : this(DateFormat.getDateTimeInstance(paramInt1, paramInt2, Locale.US), DateFormat.getDateTimeInstance(paramInt1, paramInt2))
  {
  }

  public cq(string paramString) : this(new SimpleDateFormat(paramString, Locale.US), new SimpleDateFormat(paramString))
  {
  }

  internal cq(DateFormat paramDateFormat1, DateFormat paramDateFormat2)
  {
	this.a_Conflict = paramDateFormat1;
	this.b = paramDateFormat2;
	this.c = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss'Z'", Locale.US);
	this.c.setTimeZone(TimeZone.getTimeZone("UTC"));
  }

  private Date a(JsonElement paramJsonElement)
  {
	lock (this.b)
	{
	  Date date = this.b.parse(paramJsonElement.AsString);
	  null = date;
	  return null;
	}
  }

  public JsonElement a(Date paramDate)
  {
	lock (this.b)
	{
	  string str = this.a_Conflict.format(paramDate);
	  JsonPrimitive jsonPrimitive = new JsonPrimitive();
	  this(str);
	  return (JsonElement)jsonPrimitive;
	}
  }

  public Date a(JsonElement paramJsonElement, Type paramType)
  {
	if (!(paramJsonElement is JsonPrimitive))
	{
	  throw new JsonParseException("The date should be a string value");
	}
	Date date = a(paramJsonElement);
	if (paramType != typeof(Date))
	{
	  if (paramType == typeof(Timestamp))
	  {
		return new Timestamp(date.getTime());
	  }
	  if (paramType == typeof(Date))
	  {
		return new Date(date.getTime());
	  }
	  throw new System.ArgumentException(this.GetType() + " cannot deserialize to " + paramType);
	}
	return date;
  }

  public override string ToString()
  {
	StringBuilder stringBuilder = new StringBuilder();
	stringBuilder.Append(typeof(cq).Name);
	stringBuilder.Append('(').Append(this.b.GetType().Name).Append(')');
	return stringBuilder.ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */