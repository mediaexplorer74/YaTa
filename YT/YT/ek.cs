using System;

using com.google.gson;
using  = com.google.gson.@internal.;

public sealed class ek : eo
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly fb a_Conflict = fb.a();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly cg b_Conflict = new cg(500);

//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final er<com.google.gson.InstanceCreator<?>> c;
  private readonly er<InstanceCreator<object>> c;

//JAVA TO C# CONVERTER TODO TASK: Wildcard generics in constructor parameters are not converted. Move the generic type parameter and constraint to the class header:
//ORIGINAL LINE: public ek(er<com.google.gson.InstanceCreator<?>> paramer)
  public ek(er<T1> paramer)
  {
	this.c = paramer;
  }

  private static T b<T>(Type paramType)
  {
	try
	{
	  Type clazz = .Gson.Types.getRawType(paramType);
	  T t1 = (T)b.a(clazz);
	  T t2 = t1;
	  if (t1 == null)
	  {
		t2 = a.a(clazz);
	  }
	  return t2;
	}
	catch (Exception exception)
	{
	  throw new Exception("Unable to invoke no-args constructor for " + paramType + ". " + "Register an InstanceCreator with Gson for this type may fix this problem.", exception);
	}
  }

  public T a<T>(Type paramType)
  {
	InstanceCreator instanceCreator = this.c.a(paramType);
	return (T)((instanceCreator != null) ? instanceCreator.createInstance(paramType) : b(paramType));
  }

  public object a(Type paramType, int paramInt)
  {
	return Array.CreateInstance(.Gson.Types.getRawType(paramType), paramInt);
  }

  public override string ToString()
  {
	return this.c.ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ek.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */