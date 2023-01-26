using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

using Context = android.content.Context;
using Build = android.os.Build;
using Environment = android.os.Environment;
using DisplayMetrics = android.util.DisplayMetrics;
using Log = android.util.Log;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class b
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  protected internal static readonly bool[] a_Conflict = new bool[256];

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public static int b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static int[] c_Conflict;

  private static readonly float[] d = new float[] {1.0F, 10.0F, 100.0F, 1000.0F, 10000.0F};

  private static readonly float[] e = new float[] {0.1F, 0.01F, 0.001F, 1.0E-4F, 1.0E-5F, 1.0E-6F, 1.0E-7F, 1.0E-8F};

  private static int f = 0;

  private static string g = null;

  static b()
  {
	b_Conflict = 3;
	try
	{
	  if (Build.VERSION.SDK.Equals("3"))
	  {
		b_Conflict = 3;
		return;
	  }
	  System.Reflection.FieldInfo field = typeof(Build.VERSION).GetField("SDK_INT");
	  if (field != null)
	  {
		b_Conflict = field.getInt(null);
	  }
	}
	catch (Exception)
	{
	}
	sbyte b1;
	for (b1 = 97; b1 <= 122; b1++)
	{
	  a_Conflict[b1] = true;
	}
	for (b1 = 65; b1 <= 90; b1++)
	{
	  a_Conflict[b1] = true;
	}
	for (b1 = 48; b1 <= 57; b1++)
	{
	  a_Conflict[b1] = true;
	}
	a_Conflict[45] = true;
	a_Conflict[95] = true;
	a_Conflict[46] = true;
	a_Conflict[42] = true;
	a_Conflict[32] = true;
  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public static extern void InvertBitmapNative(int[] paramArrayOfint, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
  [DllImport("unknown")]
  public static extern void InvertBitmapNative(short[] paramArrayOfshort, int paramInt);

  private static char a(int paramInt1, int paramInt2)
  {
	sbyte b1 = 0;
	int i = b1;
	if (paramInt1 < paramInt2)
	{
	  if (paramInt1 < 0)
	  {
		return (char)b1;
	  }
	}
	else
	{
	  return (char)i;
	}
	i = b1;
	if (paramInt2 >= 2)
	{
	  i = b1;
	  if (paramInt2 <= 36)
	  {
		if (paramInt1 < 10)
		{
		  paramInt1 = (char)(paramInt1 + 48);
		  return (char)paramInt1;
		}
		paramInt1 = (char)(paramInt1 + 87);
		i = paramInt1;
	  }
	}
	return (char)i;
  }

  public static float a(float paramFloat1, float paramFloat2)
  {
	if (paramFloat1 <= paramFloat2)
	{
	  paramFloat2 = paramFloat1;
	}
	return paramFloat2;
  }

  public static float a(char[] paramArrayOfchar, int paramInt1, int paramInt2)
  {
	// Byte code:
	//   0: iload_1
	//   1: istore_3
	//   2: iload_3
	//   3: iload_2
	//   4: if_icmpge -> 185
	//   7: aload_0
	//   8: iload_3
	//   9: caload
	//   10: bipush #46
	//   12: if_icmpne -> 105
	//   15: iload_3
	//   16: istore #4
	//   18: aload_0
	//   19: iload_1
	//   20: caload
	//   21: istore #5
	//   23: iload #5
	//   25: bipush #45
	//   27: if_icmpne -> 111
	//   30: iconst_1
	//   31: istore_3
	//   32: iload_3
	//   33: ifne -> 46
	//   36: iload_1
	//   37: istore #6
	//   39: iload #5
	//   41: bipush #43
	//   43: if_icmpne -> 51
	//   46: iload_1
	//   47: iconst_1
	//   48: iadd
	//   49: istore #6
	//   51: iconst_0
	//   52: istore_1
	//   53: fconst_0
	//   54: fstore #7
	//   56: iload #4
	//   58: iconst_1
	//   59: isub
	//   60: istore #5
	//   62: iload #5
	//   64: iload #6
	//   66: if_icmplt -> 116
	//   69: aload_0
	//   70: iload #5
	//   72: caload
	//   73: bipush #48
	//   75: isub
	//   76: i2f
	//   77: fstore #8
	//   79: getstatic b.d : [F
	//   82: iload_1
	//   83: faload
	//   84: fstore #9
	//   86: iinc #1, 1
	//   89: iinc #5, -1
	//   92: fload #8
	//   94: fload #9
	//   96: fmul
	//   97: fload #7
	//   99: fadd
	//   100: fstore #7
	//   102: goto -> 62
	//   105: iinc #3, 1
	//   108: goto -> 2
	//   111: iconst_0
	//   112: istore_3
	//   113: goto -> 32
	//   116: iconst_0
	//   117: istore #6
	//   119: iload #4
	//   121: iconst_1
	//   122: iadd
	//   123: istore_1
	//   124: iload #6
	//   126: istore #4
	//   128: iload_1
	//   129: iload_2
	//   130: if_icmpge -> 169
	//   133: aload_0
	//   134: iload_1
	//   135: caload
	//   136: bipush #48
	//   138: isub
	//   139: i2f
	//   140: fstore #9
	//   142: getstatic b.e : [F
	//   145: iload #4
	//   147: faload
	//   148: fstore #8
	//   150: iinc #4, 1
	//   153: iinc #1, 1
	//   156: fload #9
	//   158: fload #8
	//   160: fmul
	//   161: fload #7
	//   163: fadd
	//   164: fstore #7
	//   166: goto -> 128
	//   169: fload #7
	//   171: fstore #8
	//   173: iload_3
	//   174: ifeq -> 182
	//   177: fload #7
	//   179: fneg
	//   180: fstore #8
	//   182: fload #8
	//   184: freturn
	//   185: iload_2
	//   186: istore #4
	//   188: goto -> 18
  }

  public static int a(float paramFloat)
  {
	int i = (int)paramFloat;
	if (paramFloat > 0.0F)
	{
	  int k = i;
	  if ((paramFloat - i) >= 0.5D)
	  {
		k = i + 1;
	  }
	  return k;
	}
	int j = i;
	if (paramFloat < 0.0F)
	{
	  j = i;
	  if ((paramFloat - i) <= -0.5D)
	  {
		j = i - 1;
	  }
	}
	return j;
  }

  public static int a(int paramInt)
  {
	if (paramInt < 0)
	{
	  paramInt = -paramInt;
	}
	return paramInt;
  }

  public static int a(Context paramContext)
  {
	if (f == 0)
	{
	  DisplayMetrics displayMetrics = paramContext.getResources().getDisplayMetrics();
	  if (displayMetrics != null)
	  {
		try
		{
		  f = typeof(DisplayMetrics).GetField("densityDpi").getInt(displayMetrics);
		}
		catch (Exception)
		{
		  f = (long)Math.Round(displayMetrics.density * 160.0F, MidpointRounding.AwayFromZero);
		}
	  }
	}
	return f;
  }

  public static int a(sbyte[] paramArrayOfbyte, int paramInt)
  {
	sbyte b1 = 0;
	int i = 0;
	while (b1 < 4 && paramInt + b1 < paramArrayOfbyte.Length)
	{
	  i |= (paramArrayOfbyte[paramInt + b1] & 0xFF) << b1 << 3;
	  b1++;
	}
	return i;
  }

  public static string a()
  {
	if (!string.ReferenceEquals(g, null))
	{
	  return g;
	}
	try
	{
	  System.Reflection.FieldInfo field = typeof(Build).GetField("MANUFACTURER");
	  Build build = new Build();
	  this();
	  g = (string)field.get(build);
	}
	catch (Exception)
	{
	  g = "Unknown";
	}
	return g;
  }

  public static string a(double paramDouble)
  {
	StringBuilder stringBuilder = new StringBuilder(10);
	int i = a((int)paramDouble);
	if (paramDouble < 0.0D)
	{
	  stringBuilder.Append('-');
	}
	stringBuilder.Append(i);
	stringBuilder.Append('.');
	paramDouble = Math.Abs(paramDouble) - i;
	for (i = 0; i < 6; i++)
	{
	  paramDouble *= 10.0D;
	  int j = a((int)(paramDouble + 1.0E-9D));
	  stringBuilder.Append(j);
	  paramDouble = paramDouble - j + 1.0E-9D;
	}
	return stringBuilder.ToString();
  }

  public static string a(string paramString)
  {
	return (string.ReferenceEquals(paramString, null)) ? "" : StringHelper.NewString(c(b(paramString)));
  }

  public static GeoPoint a(string paramString, bool paramBoolean)
  {
	if (!string.ReferenceEquals(paramString, null))
	{
	  int i = paramString.IndexOf(',');
	  if (i > 0)
	  {
		float f1;
		float f2;
		char[] arrayOfChar = paramString.ToCharArray();
		if (paramBoolean)
		{
		  f1 = float.Parse(new string(arrayOfChar, 0, i));
		  f2 = float.Parse(new string(arrayOfChar, i + 1, arrayOfChar.Length - i - 1));
		}
		else
		{
		  f1 = a(arrayOfChar, 0, i);
		  f2 = a(arrayOfChar, i + 1, arrayOfChar.Length);
		}
		return new GeoPoint(f1, f2);
	  }
	}
	return null;
  }

  public static void a(int paramInt1, sbyte[] paramArrayOfbyte, int paramInt2)
  {
	bool @bool = false;
	int i = paramInt1;
	for (paramInt1 = @bool; paramInt1 < 4 && paramInt2 + paramInt1 < paramArrayOfbyte.Length; paramInt1++)
	{
	  paramArrayOfbyte[paramInt2 + paramInt1] = (sbyte)(sbyte)i;
	  i >>= 8;
	}
  }

  public static bool a(int paramInt1, int paramInt2, int paramInt3)
  {
	return (paramInt1 >= 0 && paramInt2 >= 0 && paramInt3 >= 0 && paramInt3 < 23 && paramInt1 < 2 << paramInt3 && paramInt2 < 2 << paramInt3);
  }

  public static bool a(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
  {
	paramInt3 += paramInt1;
	paramInt4 += paramInt2;
	return (128 > paramInt1 && 128 > paramInt2 && (paramInt3 < paramInt1 || paramInt3 > 0) && (paramInt4 < paramInt2 || paramInt4 > 0));
  }

  public static bool a(int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5, int paramInt6)
  {
	return (paramInt1 < paramInt5 && paramInt1 + paramInt3 > paramInt5 && paramInt2 < paramInt6 && paramInt2 + paramInt4 > paramInt6);
  }

  public static bool a(int paramInt1, int paramInt2, int paramInt3, int paramInt4, int paramInt5, int paramInt6, int paramInt7, int paramInt8)
  {
	return (paramInt1 < paramInt5 + paramInt7 && paramInt1 + paramInt3 > paramInt5 && paramInt2 < paramInt6 + paramInt8 && paramInt2 + paramInt4 > paramInt6);
  }

  public static bool a(long paramLong1, long paramLong2, long paramLong3, long paramLong4, long paramLong5, long paramLong6, long paramLong7, long paramLong8)
  {
	return (paramLong5 < paramLong1 && paramLong1 + paramLong3 < paramLong5 + paramLong7 && paramLong2 > paramLong6 && paramLong2 + paramLong4 < paramLong6 + paramLong8);
  }

  public static bool a(Stream paramInputStream, sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
  {
	bool bool1 = false;
	bool bool2 = bool1;
	if (paramInputStream != null)
	{
	  if (paramInt2 > 0)
	  {
		int i = paramInputStream.Read(paramArrayOfbyte, paramInt1, paramInt2);
		while (i < paramInt2)
		{
		  int j = paramInputStream.Read(paramArrayOfbyte, paramInt1 + i, paramInt2 - i);
		  bool2 = bool1;
		  if (j != -1)
		  {
			i += j;
			continue;
		  }
		  // Byte code: goto -> 68
		}
	  }
	  bool2 = true;
	}
	return bool2;
  }

  public static bool a(sbyte[] paramArrayOfbyte)
  {
	bool @bool = true;
	if (paramArrayOfbyte == null || paramArrayOfbyte.Length <= 2 || (paramArrayOfbyte[0] & 0xFF) != 31 || (paramArrayOfbyte[1] & 0xFF) != 139)
	{
	  @bool = false;
	}
	return @bool;
  }

  public static sbyte[] a(Stream paramInputStream)
  {
	if (paramInputStream != null)
	{
	  sbyte[] arrayOfByte = new sbyte[1024];
	  MemoryStream byteArrayOutputStream = new MemoryStream();
	  try
	  {
		while (true)
		{
		  int i = paramInputStream.Read(arrayOfByte, 0, arrayOfByte.Length);
		  if (i == -1)
		  {
			byteArrayOutputStream.Close();
			return byteArrayOutputStream.toByteArray();
		  }
		  if (i > 0)
		  {
			byteArrayOutputStream.Write(arrayOfByte, 0, i);
		  }
		}
	  }
	  finally
	  {
		if (byteArrayOutputStream != null)
		{
		  byteArrayOutputStream.Close();
		}
	  }
	}
	return null;
  }

  public static string[] a(string paramString1, string paramString2, bool paramBoolean, Context paramContext)
  {
	ae ae;
	string str = "." + paramString2;
	bool @bool = Environment.getExternalStorageState().Equals("mounted");
	if (@bool)
	{
	  paramString2 = Environment.getExternalStorageDirectory().getAbsolutePath();
	}
	else
	{
	  paramString2 = Environment.getDataDirectory().getAbsolutePath();
	}
	StringBuilder stringBuffer = new StringBuilder(paramString2);
	if (!string.ReferenceEquals(paramString1, null) && paramString1.Length > 0 && !paramString1.StartsWith("/", StringComparison.Ordinal))
	{
	  stringBuffer.Append('/');
	}
	stringBuffer.Append(paramString1);
	File[] arrayOfFile = new File[0];
	if (@bool)
	{
	  try
	  {
		Log.d("bufstr=", stringBuffer.ToString());
		File file = new File();
		this(stringBuffer.ToString());
		ae = new ae();
		this(str);
		File[] arrayOfFile1 = file.listFiles(ae);
		arrayOfFile = arrayOfFile1;
		if (arrayOfFile == null)
		{
		  return null;
		}
	  }
	  catch (Exception)
	  {
		Log.e("***", "sdcard access error");
		if (arrayOfFile == null)
		{
		  return null;
		}
	  }
	}
	else
	{
	  if (paramBoolean && ae != null)
	  {
		string[] arrayOfString1 = ae.fileList();
		int j = arrayOfString1.Length;
		sbyte b2 = 0;
		while (true)
		{
		  string str1;
		  string[] arrayOfString2 = arrayOfString1;
		  if (b2 < j)
		  {
			str1 = arrayOfString1[b2];
			arrayOfString1[b2] = str1.Substring(0, str1.IndexOf(str, StringComparison.Ordinal));
			b2++;
			continue;
		  }
		  return (string[])str1;
		}
	  }
	  if (arrayOfFile == null)
	  {
		return null;
	  }
	}
	int i = arrayOfFile.Length;
	string[] arrayOfString = new string[i];
	sbyte b1 = 0;
	while (true)
	{
	  string str1;
	  string[] arrayOfString1 = arrayOfString;
	  if (b1 < i)
	  {
		str1 = arrayOfFile[b1].getName();
		arrayOfString[b1] = str1.Substring(0, str1.Length - str.Length);
		b1++;
		continue;
	  }
	  return (string[])str1;
	}
  }

  public static float b(float paramFloat1, float paramFloat2)
  {
	if (paramFloat1 <= paramFloat2)
	{
	  paramFloat1 = paramFloat2;
	}
	return paramFloat1;
  }

  public static int b(Stream paramInputStream, sbyte[] paramArrayOfbyte, int paramInt1, int paramInt2)
  {
	if (paramInputStream != null)
	{
	  int j;
	  int i = paramInt2;
	  if (paramInt2 > 0)
	  {
		i = paramInputStream.Read(paramArrayOfbyte, paramInt1, paramInt2);
		j = i;
		if (i == -1)
		{
		  return -1;
		}
	  }
	  else
	  {
		return i;
	  }
	  while (true)
	  {
		i = paramInt2;
		if (j < paramInt2)
		{
		  i = paramInputStream.Read(paramArrayOfbyte, paramInt1 + j, paramInt2 - j);
		  if (i != -1)
		  {
			j += i;
			continue;
		  }
		  if (j > 0)
		  {
			return j;
		  }
		  i = -1;
		}
		return i;
	  }
	}
	return -1;
  }

  public static int b(sbyte[] paramArrayOfbyte, int paramInt)
  {
	sbyte b1 = 0;
	int i = 0;
	while (b1 < 2 && paramInt + b1 < paramArrayOfbyte.Length)
	{
	  i |= (paramArrayOfbyte[paramInt + b1] & 0xFF) << b1 << 3;
	  b1++;
	}
	return i;
  }

  public static long b(sbyte[] paramArrayOfbyte)
  {
	if (c_Conflict == null)
	{
	  c_Conflict = new int[256];
	  for (sbyte b2 = 0; b2 <= (sbyte)'ÿ'; b2++)
	  {
		sbyte b3 = 8;
		int k = b2;
		while (b3 > 0)
		{
		  if ((k & 0x1) == 1)
		  {
			k = (int)((uint)k >> 1) ^ 0xEDB88320;
		  }
		  else
		  {
			k = (int)((uint)k >> 1);
		  }
		  b3--;
		}
		c_Conflict[b2] = k;
	  }
	}
	int j = paramArrayOfbyte.Length;
	sbyte b1 = 0;
	int i = -1;
	while (j != 0)
	{
	  i = (int)((uint)i >> 8) ^ c_Conflict[(i ^ paramArrayOfbyte[b1]) & 0xFF];
	  b1++;
	  j--;
	}
	return (i ^ 0xFFFFFFFF) & 0xFFFFFFFFL;
  }

//JAVA TO C# CONVERTER NOTE: Members cannot have the same name as their enclosing type:
  public static void b_Conflict(int paramInt1, sbyte[] paramArrayOfbyte, int paramInt2)
  {
	bool @bool = false;
	int i = paramInt1;
	for (paramInt1 = @bool; paramInt1 < 2 && paramInt2 + paramInt1 < paramArrayOfbyte.Length; paramInt1++)
	{
	  paramArrayOfbyte[paramInt2 + paramInt1] = (sbyte)(sbyte)i;
	  i >>= 8;
	}
  }

  public static sbyte[] b(string paramString)
  {
	if (string.ReferenceEquals(paramString, null))
	{
	  return null;
	}
	sbyte[] arrayOfByte = new sbyte[paramString.Length];
	for (sbyte b1 = 0; b1 < paramString.Length; b1++)
	{
	  char c = paramString[b1];
	  char c1 = c;
	  if (c == 'Ё')
	  {
		c1 = '¨';
	  }
	  c = c1;
	  if (c1 == 'ё')
	  {
		c = '¸';
	  }
	  c1 = c;
	  if (c > 'Љ')
	  {
		c1 = (char)(c - 848);
	  }
	  arrayOfByte[b1] = (sbyte)(sbyte)c1;
	}
	return arrayOfByte;
  }

  public static sbyte[] c(sbyte[] paramArrayOfbyte)
  {
	if (paramArrayOfbyte == null)
	{
	  return null;
	}
	bool[] arrayOfBoolean = a_Conflict;
	MemoryStream byteArrayOutputStream = new MemoryStream();
	for (sbyte b1 = 0; b1 < paramArrayOfbyte.Length; b1++)
	{
	  sbyte b2 = paramArrayOfbyte[b1];
	  int i = b2;
	  if (b2 < 0)
	  {
		i = b2 + 256;
	  }
	  if (arrayOfBoolean[i])
	  {
		int j = i;
		if (i == 32)
		{
		  j = 43;
		}
		byteArrayOutputStream.WriteByte(j);
	  }
	  else
	  {
		byteArrayOutputStream.WriteByte(37);
		char c = char.ToUpper(a(i >> 4 & 0xF, 16));
		i = char.ToUpper(a(i & 0xF, 16));
		byteArrayOutputStream.WriteByte(c);
		byteArrayOutputStream.WriteByte(i);
	  }
	}
	return byteArrayOutputStream.toByteArray();
  }

}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\b.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */