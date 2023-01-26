using System;
using System.Collections.Generic;

namespace com.google.gson
{
	using ci;
	using  = com.google.gson.@internal.;
	using cq;
	using dn;
	using dp;
	using dq;
	using dr;
	using ds;
	using dt;
	using dy;
	using ei;
	using ek;
	using em;
	using er;
	using ev;
	using fh;

	public sealed class GsonBuilder
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static readonly ei a_Conflict = new ei();

	  private static readonly dt b = new dt();

	  private static readonly dp c = new dp();

	  private static readonly dq d = new dq();

	  private readonly ISet<ExclusionStrategy> e = new HashSet<ExclusionStrategy>();

	  private readonly ISet<ExclusionStrategy> f = new HashSet<ExclusionStrategy>();

	  private double g;

	  private em h;

	  private bool i;

	  private bool j;

	  private LongSerializationPolicy k;

	  private dr l;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<InstanceCreator<?>> m;
	  private readonly er<InstanceCreator<object>> m;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<JsonSerializer<?>> n;
	  private readonly er<JsonSerializer<object>> n;

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<JsonDeserializer<?>> o;
	  private readonly er<JsonDeserializer<object>> o;

	  private bool p;

	  private string q;

	  private int r;

	  private int s;

	  private bool t;

	  private bool u;

	  private bool v;

	  private bool w;

	  public GsonBuilder()
	  {
		this.f.Add(Gson.a_Conflict);
		this.f.Add(Gson.b);
		this.e.Add(Gson.a_Conflict);
		this.e.Add(Gson.b);
		this.g = -1.0D;
		this.i = true;
		this.v = false;
		this.u = true;
		this.h = Gson.c;
		this.j = false;
		this.k = com.google.gson.LongSerializationPolicy.DEFAULT;
		this.l = Gson.d;
		this.m = new er();
		this.n = new er();
		this.o = new er();
		this.p = false;
		this.r = 2;
		this.s = 2;
		this.t = false;
		this.w = false;
	  }

	  private static void a<T>(Type paramClass, er<T> paramer, T paramT)
	  {
		if (!paramer.b(paramClass))
		{
		  paramer.a(paramClass, paramT);
		}
	  }

	  internal GsonBuilder a(dr paramdr)
	  {
		this.l = (dr)new ev(paramdr);
		return this;
	  }

	  public GsonBuilder addDeserializationExclusionStrategy(ExclusionStrategy paramExclusionStrategy)
	  {
		this.f.Add(paramExclusionStrategy);
		return this;
	  }

	  public GsonBuilder addSerializationExclusionStrategy(ExclusionStrategy paramExclusionStrategy)
	  {
		this.e.Add(paramExclusionStrategy);
		return this;
	  }

	  public Gson create()
	  {
		cq cq;
		LinkedList<ExclusionStrategy> linkedList1 = new LinkedList<ExclusionStrategy>(this.f);
		LinkedList<ExclusionStrategy> linkedList2 = new LinkedList<ExclusionStrategy>(this.e);
		linkedList1.AddLast(this.h);
		linkedList2.AddLast(this.h);
		if (!this.i)
		{
		  linkedList1.AddLast(b);
		  linkedList2.AddLast(b);
		}
		if (this.g != -1.0D)
		{
		  fh fh = new fh(this.g);
		  linkedList1.AddLast(fh);
		  linkedList2.AddLast(fh);
		}
		if (this.j)
		{
		  linkedList1.AddLast(c);
		  linkedList2.AddLast(d);
		}
		er<cq> er2 = ci.a_Conflict.b();
		er2.b(this.n.b());
		er<cq> er3 = ci.b_Conflict.b();
		er3.b(this.o.b());
		string str1 = this.q;
		int i = this.r;
		int j = this.s;
		string str2 = null;
		if (!string.ReferenceEquals(str1, null) && !"".Equals(str1.Trim()))
		{
		  cq = new cq(str1);
		}
		else
		{
		  str1 = str2;
		  if (i != 2)
		  {
			str1 = str2;
			if (j != 2)
			{
			  cq = new cq(i, j);
			}
		  }
		}
		if (cq != null)
		{
		  a(typeof(Date), er2, cq);
		  a(typeof(Date), er3, cq);
		  a(typeof(Timestamp), er2, cq);
		  a(typeof(Timestamp), er3, cq);
		  a(typeof(Date), er2, cq);
		  a(typeof(Date), er3, cq);
		}
		er2.a(ci.a(this.t, this.k));
		er3.a(ci.c());
		er er1 = this.m.b();
		er1.a(ci.d());
		er2.a();
		er3.a();
		this.m.a();
		ek ek = new ek(er1);
		return new Gson((ExclusionStrategy)new dn(linkedList1), (ExclusionStrategy)new dn(linkedList2), this.l, ek, this.p, (er)er2, (er)er3, this.w, this.u, this.v);
	  }

	  public GsonBuilder disableHtmlEscaping()
	  {
		this.u = false;
		return this;
	  }

	  public GsonBuilder disableInnerClassSerialization()
	  {
		this.i = false;
		return this;
	  }

	  public GsonBuilder enableComplexMapKeySerialization()
	  {
		registerTypeHierarchyAdapter(typeof(System.Collections.IDictionary), a_Conflict);
		return this;
	  }

	  public GsonBuilder excludeFieldsWithModifiers(params int[] paramVarArgs)
	  {
		this.h = new em(paramVarArgs);
		return this;
	  }

	  public GsonBuilder excludeFieldsWithoutExposeAnnotation()
	  {
		this.j = true;
		return this;
	  }

	  public GsonBuilder generateNonExecutableJson()
	  {
		this.w = true;
		return this;
	  }

	  public GsonBuilder registerTypeAdapter(Type paramType, object paramObject)
	  {
		bool @bool;
		if (paramObject is JsonSerializer || paramObject is JsonDeserializer || paramObject is InstanceCreator)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		.Gson.Preconditions.checkArgument(@bool);
		if (paramObject is InstanceCreator)
		{
		  InstanceCreator instanceCreator = (InstanceCreator)paramObject;
		  this.m.a(paramType, instanceCreator);
		}
		if (paramObject is JsonSerializer)
		{
		  JsonSerializer jsonSerializer = (JsonSerializer)paramObject;
		  this.n.a(paramType, jsonSerializer);
		}
		if (paramObject is JsonDeserializer)
		{
		  paramObject = paramObject;
		  this.o.a(paramType, new dy((JsonDeserializer)paramObject));
		}
		return this;
	  }

	  public GsonBuilder registerTypeHierarchyAdapter(Type paramClass, object paramObject)
	  {
		bool @bool;
		if (paramObject is JsonSerializer || paramObject is JsonDeserializer || paramObject is InstanceCreator)
		{
		  @bool = true;
		}
		else
		{
		  @bool = false;
		}
		.Gson.Preconditions.checkArgument(@bool);
		if (paramObject is InstanceCreator)
		{
		  InstanceCreator instanceCreator = (InstanceCreator)paramObject;
		  this.m.a(paramClass, instanceCreator);
		}
		if (paramObject is JsonSerializer)
		{
		  JsonSerializer jsonSerializer = (JsonSerializer)paramObject;
		  this.n.a(paramClass, jsonSerializer);
		}
		if (paramObject is JsonDeserializer)
		{
		  paramObject = paramObject;
		  this.o.a(paramClass, new dy((JsonDeserializer)paramObject));
		}
		return this;
	  }

	  public GsonBuilder serializeNulls()
	  {
		this.p = true;
		return this;
	  }

	  public GsonBuilder serializeSpecialFloatingPointValues()
	  {
		this.t = true;
		return this;
	  }

	  public GsonBuilder setDateFormat(int paramInt)
	  {
		this.r = paramInt;
		this.q = null;
		return this;
	  }

	  public GsonBuilder setDateFormat(int paramInt1, int paramInt2)
	  {
		this.r = paramInt1;
		this.s = paramInt2;
		this.q = null;
		return this;
	  }

	  public GsonBuilder setDateFormat(string paramString)
	  {
		this.q = paramString;
		return this;
	  }

	  public GsonBuilder setExclusionStrategies(params ExclusionStrategy[] paramVarArgs)
	  {
		IList<ExclusionStrategy> list = new List<ExclusionStrategy> {paramVarArgs};
		this.e.addAll(list);
		this.f.addAll(list);
		return this;
	  }

	  public GsonBuilder setFieldNamingPolicy(FieldNamingPolicy paramFieldNamingPolicy)
	  {
		return a(paramFieldNamingPolicy.a());
	  }

	  public GsonBuilder setFieldNamingStrategy(FieldNamingStrategy paramFieldNamingStrategy)
	  {
		return a((dr)new ds(paramFieldNamingStrategy));
	  }

	  public GsonBuilder setLongSerializationPolicy(LongSerializationPolicy paramLongSerializationPolicy)
	  {
		this.k = paramLongSerializationPolicy;
		return this;
	  }

	  public GsonBuilder setPrettyPrinting()
	  {
		this.v = true;
		return this;
	  }

	  public GsonBuilder setVersion(double paramDouble)
	  {
		this.g = paramDouble;
		return this;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\GsonBuilder.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}