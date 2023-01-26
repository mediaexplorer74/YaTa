using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;

public sealed class en : ExclusionStrategy
{
  public bool shouldSkipClass(Type paramClass)
  {
	return false;
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\en.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */