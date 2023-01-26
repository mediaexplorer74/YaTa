﻿using System;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;
using Expose = com.google.gson.annotations.Expose;

public sealed class dp : ExclusionStrategy
{
  public bool shouldSkipClass(Type paramClass)
  {
	return false;
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	Expose expose = (Expose)paramFieldAttributes.getAnnotation(typeof(Expose));
	return (expose == null) ? true : (!expose.deserialize());
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dp.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */