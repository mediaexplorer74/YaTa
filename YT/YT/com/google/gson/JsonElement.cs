using System;
using System.Numerics;
using System.Text;

namespace com.google.gson
{
	using do;

	public abstract class JsonElement
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly do a_Conflict = new do(false);

	  internal virtual object a()
	  {
		throw new System.NotSupportedException();
	  }

	  internal virtual bool? b()
	  {
		throw new System.NotSupportedException();
	  }

	  public virtual decimal AsBigDecimal
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual BigInteger AsBigInteger
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual bool AsBoolean
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual sbyte AsByte
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual char AsCharacter
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual double AsDouble
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual float AsFloat
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual int AsInt
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual JsonArray AsJsonArray
	  {
		  get
		  {
			if (JsonArray)
			{
			  return (JsonArray)this;
			}
			throw new System.InvalidOperationException("This is not a JSON Array.");
		  }
	  }

	  public virtual JsonNull AsJsonNull
	  {
		  get
		  {
			if (JsonNull)
			{
			  return (JsonNull)this;
			}
			throw new System.InvalidOperationException("This is not a JSON Null.");
		  }
	  }

	  public virtual JsonObject AsJsonObject
	  {
		  get
		  {
			if (JsonObject)
			{
			  return (JsonObject)this;
			}
			throw new System.InvalidOperationException("This is not a JSON Object.");
		  }
	  }

	  public virtual JsonPrimitive AsJsonPrimitive
	  {
		  get
		  {
			if (JsonPrimitive)
			{
			  return (JsonPrimitive)this;
			}
			throw new System.InvalidOperationException("This is not a JSON Primitive.");
		  }
	  }

	  public virtual long AsLong
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual Number AsNumber
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual short AsShort
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual string AsString
	  {
		  get
		  {
			throw new System.NotSupportedException();
		  }
	  }

	  public virtual bool JsonArray
	  {
		  get
		  {
			return this is JsonArray;
		  }
	  }

	  public virtual bool JsonNull
	  {
		  get
		  {
			return this is JsonNull;
		  }
	  }

	  public virtual bool JsonObject
	  {
		  get
		  {
			return this is JsonObject;
		  }
	  }

	  public virtual bool JsonPrimitive
	  {
		  get
		  {
			return this is JsonPrimitive;
		  }
	  }

	  public override string ToString()
	  {
		try
		{
		  StringBuilder stringBuilder = new StringBuilder();
		  this();
		  toString(stringBuilder, a_Conflict);
		  return stringBuilder.ToString();
		}
		catch (IOException iOException)
		{
		  throw new Exception(iOException);
		}
	  }

	  protected internal abstract void toString(Appendable paramAppendable, do paramdo);
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonElement.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}