using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using  = com.google.gson.@internal.;

public sealed class er<T>
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
  private static readonly Logger a_Conflict = Logger.getLogger(typeof(er).FullName);

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly IDictionary<Type, T> b_Conflict = new Dictionary<Type, T>();

  private readonly IList<eq<Type, T>> c = new List<eq<Type, T>>();

  private bool d = true;

  private int a(Type paramClass)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield c : Ljava/util/List;
	//   4: invokeinterface size : ()I
	//   9: iconst_1
	//   10: isub
	//   11: istore_2
	//   12: iload_2
	//   13: iflt -> 50
	//   16: aload_1
	//   17: aload_0
	//   18: getfield c : Ljava/util/List;
	//   21: iload_2
	//   22: invokeinterface get : (I)Ljava/lang/Object;
	//   27: checkcast eq
	//   30: getfield a : Ljava/lang/Object;
	//   33: checkcast java/lang/Class
	//   36: invokevirtual isAssignableFrom : (Ljava/lang/Class;)Z
	//   39: ifeq -> 44
	//   42: iload_2
	//   43: ireturn
	//   44: iinc #2, -1
	//   47: goto -> 12
	//   50: iconst_m1
	//   51: istore_2
	//   52: goto -> 42
  }

  private int b(Type paramClass)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield c : Ljava/util/List;
	//   6: invokeinterface size : ()I
	//   11: iconst_1
	//   12: isub
	//   13: istore_2
	//   14: iload_2
	//   15: iflt -> 53
	//   18: aload_1
	//   19: aload_0
	//   20: getfield c : Ljava/util/List;
	//   23: iload_2
	//   24: invokeinterface get : (I)Ljava/lang/Object;
	//   29: checkcast eq
	//   32: getfield a : Ljava/lang/Object;
	//   35: invokevirtual equals : (Ljava/lang/Object;)Z
	//   38: istore_3
	//   39: iload_3
	//   40: ifeq -> 47
	//   43: aload_0
	//   44: monitorexit
	//   45: iload_2
	//   46: ireturn
	//   47: iinc #2, -1
	//   50: goto -> 14
	//   53: iconst_m1
	//   54: istore_2
	//   55: goto -> 43
	//   58: astore_1
	//   59: aload_0
	//   60: monitorexit
	//   61: aload_1
	//   62: athrow
	// Exception table:
	//   from	to	target	type
	//   2	14	58	finally
	//   18	39	58	finally
  }

  public T a(Type paramType)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield b : Ljava/util/Map;
	//   6: aload_1
	//   7: invokeinterface get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   12: astore_2
	//   13: aload_2
	//   14: astore_3
	//   15: aload_2
	//   16: ifnonnull -> 93
	//   19: aload_1
	//   20: invokestatic getRawType : (Ljava/lang/reflect/Type;)Ljava/lang/Class;
	//   23: astore #4
	//   25: aload #4
	//   27: aload_1
	//   28: if_acmpeq -> 38
	//   31: aload_0
	//   32: aload #4
	//   34: invokevirtual a : (Ljava/lang/reflect/Type;)Ljava/lang/Object;
	//   37: astore_2
	//   38: aload_2
	//   39: astore_3
	//   40: aload_2
	//   41: ifnonnull -> 93
	//   44: aload_0
	//   45: getfield c : Ljava/util/List;
	//   48: invokeinterface iterator : ()Ljava/util/Iterator;
	//   53: astore_3
	//   54: aload_3
	//   55: invokeinterface hasNext : ()Z
	//   60: ifeq -> 97
	//   63: aload_3
	//   64: invokeinterface next : ()Ljava/lang/Object;
	//   69: checkcast eq
	//   72: astore_1
	//   73: aload_1
	//   74: getfield a : Ljava/lang/Object;
	//   77: checkcast java/lang/Class
	//   80: aload #4
	//   82: invokevirtual isAssignableFrom : (Ljava/lang/Class;)Z
	//   85: ifeq -> 54
	//   88: aload_1
	//   89: getfield b : Ljava/lang/Object;
	//   92: astore_3
	//   93: aload_0
	//   94: monitorexit
	//   95: aload_3
	//   96: areturn
	//   97: aconst_null
	//   98: astore_3
	//   99: goto -> 93
	//   102: astore_1
	//   103: aload_0
	//   104: monitorexit
	//   105: aload_1
	//   106: athrow
	// Exception table:
	//   from	to	target	type
	//   2	13	102	finally
	//   19	25	102	finally
	//   31	38	102	finally
	//   44	54	102	finally
	//   54	93	102	finally
  }

  public void a()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: iconst_0
	//   4: putfield d : Z
	//   7: aload_0
	//   8: monitorexit
	//   9: return
	//   10: astore_1
	//   11: aload_0
	//   12: monitorexit
	//   13: aload_1
	//   14: athrow
	// Exception table:
	//   from	to	target	type
	//   2	7	10	finally
  }

  public void a(eq<Type, T> parameq)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Z
	//   6: ifne -> 26
	//   9: new java/lang/IllegalStateException
	//   12: astore_1
	//   13: aload_1
	//   14: ldc 'Attempted to modify an unmodifiable map.'
	//   16: invokespecial <init> : (Ljava/lang/String;)V
	//   19: aload_1
	//   20: athrow
	//   21: astore_1
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_1
	//   25: athrow
	//   26: aload_0
	//   27: aload_1
	//   28: getfield a : Ljava/lang/Object;
	//   31: checkcast java/lang/Class
	//   34: invokespecial b : (Ljava/lang/Class;)I
	//   37: istore_2
	//   38: iload_2
	//   39: iflt -> 68
	//   42: getstatic er.a : Ljava/util/logging/Logger;
	//   45: getstatic java/util/logging/Level.WARNING : Ljava/util/logging/Level;
	//   48: ldc 'Overriding the existing type handler for {0}'
	//   50: aload_1
	//   51: getfield a : Ljava/lang/Object;
	//   54: invokevirtual log : (Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V
	//   57: aload_0
	//   58: getfield c : Ljava/util/List;
	//   61: iload_2
	//   62: invokeinterface remove : (I)Ljava/lang/Object;
	//   67: pop
	//   68: aload_0
	//   69: aload_1
	//   70: getfield a : Ljava/lang/Object;
	//   73: checkcast java/lang/Class
	//   76: invokespecial a : (Ljava/lang/Class;)I
	//   79: istore_2
	//   80: iload_2
	//   81: iflt -> 150
	//   84: new java/lang/IllegalArgumentException
	//   87: astore_3
	//   88: new java/lang/StringBuilder
	//   91: astore #4
	//   93: aload #4
	//   95: invokespecial <init> : ()V
	//   98: aload_3
	//   99: aload #4
	//   101: ldc 'The specified type handler for type '
	//   103: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   106: aload_1
	//   107: getfield a : Ljava/lang/Object;
	//   110: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
	//   113: ldc ' hides the previously registered type hierarchy handler for '
	//   115: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   118: aload_0
	//   119: getfield c : Ljava/util/List;
	//   122: iload_2
	//   123: invokeinterface get : (I)Ljava/lang/Object;
	//   128: checkcast eq
	//   131: getfield a : Ljava/lang/Object;
	//   134: invokevirtual append : (Ljava/lang/Object;)Ljava/lang/StringBuilder;
	//   137: ldc '. Gson does not allow this.'
	//   139: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   142: invokevirtual toString : ()Ljava/lang/String;
	//   145: invokespecial <init> : (Ljava/lang/String;)V
	//   148: aload_3
	//   149: athrow
	//   150: aload_0
	//   151: getfield c : Ljava/util/List;
	//   154: iconst_0
	//   155: aload_1
	//   156: invokeinterface add : (ILjava/lang/Object;)V
	//   161: aload_0
	//   162: monitorexit
	//   163: return
	// Exception table:
	//   from	to	target	type
	//   2	21	21	finally
	//   26	38	21	finally
	//   42	68	21	finally
	//   68	80	21	finally
	//   84	150	21	finally
	//   150	161	21	finally
  }

  public void a(er<T> paramer)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Z
	//   6: ifne -> 26
	//   9: new java/lang/IllegalStateException
	//   12: astore_1
	//   13: aload_1
	//   14: ldc 'Attempted to modify an unmodifiable map.'
	//   16: invokespecial <init> : (Ljava/lang/String;)V
	//   19: aload_1
	//   20: athrow
	//   21: astore_1
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_1
	//   25: athrow
	//   26: aload_1
	//   27: getfield b : Ljava/util/Map;
	//   30: invokeinterface entrySet : ()Ljava/util/Set;
	//   35: invokeinterface iterator : ()Ljava/util/Iterator;
	//   40: astore_2
	//   41: aload_2
	//   42: invokeinterface hasNext : ()Z
	//   47: ifeq -> 100
	//   50: aload_2
	//   51: invokeinterface next : ()Ljava/lang/Object;
	//   56: checkcast java/util/Map$Entry
	//   59: astore_3
	//   60: aload_0
	//   61: getfield b : Ljava/util/Map;
	//   64: aload_3
	//   65: invokeinterface getKey : ()Ljava/lang/Object;
	//   70: invokeinterface containsKey : (Ljava/lang/Object;)Z
	//   75: ifne -> 41
	//   78: aload_0
	//   79: aload_3
	//   80: invokeinterface getKey : ()Ljava/lang/Object;
	//   85: checkcast java/lang/reflect/Type
	//   88: aload_3
	//   89: invokeinterface getValue : ()Ljava/lang/Object;
	//   94: invokevirtual a : (Ljava/lang/reflect/Type;Ljava/lang/Object;)V
	//   97: goto -> 41
	//   100: aload_1
	//   101: getfield c : Ljava/util/List;
	//   104: invokeinterface size : ()I
	//   109: iconst_1
	//   110: isub
	//   111: istore #4
	//   113: iload #4
	//   115: iflt -> 158
	//   118: aload_1
	//   119: getfield c : Ljava/util/List;
	//   122: iload #4
	//   124: invokeinterface get : (I)Ljava/lang/Object;
	//   129: checkcast eq
	//   132: astore_2
	//   133: aload_0
	//   134: aload_2
	//   135: getfield a : Ljava/lang/Object;
	//   138: checkcast java/lang/Class
	//   141: invokespecial b : (Ljava/lang/Class;)I
	//   144: ifge -> 152
	//   147: aload_0
	//   148: aload_2
	//   149: invokevirtual a : (Leq;)V
	//   152: iinc #4, -1
	//   155: goto -> 113
	//   158: aload_0
	//   159: monitorexit
	//   160: return
	// Exception table:
	//   from	to	target	type
	//   2	21	21	finally
	//   26	41	21	finally
	//   41	97	21	finally
	//   100	113	21	finally
	//   118	152	21	finally
  }

  public void a(Type paramClass, T paramT)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: new eq
	//   5: astore_3
	//   6: aload_3
	//   7: aload_1
	//   8: aload_2
	//   9: invokespecial <init> : (Ljava/lang/Object;Ljava/lang/Object;)V
	//   12: aload_0
	//   13: aload_3
	//   14: invokevirtual a : (Leq;)V
	//   17: aload_0
	//   18: monitorexit
	//   19: return
	//   20: astore_1
	//   21: aload_0
	//   22: monitorexit
	//   23: aload_1
	//   24: athrow
	// Exception table:
	//   from	to	target	type
	//   2	17	20	finally
  }

  public void a(Type paramType, T paramT)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Z
	//   6: ifne -> 26
	//   9: new java/lang/IllegalStateException
	//   12: astore_1
	//   13: aload_1
	//   14: ldc 'Attempted to modify an unmodifiable map.'
	//   16: invokespecial <init> : (Ljava/lang/String;)V
	//   19: aload_1
	//   20: athrow
	//   21: astore_1
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_1
	//   25: athrow
	//   26: aload_0
	//   27: aload_1
	//   28: invokevirtual b : (Ljava/lang/reflect/Type;)Z
	//   31: ifeq -> 46
	//   34: getstatic er.a : Ljava/util/logging/Logger;
	//   37: getstatic java/util/logging/Level.WARNING : Ljava/util/logging/Level;
	//   40: ldc 'Overriding the existing type handler for {0}'
	//   42: aload_1
	//   43: invokevirtual log : (Ljava/util/logging/Level;Ljava/lang/String;Ljava/lang/Object;)V
	//   46: aload_0
	//   47: getfield b : Ljava/util/Map;
	//   50: aload_1
	//   51: aload_2
	//   52: invokeinterface put : (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
	//   57: pop
	//   58: aload_0
	//   59: monitorexit
	//   60: return
	// Exception table:
	//   from	to	target	type
	//   2	21	21	finally
	//   26	46	21	finally
	//   46	58	21	finally
  }

  public er<T> b()
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: new er
	//   5: astore_1
	//   6: aload_1
	//   7: invokespecial <init> : ()V
	//   10: aload_1
	//   11: getfield b : Ljava/util/Map;
	//   14: aload_0
	//   15: getfield b : Ljava/util/Map;
	//   18: invokeinterface putAll : (Ljava/util/Map;)V
	//   23: aload_1
	//   24: getfield c : Ljava/util/List;
	//   27: aload_0
	//   28: getfield c : Ljava/util/List;
	//   31: invokeinterface addAll : (Ljava/util/Collection;)Z
	//   36: pop
	//   37: aload_0
	//   38: monitorexit
	//   39: aload_1
	//   40: areturn
	//   41: astore_1
	//   42: aload_0
	//   43: monitorexit
	//   44: aload_1
	//   45: athrow
	// Exception table:
	//   from	to	target	type
	//   2	37	41	finally
  }

  public void b(er<T> paramer)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Z
	//   6: ifne -> 26
	//   9: new java/lang/IllegalStateException
	//   12: astore_1
	//   13: aload_1
	//   14: ldc 'Attempted to modify an unmodifiable map.'
	//   16: invokespecial <init> : (Ljava/lang/String;)V
	//   19: aload_1
	//   20: athrow
	//   21: astore_1
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_1
	//   25: athrow
	//   26: aload_1
	//   27: getfield b : Ljava/util/Map;
	//   30: invokeinterface entrySet : ()Ljava/util/Set;
	//   35: invokeinterface iterator : ()Ljava/util/Iterator;
	//   40: astore_2
	//   41: aload_2
	//   42: invokeinterface hasNext : ()Z
	//   47: ifeq -> 82
	//   50: aload_2
	//   51: invokeinterface next : ()Ljava/lang/Object;
	//   56: checkcast java/util/Map$Entry
	//   59: astore_3
	//   60: aload_0
	//   61: aload_3
	//   62: invokeinterface getKey : ()Ljava/lang/Object;
	//   67: checkcast java/lang/reflect/Type
	//   70: aload_3
	//   71: invokeinterface getValue : ()Ljava/lang/Object;
	//   76: invokevirtual a : (Ljava/lang/reflect/Type;Ljava/lang/Object;)V
	//   79: goto -> 41
	//   82: aload_1
	//   83: getfield c : Ljava/util/List;
	//   86: invokeinterface size : ()I
	//   91: iconst_1
	//   92: isub
	//   93: istore #4
	//   95: iload #4
	//   97: iflt -> 124
	//   100: aload_0
	//   101: aload_1
	//   102: getfield c : Ljava/util/List;
	//   105: iload #4
	//   107: invokeinterface get : (I)Ljava/lang/Object;
	//   112: checkcast eq
	//   115: invokevirtual a : (Leq;)V
	//   118: iinc #4, -1
	//   121: goto -> 95
	//   124: aload_0
	//   125: monitorexit
	//   126: return
	// Exception table:
	//   from	to	target	type
	//   2	21	21	finally
	//   26	41	21	finally
	//   41	79	21	finally
	//   82	95	21	finally
	//   100	118	21	finally
  }

  public void b(Type paramType, T paramT)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield d : Z
	//   6: ifne -> 26
	//   9: new java/lang/IllegalStateException
	//   12: astore_1
	//   13: aload_1
	//   14: ldc 'Attempted to modify an unmodifiable map.'
	//   16: invokespecial <init> : (Ljava/lang/String;)V
	//   19: aload_1
	//   20: athrow
	//   21: astore_1
	//   22: aload_0
	//   23: monitorexit
	//   24: aload_1
	//   25: athrow
	//   26: aload_0
	//   27: getfield b : Ljava/util/Map;
	//   30: aload_1
	//   31: invokeinterface containsKey : (Ljava/lang/Object;)Z
	//   36: ifne -> 45
	//   39: aload_0
	//   40: aload_1
	//   41: aload_2
	//   42: invokevirtual a : (Ljava/lang/reflect/Type;Ljava/lang/Object;)V
	//   45: aload_0
	//   46: monitorexit
	//   47: return
	// Exception table:
	//   from	to	target	type
	//   2	21	21	finally
	//   26	45	21	finally
  }

  public bool b(Type paramType)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: getfield b : Ljava/util/Map;
	//   6: aload_1
	//   7: invokeinterface containsKey : (Ljava/lang/Object;)Z
	//   12: istore_2
	//   13: aload_0
	//   14: monitorexit
	//   15: iload_2
	//   16: ireturn
	//   17: astore_1
	//   18: aload_0
	//   19: monitorexit
	//   20: aload_1
	//   21: athrow
	// Exception table:
	//   from	to	target	type
	//   2	13	17	finally
  }

  public override string ToString()
  {
	bool bool1 = true;
	StringBuilder stringBuilder = new StringBuilder("{mapForTypeHierarchy:{");
	IEnumerator<eq<Type, T>> iterator = this.c.GetEnumerator();
	bool bool2 = true;
	while (iterator.MoveNext())
	{
	  eq eq = iterator.Current;
	  if (bool2)
	  {
		bool2 = false;
	  }
	  else
	  {
		stringBuilder.Append(',');
	  }
	  stringBuilder.Append(.Gson.Types.getRawType((Type)eq.a).getSimpleName()).Append(':');
	  stringBuilder.Append(eq.b);
	}
	stringBuilder.Append("},map:{");
	iterator = this.b_Conflict.SetOfKeyValuePairs().GetEnumerator();
	bool2 = bool1;
	while (iterator.MoveNext())
	{
	  DictionaryEntry entry = (DictionaryEntry)iterator.Current;
	  if (bool2)
	  {
		bool2 = false;
	  }
	  else
	  {
		stringBuilder.Append(',');
	  }
	  stringBuilder.Append(.Gson.Types.getRawType((Type)entry.Key).getSimpleName()).Append(':');
	  stringBuilder.Append(entry.Value);
	}
	stringBuilder.Append("}");
	return stringBuilder.ToString();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\er.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */