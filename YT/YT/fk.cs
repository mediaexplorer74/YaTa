using System;

using  = com.google.gson.@internal.;

[Serializable]
public sealed class fk : WildcardType
{
  private const long serialVersionUID = 0L;

  private readonly Type a;

  private readonly Type b;

  public fk(Type[] paramArrayOfType1, Type[] paramArrayOfType2)
  {
	bool bool2;
	if (paramArrayOfType2.Length <= 1)
	{
	  bool2 = true;
	}
	else
	{
	  bool2 = false;
	}
	.Gson.Preconditions.checkArgument(bool2);
	if (paramArrayOfType1.Length == 1)
	{
	  bool2 = true;
	}
	else
	{
	  bool2 = false;
	}
	.Gson.Preconditions.checkArgument(bool2);
	if (paramArrayOfType2.Length == 1)
	{
	  .Gson.Preconditions.checkNotNull(paramArrayOfType2[0]);
	  .Gson.Types.a(paramArrayOfType2[0]);
	  if (paramArrayOfType1[0] == typeof(object))
	  {
		bool2 = bool1;
	  }
	  else
	  {
		bool2 = false;
	  }
	  .Gson.Preconditions.checkArgument(bool2);
	  this.b = .Gson.Types.canonicalize(paramArrayOfType2[0]);
	  this.a = typeof(object);
	  return;
	}
	.Gson.Preconditions.checkNotNull(paramArrayOfType1[0]);
	.Gson.Types.a(paramArrayOfType1[0]);
	this.b = null;
	this.a = .Gson.Types.canonicalize(paramArrayOfType1[0]);
  }

  public override bool Equals(object paramObject)
  {
	return (paramObject is WildcardType && .Gson.Types.equals(this, (WildcardType)paramObject));
  }

  public Type[] LowerBounds
  {
	  get
	  {
		if (this.b != null)
		{
		  Type[] arrayOfType = new Type[1];
		  arrayOfType[0] = this.b;
		  return arrayOfType;
		}
		return.Gson.Types.a;
	  }
  }

  public Type[] UpperBounds
  {
	  get
	  {
		return new Type[] {this.a};
	  }
  }

  public override int GetHashCode()
  {
	if (this.b != null)
	{
	  int i = this.b.GetHashCode() + 31;
	  return i ^ this.a.GetHashCode() + 31;
	}
	bool @bool = true;
	return @bool ^ this.a.GetHashCode() + 31;
  }

  public override string ToString()
  {
	return (this.b != null) ? ("? super " + .Gson.Types.typeToString(this.b)) : ((this.a == typeof(object)) ? "?" : ("? extends " + .Gson.Types.typeToString(this.a)));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fk.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */