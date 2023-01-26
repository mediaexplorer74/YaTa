using System;

internal sealed class cg
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly System.Reflection.ConstructorInfo<ch> a_Conflict = a();

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: private final be<Class, java.lang.reflect.Constructor<?>> b;
  private readonly be<Type, System.Reflection.ConstructorInfo<object>> b_Conflict;

  public cg() : this(200)
  {
  }

  public cg(int paramInt)
  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: this.b = new eh<Class, java.lang.reflect.Constructor<?>>(paramInt);
	this.b_Conflict = new eh<Type, System.Reflection.ConstructorInfo<object>>(paramInt);
  }

  private static System.Reflection.ConstructorInfo<ch> a()
  {
	try
	{
	  System.Reflection.ConstructorInfo<ch> constructor = b(typeof(ch));
	}
	catch (Exception exception)
	{
	  exception = null;
	}
	return (System.Reflection.ConstructorInfo<ch>)exception;
  }

  private static System.Reflection.ConstructorInfo<T> b<T>(Type paramClass)
  {
	try
	{
	  System.Reflection.ConstructorInfo<T> constructor = paramClass.getDeclaredConstructor(new Type[0]);
	  constructor.setAccessible(true);
	}
	catch (Exception exception)
	{
	  exception = null;
	}
	return (System.Reflection.ConstructorInfo<T>)exception;
  }

  public T a<T>(Type paramClass)
  {
	System.Reflection.ConstructorInfo<ch> constructor = (System.Reflection.ConstructorInfo)this.b_Conflict.a(paramClass);
	if (constructor != null)
	{
	  null = constructor;
	  if (constructor == a_Conflict)
	  {
		null = null;
	  }
	}
	else
	{
	  constructor = b((Type<ch>)null);
	  if (constructor != null)
	  {
		this.b_Conflict.a(null, constructor);
		null = constructor;
	  }
	  else
	  {
		this.b_Conflict.a(null, a_Conflict);
		null = constructor;
	  }
	}
	return (T)((null != null) ? null.newInstance(new object[0]) : null);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cg.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */