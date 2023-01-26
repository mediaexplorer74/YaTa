using System;
using System.Collections.Generic;

using ExclusionStrategy = com.google.gson.ExclusionStrategy;
using FieldAttributes = com.google.gson.FieldAttributes;
using  = com.google.gson.@internal.;

public sealed class dn : ExclusionStrategy
{
  private readonly ICollection<ExclusionStrategy> a;

  public dn(ICollection<ExclusionStrategy> paramCollection)
  {
	this.a = (ICollection<ExclusionStrategy>).Gson.Preconditions.checkNotNull(paramCollection);
  }

  public bool shouldSkipClass(Type paramClass)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield a : Ljava/util/Collection;
	//   4: invokeinterface iterator : ()Ljava/util/Iterator;
	//   9: astore_2
	//   10: aload_2
	//   11: invokeinterface hasNext : ()Z
	//   16: ifeq -> 41
	//   19: aload_2
	//   20: invokeinterface next : ()Ljava/lang/Object;
	//   25: checkcast com/google/gson/ExclusionStrategy
	//   28: aload_1
	//   29: invokeinterface shouldSkipClass : (Ljava/lang/Class;)Z
	//   34: ifeq -> 10
	//   37: iconst_1
	//   38: istore_3
	//   39: iload_3
	//   40: ireturn
	//   41: iconst_0
	//   42: istore_3
	//   43: goto -> 39
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
	//   16: ifeq -> 41
	//   19: aload_2
	//   20: invokeinterface next : ()Ljava/lang/Object;
	//   25: checkcast com/google/gson/ExclusionStrategy
	//   28: aload_1
	//   29: invokeinterface shouldSkipField : (Lcom/google/gson/FieldAttributes;)Z
	//   34: ifeq -> 10
	//   37: iconst_1
	//   38: istore_3
	//   39: iload_3
	//   40: ireturn
	//   41: iconst_0
	//   42: istore_3
	//   43: goto -> 39
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\dn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */