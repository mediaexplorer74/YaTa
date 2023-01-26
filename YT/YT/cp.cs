using System;

using com.google.gson;
using JsonIOException = com.google.gson.JsonIOException;
using  = com.google.gson.@internal.;

internal sealed class cp<T> : InstanceCreator<T>
{
  private readonly Type a;

  private readonly cg b;

  public cp(Type paramClass, cg paramcg)
  {
	this.a = paramClass;
	this.b = paramcg;
  }

  public T createInstance(Type paramType)
  {
	paramType = .Gson.Types.getRawType(paramType);
	try
	{
	  Type type = (Type)this.b.a((Type<object>)paramType);
	  paramType = type;
	  if (type == null)
	  {
		paramType = this.b.a((Type)this.a);
	  }
	  return (T)paramType;
	}
	catch (Exception exception)
	{
	  throw new JsonIOException(exception);
	}
  }

  public override string ToString()
  {
	return typeof(cp).Name;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */