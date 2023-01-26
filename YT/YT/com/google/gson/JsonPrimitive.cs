using System;
using System.Numerics;

namespace com.google.gson
{
	using do;

	public sealed class JsonPrimitive : JsonElement
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly Type[] a_Conflict = new Type[] {typeof(int), typeof(long), typeof(short), typeof(float), typeof(double), typeof(sbyte), typeof(bool), typeof(char), typeof(Integer), typeof(Long), typeof(Short), typeof(Float), typeof(Double), typeof(Byte), typeof(Boolean), typeof(Character)};

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly BigInteger b_Conflict = 2147483647L;

	  private static readonly BigInteger c = long.MaxValue;

	  private object d;

	  public JsonPrimitive(bool? paramBoolean)
	  {
		a(paramBoolean);
	  }

	  public JsonPrimitive(char? paramCharacter)
	  {
		a(paramCharacter);
	  }

	  public JsonPrimitive(Number paramNumber)
	  {
		a(paramNumber);
	  }

	  public JsonPrimitive(object paramObject)
	  {
		a(paramObject);
	  }

	  public JsonPrimitive(string paramString)
	  {
		a(paramString);
	  }

	  public static Number a(string paramString)
	  {
		long? long_;
		try
		{
		  long l = long.Parse(paramString);
		  if (l >= -2147483648L && l <= 2147483647L)
		  {
			return Convert.ToInt32((int)l);
		  }
		  long_ = Convert.ToInt64(l);
		}
		catch (System.FormatException)
		{
		}
		return long_;
	  }

	  private static bool a(JsonPrimitive paramJsonPrimitive)
	  {
		if (paramJsonPrimitive.d is Number)
		{
		  Number number = (Number)paramJsonPrimitive.d;
		  return (number is BigInteger || number is long? || number is int? || number is short? || number is Byte);
		}
		return false;
	  }

	  private static bool b(JsonPrimitive paramJsonPrimitive)
	  {
		if (paramJsonPrimitive.d is Number)
		{
		  Number number = (Number)paramJsonPrimitive.d;
		  return (number is decimal || number is double? || number is Float);
		}
		return false;
	  }

	  public override object a()
	  {
		if (this.d is BigInteger)
		{
		  BigInteger bigInteger = (BigInteger)this.d;
		  if (bigInteger.compareTo(b_Conflict) < 0)
		  {
			return Convert.ToInt32((int)(uint)(bigInteger & uint.MaxValue));
		  }
		  if (bigInteger.compareTo(c) < 0)
		  {
			return Convert.ToInt64(bigInteger.longValue());
		  }
		}
		return this.d;
	  }

	  internal void a(object paramObject)
	  {
		// Byte code:
		//   0: iconst_0
		//   1: istore_2
		//   2: aload_1
		//   3: instanceof java/lang/Character
		//   6: ifeq -> 24
		//   9: aload_0
		//   10: aload_1
		//   11: checkcast java/lang/Character
		//   14: invokevirtual charValue : ()C
		//   17: invokestatic valueOf : (C)Ljava/lang/String;
		//   20: putfield d : Ljava/lang/Object;
		//   23: return
		//   24: aload_1
		//   25: instanceof java/lang/Number
		//   28: ifne -> 44
		//   31: aload_1
		//   32: instanceof java/lang/String
		//   35: ifeq -> 58
		//   38: iconst_1
		//   39: istore_3
		//   40: iload_3
		//   41: ifeq -> 46
		//   44: iconst_1
		//   45: istore_2
		//   46: iload_2
		//   47: invokestatic checkArgument : (Z)V
		//   50: aload_0
		//   51: aload_1
		//   52: putfield d : Ljava/lang/Object;
		//   55: goto -> 23
		//   58: aload_1
		//   59: invokevirtual getClass : ()Ljava/lang/Class;
		//   62: astore #4
		//   64: getstatic com/google/gson/JsonPrimitive.a : [Ljava/lang/Class;
		//   67: astore #5
		//   69: aload #5
		//   71: arraylength
		//   72: istore #6
		//   74: iconst_0
		//   75: istore_3
		//   76: iload_3
		//   77: iload #6
		//   79: if_icmpge -> 105
		//   82: aload #5
		//   84: iload_3
		//   85: aaload
		//   86: aload #4
		//   88: invokevirtual isAssignableFrom : (Ljava/lang/Class;)Z
		//   91: ifeq -> 99
		//   94: iconst_1
		//   95: istore_3
		//   96: goto -> 40
		//   99: iinc #3, 1
		//   102: goto -> 76
		//   105: iconst_0
		//   106: istore_3
		//   107: goto -> 40
	  }

	  internal override bool? b()
	  {
		return (bool?)this.d;
	  }

	  public override bool Equals(object paramObject)
	  {
		bool @bool = true;
		if (this == paramObject)
		{
		  return @bool;
		}
		if (paramObject == null || this.GetType() != paramObject.GetType())
		{
		  return false;
		}
		paramObject = paramObject;
		if (this.d == null)
		{
		  bool bool1 = @bool;
		  if (((JsonPrimitive)paramObject).d != null)
		  {
			bool1 = false;
		  }
		  return bool1;
		}
		if (a(this) && a((JsonPrimitive)paramObject))
		{
		  bool bool1 = @bool;
		  if (AsNumber.longValue() != paramObject.getAsNumber().longValue())
		  {
			bool1 = false;
		  }
		  return bool1;
		}
		if (b(this) && b((JsonPrimitive)paramObject))
		{
		  double d1 = AsNumber.doubleValue();
		  double d2 = paramObject.getAsNumber().doubleValue();
		  bool bool1 = @bool;
		  if (d1 != d2)
		  {
			if (double.IsNaN(d1))
			{
			  bool1 = @bool;
			  return !double.IsNaN(d2) ? false : bool1;
			}
		  }
		  else
		  {
			return bool1;
		  }
		}
		else
		{
		  return this.d.Equals(((JsonPrimitive)paramObject).d);
		}
		return false;
	  }

	  public override decimal AsBigDecimal
	  {
		  get
		  {
			return (this.d is decimal) ? (decimal)this.d : new decimal(this.d.ToString());
		  }
	  }

	  public override BigInteger AsBigInteger
	  {
		  get
		  {
			return (this.d is BigInteger) ? (BigInteger)this.d : new BigInteger(this.d.ToString());
		  }
	  }

	  public override bool AsBoolean
	  {
		  get
		  {
			return Boolean ? b().Value : bool.Parse(AsString);
		  }
	  }

	  public override sbyte AsByte
	  {
		  get
		  {
			if (Number)
			{
			  return AsNumber.byteValue();
			}
			return sbyte.Parse(AsString);
		  }
	  }

	  public override char AsCharacter
	  {
		  get
		  {
			return AsString[0];
		  }
	  }

	  public override double AsDouble
	  {
		  get
		  {
			return Number ? AsNumber.doubleValue() : double.Parse(AsString);
		  }
	  }

	  public override float AsFloat
	  {
		  get
		  {
			return Number ? AsNumber.floatValue() : float.Parse(AsString);
		  }
	  }

	  public override int AsInt
	  {
		  get
		  {
			return Number ? AsNumber.intValue() : int.Parse(AsString);
		  }
	  }

	  public override long AsLong
	  {
		  get
		  {
			return Number ? AsNumber.longValue() : long.Parse(AsString);
		  }
	  }

	  public override Number AsNumber
	  {
		  get
		  {
			return (this.d is string) ? a((string)this.d) : (Number)this.d;
		  }
	  }

	  public override short AsShort
	  {
		  get
		  {
			if (Number)
			{
			  return AsNumber.shortValue();
			}
			return short.Parse(AsString);
		  }
	  }

	  public override string AsString
	  {
		  get
		  {
			return Number ? AsNumber.ToString() : (Boolean ? b().ToString() : (string)this.d);
		  }
	  }

	  public override int GetHashCode()
	  {
		if (this.d == null)
		{
		  return 31;
		}
		if (a(this))
		{
		  long l = AsNumber.longValue();
		  return (int)(l ^ (long)((ulong)l >> 32L));
		}
		if (b(this))
		{
		  long l = System.BitConverter.DoubleToInt64Bits(AsNumber.doubleValue());
		  return (int)(l ^ (long)((ulong)l >> 32L));
		}
		return this.d.GetHashCode();
	  }

	  public bool Boolean
	  {
		  get
		  {
			return this.d is bool?;
		  }
	  }

	  public bool Number
	  {
		  get
		  {
			return this.d is Number;
		  }
	  }

	  public bool String
	  {
		  get
		  {
			return this.d is string;
		  }
	  }

	  protected internal override void toString(Appendable paramAppendable, do paramdo)
	  {
		if (String)
		{
		  paramAppendable.append('"');
		  paramAppendable.append(paramdo.a(this.d.ToString()));
		  paramAppendable.append('"');
		  return;
		}
		paramAppendable.append(this.d.ToString());
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\JsonPrimitive.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}