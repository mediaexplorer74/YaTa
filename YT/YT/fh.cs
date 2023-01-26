using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;
using Since = com.google.gson.annotations.Since;
using Until = com.google.gson.annotations.Until;
using  = com.google.gson.@internal.;

public sealed class fh : ExclusionStrategy
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly double a_Conflict;

  public fh(double paramDouble)
  {
	bool @bool;
	if (paramDouble >= 0.0D)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	.Gson.Preconditions.checkArgument(@bool);
	this.a_Conflict = paramDouble;
  }

  private bool a(Since paramSince, Until paramUntil)
  {
	bool @bool;
	null = true;
	if (paramSince != null && paramSince.value() > this.a_Conflict)
	{
	  @bool = false;
	}
	else
	{
	  @bool = true;
	}
	if (@bool)
	{
	  if (paramUntil != null && paramUntil.value() <= this.a_Conflict)
	  {
		@bool = false;
	  }
	  else
	  {
		@bool = true;
	  }
	  if (@bool)
	  {
		return null;
	  }
	}
	return false;
  }

  public bool shouldSkipClass(Type paramClass)
  {
	return !a(paramClass.getAnnotation<Since>(typeof(Since)), paramClass.getAnnotation<Until>(typeof(Until)));
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	return !a((Since)paramFieldAttributes.getAnnotation(typeof(Since)), (Until)paramFieldAttributes.getAnnotation(typeof(Until)));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */