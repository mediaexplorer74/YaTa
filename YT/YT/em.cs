using System;
using System.Collections.Generic;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;

public sealed class em : ExclusionStrategy
{
  private readonly ICollection<int> a = new HashSet<int>();

  public em(params int[] paramVarArgs)
  {
	if (paramVarArgs != null)
	{
	  int i = paramVarArgs.Length;
	  for (sbyte b = 0; b < i; b++)
	  {
		int j = paramVarArgs[b];
		this.a.Add(Convert.ToInt32(j));
	  }
	}
  }

  public bool shouldSkipClass(Type paramClass)
  {
	return false;
  }

  public bool shouldSkipField(FieldAttributes paramFieldAttributes)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield a : Ljava/util/Collection;
	//   4: invokeinterface iterator : ()Ljava/util/Iterator;
	//   9: astore_2
	//   10: aload_2
	//   11: invokeinterface hasNext : ()Z
	//   16: ifeq -> 42
	//   19: aload_1
	//   20: aload_2
	//   21: invokeinterface next : ()Ljava/lang/Object;
	//   26: checkcast java/lang/Integer
	//   29: invokevirtual intValue : ()I
	//   32: invokevirtual hasModifier : (I)Z
	//   35: ifeq -> 10
	//   38: iconst_1
	//   39: istore_3
	//   40: iload_3
	//   41: ireturn
	//   42: iconst_0
	//   43: istore_3
	//   44: goto -> 40
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\em.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */