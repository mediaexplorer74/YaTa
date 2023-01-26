using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;
using ObjectNavigator = com.google.gson.ObjectNavigator;
using  = com.google.gson.@internal.;

public sealed class eu
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly be<Type, IList<FieldAttributes>> a_Conflict = new eh<Type, IList<FieldAttributes>>(500);

  private readonly ExclusionStrategy b;

  public eu(ExclusionStrategy paramExclusionStrategy)
  {
	this.b = (ExclusionStrategy).Gson.Preconditions.checkNotNull(paramExclusionStrategy);
  }

  private static IList<Type> a(Type paramType)
  {
	List<Type> arrayList = new ArrayList();
	for (paramType = .Gson.Types.getRawType(paramType); paramType != null && !paramType.Equals(typeof(object)); paramType = paramType.BaseType)
	{
	  if (!paramType.isSynthetic())
	  {
		arrayList.Add(paramType);
	  }
	}
	return (System.Collections.IList)arrayList;
  }

  public void a(ep paramep, ObjectNavigator.Visitor paramVisitor)
  {
	Type type1 = paramep.d();
	object @object = paramep.a();
	Type type2 = paramep.b();
	IList<FieldAttributes> list2 = a.a(type1);
	IList<FieldAttributes> list1 = list2;
	if (list2 == null)
	{
	  list1 = new ArrayList();
	  foreach (Type clazz in a(type1))
	  {
		System.Reflection.FieldInfo[] arrayOfField = clazz.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
		AccessibleObject.setAccessible((AccessibleObject[])arrayOfField, true);
		int i = arrayOfField.Length;
		for (sbyte b = 0; b < i; b++)
		{
		  list1.Add(new FieldAttributes(clazz, arrayOfField[b], type2));
		}
	  }
	  a.a(type1, list1);
	}
	foreach (FieldAttributes fieldAttributes in list1)
	{
	  if (!this.b.shouldSkipField(fieldAttributes) && !this.b.shouldSkipClass(fieldAttributes.DeclaredClass))
	  {
		Type type = fieldAttributes.c();
		if (!paramVisitor.visitFieldUsingCustomHandler(fieldAttributes, type, @object))
		{
		  if (.Gson.Types.isArray(type))
		  {
			paramVisitor.visitArrayField(fieldAttributes, type, @object);
			continue;
		  }
		  paramVisitor.visitObjectField(fieldAttributes, type, @object);
		}
	  }
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\eu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */