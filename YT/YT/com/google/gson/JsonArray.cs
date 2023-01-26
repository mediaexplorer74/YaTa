using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace com.google.gson
{
	using do;

	public sealed class JsonArray : JsonElement, IEnumerable<JsonElement>
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly IList<JsonElement> a_Conflict = new List<JsonElement>();

	  internal override object a()
	  {
		if (this.a_Conflict.Count == 1)
		{
		  return ((JsonElement)this.a_Conflict[0]).a();
		}
		throw new System.InvalidOperationException();
	  }

	  public void add(JsonElement paramJsonElement)
	  {
		JsonElement jsonElement = paramJsonElement;
		if (paramJsonElement == null)
		{
		  jsonElement = JsonNull.c();
		}
		this.a_Conflict.Add(jsonElement);
	  }

	  public void addAll(JsonArray paramJsonArray)
	  {
		((List<JsonElement>)this.a_Conflict).AddRange(paramJsonArray.a_Conflict);
	  }

	  public override bool Equals(object paramObject)
	  {
//JAVA TO C# CONVERTER WARNING: LINQ 'SequenceEqual' is not always identical to Java AbstractList 'equals':
//ORIGINAL LINE: return (paramObject == this || (paramObject instanceof JsonArray && ((JsonArray)paramObject).a.equals(this.a)));
		return (paramObject == this || (paramObject is JsonArray && ((JsonArray)paramObject).a_Conflict.SequenceEqual(this.a_Conflict)));
	  }

	  public JsonElement get(int paramInt)
	  {
		return this.a_Conflict[paramInt];
	  }

	  public override decimal AsBigDecimal
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsBigDecimal;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override BigInteger AsBigInteger
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsBigInteger;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override bool AsBoolean
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsBoolean;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override sbyte AsByte
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsByte;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override char AsCharacter
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsCharacter;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override double AsDouble
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsDouble;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override float AsFloat
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsFloat;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override int AsInt
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsInt;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override long AsLong
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsLong;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override Number AsNumber
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsNumber;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override short AsShort
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsShort;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override string AsString
	  {
		  get
		  {
			if (this.a_Conflict.Count == 1)
			{
			  return ((JsonElement)this.a_Conflict[0]).AsString;
			}
			throw new System.InvalidOperationException();
		  }
	  }

	  public override int GetHashCode()
	  {
		return this.a_Conflict.GetHashCode();
	  }

	  public IEnumerator<JsonElement> GetEnumerator()
	  {
		return this.a_Conflict.GetEnumerator();
	  }

	  public int size()
	  {
		return this.a_Conflict.Count;
	  }

	  protected internal override void toString(Appendable paramAppendable, do paramdo)
	  {
		paramAppendable.append('[');
		IEnumerator<JsonElement> iterator = this.a_Conflict.GetEnumerator();
		bool @bool = true;
		while (iterator.MoveNext())
		{
		  JsonElement jsonElement = iterator.Current;
		  if (@bool)
		  {
			@bool = false;
		  }
		  else
		  {
			paramAppendable.append(',');
		  }
		  jsonElement.toString(paramAppendable, paramdo);
		}
		paramAppendable.append(']');
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonArray.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}