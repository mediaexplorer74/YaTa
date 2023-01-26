using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using com.google.gson;
using com.google.gson;
using com.google.gson;
using LongSerializationPolicy = com.google.gson.LongSerializationPolicy;

public sealed class ci
{
  private static readonly di A;

  private static readonly dh B;

  private static readonly da C;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private static final er<com.google.gson.JsonSerializer<?>> D;
  private static readonly er<JsonSerializer<object>> D;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private static final er<com.google.gson.JsonDeserializer<?>> E;
  private static readonly er<JsonDeserializer<object>> E;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private static final er<com.google.gson.InstanceCreator<?>> F;
  private static readonly er<InstanceCreator<object>> F;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static final er<com.google.gson.JsonSerializer<?>> a;
  public static readonly er<JsonSerializer<object>> a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static final er<com.google.gson.JsonDeserializer<?>> b;
  public static readonly er<JsonDeserializer<object>> b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly cq c_Conflict = new cq();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly cs d_Conflict = new cs();

  private static readonly ct e = new ct();

  private static readonly cu f = new cu();

  private static readonly cx g = new cx<Enum>();

  private static readonly dl h = new dl();

  private static readonly dk i = new dk();

  private static readonly dm j = new dm();

  private static readonly dc k = new dc();

  private static readonly cr l = new cr();

  private static readonly co m = new co();

  private static readonly ej n = new ej();

  private static readonly cj o = new cj();

  private static readonly ck p = new ck();

  private static readonly cl q = new cl();

  private static readonly cm r = new cm();

  private static readonly cn s = new cn();

  private static readonly cv t = new cv();

  private static readonly cy u = new cy();

  private static readonly db v = new db();

  private static readonly dd w = new dd();

  private static readonly df x = new df();

  private static readonly dg y = new dg();

  private static readonly dj z = new dj();

  static ci()
  {
	A = new di();
	B = new dh();
	C = new da();
	er<dl> er1 = new er();
	er1.a(typeof(URL), h);
	er1.a(typeof(URI), i);
	er1.a(typeof(System.Guid), j);
	er1.a(typeof(Locale), k);
	er1.a(typeof(Date), c_Conflict);
	er1.a(typeof(Date), d_Conflict);
	er1.a(typeof(Timestamp), c_Conflict);
	er1.a(typeof(Time), e);
	er1.a(typeof(DateTime), C);
	er1.a(typeof(GregorianCalendar), C);
	er1.a(typeof(decimal), o);
	er1.a(typeof(BigInteger), p);
	er1.a(typeof(Boolean), q);
	er1.a(typeof(bool), q);
	er1.a(typeof(Byte), r);
	er1.a(typeof(sbyte), r);
	er1.a(typeof(Character), s);
	er1.a(typeof(char), s);
	er1.a(typeof(Integer), v);
	er1.a(typeof(int), v);
	er1.a(typeof(Number), x);
	er1.a(typeof(Short), y);
	er1.a(typeof(short), y);
	er1.a(typeof(string), z);
	er1.a(typeof(StringBuilder), A);
	er1.a(typeof(StringBuilder), B);
	er1.a();
	D = (er)er1;
	er1 = new er<dl>();
	er1.a(typeof(Enum), g);
	er1.a(typeof(InetAddress), l);
	er1.a(typeof(System.Collections.ICollection), m);
	er1.a(typeof(System.Collections.IDictionary), n);
	er1.a();
	a_Conflict = (er)er1;
	er1 = new er<dl>();
	er1.a(typeof(URL), a(h));
	er1.a(typeof(URI), a(i));
	er1.a(typeof(System.Guid), a(j));
	er1.a(typeof(Locale), a(k));
	er1.a(typeof(Date), a(c_Conflict));
	er1.a(typeof(Date), a(d_Conflict));
	er1.a(typeof(Timestamp), a(f));
	er1.a(typeof(Time), a(e));
	er1.a(typeof(DateTime), C);
	er1.a(typeof(GregorianCalendar), C);
	er1.a(typeof(decimal), o);
	er1.a(typeof(BigInteger), p);
	er1.a(typeof(Boolean), q);
	er1.a(typeof(bool), q);
	er1.a(typeof(Byte), r);
	er1.a(typeof(sbyte), r);
	er1.a(typeof(Character), a(s));
	er1.a(typeof(char), a(s));
	er1.a(typeof(Double), t);
	er1.a(typeof(double), t);
	er1.a(typeof(Float), u);
	er1.a(typeof(float), u);
	er1.a(typeof(Integer), v);
	er1.a(typeof(int), v);
	er1.a(typeof(Long), w);
	er1.a(typeof(long), w);
	er1.a(typeof(Number), x);
	er1.a(typeof(Short), y);
	er1.a(typeof(short), y);
	er1.a(typeof(string), a(z));
	er1.a(typeof(StringBuilder), a(A));
	er1.a(typeof(StringBuilder), a(B));
	er1.a();
	E = (er)er1;
	er1 = new er<dl>();
	er1.a(typeof(Enum), a(g));
	er1.a(typeof(InetAddress), a(l));
	er1.a(typeof(System.Collections.ICollection), a(m));
	er1.a(typeof(System.Collections.IDictionary), a(n));
	er1.a();
	b_Conflict = (er)er1;
	er1 = new er<dl>();
	cg cg = new cg(50);
	er1.a(typeof(System.Collections.IDictionary), (dl)new cp<LinkedHashMap>(typeof(LinkedHashMap), cg));
	cp<ArrayList> cp1 = new cp<ArrayList>(typeof(ArrayList), cg);
	cp<LinkedList> cp2 = new cp<LinkedList>(typeof(LinkedList), cg);
	cp<HashSet<object>> cp3 = new cp<HashSet<object>>(typeof(HashSet<object>), cg);
	cp<SortedSet> cp = new cp<SortedSet>(typeof(SortedSet), cg);
	er1.a(typeof(System.Collections.ICollection), cp1);
	er1.a(typeof(LinkedList), cp2);
	er1.a(typeof(ISet<object>), cp3);
	er1.a(typeof(SortedSet), cp);
	er1.a();
	F = (er)er1;
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private static com.google.gson.JsonDeserializer<?> a(com.google.gson.JsonDeserializer<?> paramJsonDeserializer)
  private static JsonDeserializer<object> a<T1>(JsonDeserializer<T1> paramJsonDeserializer)
  {
	return new dy(paramJsonDeserializer);
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static er<com.google.gson.JsonSerializer<?>> a()
  public static er<JsonSerializer<object>> a()
  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: er<com.google.gson.JsonSerializer<?>> er1 = a(false, com.google.gson.LongSerializationPolicy.DEFAULT);
	er<JsonSerializer<object>> er1 = a(false, LongSerializationPolicy.DEFAULT);
	er1.b(a_Conflict);
	return er1;
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static er<com.google.gson.JsonSerializer<?>> a(boolean paramBoolean, com.google.gson.LongSerializationPolicy paramLongSerializationPolicy)
  public static er<JsonSerializer<object>> a(bool paramBoolean, LongSerializationPolicy paramLongSerializationPolicy)
  {
	er<cw> er1 = new er();
	cw cw = new cw(paramBoolean);
	er1.b(typeof(Double), cw);
	er1.b(typeof(double), cw);
	cz cz = new cz(paramBoolean);
	er1.b(typeof(Float), cz);
	er1.b(typeof(float), cz);
	de de = new de(paramLongSerializationPolicy);
	er1.b(typeof(Long), de);
	er1.b(typeof(long), de);
	er1.a(D);
	return (er)er1;
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static er<com.google.gson.JsonDeserializer<?>> b()
  public static er<JsonDeserializer<object>> b()
  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: er<com.google.gson.JsonDeserializer<?>> er1 = E.b();
	er<JsonDeserializer<object>> er1 = E.b();
	er1.b(b_Conflict);
	return er1;
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static er<com.google.gson.JsonDeserializer<?>> c()
  public static er<JsonDeserializer<object>> c()
  {
	return E;
  }

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: public static er<com.google.gson.InstanceCreator<?>> d()
  public static er<InstanceCreator<object>> d()
  {
	return F;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ci.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */