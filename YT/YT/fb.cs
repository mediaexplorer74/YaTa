using System;

internal abstract class fb
{
  public static fb a()
  {
	try
	{
	  Type clazz = Type.GetType("sun.misc.Unsafe");
	  System.Reflection.FieldInfo field = clazz.getDeclaredField("theUnsafe");
	  field.setAccessible(true);
	  object @object = field.get((object)null);
	  System.Reflection.MethodInfo method = clazz.GetMethod("allocateInstance", new Type[] {typeof(Type)});
	  fc fc = new fc();
	  this(method, @object);
	}
	catch (Exception)
	{
	}
	return (fb)exception;
  }

  public abstract T a<T>(Type paramClass);
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fb.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */