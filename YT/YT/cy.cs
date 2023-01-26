using System;

using JsonDeserializationContext = com.google.gson.JsonDeserializationContext;
using com.google.gson;
using JsonElement = com.google.gson.JsonElement;
using JsonSyntaxException = com.google.gson.JsonSyntaxException;

internal sealed class cy : JsonDeserializer<float>
{
  private cy(sbyte paramByte)
  {
  }

  public static float? a(JsonElement paramJsonElement)
  {
	try
	{
	  float f = paramJsonElement.AsFloat;
	  return Convert.ToSingle(f);
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
	return typeof(cy).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cy.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */