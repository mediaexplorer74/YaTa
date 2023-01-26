using System;
using System.Collections.Generic;
using System.Text;

namespace com.google.gson.stream
{
	using fl;
	using fm;

	public sealed class JsonReader : System.IDisposable
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly char[] a_Conflict = ")]}'\n".ToCharArray();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly Reader b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool c_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly char[] d_Conflict = new char[1024];

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int e_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private int f_Conflict = 0;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly IList<fm> g_Conflict = new List<fm>();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private bool h_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private JsonToken i_Conflict;

	  private string j;

	  private string k;

	  private bool l;

	  public JsonReader(Reader paramReader)
	  {
		a(fm.f);
		this.l = false;
		if (paramReader == null)
		{
		  throw new System.NullReferenceException("in == null");
		}
		this.b_Conflict = paramReader;
	  }

	  private JsonToken a()
	  {
		JsonToken jsonToken1;
		JsonToken jsonToken2;
		if (this.h_Conflict)
		{
		  return this.i_Conflict;
		}
		switch (fl.a[((fm)this.g_Conflict[this.g_Conflict.Count - 1]).ordinal()])
		{
		  default:
			throw new AssertionError();
		  case 1:
			if (this.c_Conflict)
			{
			  e();
			  this.e_Conflict--;
			  if (this.e_Conflict + a_Conflict.Length <= this.f_Conflict || a(a_Conflict.Length))
			  {
				sbyte b = 0;
				while (true)
				{
				  if (b < a_Conflict.Length)
				  {
					if (this.d_Conflict[this.e_Conflict + b] == a_Conflict[b])
					{
					  b++;
					  continue;
					}
					break;
				  }
				  this.e_Conflict += a_Conflict.Length;
				  break;
				}
			  }
			}
			b(fm.g);
			jsonToken2 = d();
			null = jsonToken2;
			if (!this.c_Conflict)
			{
			  null = jsonToken2;
			  if (jsonToken2 != JsonToken.BEGIN_ARRAY)
			  {
				null = jsonToken2;
				if (jsonToken2 != JsonToken.BEGIN_OBJECT)
				{
				  a("Expected JSON document to start with '[' or '{'");
				  null = jsonToken2;
				}
			  }
			}
			return null;
		  case 2:
			return a(true);
		  case 3:
			return a(false);
		  case 4:
			return b(true);
		  case 5:
			switch (e())
			{
			  default:
				throw a("Expected ':'");
			  case 61:
				f();
				if ((this.e_Conflict < this.f_Conflict || a(1)) && this.d_Conflict[this.e_Conflict] == '>')
				{
				  this.e_Conflict++;
				}
				break;
			  case 58:
				break;
			}
			b(fm.e);
			return d();
		  case 6:
			return b(false);
		  case 7:
			try
			{
			  jsonToken1 = d();
			  if (!this.c_Conflict)
			  {
				throw a("Expected EOF");
			  }
			}
			catch (EOFException)
			{
			  this.h_Conflict = true;
			  jsonToken1 = JsonToken.END_DOCUMENT;
			  this.i_Conflict = jsonToken1;
			}
			return jsonToken1;
		  case 8:
			break;
		}
		throw new System.InvalidOperationException("JsonReader is closed");
	  }

	  private JsonToken a(bool paramBoolean)
	  {
		if (paramBoolean)
		{
		  b(fm.b);
		}
		switch (e())
		{
		  case 44:
			switch (e())
			{
			  default:
				this.e_Conflict--;
				return d();
			  case 93:
				if (paramBoolean)
				{
				  c();
				  this.h_Conflict = true;
				  JsonToken jsonToken1 = JsonToken.END_ARRAY;
				  this.i_Conflict = jsonToken1;
				  return jsonToken1;
				}
				break;
			  case 44:
			  case 59:
				break;
			}
			break;
		  default:
			throw a("Unterminated array");
		  case 93:
			c();
			this.h_Conflict = true;
			jsonToken = JsonToken.END_ARRAY;
			this.i_Conflict = jsonToken;
			return jsonToken;
		  case 59:
			f();
		break;
		}
		f();
		this.e_Conflict--;
		this.h_Conflict = true;
		this.k = "null";
		JsonToken jsonToken = JsonToken.NULL;
		this.i_Conflict = jsonToken;
		return jsonToken;
	  }

	  private IOException a(string paramString)
	  {
		throw new MalformedJsonException(paramString + " near " + i());
	  }

	  private string a(char paramChar)
	  {
		string str = null;
		while (true)
		{
		  int i = this.e_Conflict;
		  while (true)
		  {
			StringBuilder stringBuilder;
			int j;
			if (this.e_Conflict < this.f_Conflict)
			{
			  char[] arrayOfChar = this.d_Conflict;
			  int k = this.e_Conflict;
			  this.e_Conflict = k + 1;
			  k = arrayOfChar[k];
			  if ((char)k == paramChar)
			  {
				if (this.l)
				{
				  return "skipped!";
				}
				if (string.ReferenceEquals(str, null))
				{
				  return new string(this.d_Conflict, i, this.e_Conflict - i - 1);
				}
				str.append(this.d_Conflict, i, this.e_Conflict - i - 1);
				return str.ToString();
			  }
			  if (k == 92)
			  {
				StringBuilder stringBuilder4;
				string str1;
				StringBuilder stringBuilder3;
				string str2 = str;
				if (string.ReferenceEquals(str, null))
				{
				  stringBuilder = new StringBuilder();
				}
				stringBuilder.Append(this.d_Conflict, i, this.e_Conflict - i - 1);
				if (this.e_Conflict == this.f_Conflict && !a(1))
				{
				  throw a("Unterminated escape sequence");
				}
				char[] arrayOfChar1 = this.d_Conflict;
				i = this.e_Conflict;
				this.e_Conflict = i + 1;
				i = arrayOfChar1[i];
				switch (i)
				{
				  default:
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder4 = stringBuilder;
					continue;
				  case 117:
					if (this.e_Conflict + 4 > this.f_Conflict && !a(4))
					{
					  throw a("Unterminated escape sequence");
					}
					str1 = new string(this.d_Conflict, this.e_Conflict, 4);
					this.e_Conflict += 4;
					i = (char)Convert.ToInt32(str1, 16);
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder3 = stringBuilder;
					continue;
				  case 116:
					i = 9;
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder3 = stringBuilder;
					continue;
				  case 98:
					i = 8;
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder3 = stringBuilder;
					continue;
				  case 110:
					i = 10;
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder3 = stringBuilder;
					continue;
				  case 114:
					i = 13;
					j = i;
					stringBuilder.Append(j);
					i = this.e_Conflict;
					stringBuilder3 = stringBuilder;
					continue;
				  case 102:
					break;
				}
				i = 12;
				j = i;
			  }
			  else
			  {
				continue;
			  }
			}
			else
			{
			  break;
			}
			stringBuilder.Append(j);
			i = this.e_Conflict;
			stringBuilder1 = stringBuilder;
		  }
		  StringBuilder stringBuilder2 = stringBuilder1;
		  if (stringBuilder1 == null)
		  {
			stringBuilder2 = new StringBuilder();
		  }
		  stringBuilder2.Append(this.d_Conflict, i, this.e_Conflict - i);
		  StringBuilder stringBuilder1 = stringBuilder2;
		  if (!a(1))
		  {
			throw a("Unterminated string");
		  }
		}
	  }

	  private void a(JsonToken paramJsonToken)
	  {
		a();
		if (this.i_Conflict != paramJsonToken)
		{
		  throw new System.InvalidOperationException("Expected " + paramJsonToken + " but was " + peek());
		}
		b();
	  }

	  private void a(fm paramfm)
	  {
		this.g_Conflict.Add(paramfm);
	  }

	  private bool a(int paramInt)
	  {
		bool bool2;
		bool bool1 = false;
		if (this.f_Conflict != this.e_Conflict)
		{
		  this.f_Conflict -= this.e_Conflict;
		  Array.Copy(this.d_Conflict, this.e_Conflict, this.d_Conflict, 0, this.f_Conflict);
		}
		else
		{
		  this.f_Conflict = 0;
		}
		this.e_Conflict = 0;
		while (true)
		{
		  int i = this.b_Conflict.read(this.d_Conflict, this.f_Conflict, this.d_Conflict.Length - this.f_Conflict);
		  bool2 = bool1;
		  if (i != -1)
		  {
			this.f_Conflict = i + this.f_Conflict;
			if (this.f_Conflict >= paramInt)
			{
			  bool2 = true;
			  break;
			}
			continue;
		  }
		  break;
		}
		return bool2;
	  }

	  private JsonToken b()
	  {
		a();
		JsonToken jsonToken = this.i_Conflict;
		this.h_Conflict = false;
		this.i_Conflict = null;
		this.k = null;
		this.j = null;
		return jsonToken;
	  }

	  private JsonToken b(bool paramBoolean)
	  {
		if (paramBoolean)
		{
		  JsonToken jsonToken1;
		  switch (e())
		  {
			default:
			  this.e_Conflict--;
				goto case 125;
			case 125:
			  c();
			  this.h_Conflict = true;
			  jsonToken1 = JsonToken.END_OBJECT;
			  this.i_Conflict = jsonToken1;
			  return jsonToken1;
		  }
		}
		else
		{
		  int i;
		  JsonToken jsonToken1;
		  switch (e())
		  {
			case 44:
			case 59:
			  i = e();
			  switch (i)
			  {
				default:
				  f();
				  this.e_Conflict--;
				  this.j = h();
				  if (this.j.Length == 0)
				  {
					throw a("Expected name");
				  }
				  break;
				case 39:
				  f();
				  break;
				case 34:
				  break;
			  }
			  break;
			default:
			  throw a("Unterminated object");
			case 125:
			  c();
			  this.h_Conflict = true;
			  jsonToken1 = JsonToken.END_OBJECT;
			  this.i_Conflict = jsonToken1;
			  return jsonToken1;
		  }
		  this.j = a((char)i);
		}
		b(fm.d);
		this.h_Conflict = true;
		JsonToken jsonToken = JsonToken.NAME;
		this.i_Conflict = jsonToken;
		return jsonToken;
	  }

	  private void b(fm paramfm)
	  {
		this.g_Conflict[this.g_Conflict.Count - 1] = paramfm;
	  }

	  private fm c()
	  {
		return this.g_Conflict.RemoveAndReturn(this.g_Conflict.Count - 1);
	  }

	  private JsonToken d()
	  {
		string str;
		int i = e();
		switch (i)
		{
		  default:
			this.e_Conflict--;
			str = h();
			if (str.Length == 0)
			{
			  throw a("Expected literal value");
			}
			break;
		  case 123:
			a(fm.c);
			this.h_Conflict = true;
			jsonToken = JsonToken.BEGIN_OBJECT;
			this.i_Conflict = jsonToken;
			return jsonToken;
		  case 91:
			a(fm.a);
			this.h_Conflict = true;
			jsonToken = JsonToken.BEGIN_ARRAY;
			this.i_Conflict = jsonToken;
			return jsonToken;
		  case 39:
			f();
			  goto case 34;
		  case 34:
			this.k = a((char)i);
			this.h_Conflict = true;
			jsonToken = JsonToken.STRING;
			this.i_Conflict = jsonToken;
			return jsonToken;
		}
		this.k = (string)jsonToken;
		this.h_Conflict = true;
		JsonToken jsonToken = null;
		this.i_Conflict = null;
		return jsonToken;
	  }

	  private int e()
	  {
		while (true)
		{
		  if (this.e_Conflict < this.f_Conflict || a(1))
		  {
			char[] arrayOfChar = this.d_Conflict;
			int i = this.e_Conflict;
			this.e_Conflict = i + 1;
			i = arrayOfChar[i];
			switch (i)
			{
			  case 9:
			  case 10:
			  case 13:
			  case 32:
				continue;
			  default:

			  case 47:
				if (this.e_Conflict != this.f_Conflict || a(1))
				{
				  f();
				  switch (this.d_Conflict[this.e_Conflict])
				  {
					default:
					  return i;
					case '*':
					  this.e_Conflict++;
					  while (true)
					  {
						if (this.e_Conflict + "*/".Length < this.f_Conflict || a("*/".Length))
						{
						  i = 0;
						  while (i < "*/".Length)
						  {
							if (this.d_Conflict[this.e_Conflict + i] == "*/"[i])
							{
							  i++;
							  continue;
							}
							this.e_Conflict++;
						  }
						  i = 1;
						  if (i == 0)
						  {
							throw a("Unterminated comment");
						  }
						}
						else
						{
						  i = 0;
						  continue;
						}
						this.e_Conflict += 2;
					  }
					  break;
					case '/':
					  break;
				  }
				  this.e_Conflict++;
				  g();
				  continue;
				}
			  case 35:
				break;
			}
			f();
			g();
			continue;
		  }
		  throw new EOFException("End of input");
		}
	  }

	  private void f()
	  {
		if (!this.c_Conflict)
		{
		  throw a("Use JsonReader.setLenient(true) to accept malformed JSON");
		}
	  }

	  private void g()
	  {
		while (this.e_Conflict < this.f_Conflict || a(1))
		{
		  char[] arrayOfChar = this.d_Conflict;
		  int i = this.e_Conflict;
		  this.e_Conflict = i + 1;
		  i = arrayOfChar[i];
		  if (i == 13 || i == 10)
		  {
			break;
		  }
		}
	  }

	  private string h()
	  {
		string str = null;
		while (true)
		{
		  StringBuilder stringBuilder2;
		  int i = this.e_Conflict;
		  while (this.e_Conflict < this.f_Conflict)
		  {
			char[] arrayOfChar = this.d_Conflict;
			int j = this.e_Conflict;
			this.e_Conflict = j + 1;
			switch (arrayOfChar[j])
			{
			  default:
				continue;
			  case '\t':
			  case '\n':
			  case '\f':
			  case '\r':
			  case ' ':
			  case ',':
			  case ':':
			  case '[':
			  case ']':
			  case '{':
			  case '}':
				this.e_Conflict--;
				if (this.l)
				{
				  return "skipped!";
				}
				break;
			  case '#':
			  case '/':
			  case ';':
			  case '=':
			  case '\\':
				f();
				continue;
			}
			if (string.ReferenceEquals(str, null))
			{
			  return new string(this.d_Conflict, i, this.e_Conflict - i);
			}
			str.append(this.d_Conflict, i, this.e_Conflict - i);
			return str.ToString();
		  }
		  string str1 = str;
		  if (string.ReferenceEquals(str, null))
		  {
			stringBuilder2 = new StringBuilder();
		  }
		  stringBuilder2.Append(this.d_Conflict, i, this.e_Conflict - i);
		  StringBuilder stringBuilder1 = stringBuilder2;
		  if (!a(1))
		  {
			return stringBuilder2.ToString();
		  }
		}
	  }

	  private CharSequence i()
	  {
		StringBuilder stringBuilder = new StringBuilder();
		int i = Math.Min(this.e_Conflict, 20);
		stringBuilder.Append(this.d_Conflict, this.e_Conflict - i, i);
		i = Math.Min(this.f_Conflict - this.e_Conflict, 20);
		stringBuilder.Append(this.d_Conflict, this.e_Conflict, i);
		return stringBuilder;
	  }

	  public void beginArray()
	  {
		a(JsonToken.BEGIN_ARRAY);
	  }

	  public void beginObject()
	  {
		a(JsonToken.BEGIN_OBJECT);
	  }

	  public void Dispose()
	  {
		this.h_Conflict = false;
		this.k = null;
		this.i_Conflict = null;
		this.g_Conflict.Clear();
		this.g_Conflict.Add(fm.h);
		this.b_Conflict.close();
	  }

	  public void endArray()
	  {
		a(JsonToken.END_ARRAY);
	  }

	  public void endObject()
	  {
		a(JsonToken.END_OBJECT);
	  }

	  public bool hasNext()
	  {
		a();
		return (this.i_Conflict != JsonToken.END_OBJECT && this.i_Conflict != JsonToken.END_ARRAY);
	  }

	  public bool Lenient
	  {
		  get
		  {
			return this.c_Conflict;
		  }
		  set
		  {
			this.c_Conflict = value;
		  }
	  }

	  public bool nextBoolean()
	  {
		a();
		if (string.ReferenceEquals(this.k, null) || this.i_Conflict == JsonToken.STRING)
		{
		  throw new System.InvalidOperationException("Expected a boolean but was " + peek());
		}
		if (this.k.Equals("true", StringComparison.OrdinalIgnoreCase))
		{
		  bool @bool = true;
		  b();
		  return @bool;
		}
		if (this.k.Equals("false", StringComparison.OrdinalIgnoreCase))
		{
		  bool @bool = false;
		  b();
		  return @bool;
		}
		throw new System.InvalidOperationException("Not a boolean: " + this.k);
	  }

	  public double nextDouble()
	  {
		a();
		if (string.ReferenceEquals(this.k, null))
		{
		  throw new System.InvalidOperationException("Expected a double but was " + peek());
		}
		double d = double.Parse(this.k);
		if (d >= 1.0D && this.k.StartsWith("0", StringComparison.Ordinal))
		{
		  throw new System.FormatException("JSON forbids octal prefixes: " + this.k);
		}
		if (!this.c_Conflict && (double.IsNaN(d) || double.IsInfinity(d)))
		{
		  throw new System.FormatException("JSON forbids NaN and infinities: " + this.k);
		}
		b();
		return d;
	  }

	  public int nextInt()
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokespecial a : ()Lcom/google/gson/stream/JsonToken;
		//   4: pop
		//   5: aload_0
		//   6: getfield k : Ljava/lang/String;
		//   9: ifnonnull -> 43
		//   12: new java/lang/IllegalStateException
		//   15: dup
		//   16: new java/lang/StringBuilder
		//   19: dup
		//   20: invokespecial <init> : ()V
		//   23: ldc_w 'Expected an int but was '
		//   26: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   29: aload_0
		//   30: invokevirtual peek : ()Lcom/google/gson/stream/JsonToken;
		//   33: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   36: invokevirtual toString : ()Ljava/lang/String;
		//   39: invokespecial <init> : (Ljava/lang/String;)V
		//   42: athrow
		//   43: aload_0
		//   44: getfield k : Ljava/lang/String;
		//   47: invokestatic parseInt : (Ljava/lang/String;)I
		//   50: istore_1
		//   51: iload_1
		//   52: i2l
		//   53: lconst_1
		//   54: lcmp
		//   55: iflt -> 138
		//   58: aload_0
		//   59: getfield k : Ljava/lang/String;
		//   62: ldc_w '0'
		//   65: invokevirtual startsWith : (Ljava/lang/String;)Z
		//   68: ifeq -> 138
		//   71: new java/lang/NumberFormatException
		//   74: dup
		//   75: new java/lang/StringBuilder
		//   78: dup
		//   79: invokespecial <init> : ()V
		//   82: ldc_w 'JSON forbids octal prefixes: '
		//   85: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   88: aload_0
		//   89: getfield k : Ljava/lang/String;
		//   92: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   95: invokevirtual toString : ()Ljava/lang/String;
		//   98: invokespecial <init> : (Ljava/lang/String;)V
		//   101: athrow
		//   102: astore_2
		//   103: aload_0
		//   104: getfield k : Ljava/lang/String;
		//   107: invokestatic parseDouble : (Ljava/lang/String;)D
		//   110: dstore_3
		//   111: dload_3
		//   112: d2i
		//   113: istore #5
		//   115: iload #5
		//   117: istore_1
		//   118: iload #5
		//   120: i2d
		//   121: dload_3
		//   122: dcmpl
		//   123: ifeq -> 51
		//   126: new java/lang/NumberFormatException
		//   129: dup
		//   130: aload_0
		//   131: getfield k : Ljava/lang/String;
		//   134: invokespecial <init> : (Ljava/lang/String;)V
		//   137: athrow
		//   138: aload_0
		//   139: invokespecial b : ()Lcom/google/gson/stream/JsonToken;
		//   142: pop
		//   143: iload_1
		//   144: ireturn
		// Exception table:
		//   from	to	target	type
		//   43	51	102	java/lang/NumberFormatException
	  }

	  public long nextLong()
	  {
		// Byte code:
		//   0: aload_0
		//   1: invokespecial a : ()Lcom/google/gson/stream/JsonToken;
		//   4: pop
		//   5: aload_0
		//   6: getfield k : Ljava/lang/String;
		//   9: ifnonnull -> 43
		//   12: new java/lang/IllegalStateException
		//   15: dup
		//   16: new java/lang/StringBuilder
		//   19: dup
		//   20: invokespecial <init> : ()V
		//   23: ldc_w 'Expected a long but was '
		//   26: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   29: aload_0
		//   30: invokevirtual peek : ()Lcom/google/gson/stream/JsonToken;
		//   33: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
		//   36: invokevirtual toString : ()Ljava/lang/String;
		//   39: invokespecial <init> : (Ljava/lang/String;)V
		//   42: athrow
		//   43: aload_0
		//   44: getfield k : Ljava/lang/String;
		//   47: invokestatic parseLong : (Ljava/lang/String;)J
		//   50: lstore_1
		//   51: lload_1
		//   52: lconst_1
		//   53: lcmp
		//   54: iflt -> 140
		//   57: aload_0
		//   58: getfield k : Ljava/lang/String;
		//   61: ldc_w '0'
		//   64: invokevirtual startsWith : (Ljava/lang/String;)Z
		//   67: ifeq -> 140
		//   70: new java/lang/NumberFormatException
		//   73: dup
		//   74: new java/lang/StringBuilder
		//   77: dup
		//   78: invokespecial <init> : ()V
		//   81: ldc_w 'JSON forbids octal prefixes: '
		//   84: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   87: aload_0
		//   88: getfield k : Ljava/lang/String;
		//   91: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   94: invokevirtual toString : ()Ljava/lang/String;
		//   97: invokespecial <init> : (Ljava/lang/String;)V
		//   100: athrow
		//   101: astore_3
		//   102: aload_0
		//   103: getfield k : Ljava/lang/String;
		//   106: invokestatic parseDouble : (Ljava/lang/String;)D
		//   109: dstore #4
		//   111: dload #4
		//   113: d2l
		//   114: lstore #6
		//   116: lload #6
		//   118: lstore_1
		//   119: lload #6
		//   121: l2d
		//   122: dload #4
		//   124: dcmpl
		//   125: ifeq -> 51
		//   128: new java/lang/NumberFormatException
		//   131: dup
		//   132: aload_0
		//   133: getfield k : Ljava/lang/String;
		//   136: invokespecial <init> : (Ljava/lang/String;)V
		//   139: athrow
		//   140: aload_0
		//   141: invokespecial b : ()Lcom/google/gson/stream/JsonToken;
		//   144: pop
		//   145: lload_1
		//   146: lreturn
		// Exception table:
		//   from	to	target	type
		//   43	51	101	java/lang/NumberFormatException
	  }

	  public string nextName()
	  {
		a();
		if (this.i_Conflict != JsonToken.NAME)
		{
		  throw new System.InvalidOperationException("Expected a name but was " + peek());
		}
		string str = this.j;
		b();
		return str;
	  }

	  public void nextNull()
	  {
		a();
		if (string.ReferenceEquals(this.k, null) || this.i_Conflict == JsonToken.STRING)
		{
		  throw new System.InvalidOperationException("Expected null but was " + peek());
		}
		if (!this.k.Equals("null", StringComparison.OrdinalIgnoreCase))
		{
		  throw new System.InvalidOperationException("Not a null: " + this.k);
		}
		b();
	  }

	  public string nextString()
	  {
		peek();
		if (string.ReferenceEquals(this.k, null) || (this.i_Conflict != JsonToken.STRING && this.i_Conflict != JsonToken.NUMBER))
		{
		  throw new System.InvalidOperationException("Expected a string but was " + peek());
		}
		string str = this.k;
		b();
		return str;
	  }

	  public JsonToken peek()
	  {
		a();
		if (this.i_Conflict == null)
		{
		  if (this.k.Equals("null", StringComparison.OrdinalIgnoreCase))
		  {
			this.i_Conflict = JsonToken.NULL;
			return this.i_Conflict;
		  }
		}
		else
		{
		  return this.i_Conflict;
		}
		if (this.k.Equals("true", StringComparison.OrdinalIgnoreCase) || this.k.Equals("false", StringComparison.OrdinalIgnoreCase))
		{
		  this.i_Conflict = JsonToken.BOOLEAN;
		  return this.i_Conflict;
		}
		try
		{
		  double.Parse(this.k);
		  this.i_Conflict = JsonToken.NUMBER;
		}
		catch (System.FormatException)
		{
		  f();
		  this.i_Conflict = JsonToken.STRING;
		}
		return this.i_Conflict;
	  }


	  public void skipValue()
	  {
		this.l = true;
		bool @bool = false;
		try
		{
		  while (true)
		  {
			while (true)
			{
			  JsonToken jsonToken = b();
			  break;
			}
			if (SYNTHETIC_LOCAL_VARIABLE_4 == null)
			{
			  return;
			}
		  }
		}
		finally
		{
		  this.l = false;
		}
	  }

	  public override string ToString()
	  {
		return this.GetType().Name + " near " + i();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\stream\JsonReader.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}