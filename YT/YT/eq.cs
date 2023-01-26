public sealed class eq<FIRST, SECOND>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public readonly FIRST a_Conflict;

  public readonly SECOND b;

  public eq(FIRST paramFIRST, SECOND paramSECOND)
  {
	this.a_Conflict = paramFIRST;
	this.b = paramSECOND;
  }

  private static bool a(object paramObject1, object paramObject2)
  {
	return (paramObject1 == paramObject2 || (paramObject1 != null && paramObject1.Equals(paramObject2)));
  }

  public override bool Equals(object paramObject)
  {
	bool bool1 = false;
	if (!(paramObject is eq))
	{
	  return bool1;
	}
	paramObject = paramObject;
	bool bool2 = bool1;
	if (a(this.a_Conflict, ((eq)paramObject).a_Conflict))
	{
	  bool2 = bool1;
	  if (a(this.b, ((eq)paramObject).b))
	  {
		bool2 = true;
	  }
	}
	return bool2;
  }

  public override int GetHashCode()
  {
	sbyte b;
	int i = 0;
	if (this.a_Conflict != null)
	{
	  b = this.a_Conflict.GetHashCode();
	}
	else
	{
	  b = 0;
	}
	if (this.b != null)
	{
	  i = this.b.GetHashCode();
	}
	return b * 17 + i * 17;
  }

  public override string ToString()
  {
	return string.Format("{{{0},{1}}}", new object[] {this.a_Conflict, this.b});
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\eq.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */