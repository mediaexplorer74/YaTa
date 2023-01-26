using System;
using System.Collections.Generic;

namespace com.google.gson.stream
{
	using fm;
	using fn;

	public sealed class JsonWriter : System.IDisposable
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly Writer a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly IList<fm> b_Conflict = new List<fm>();

	  private string c;

	  private string d;

	  private bool e;

	  private bool f;

	  public JsonWriter(Writer paramWriter)
	  {
		this.b_Conflict.Add(fm.f);
		this.d = ":";
		if (paramWriter == null)
		{
		  throw new System.NullReferenceException("out == null");
		}
		this.a_Conflict = paramWriter;
	  }

	  private JsonWriter a(fm paramfm1, fm paramfm2, string paramString)
	  {
		fm fm1 = a();
		if (fm1 != paramfm2 && fm1 != paramfm1)
		{
		  throw new System.InvalidOperationException("Nesting problem: " + this.b_Conflict);
		}
		this.b_Conflict.RemoveAt(this.b_Conflict.Count - 1);
		if (fm1 == paramfm2)
		{
		  b();
		}
		this.a_Conflict.write(paramString);
		return this;
	  }

	  private JsonWriter a(fm paramfm, string paramString)
	  {
		a(true);
		this.b_Conflict.Add(paramfm);
		this.a_Conflict.write(paramString);
		return this;
	  }

	  private fm a()
	  {
		return this.b_Conflict[this.b_Conflict.Count - 1];
	  }

	  private void a(fm paramfm)
	  {
		this.b_Conflict[this.b_Conflict.Count - 1] = paramfm;
	  }

	  private void a(string paramString)
	  {
		this.a_Conflict.write("\"");
		int i = paramString.Length;
		for (sbyte b = 0;; b++)
		{
		  if (b < i)
		  {
			char c = paramString[b];
			switch (c)
			{
			  default:
				if (c <= '\x001F')
				{
				  this.a_Conflict.write(string.Format("\\u{0:x4}", new object[] {Convert.ToInt32(c)}));
				}
				else
				{
				  break;
				}
				b++;
				continue;
			  case '"':
			  case '\\':
				this.a_Conflict.write(92);
				this.a_Conflict.write(c);
				b++;
				continue;
			  case '\t':
				this.a_Conflict.write("\\t");
				b++;
				continue;
			  case '\b':
				this.a_Conflict.write("\\b");
				b++;
				continue;
			  case '\n':
				this.a_Conflict.write("\\n");
				b++;
				continue;
			  case '\r':
				this.a_Conflict.write("\\r");
				b++;
				continue;
			  case '\f':
				this.a_Conflict.write("\\f");
				b++;
				continue;
			  case '&':
			  case '\'':
			  case '<':
			  case '=':
			  case '>':
				if (this.f)
				{
				  this.a_Conflict.write(string.Format("\\u{0:x4}", new object[] {Convert.ToInt32(c)}));
				}
				else
				{
				  this.a_Conflict.write(c);
				}
				b++;
				continue;
			}
			this.a_Conflict.write(c);
		  }
		  else
		  {
			break;
		  }
		}
		this.a_Conflict.write("\"");
	  }

	  private void a(bool paramBoolean)
	  {
		switch (fn.a[a().ordinal()])
		{
		  default:
			throw new System.InvalidOperationException("Nesting problem: " + this.b_Conflict);
		  case 1:
			if (!this.e && !paramBoolean)
			{
			  throw new System.InvalidOperationException("JSON must start with an array or an object.");
			}
			a(fm.g);
			return;
		  case 2:
			a(fm.b);
			b();
			return;
		  case 3:
			this.a_Conflict.append(',');
			b();
			return;
		  case 4:
			this.a_Conflict.append(this.d);
			a(fm.e);
			return;
		  case 5:
			break;
		}
		throw new System.InvalidOperationException("JSON must have only one top-level value.");
	  }

	  private void b()
	  {
		if (!string.ReferenceEquals(this.c, null))
		{
		  this.a_Conflict.write("\n");
		  sbyte b = 1;
		  while (true)
		  {
			if (b < this.b_Conflict.Count)
			{
			  this.a_Conflict.write(this.c);
			  b++;
			  continue;
			}
			return;
		  }
		}
	  }

	  public JsonWriter beginArray()
	  {
		return a(fm.a, "[");
	  }

	  public JsonWriter beginObject()
	  {
		return a(fm.c, "{");
	  }

	  public void Dispose()
	  {
		this.a_Conflict.close();
		if (a() != fm.g)
		{
		  throw new IOException("Incomplete document");
		}
	  }

	  public JsonWriter endArray()
	  {
		return a(fm.a, fm.b, "]");
	  }

	  public JsonWriter endObject()
	  {
		return a(fm.c, fm.e, "}");
	  }

	  public void flush()
	  {
		this.a_Conflict.flush();
	  }

	  public bool HtmlSafe
	  {
		  get
		  {
			return this.f;
		  }
		  set
		  {
			this.f = value;
		  }
	  }

	  public bool Lenient
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }

	  public JsonWriter name(string paramString)
	  {
		if (string.ReferenceEquals(paramString, null))
		{
		  throw new System.NullReferenceException("name == null");
		}
		fm fm = a();
		if (fm == fm.e)
		{
		  this.a_Conflict.write(44);
		  b();
		  a(fm.d);
		  a(paramString);
		  return this;
		}
		if (fm != fm.c)
		{
		  throw new System.InvalidOperationException("Nesting problem: " + this.b_Conflict);
		}
		b();
		a(fm.d);
		a(paramString);
		return this;
	  }

	  public JsonWriter nullValue()
	  {
		a(false);
		this.a_Conflict.write("null");
		return this;
	  }


	  public string Indent
	  {
		  set
		  {
			if (value.Length == 0)
			{
			  this.c = null;
			  this.d = ":";
			  return;
			}
			this.c = value;
			this.d = ": ";
		  }
	  }


	  public JsonWriter value(double paramDouble)
	  {
		if (double.IsNaN(paramDouble) || double.IsInfinity(paramDouble))
		{
		  throw new System.ArgumentException("Numeric values must be finite, but was " + paramDouble);
		}
		a(false);
		this.a_Conflict.append(Convert.ToString(paramDouble));
		return this;
	  }

	  public JsonWriter value(long paramLong)
	  {
		a(false);
		this.a_Conflict.write(Convert.ToString(paramLong));
		return this;
	  }

	  public JsonWriter value(Number paramNumber)
	  {
		if (paramNumber == null)
		{
		  return nullValue();
		}
		string str = paramNumber.ToString();
		if (!this.e && (str.Equals("-Infinity") || str.Equals("Infinity") || str.Equals("NaN")))
		{
		  throw new System.ArgumentException("Numeric values must be finite, but was " + paramNumber);
		}
		a(false);
		this.a_Conflict.append(str);
		return this;
	  }

	  public JsonWriter value(string paramString)
	  {
		if (string.ReferenceEquals(paramString, null))
		{
		  return nullValue();
		}
		a(false);
		a(paramString);
		return this;
	  }

	  public JsonWriter value(bool paramBoolean)
	  {
		a(false);
		Writer writer = this.a_Conflict;
		if (paramBoolean)
		{
		  string str1 = "true";
		  writer.write(str1);
		  return this;
		}
		string str = "false";
		writer.write(str);
		return this;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\stream\JsonWriter.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}