using System;
using System.Collections.Generic;

using  = com.google.gson.@internal.;

public sealed class es
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly IDictionary<Type, Type> a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly IDictionary<Type, Type> b_Conflict;

  static es()
  {
	Dictionary<object, object> hashMap1 = new Dictionary<object, object>(16);
	Dictionary<object, object> hashMap2 = new Dictionary<object, object>(16);
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(bool), typeof(Boolean));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(sbyte), typeof(Byte));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(char), typeof(Character));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(double), typeof(Double));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(float), typeof(Float));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(int), typeof(Integer));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(long), typeof(Long));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(short), typeof(Short));
	a((System.Collections.IDictionary)hashMap1, (System.Collections.IDictionary)hashMap2, typeof(void), typeof(Void));
	a_Conflict = Collections.unmodifiableMap(hashMap1);
	b_Conflict = Collections.unmodifiableMap(hashMap2);
  }

  public static Type<T> a<T>(Type paramClass)
  {
	Type clazz = (Type)a_Conflict[.Gson.Preconditions.checkNotNull(paramClass)];
	if (clazz != null)
	{
	  paramClass = clazz;
	}
	return paramClass;
  }

  private static void a(IDictionary<Type, Type> paramMap1, IDictionary<Type, Type> paramMap2, Type paramClass1, Type paramClass2)
  {
	paramMap1[paramClass1] = paramClass2;
	paramMap2[paramClass2] = paramClass1;
  }

  public static bool a(Type paramType)
  {
	return a_Conflict.ContainsKey(paramType);
  }

  public static Type<T> b<T>(Type paramClass)
  {
	Type clazz = (Type)b_Conflict[.Gson.Preconditions.checkNotNull(paramClass)];
	if (clazz != null)
	{
	  paramClass = clazz;
	}
	return paramClass;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\es.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */