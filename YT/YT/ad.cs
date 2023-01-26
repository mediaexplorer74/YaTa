public sealed class ad
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal am[][] a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal int b_Conflict;

  public ad(int paramInt)
  {
	int i;
	for (i = 1; i < paramInt; i <<= 1)
	{
		;
	}
	this.a_Conflict = new am[i][];
	this.b_Conflict = i - 1;
  }

  internal void a()
  {
	for (int i = this.a_Conflict.Length - 1; i >= 0; i--)
	{
	  am[] arrayOfAm = this.a_Conflict[i];
	  if (arrayOfAm != null)
	  {
		for (int j = arrayOfAm.Length - 1; j >= 0; j--)
		{
		  arrayOfAm[j] = null;
		}
	  }
	}
  }

  internal void a(long paramLong)
  {
	am[] arrayOfAm = this.a_Conflict[((int)paramLong ^ (int)((long)((ulong)paramLong >> 32L))) & this.b_Conflict];
	if (arrayOfAm != null)
	{
	  for (int i = arrayOfAm.Length - 1;; i--)
	  {
		if (i >= 0)
		{
		  am am1 = arrayOfAm[i];
		  if (am1 != null && am1.e() == paramLong)
		  {
			arrayOfAm[i] = null;
			return;
		  }
		}
		else
		{
		  return;
		}
	  }
	}
  }

  internal void a(long paramLong, am paramam)
  {
	// Byte code:
	//   0: lload_1
	//   1: l2i
	//   2: istore #4
	//   4: lload_1
	//   5: bipush #32
	//   7: lushr
	//   8: l2i
	//   9: istore #5
	//   11: aload_0
	//   12: getfield b : I
	//   15: iload #4
	//   17: iload #5
	//   19: ixor
	//   20: iand
	//   21: istore #5
	//   23: aload_0
	//   24: getfield a : [[Lam;
	//   27: iload #5
	//   29: aaload
	//   30: ifnonnull -> 44
	//   33: aload_0
	//   34: getfield a : [[Lam;
	//   37: iload #5
	//   39: iconst_2
	//   40: anewarray am
	//   43: aastore
	//   44: aload_0
	//   45: getfield a : [[Lam;
	//   48: iload #5
	//   50: aaload
	//   51: astore #6
	//   53: aload #6
	//   55: arraylength
	//   56: iconst_1
	//   57: isub
	//   58: istore #4
	//   60: iload #4
	//   62: iflt -> 86
	//   65: aload #6
	//   67: iload #4
	//   69: aaload
	//   70: ifnonnull -> 80
	//   73: aload #6
	//   75: iload #4
	//   77: aload_3
	//   78: aastore
	//   79: return
	//   80: iinc #4, -1
	//   83: goto -> 60
	//   86: aload #6
	//   88: arraylength
	//   89: istore #4
	//   91: iload #4
	//   93: iconst_1
	//   94: ishl
	//   95: anewarray am
	//   98: astore #7
	//   100: aload #6
	//   102: iconst_0
	//   103: aload #7
	//   105: iconst_0
	//   106: iload #4
	//   108: invokestatic arraycopy : (Ljava/lang/Object;ILjava/lang/Object;II)V
	//   111: aload_0
	//   112: getfield a : [[Lam;
	//   115: iload #5
	//   117: aload #7
	//   119: aastore
	//   120: aload #7
	//   122: iload #4
	//   124: aload_3
	//   125: aastore
	//   126: goto -> 79
  }

  internal bool b(long paramLong)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield a : [[Lam;
	//   4: lload_1
	//   5: l2i
	//   6: lload_1
	//   7: bipush #32
	//   9: lushr
	//   10: l2i
	//   11: ixor
	//   12: aload_0
	//   13: getfield b : I
	//   16: iand
	//   17: aaload
	//   18: astore_3
	//   19: aload_3
	//   20: ifnull -> 67
	//   23: aload_3
	//   24: arraylength
	//   25: iconst_1
	//   26: isub
	//   27: istore #4
	//   29: iload #4
	//   31: iflt -> 67
	//   34: aload_3
	//   35: iload #4
	//   37: aaload
	//   38: astore #5
	//   40: aload #5
	//   42: ifnull -> 61
	//   45: aload #5
	//   47: invokevirtual e : ()J
	//   50: lload_1
	//   51: lcmp
	//   52: ifne -> 61
	//   55: iconst_1
	//   56: istore #6
	//   58: iload #6
	//   60: ireturn
	//   61: iinc #4, -1
	//   64: goto -> 29
	//   67: iconst_0
	//   68: istore #6
	//   70: goto -> 58
  }

  internal am c(long paramLong)
  {
	// Byte code:
	//   0: aload_0
	//   1: getfield a : [[Lam;
	//   4: lload_1
	//   5: l2i
	//   6: lload_1
	//   7: bipush #32
	//   9: lushr
	//   10: l2i
	//   11: ixor
	//   12: aload_0
	//   13: getfield b : I
	//   16: iand
	//   17: aaload
	//   18: astore_3
	//   19: aload_3
	//   20: ifnull -> 64
	//   23: aload_3
	//   24: arraylength
	//   25: iconst_1
	//   26: isub
	//   27: istore #4
	//   29: iload #4
	//   31: iflt -> 64
	//   34: aload_3
	//   35: iload #4
	//   37: aaload
	//   38: astore #5
	//   40: aload #5
	//   42: ifnull -> 58
	//   45: aload #5
	//   47: invokevirtual e : ()J
	//   50: lload_1
	//   51: lcmp
	//   52: ifne -> 58
	//   55: aload #5
	//   57: areturn
	//   58: iinc #4, -1
	//   61: goto -> 29
	//   64: aconst_null
	//   65: astore #5
	//   67: goto -> 55
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ad.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */