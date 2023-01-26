namespace com.google.gson
{
	using en;
	using ep;
	using eu;

	public sealed class ObjectNavigator
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private readonly ExclusionStrategy a_Conflict;

	  private readonly eu b;

	  internal ObjectNavigator(ExclusionStrategy paramExclusionStrategy)
	  {
		en en;
		ExclusionStrategy exclusionStrategy = paramExclusionStrategy;
		if (paramExclusionStrategy == null)
		{
		  en = new en();
		}
		this.a_Conflict = (ExclusionStrategy)en;
		this.b = new eu(this.a_Conflict);
	  }

	  public void a(ep paramep, ObjectNavigator$Visitor paramObjectNavigator$Visitor)
	  {
		// Byte code:
		//   0: aload_0
		//   1: getfield a : Lcom/google/gson/ExclusionStrategy;
		//   4: aload_1
		//   5: getfield a : Ljava/lang/reflect/Type;
		//   8: invokestatic getRawType : (Ljava/lang/reflect/Type;)Ljava/lang/Class;
		//   11: invokeinterface shouldSkipClass : (Ljava/lang/Class;)Z
		//   16: ifeq -> 20
		//   19: return
		//   20: aload_2
		//   21: aload_1
		//   22: invokeinterface visitUsingCustomHandler : (Lep;)Z
		//   27: ifne -> 19
		//   30: aload_1
		//   31: invokevirtual a : ()Ljava/lang/Object;
		//   34: astore_3
		//   35: aload_3
		//   36: ifnonnull -> 93
		//   39: aload_2
		//   40: invokeinterface getTarget : ()Ljava/lang/Object;
		//   45: astore_3
		//   46: aload_3
		//   47: ifnull -> 19
		//   50: aload_1
		//   51: aload_3
		//   52: invokevirtual a : (Ljava/lang/Object;)V
		//   55: aload_2
		//   56: aload_1
		//   57: invokeinterface start : (Lep;)V
		//   62: aload_1
		//   63: getfield a : Ljava/lang/reflect/Type;
		//   66: invokestatic isArray : (Ljava/lang/reflect/Type;)Z
		//   69: ifeq -> 96
		//   72: aload_2
		//   73: aload_3
		//   74: aload_1
		//   75: getfield a : Ljava/lang/reflect/Type;
		//   78: invokeinterface visitArray : (Ljava/lang/Object;Ljava/lang/reflect/Type;)V
		//   83: aload_2
		//   84: aload_1
		//   85: invokeinterface end : (Lep;)V
		//   90: goto -> 19
		//   93: goto -> 46
		//   96: aload_1
		//   97: getfield a : Ljava/lang/reflect/Type;
		//   100: ldc java/lang/Object
		//   102: if_acmpne -> 177
		//   105: aload_3
		//   106: invokevirtual getClass : ()Ljava/lang/Class;
		//   109: astore #4
		//   111: aload #4
		//   113: ldc java/lang/Object
		//   115: if_acmpeq -> 136
		//   118: aload #4
		//   120: ldc java/lang/String
		//   122: if_acmpeq -> 136
		//   125: aload #4
		//   127: invokestatic b : (Ljava/lang/Class;)Ljava/lang/Class;
		//   130: invokevirtual isPrimitive : ()Z
		//   133: ifeq -> 171
		//   136: iconst_1
		//   137: istore #5
		//   139: iload #5
		//   141: ifeq -> 177
		//   144: aload_2
		//   145: aload_3
		//   146: invokeinterface visitPrimitive : (Ljava/lang/Object;)V
		//   151: aload_2
		//   152: invokeinterface getTarget : ()Ljava/lang/Object;
		//   157: pop
		//   158: goto -> 83
		//   161: astore_3
		//   162: aload_2
		//   163: aload_1
		//   164: invokeinterface end : (Lep;)V
		//   169: aload_3
		//   170: athrow
		//   171: iconst_0
		//   172: istore #5
		//   174: goto -> 139
		//   177: aload_2
		//   178: aload_3
		//   179: invokeinterface startVisitingObject : (Ljava/lang/Object;)V
		//   184: aload_0
		//   185: getfield b : Leu;
		//   188: aload_1
		//   189: aload_2
		//   190: invokevirtual a : (Lep;Lcom/google/gson/ObjectNavigator$Visitor;)V
		//   193: goto -> 83
		// Exception table:
		//   from	to	target	type
		//   62	83	161	finally
		//   96	111	161	finally
		//   125	136	161	finally
		//   144	158	161	finally
		//   177	193	161	finally
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\com\google\gson\ObjectNavigator.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}