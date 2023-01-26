using System;

public sealed class cc
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public string[] a_Conflict = new string[20];

  public string[] b = new string[20];

  private int c = 0;

  public string a(string paramString)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield c : I
	//   4: istore_2
	//   5: aload_0
	//   6: getfield a : [Ljava/lang/String;
	//   9: astore_3
	//   10: iconst_0
	//   11: istore #4
	//   13: iload #4
	//   15: iload_2
	//   16: if_icmpge -> 46
	//   19: aload_3
	//   20: iload #4
	//   22: aaload
	//   23: aload_1
	//   24: invokevirtual equals : (Ljava/lang/Object;)Z
	//   27: ifeq -> 40
	//   30: aload_0
	//   31: getfield b : [Ljava/lang/String;
	//   34: iload #4
	//   36: aaload
	//   37: astore_1
	//   38: aload_1
	//   39: areturn
	//   40: iinc #4, 1
	//   43: goto -> 13
	//   46: aconst_null
	//   47: astore_1
	//   48: goto -> 38
  }

  public void a()
  {
	this.c = 0;
  }

  internal void a(string paramString1, string paramString2)
  {
	this.a_Conflict[this.c] = paramString1;
	this.b[this.c] = paramString2;
	this.c++;
	if (this.c >= this.a_Conflict.Length)
	{
	  string[] arrayOfString = new string[this.c << 1];
	  Array.Copy(this.a_Conflict, 0, arrayOfString, 0, this.c);
	  this.a_Conflict = arrayOfString;
	  arrayOfString = new string[this.c << 1];
	  Array.Copy(this.b, 0, arrayOfString, 0, this.c);
	  this.b = arrayOfString;
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\cc.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */