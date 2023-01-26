using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class cv : JsonDeserializer<double>
{
  private cv(sbyte paramByte)
  {
  }

  public static double? a(JsonElement paramJsonElement)
  {
	try
	{
	  double d = paramJsonElement.AsDouble;
	  return Convert.ToDouble(d);
	}
	catch (System.FormatException numberFormatException)
	{
	  throw new JsonSyntaxException(numberFormatException);
	}
	catch (System.NotSupportedException unsupportedOperationException)
	{
	  throw new JsonSyntaxException(unsupportedOperationException);
	}
	catch (System.InvalidOperationException illegalStateException)
	{
	  throw new JsonSyntaxException(illegalStateException);
	}
  }

  public override string ToString()
  {
	return typeof(cv).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cv.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */