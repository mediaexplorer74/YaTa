﻿using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;

public sealed class fa : ExclusionStrategy
{
  private readonly bool a;

  public fa(bool paramBoolean)
  {
	this.a = paramBoolean;
  }

  public bool shouldSkipClass(Type paramClass)
  {
	return false;
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	return (this.a && paramFieldAttributes.a());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fa.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */