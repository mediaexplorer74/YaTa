using System.Collections.Generic;

using  = com.google.gson.@internal.;

internal sealed class el
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly Stack<ep> a_Conflict = new Stack<ep>();

  public ep a()
  {
	return this.a_Conflict.Pop();
  }

  public ep a(ep paramep)
  {
	.Gson.Preconditions.checkNotNull(paramep);
	return this.a_Conflict.Push(paramep);
  }

  public bool b(ep paramep)
  {
	// Byte code:
	//   0: aload_1
	//   1: ifnonnull -> 8
	//   4: iconst_0
	//   5: istore_2
	//   6: iload_2
	//   7: ireturn
	//   8: aload_0
	//   9: getfield a : Ljava/util/Stack;
	//   12: invokevirtual iterator : ()Ljava/util/Iterator;
	//   15: astore_3
	//   16: aload_3
	//   17: invokeinterface hasNext : ()Z
	//   22: ifeq -> 68
	//   25: aload_3
	//   26: invokeinterface next : ()Ljava/lang/Object;
	//   31: checkcast ep
	//   34: astore #4
	//   36: aload #4
	//   38: invokevirtual a : ()Ljava/lang/Object;
	//   41: aload_1
	//   42: invokevirtual a : ()Ljava/lang/Object;
	//   45: if_acmpne -> 16
	//   48: aload #4
	//   50: getfield a : Ljava/lang/reflect/Type;
	//   53: aload_1
	//   54: getfield a : Ljava/lang/reflect/Type;
	//   57: invokevirtual equals : (Ljava/lang/Object;)Z
	//   60: ifeq -> 16
	//   63: iconst_1
	//   64: istore_2
	//   65: goto -> 6
	//   68: iconst_0
	//   69: istore_2
	//   70: goto -> 6
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\el.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */