using System.Collections.Generic;

public sealed class eh<K, V> : LinkedHashMap<K, V>, be<K, V>
{
  private const long serialVersionUID = 1L;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly int a_Conflict;

  public eh(int paramInt) : base(paramInt, 0.7F, true)
  {
	this.a_Conflict = paramInt;
  }

  public V a(K paramK)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: aload_1
	//   4: invokevirtual get : (Ljava/lang/Object;)Ljava/lang/Object;
	//   7: astore_1
	//   8: aload_0
	//   9: monitorexit
	//   10: aload_1
	//   11: areturn
	//   12: astore_1
	//   13: aload_0
	//   14: monitorexit
	//   15: aload_1
	//   16: athrow
	// Exception table:
	//   from	to	target	type
	//   2	8	12	finally
  }

  public void a(K paramK, V paramV)
  {
	// Byte code:
	//   0: aload_0
	//   1: monitorenter
	//   2: aload_0
	//   3: aload_1
	//   4: aload_2
	//   5: invokevirtual put : (Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;
	//   8: pop
	//   9: aload_0
	//   10: monitorexit
	//   11: return
	//   12: astore_1
	//   13: aload_0
	//   14: monitorexit
	//   15: aload_1
	//   16: athrow
	// Exception table:
	//   from	to	target	type
	//   2	9	12	finally
  }

  protected internal bool removeEldestEntry(KeyValuePair<K, V> paramEntry)
  {
	return (size() > this.a_Conflict);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\eh.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */