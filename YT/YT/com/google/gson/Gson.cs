using System;
using System.Collections.Generic;

namespace com.google.gson
{
	using @as;
	using ci;
	using JsonReader = com.google.gson.stream.JsonReader;
	using JsonToken = com.google.gson.stream.JsonToken;
	using JsonWriter = com.google.gson.stream.JsonWriter;
	using MalformedJsonException = com.google.gson.stream.MalformedJsonException;
	using dn;
	using dr;
	using du;
	using dw;
	using ea;
	using ek;
	using em;
	using er;
	using es;
	using ev;
	using ew;
	using ey;
	using fa;

	public sealed class Gson
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal static readonly @as a_Conflict = new @as();

	  internal static readonly fa b = new fa(true);

	  internal static readonly em c = new em(new int[] {128, 8});

	  internal static readonly dr d = (dr)new ev((dr)new du());

	  private static readonly ExclusionStrategy e;

	  private readonly ExclusionStrategy f;

	  private readonly ExclusionStrategy g;

	  private readonly dr h;

	  private readonly ek i;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<JsonSerializer<?>> j;
	  private readonly er<JsonSerializer<object>> j;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<JsonDeserializer<?>> k;
	  private readonly er<JsonDeserializer<object>> k;

	  private readonly bool l;

	  private readonly bool m;

	  private readonly bool n;

	  private readonly bool o;

	  static Gson()
	  {
		LinkedList<@as> linkedList = new LinkedList();
		linkedList.AddLast(a_Conflict);
		linkedList.AddLast(b);
		linkedList.AddLast(c);
		e = (ExclusionStrategy)new dn(linkedList);
	  }

	  public Gson() : this(e, e, d, new ek(ci.d()), false, ci.a(), ci.b(), false, true, false)
	  {
	  }

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: Gson(ExclusionStrategy paramExclusionStrategy1, ExclusionStrategy paramExclusionStrategy2, dr paramdr, ek paramek, boolean paramBoolean1, er<JsonSerializer<?>> paramer, er<JsonDeserializer<?>> paramer1, boolean paramBoolean2, boolean paramBoolean3, boolean paramBoolean4)
	  internal Gson(ExclusionStrategy paramExclusionStrategy1, ExclusionStrategy paramExclusionStrategy2, dr paramdr, ek paramek, bool paramBoolean1, er<T1> paramer, er<T2> paramer1, bool paramBoolean2, bool paramBoolean3, bool paramBoolean4)
	  {
		this.f = paramExclusionStrategy1;
		this.g = paramExclusionStrategy2;
		this.h = paramdr;
		this.i = paramek;
		this.l = paramBoolean1;
		this.j = paramer;
		this.k = paramer1;
		this.n = paramBoolean2;
		this.m = paramBoolean3;
		this.o = paramBoolean4;
	  }

	  private static void a(object paramObject, JsonReader paramJsonReader)
	  {
		if (paramObject != null)
		{
		  try
		  {
			if (paramJsonReader.peek() != JsonToken.END_DOCUMENT)
			{
			  paramObject = new JsonIOException();
			  base("JSON document was not fully consumed.");
			  throw paramObject;
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
		}
	  }

	  public T fromJson<T>(JsonElement paramJsonElement, Type paramClass)
	  {
		paramJsonElement = fromJson(paramJsonElement, paramClass);
		return es.a(paramClass).cast(paramJsonElement);
	  }

	  public T fromJson<T>(JsonElement paramJsonElement, Type paramType)
	  {
		return (T)((paramJsonElement == null) ? null : (new dw(new ObjectNavigator(this.f), this.h, this.k, this.i)).deserialize(paramJsonElement, paramType));
	  }

	  public T fromJson<T>(JsonReader paramJsonReader, Type paramType)
	  {
		bool @bool = paramJsonReader.Lenient;
		paramJsonReader.Lenient = true;
		try
		{
		  paramType = fromJson(ew.a(paramJsonReader), paramType);
		  return (T)paramType;
		}
		finally
		{
		  paramJsonReader.Lenient = @bool;
		}
	  }

	  public T fromJson<T>(Reader paramReader, Type paramClass)
	  {
		JsonReader jsonReader = new JsonReader(paramReader);
		object @object = fromJson(jsonReader, paramClass);
		a(@object, jsonReader);
		return es.a(paramClass).cast(@object);
	  }

	  public T fromJson<T>(Reader paramReader, Type paramType)
	  {
		JsonReader jsonReader = new JsonReader(paramReader);
		paramType = fromJson(jsonReader, paramType);
		a(paramType, jsonReader);
		return (T)paramType;
	  }

	  public T fromJson<T>(string paramString, Type paramClass)
	  {
		paramString = fromJson(paramString, paramClass);
		return es.a(paramClass).cast(paramString);
	  }

	  public T fromJson<T>(string paramString, Type paramType)
	  {
		return (T)((string.ReferenceEquals(paramString, null)) ? null : fromJson(new StringReader(paramString), paramType));
	  }

	  public string toJson(JsonElement paramJsonElement)
	  {
		StringWriter stringWriter = new StringWriter();
		toJson(paramJsonElement, stringWriter);
		return stringWriter.ToString();
	  }

	  public string toJson(object paramObject)
	  {
		return (paramObject == null) ? toJson(JsonNull.c()) : toJson(paramObject, paramObject.GetType());
	  }

	  public string toJson(object paramObject, Type paramType)
	  {
		StringWriter stringWriter = new StringWriter();
		toJson(toJsonTree(paramObject, paramType), stringWriter);
		return stringWriter.ToString();
	  }

	  public void toJson(JsonElement paramJsonElement, JsonWriter paramJsonWriter)
	  {
		bool bool1 = paramJsonWriter.Lenient;
		paramJsonWriter.Lenient = true;
		bool bool2 = paramJsonWriter.HtmlSafe;
		paramJsonWriter.HtmlSafe = this.m;
		try
		{
		  ew.a(paramJsonElement, this.l, paramJsonWriter);
		  return;
		}
		catch (IOException iOException)
		{
		  JsonIOException jsonIOException = new JsonIOException();
		  this(iOException);
		  throw jsonIOException;
		}
		finally
		{
		  paramJsonWriter.Lenient = bool1;
		  paramJsonWriter.HtmlSafe = bool2;
		}
	  }

	  public void toJson(JsonElement paramJsonElement, Appendable paramAppendable)
	  {
		try
		{
		  ey ey;
		  if (this.n)
		  {
			paramAppendable.append(")]}'\n");
		  }
		  JsonWriter jsonWriter = new JsonWriter();
		  if (paramAppendable is Writer)
		  {
			paramAppendable = paramAppendable;
		  }
		  else
		  {
			ey = new ey(paramAppendable);
		  }
		  this((Writer)ey);
		  if (this.o)
		  {
			jsonWriter.Indent = "  ";
		  }
		  toJson(paramJsonElement, jsonWriter);
		  return;
		}
		catch (IOException iOException)
		{
		  throw new Exception(iOException);
		}
	  }

	  public void toJson(object paramObject, Appendable paramAppendable)
	  {
		if (paramObject != null)
		{
		  toJson(paramObject, paramObject.GetType(), paramAppendable);
		  return;
		}
		toJson(JsonNull.c(), paramAppendable);
	  }

	  public void toJson(object paramObject, Type paramType, JsonWriter paramJsonWriter)
	  {
		toJson(toJsonTree(paramObject, paramType), paramJsonWriter);
	  }

	  public void toJson(object paramObject, Type paramType, Appendable paramAppendable)
	  {
		toJson(toJsonTree(paramObject, paramType), paramAppendable);
	  }

	  public JsonElement toJsonTree(object paramObject)
	  {
		return (paramObject == null) ? JsonNull.c() : toJsonTree(paramObject, paramObject.GetType());
	  }

	  public JsonElement toJsonTree(object paramObject, Type paramType)
	  {
		return (new ea(new ObjectNavigator(this.g), this.h, this.l, this.j)).serialize(paramObject, paramType);
	  }

	  public override string ToString()
	  {
		return "{" + "serializeNulls:" + this.l + ",serializers:" + this.j + ",deserializers:" + this.k + ",instanceCreators:" + this.i + "}";
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\Gson.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}