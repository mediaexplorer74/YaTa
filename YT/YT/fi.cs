using System;

using  = com.google.gson.@internal.;

[Serializable]
public sealed class fi : GenericArrayType
{
  private const long serialVersionUID = 0L;

  private readonly Type a;

  public fi(Type paramType)
  {
	this.a = .Gson.Types.canonicalize(paramType);
  }

  public override bool Equals(object paramObject)
  {
	return (paramObject is GenericArrayType && .Gson.Types.equals(this, (GenericArrayType)paramObject));
  }

  public Type GenericComponentType
  {
	  get
	  {
		return this.a;
	  }
  }

  public override int GetHashCode()
  {
	return this.a.GetHashCode();
  }

  public override string ToString()
  {
	return.Gson.Types.typeToString(this.a) + "[]";
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fi.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */