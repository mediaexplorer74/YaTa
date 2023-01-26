using System;
using System.Collections.Generic;
using System.Text;

public sealed class do
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static readonly char[] a_Conflict = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};

  private static readonly ISet<char> b;

  private static readonly ISet<char> c;

  private readonly bool d;

  static do()
  {
	HashSet<char> hashSet = new HashSet<object>();
	hashSet.Add(Convert.ToChar('"'));
	hashSet.Add(Convert.ToChar('\\'));
	b = Collections.unmodifiableSet(hashSet);
	hashSet = new HashSet<char>();
	hashSet.Add(Convert.ToChar('<'));
	hashSet.Add(Convert.ToChar('>'));
	hashSet.Add(Convert.ToChar('&'));
	hashSet.Add(Convert.ToChar('='));
	hashSet.Add(Convert.ToChar('\''));
	c = Collections.unmodifiableSet(hashSet);
  }

  public do(bool paramBoolean)
  {
	this.d = paramBoolean;
  }

  private static void a(int paramInt, Appendable paramAppendable)
  {
	while (Character.isSupplementaryCodePoint(paramInt))
	{
	  char[] arrayOfChar = Character.toChars(paramInt);
	  a(arrayOfChar[0], paramAppendable);
	  paramInt = arrayOfChar[1];
	}
	paramAppendable.append("\\u").append(a_Conflict[(int)((uint)paramInt >> 12) & 0xF]).append(a_Conflict[(int)((uint)paramInt >> 8) & 0xF]).append(a_Conflict[(int)((uint)paramInt >> 4) & 0xF]).append(a_Conflict[paramInt & 0xF]);
  }

  private void a(CharSequence paramCharSequence, StringBuilder paramStringBuilder)
  {
	// Byte code:
	//   0: aload_1
	//   1: invokeinterface length : ()I
	//   6: istore_3
	//   7: iconst_0
	//   8: istore #4
	//   10: iconst_0
	//   11: istore #5
	//   13: iload #4
	//   15: iload_3
	//   16: if_icmpge -> 354
	//   19: aload_1
	//   20: iload #4
	//   22: invokestatic codePointAt : (Ljava/lang/CharSequence;I)I
	//   25: istore #6
	//   27: iload #6
	//   29: invokestatic charCount : (I)I
	//   32: istore #7
	//   34: iload #6
	//   36: bipush #32
	//   38: if_icmplt -> 72
	//   41: iload #6
	//   43: sipush #8232
	//   46: if_icmpeq -> 72
	//   49: iload #6
	//   51: sipush #8233
	//   54: if_icmpeq -> 72
	//   57: iload #6
	//   59: bipush #127
	//   61: if_icmplt -> 256
	//   64: iload #6
	//   66: sipush #159
	//   69: if_icmpgt -> 256
	//   72: iconst_1
	//   73: istore #8
	//   75: iload #8
	//   77: ifne -> 144
	//   80: iload #6
	//   82: invokestatic isSupplementaryCodePoint : (I)Z
	//   85: ifne -> 268
	//   88: iload #6
	//   90: i2c
	//   91: istore #9
	//   93: getstatic do.b : Ljava/util/Set;
	//   96: iload #9
	//   98: invokestatic valueOf : (C)Ljava/lang/Character;
	//   101: invokeinterface contains : (Ljava/lang/Object;)Z
	//   106: ifne -> 132
	//   109: aload_0
	//   110: getfield d : Z
	//   113: ifeq -> 262
	//   116: getstatic do.c : Ljava/util/Set;
	//   119: iload #9
	//   121: invokestatic valueOf : (C)Ljava/lang/Character;
	//   124: invokeinterface contains : (Ljava/lang/Object;)Z
	//   129: ifeq -> 262
	//   132: iconst_1
	//   133: istore #8
	//   135: iload #5
	//   137: istore #10
	//   139: iload #8
	//   141: ifeq -> 242
	//   144: aload_2
	//   145: aload_1
	//   146: iload #5
	//   148: iload #4
	//   150: invokevirtual append : (Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;
	//   153: pop
	//   154: iload #4
	//   156: iload #7
	//   158: iadd
	//   159: istore #10
	//   161: iload #6
	//   163: lookupswitch default -> 236, 8 -> 274, 9 -> 284, 10 -> 294, 12 -> 304, 13 -> 314, 34 -> 344, 47 -> 334, 92 -> 324
	//   236: iload #6
	//   238: aload_2
	//   239: invokestatic a : (ILjava/lang/Appendable;)V
	//   242: iload #4
	//   244: iload #7
	//   246: iadd
	//   247: istore #4
	//   249: iload #10
	//   251: istore #5
	//   253: goto -> 13
	//   256: iconst_0
	//   257: istore #8
	//   259: goto -> 75
	//   262: iconst_0
	//   263: istore #8
	//   265: goto -> 135
	//   268: iconst_0
	//   269: istore #8
	//   271: goto -> 135
	//   274: aload_2
	//   275: ldc '\b'
	//   277: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   280: pop
	//   281: goto -> 242
	//   284: aload_2
	//   285: ldc '\t'
	//   287: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   290: pop
	//   291: goto -> 242
	//   294: aload_2
	//   295: ldc '\n'
	//   297: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   300: pop
	//   301: goto -> 242
	//   304: aload_2
	//   305: ldc '\f'
	//   307: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   310: pop
	//   311: goto -> 242
	//   314: aload_2
	//   315: ldc '\r'
	//   317: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   320: pop
	//   321: goto -> 242
	//   324: aload_2
	//   325: ldc '\\'
	//   327: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   330: pop
	//   331: goto -> 242
	//   334: aload_2
	//   335: ldc '\/'
	//   337: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   340: pop
	//   341: goto -> 242
	//   344: aload_2
	//   345: ldc '\"'
	//   347: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
	//   350: pop
	//   351: goto -> 242
	//   354: aload_2
	//   355: aload_1
	//   356: iload #5
	//   358: iload_3
	//   359: invokevirtual append : (Ljava/lang/CharSequence;II)Ljava/lang/StringBuilder;
	//   362: pop
	//   363: return
  }

  public string a(CharSequence paramCharSequence)
  {
	StringBuilder stringBuilder = new StringBuilder(paramCharSequence.length() + 20);
	try
	{
	  a(paramCharSequence, stringBuilder);
	  return stringBuilder.ToString();
	}
	catch (IOException iOException)
	{
	  throw new Exception(iOException);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\do.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */