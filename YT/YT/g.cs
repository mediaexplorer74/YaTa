public sealed class g
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal readonly object a_Conflict;

  internal readonly object b;

  public g(object paramObject1, object paramObject2)
  {
	this.a_Conflict = paramObject1;
	this.b = paramObject2;
  }

  public static g a(object paramObject1, object paramObject2)
  {
	return new g(paramObject1, paramObject2);
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
	  if (this.a_Conflict == null)
	  {
		if (((g)paramObject).a_Conflict != null)
		{
		  return false;
		}
	  }
	  else if (!this.a_Conflict.Equals(((g)paramObject).a_Conflict))
	  {
		return false;
	  }
	  if (this.b == null)
	  {
		if (((g)paramObject).b != null)
		{
		  @bool = false;
		}
		return @bool;
	  }
	  if (!this.b.Equals(((g)paramObject).b))
	  {
		@bool = false;
	  }
	}
	return @bool;
  }

  public override int GetHashCode()
  {
	int j;
	int i = 0;
	if (this.a_Conflict == null)
	{
	  j = 0;
	}
	else
	{
	  j = this.a_Conflict.GetHashCode();
	}
	if (this.b != null)
	{
	  i = this.b.GetHashCode();
	}
	return (j + 31) * 31 + i;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\g.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */