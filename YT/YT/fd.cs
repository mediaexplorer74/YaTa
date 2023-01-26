using System;

internal sealed class fd : fb
{
  internal fd(System.Reflection.MethodInfo paramMethod)
  {
  }

  public override T a<T>(Type paramClass)
  {
	return (T)this.a.invoke(null, new object[] {paramClass, typeof(object)});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fd.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */