using System;

public sealed class ep
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly Type a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private object b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly bool c_Conflict;

  internal ep(object paramObject, Type paramType, bool paramBoolean)
  {
	this.b_Conflict = paramObject;
	this.a_Conflict = paramType;
	this.c_Conflict = paramBoolean;
  }

  internal static Type a<T1>(Type<T1> paramType, Type paramClass)
  {
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.lang.reflect.Type<?> type = paramType;
	Type<object> type = paramType;
	if (paramType is Type)
	{
//JAVA TO C# CONVERTER WARNING: Java wildcard generics have no direct equivalent in C#:
//ORIGINAL LINE: java.lang.reflect.Type<?> type1 = paramType;
	  Type<object> type1 = paramType;
	  if (((Type)paramType).IsAssignableFrom(paramClass))
	  {
		type1 = paramClass;
	  }
	  type = type1;
	  if (type1 == typeof(object))
	  {
		type = paramClass;
	  }
	}
	return type;
  }

  internal eq<HANDLER, ep> a<HANDLER>(er<HANDLER> paramer)
  {
	if (!this.c_Conflict && this.b_Conflict != null)
	{
	  ep ep1 = c();
	  HANDLER hANDLER = paramer.a(ep1.a_Conflict);
	  if (hANDLER != null)
	  {
		return new eq<HANDLER, ep>(hANDLER, ep1);
	  }
	}
	paramer = (er<HANDLER>)paramer.a(this.a_Conflict);
	return (eq)((paramer == null) ? null : new eq<er<HANDLER>, ep>(paramer, this));
  }

  public object a()
  {
	return this.b_Conflict;
  }

  public void a(object paramObject)
  {
	this.b_Conflict = paramObject;
  }

  internal Type b()
  {
	return this.a_Conflict;
  }

  internal ep c()
  {
	ep ep1 = this;
	if (!this.c_Conflict)
	{
	  if (this.b_Conflict == null)
	  {
		return this;
	  }
	}
	else
	{
	  return ep1;
	}
	Type type = a(this.a_Conflict, this.b_Conflict.GetType());
	ep1 = this;
	if (type != this.a_Conflict)
	{
	  ep1 = new ep(this.b_Conflict, type, this.c_Conflict);
	}
	return ep1;
  }

  internal Type d()
  {
	return (this.c_Conflict || this.b_Conflict == null) ? this.a_Conflict : a(this.a_Conflict, this.b_Conflict.GetType());
  }

  public override bool Equals(object paramObject)
  {
	bool @bool = true;
	if (this != paramObject)
	{
	  if (paramObject == null)
	  {
		return false;
	  }
	  if (this.GetType() != paramObject.GetType())
	  {
		return false;
	  }
	  paramObject = paramObject;
	  if (this.b_Conflict == null)
	  {
		if (((ep)paramObject).b_Conflict != null)
		{
		  return false;
		}
	  }
	  else if (this.b_Conflict != ((ep)paramObject).b_Conflict)
	  {
		return false;
	  }
	  if (this.a_Conflict == null)
	  {
		if (((ep)paramObject).a_Conflict != null)
		{
		  return false;
		}
	  }
	  else if (!this.a_Conflict.Equals(((ep)paramObject).a_Conflict))
	  {
		return false;
	  }
	  if (this.c_Conflict != ((ep)paramObject).c_Conflict)
	  {
		@bool = false;
	  }
	}
	return @bool;
  }

  public override int GetHashCode()
  {
	return (this.b_Conflict == null) ? 31 : this.b_Conflict.GetHashCode();
  }

  public override string ToString()
  {
//JAVA TO C# CONVERTER TODO TASK: The following line has a Java format specifier which cannot be directly translated to .NET:
	return string.Format("preserveType: %b, type: %s, obj: %s", new object[] {Convert.ToBoolean(this.c_Conflict), this.a_Conflict, this.b_Conflict});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ep.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */