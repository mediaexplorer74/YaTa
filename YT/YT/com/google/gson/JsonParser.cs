using System.Text;

namespace com.google.gson
{
	using JsonReader = com.google.gson.stream.JsonReader;
	using JsonToken = com.google.gson.stream.JsonToken;
	using MalformedJsonException = com.google.gson.stream.MalformedJsonException;
	using ew;

	public sealed class JsonParser
	{
	  public JsonElement parse(JsonReader paramJsonReader)
	  {
		bool @bool = paramJsonReader.Lenient;
		paramJsonReader.Lenient = true;
		try
		{
		  return ew.a(paramJsonReader);
		}
		catch (StackOverflowError stackOverflowError)
		{
		  JsonParseException jsonParseException = new JsonParseException();
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  this(stringBuilder.Append("Failed parsing JSON source: ").Append(paramJsonReader).Append(" to Json").ToString(), stackOverflowError);
		  throw jsonParseException;
		}
		catch (System.OutOfMemoryException outOfMemoryError)
		{
		  JsonParseException jsonParseException = new JsonParseException();
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  this(stringBuilder.Append("Failed parsing JSON source: ").Append(paramJsonReader).Append(" to Json").ToString(), outOfMemoryError);
		  throw jsonParseException;
		}
		catch (JsonParseException jsonParseException)
		{
		  JsonNull jsonNull;
		  if (jsonParseException.InnerException is java.io.EOFException)
		  {
			jsonNull = JsonNull.c();
			return jsonNull;
		  }
		  throw jsonNull;
		}
		finally
		{
		  paramJsonReader.Lenient = @bool;
		}
	  }

	  public JsonElement parse(Reader paramReader)
	  {
		try
		{
		  JsonReader jsonReader = new JsonReader();
		  this(paramReader);
		  JsonElement jsonElement = parse(jsonReader);
		  if (!jsonElement.JsonNull && jsonReader.peek() != JsonToken.END_DOCUMENT)
		  {
			JsonSyntaxException jsonSyntaxException = new JsonSyntaxException();
			this("Did not consume the entire document.");
			throw jsonSyntaxException;
		  }
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
		return (JsonElement)numberFormatException;
	  }

	  public JsonElement parse(string paramString)
	  {
		return parse(new StringReader(paramString));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonParser.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}