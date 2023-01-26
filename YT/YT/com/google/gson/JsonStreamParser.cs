using System.Collections.Generic;

namespace com.google.gson
{
	using JsonReader = com.google.gson.stream.JsonReader;
	using JsonToken = com.google.gson.stream.JsonToken;
	using ew;

	public sealed class JsonStreamParser : IEnumerator<JsonElement>
	{
	  private readonly JsonReader a;

	  private readonly object b;

	  public JsonStreamParser(Reader paramReader)
	  {
		this.a = new JsonReader(paramReader);
		this.a.Lenient = true;
		this.b = new object();
	  }

	  public JsonStreamParser(string paramString) : this(new StringReader(paramString))
	  {
	  }

	  public bool hasNext()
	  {
		lock (this.b)
		{
		  JsonToken jsonToken1 = this.a.peek();
		  JsonToken jsonToken2 = JsonToken.END_DOCUMENT;
		  if (jsonToken1 != jsonToken2)
		  {
			return true;
		  }
		  return false;
		}
	  }

	  public JsonElement next()
	  {
//JAVA TO C# CONVERTER TODO TASK: Java iterators are only converted within the context of 'while' and 'for' loops:
		if (!hasNext())
		{
		  throw new NoSuchElementException();
		}
		try
		{
		  return ew.a(this.a);
		}
		catch (StackOverflowError stackOverflowError)
		{
		  throw new JsonParseException("Failed parsing JSON source to Json", stackOverflowError);
		}
		catch (System.OutOfMemoryException outOfMemoryError)
		{
		  throw new JsonParseException("Failed parsing JSON source to Json", outOfMemoryError);
		}
		catch (JsonParseException jsonParseException2)
		{
		  NoSuchElementException noSuchElementException;
		  JsonParseException jsonParseException1 = jsonParseException2;
		  if (jsonParseException2.InnerException is java.io.EOFException)
		  {
			noSuchElementException = new NoSuchElementException();
		  }
		  throw noSuchElementException;
		}
	  }

	  public void remove()
	  {
		throw new System.NotSupportedException();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonStreamParser.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}