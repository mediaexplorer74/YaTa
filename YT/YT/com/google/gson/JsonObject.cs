using System.Collections;
using System.Collections.Generic;

namespace com.google.gson
{
	using  = com.google.gson.@internal.;
	using do;

	public sealed class JsonObject : JsonElement
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly IDictionary<string, JsonElement> a_Conflict = new LinkedHashMap<string, JsonElement>();

	  private static JsonElement a(object paramObject)
	  {
		return (JsonElement)((paramObject == null) ? JsonNull.c() : new JsonPrimitive(paramObject));
	  }

	  public void add(string paramString, JsonElement paramJsonElement)
	  {
		JsonElement jsonElement = paramJsonElement;
		if (paramJsonElement == null)
		{
		  jsonElement = JsonNull.c();
		}
		this.a_Conflict[.Gson.Preconditions.checkNotNull(paramString)] = jsonElement;
	  }

	  public void addProperty(string paramString, bool? paramBoolean)
	  {
		add(paramString, a(paramBoolean));
	  }

	  public void addProperty(string paramString, char? paramCharacter)
	  {
		add(paramString, a(paramCharacter));
	  }

	  public void addProperty(string paramString, Number paramNumber)
	  {
		add(paramString, a(paramNumber));
	  }

	  public void addProperty(string paramString1, string paramString2)
	  {
		add(paramString1, a(paramString2));
	  }

	  public ISet<KeyValuePair<string, JsonElement>> entrySet()
	  {
		return this.a_Conflict.SetOfKeyValuePairs();
	  }

	  public override bool Equals(object paramObject)
	  {
		return (paramObject == this || (paramObject is JsonObject && ((JsonObject)paramObject).a_Conflict.Equals(this.a_Conflict)));
	  }

	  public JsonElement get(string paramString)
	  {
		if (this.a_Conflict.ContainsKey(paramString))
		{
		  JsonElement jsonElement2 = this.a_Conflict[paramString];
		  JsonElement jsonElement1 = jsonElement2;
		  if (jsonElement2 == null)
		  {
			jsonElement1 = JsonNull.c();
		  }
		  return jsonElement1;
		}
		return null;
	  }

	  public JsonArray getAsJsonArray(string paramString)
	  {
		return (JsonArray)this.a_Conflict[paramString];
	  }

	  public JsonObject getAsJsonObject(string paramString)
	  {
		return (JsonObject)this.a_Conflict[paramString];
	  }

	  public JsonPrimitive getAsJsonPrimitive(string paramString)
	  {
		return (JsonPrimitive)this.a_Conflict[paramString];
	  }

	  public bool has(string paramString)
	  {
		return this.a_Conflict.ContainsKey(paramString);
	  }

	  public override int GetHashCode()
	  {
		return this.a_Conflict.GetHashCode();
	  }

	  public JsonElement remove(string paramString)
	  {
		return this.a_Conflict.Remove(paramString);
	  }

	  protected internal override void toString(Appendable paramAppendable, do paramdo)
	  {
		paramAppendable.append('{');
		IEnumerator<DictionaryEntry> iterator = this.a_Conflict.SetOfKeyValuePairs().GetEnumerator();
		bool @bool = true;
		while (iterator.MoveNext())
		{
		  DictionaryEntry entry = iterator.Current;
		  if (@bool)
		  {
			@bool = false;
		  }
		  else
		  {
			paramAppendable.append(',');
		  }
		  paramAppendable.append('"');
		  paramAppendable.append(paramdo.a((CharSequence)entry.Key));
		  paramAppendable.append("\":");
		  ((JsonElement)entry.Value).toString(paramAppendable, paramdo);
		}
		paramAppendable.append('}');
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonObject.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}