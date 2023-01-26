using System;
using System.Text;

using  = com.google.gson.@internal.;

[Serializable]
public sealed class fj : ParameterizedType
{
  private const long serialVersionUID = 0L;

  private readonly Type a;

  private readonly Type b;

  private readonly Type[] c;

  public fj(Type paramType1, Type paramType2, params Type[] paramVarArgs)
  {
	if (paramType2 is Type)
	{
	  Type clazz = (Type)paramType2;
	  if (paramType1 != null || clazz.getEnclosingClass() == null)
	  {
		bool1 = true;
	  }
	  else
	  {
		bool1 = false;
	  }
	  .Gson.Preconditions.checkArgument(bool1);
	  bool bool1 = @bool;
	  if (paramType1 != null)
	  {
		if (clazz.getEnclosingClass() != null)
		{
		  bool1 = @bool;
		}
		else
		{
		  bool1 = false;
		}
	  }
	  .Gson.Preconditions.checkArgument(bool1);
	}
	if (paramType1 == null)
	{
	  paramType1 = null;
	}
	else
	{
	  paramType1 = .Gson.Types.canonicalize(paramType1);
	}
	this.a = paramType1;
	this.b = .Gson.Types.canonicalize(paramType2);
	this.c = (Type[])(Type[])paramVarArgs.Clone();
	while (b < this.c.Length)
	{
	  .Gson.Preconditions.checkNotNull(this.c[b]);
	  .Gson.Types.a(this.c[b]);
	  this.c[b] = .Gson.Types.canonicalize(this.c[b]);
	  b++;
	}
  }

  public override bool Equals(object paramObject)
  {
	return (paramObject is ParameterizedType && .Gson.Types.equals(this, (ParameterizedType)paramObject));
  }

  public Type[] ActualTypeArguments
  {
	  get
	  {
		return (Type[])(Type[])this.c.Clone();
	  }
  }

  public Type OwnerType
  {
	  get
	  {
		return this.a;
	  }
  }

  public Type RawType
  {
	  get
	  {
		return this.b;
	  }
  }

  public override int GetHashCode()
  {
	return Arrays.hashCode((object[])this.c) ^ this.b.GetHashCode() ^ .Gson.Types.a(this.a);
  }

  public override string ToString()
  {
	StringBuilder stringBuilder = new StringBuilder((this.c.Length + 1) * 30);
	stringBuilder.Append(.Gson.Types.typeToString(this.b));
	if (this.c.Length == 0)
	{
	  return stringBuilder.ToString();
	}
	stringBuilder.Append("<").Append(.Gson.Types.typeToString(this.c[0]));
	for (sbyte b = 1; b < this.c.Length; b++)
	{
	  stringBuilder.Append(", ").Append(.Gson.Types.typeToString(this.c[b]));
	}
	return stringBuilder.Append(">").ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */