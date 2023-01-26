using System;

using Bitmap = android.graphics.Bitmap;

public sealed class av
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal static readonly int[][][] a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static short b_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static bool c_Conflict = false;

  private static ShortBuffer e;

  private static short[] f;

  private readonly aw d;

  static av()
  {
	a_Conflict = new int[33][][];
	for (sbyte b = 0; b <= 32; b++)
	{
	  a_Conflict[b] = new int[2][];
	  a_Conflict[b][0] = new int[256];
	  a_Conflict[b][1] = new int[256];
	  for (sbyte b1 = 0; b1 < (sbyte)'Ā'; b1++)
	  {
		a_Conflict[b][1][b1] = ((b1 & 0xF8) * b << 19) + ((b1 & 0x7) * b << 3) + 33570824;
		a_Conflict[b][0][b1] = ((int)((uint)(b1 & 0xE0) * b >> 5)) + ((b1 & 0x1F) * b << 11);
	  }
	}
  }

  public av(aw paramaw)
  {
	this.d = paramaw;
  }

  public static int a(float paramFloat)
  {
	int i = (int)paramFloat;
	if (paramFloat < 0.0F && paramFloat != (int)paramFloat)
	{
	  sbyte b1 = 1;
	  return i - b1;
	}
	sbyte b = 0;
	return i - b;
  }

  private static void a(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4, float paramFloat5)
  {
	if (paramFloat5 < 2.01F)
	{
	  float f1 = b.a(paramFloat1, paramFloat3);
	  float f2 = b.b(paramFloat1, paramFloat3);
	  float f3 = b.a(paramFloat2, paramFloat4);
	  float f4 = b.b(paramFloat2, paramFloat4);
	  float f5 = paramFloat1 - paramFloat3;
	  float f6 = paramFloat2 - paramFloat4;
	  if (f5 == 0.0F)
	  {
		f5 = 0.001F;
	  }
	  if (f6 == 0.0F)
	  {
		f6 = 0.001F;
	  }
	  paramFloat1 = 0.5F * paramFloat5;
	  float f7 = 0.0F;
	  if (f5 == 0.0F)
	  {
		paramFloat5 = 0.0F;
		paramFloat2 = paramFloat1;
	  }
	  else if (f6 == 0.0F)
	  {
		paramFloat2 = 0.0F;
		paramFloat5 = paramFloat1;
	  }
	  else
	  {
		paramFloat2 = f6 / f5;
		f7 = paramFloat2 * paramFloat2;
		paramFloat5 = paramFloat1 / c(1.0F + f7);
		paramFloat2 = paramFloat1 / c((1.0F + f7) / f7);
	  }
	  if (f2 - f1 > f4 - f3)
	  {
		paramFloat5 = paramFloat1;
		if (f5 != 0.0F)
		{
		  paramFloat5 = paramFloat1 * (f7 + 2.0F) * 0.5F;
		}
		int i = b(f1 - paramFloat2);
		int j = a(paramFloat2 + f2);
		f5 = f6 / f5;
		paramFloat1 = i;
		for (paramFloat1 = paramFloat4 - f5 * paramFloat3 + paramFloat1 * f5; i <= j; paramFloat1 = paramFloat2)
		{
		  paramFloat3 = paramFloat1 - paramFloat5 + 0.5F;
		  paramFloat4 = paramFloat1 + paramFloat5 + 0.5F;
		  int k = (int)paramFloat3;
		  if (paramFloat3 < 0.0F && paramFloat3 != k)
		  {
			k--;
		  }
		  int m = (int)paramFloat4;
		  if (paramFloat4 < 0.0F && paramFloat4 != k)
		  {
			m--;
		  }
		  paramFloat2 = paramFloat1;
		  if (k <= m)
		  {
			if (i >= 0 && i < 128)
			{
			  paramFloat2 = k;
			  f6 = m;
			  int n = (int)((1.0F - paramFloat3 - paramFloat2) * 255.0F);
			  int i1 = (int)(255.0F * (paramFloat4 - f6));
			  if (k != m)
			  {
				int i2 = k + 1;
				for (k = i2; k < m; k++)
				{
				  if (k >= 0 && k < 128 && (!c_Conflict || !a(f[(k << 7) + i])))
				  {
					f[(k << 7) + i] = (short)b_Conflict;
				  }
				}
				b(i, i2 - 1, n);
				b(i, m, i1);
			  }
			  else
			  {
				b(i, k, n * i1 >> 8);
			  }
			}
			paramFloat2 = paramFloat1 + f5;
		  }
		  i++;
		}
	  }
	  else
	  {
		paramFloat2 = paramFloat1;
		if (f5 != 0.0F)
		{
		  paramFloat1 = paramFloat1 * ((1.0F + f7) / f7 + 1.0F) * 0.5F;
		  paramFloat2 = paramFloat1;
		  if (paramFloat1 < 0.0F)
		  {
			paramFloat2 = -paramFloat1;
		  }
		}
		int i = b(f3 - paramFloat5);
		int j = a(f4 + paramFloat5);
		paramFloat5 = f5 / f6;
		paramFloat1 = i;
		for (paramFloat1 = paramFloat3 - paramFloat5 * paramFloat4 + paramFloat1 * paramFloat5; i <= j; paramFloat1 = paramFloat3)
		{
		  f5 = paramFloat1 - paramFloat2 + 0.5F;
		  paramFloat4 = paramFloat1 + paramFloat2 + 0.5F;
		  int k = (int)f5;
		  if (f5 < 0.0F && f5 != k)
		  {
			k--;
		  }
		  int m = (int)paramFloat4;
		  if (paramFloat4 < 0.0F && paramFloat4 != k)
		  {
			m--;
		  }
		  paramFloat3 = paramFloat1;
		  if (k <= m)
		  {
			if (i >= 0 && i < 128)
			{
			  f6 = k;
			  paramFloat3 = m;
			  int n = (int)((1.0F - f5 - f6) * 255.0F);
			  int i1 = (int)(255.0F * (paramFloat4 - paramFloat3));
			  if (k != m)
			  {
				int i3 = i << 7;
				int i2 = k + 1;
				for (k = i2; k < m; k++)
				{
				  if (k >= 0 && k < 128 && (!c_Conflict || !a(f[i3 + k])))
				  {
					f[i3 + k] = (short)b_Conflict;
				  }
				}
				c(i2 - 1, i, n);
				c(m, i, i1);
			  }
			  else
			  {
				c(m, i, n * i1 >> 8);
			  }
			}
			paramFloat3 = paramFloat1 + paramFloat5;
		  }
		  i++;
		}
	  }
	}
	else
	{
	  float f7 = Math.Min(paramFloat1, paramFloat3);
	  float f8 = Math.Max(paramFloat1, paramFloat3);
	  float f9 = Math.Min(paramFloat2, paramFloat4);
	  float f10 = Math.Max(paramFloat2, paramFloat4);
	  float f4 = paramFloat1 - paramFloat3;
	  float f6 = paramFloat2 - paramFloat4;
	  if (f4 == 0.0F)
	  {
		f4 = 0.001F;
	  }
	  float f5 = f6;
	  if (f6 == 0.0F)
	  {
		f5 = 0.001F;
	  }
	  f6 = paramFloat5 * 0.5F;
	  paramFloat5 = (float)Math.Sqrt((f4 * f4 + f5 * f5));
	  float f3 = f6 / paramFloat5;
	  float f1 = f5 * f3;
	  float f2 = f3 * f4;
	  if (f1 < 0.0F)
	  {
		f1 = -f1;
	  }
	  if (f2 < 0.0F)
	  {
		f2 = -f2;
	  }
	  float f11 = 0.0F;
	  float f12 = 0.0F;
	  float f13 = 0.0F;
	  float f14 = 0.0F;
	  if (f8 - f7 > f10 - f9)
	  {
		bool @bool;
		paramFloat5 = f6 * paramFloat5 / f4;
		float f16 = paramFloat5;
		if (paramFloat5 < 0.0F)
		{
		  f16 = -paramFloat5;
		}
		int i = Math.Max(0, b(f7 - f1));
		int j = Math.Min(128, a(f8 + f1));
		f14 = f5 / f4;
		if (paramFloat1 == f7)
		{
		  if (paramFloat2 == f9)
		  {
			f15 = paramFloat1 - f1;
			f3 = paramFloat2 + f2;
			f6 = paramFloat1 + f1;
			f5 = paramFloat2 - f2;
			f4 = paramFloat3 - f1;
			paramFloat5 = paramFloat4 + f2;
			paramFloat2 = paramFloat3 + f1;
			paramFloat1 = paramFloat4 - f2;
			@bool = true;
		  }
		  else
		  {
			f15 = paramFloat1 - f1;
			f3 = paramFloat2 - f2;
			f6 = paramFloat1 + f1;
			f5 = paramFloat2 + f2;
			f4 = paramFloat3 - f1;
			paramFloat5 = paramFloat4 - f2;
			paramFloat2 = paramFloat3 + f1;
			paramFloat1 = paramFloat4 + f2;
			@bool = false;
		  }
		}
		else if (paramFloat4 == f9)
		{
		  f15 = paramFloat3 - f1;
		  f3 = paramFloat4 + f2;
		  f6 = paramFloat3 + f1;
		  f5 = paramFloat4 - f2;
		  f4 = paramFloat1 - f1;
		  paramFloat5 = paramFloat2 + f2;
		  f13 = paramFloat1 + f1;
		  paramFloat1 = paramFloat2 - f2;
		  @bool = true;
		  paramFloat2 = f13;
		}
		else
		{
		  f15 = paramFloat3 - f1;
		  f3 = paramFloat4 - f2;
		  f6 = paramFloat3 + f1;
		  f5 = paramFloat4 + f2;
		  f4 = paramFloat1 - f1;
		  paramFloat5 = paramFloat2 - f2;
		  f13 = paramFloat1 + f1;
		  paramFloat1 = paramFloat2 + f2;
		  @bool = false;
		  paramFloat2 = f13;
		}
		int m = a(f7 + f1);
		int k = b(f8 - f1);
		f1 = f6 - f15;
		f2 = f12;
		float f15 = f11;
		if (f1 != 0.0F)
		{
		  f15 = (f5 - f3) / f1;
		  f2 = f5 - f6 * f15;
		}
		f4 = paramFloat2 - f4;
		if (f4 != 0.0F)
		{
		  f4 = (paramFloat1 - paramFloat5) / f4;
		  paramFloat5 = paramFloat1 - paramFloat2 * f4;
		}
		else
		{
		  paramFloat5 = 0.0F;
		  f4 = 0.0F;
		}
		paramFloat1 = i * f14 + paramFloat4 - f14 * paramFloat3;
		while (i <= j)
		{
		  if (i >= 0 && i < 128)
		  {
			paramFloat4 = paramFloat1 - f16;
			f5 = paramFloat1 + f16;
			paramFloat3 = f5;
			paramFloat2 = paramFloat4;
			if (i < m)
			{
			  if (@bool)
			  {
				paramFloat2 = i * f15 + f2;
				paramFloat3 = f5;
			  }
			  else
			  {
				paramFloat3 = i * f15 + f2;
				paramFloat2 = paramFloat4;
			  }
			}
			paramFloat4 = paramFloat3;
			f5 = paramFloat2;
			if (i > k)
			{
			  if (@bool)
			  {
				paramFloat4 = i * f4 + paramFloat5;
				f5 = paramFloat2;
			  }
			  else
			  {
				f5 = i * f4 + paramFloat5;
				paramFloat4 = paramFloat3;
			  }
			}
			paramFloat2 = f5 + 0.5F;
			paramFloat3 = paramFloat4 + 0.5F;
			int i1 = (int)paramFloat2;
			if (paramFloat2 < 0.0F && paramFloat2 != i1)
			{
			  i1--;
			}
			int n = (int)paramFloat3;
			if (paramFloat3 < 0.0F && paramFloat3 != i1)
			{
			  n--;
			}
			if (i1 <= n)
			{
			  if (i >= 0 && i < 128)
			  {
				f5 = i1;
				paramFloat4 = n;
				int i2 = (int)((1.0F - paramFloat2 - f5) * 255.0F);
				int i3 = (int)(255.0F * (paramFloat3 - paramFloat4));
				if (i1 != n)
				{
				  int i4;
				  if (i1 >= 0 && n < 128)
				  {
					int i5 = ++i1;
					while (true)
					{
					  i4 = i1;
					  if (i5 < n)
					  {
						if (!c_Conflict || !a(f[(i5 << 7) + i]))
						{
						  f[(i5 << 7) + i] = (short)b_Conflict;
						}
						i5++;
						continue;
					  }
					  break;
					}
				  }
				  else
				  {
					int i5 = ++i1;
					while (true)
					{
					  i4 = i1;
					  if (i5 < n)
					  {
						if (i5 >= 0 && i5 < 128 && (!c_Conflict || !a(f[(i5 << 7) + i])))
						{
						  f[(i5 << 7) + i] = (short)b_Conflict;
						}
						i5++;
						continue;
					  }
					  break;
					}
				  }
				  b(i, i4 - 1, i2);
				  b(i, n, i3);
				}
				else
				{
				  b(i, i1, i2 * i3 >> 8);
				}
			  }
			  paramFloat1 += f14;
			}
		  }
		  i++;
		}
	  }
	  else
	  {
		bool @bool;
		paramFloat5 = f6 * paramFloat5 / f5;
		float f16 = paramFloat5;
		if (paramFloat5 < 0.0F)
		{
		  f16 = -paramFloat5;
		}
		int i = Math.Max(0, b(f9 - f2));
		int j = Math.Min(128, a(f10 + f2));
		f11 = f4 / f5;
		if (paramFloat1 == f7)
		{
		  if (paramFloat2 == f9)
		  {
			f15 = paramFloat1 + f1;
			f3 = paramFloat2 - f2;
			f6 = paramFloat1 - f1;
			f5 = paramFloat2 + f2;
			paramFloat5 = paramFloat3 + f1;
			f4 = paramFloat4 - f2;
			paramFloat2 = paramFloat3 - f1;
			paramFloat1 = paramFloat4 + f2;
			@bool = true;
		  }
		  else
		  {
			f15 = paramFloat3 - f1;
			f3 = paramFloat4 - f2;
			f6 = paramFloat3 + f1;
			f5 = paramFloat4 + f2;
			paramFloat5 = paramFloat1 - f1;
			f4 = paramFloat2 - f2;
			f1 = paramFloat1 + f1;
			paramFloat1 = paramFloat2 + f2;
			@bool = false;
			paramFloat2 = f1;
		  }
		}
		else if (paramFloat4 == f9)
		{
		  f15 = paramFloat3 + f1;
		  f3 = paramFloat4 - f2;
		  f6 = paramFloat3 - f1;
		  f5 = paramFloat4 + f2;
		  paramFloat5 = paramFloat1 + f1;
		  f4 = paramFloat2 - f2;
		  f1 = paramFloat1 - f1;
		  paramFloat1 = paramFloat2 + f2;
		  @bool = true;
		  paramFloat2 = f1;
		}
		else
		{
		  f15 = paramFloat1 - f1;
		  f3 = paramFloat2 - f2;
		  f6 = paramFloat1 + f1;
		  f5 = paramFloat2 + f2;
		  paramFloat5 = paramFloat3 - f1;
		  f4 = paramFloat4 - f2;
		  paramFloat2 = paramFloat3 + f1;
		  paramFloat1 = paramFloat4 + f2;
		  @bool = false;
		}
		int k = a(f10 - f2);
		int m = b(f2 + f9);
		f3 = f5 - f3;
		if (f3 != 0.0F)
		{
		  f3 = (f6 - f15) / f3;
		  f5 = f6 - f5 * f3;
		  f6 = f3;
		}
		else
		{
		  f5 = 0.0F;
		  f6 = 0.0F;
		}
		float f15 = paramFloat1 - f4;
		f3 = f14;
		f4 = f13;
		if (f15 != 0.0F)
		{
		  f4 = (paramFloat2 - paramFloat5) / f15;
		  f3 = paramFloat2 - paramFloat1 * f4;
		}
		paramFloat1 = i;
		for (paramFloat3 = paramFloat1 * f11 + paramFloat3 - f11 * paramFloat4; i <= j; paramFloat3 = paramFloat1)
		{
		  paramFloat4 = paramFloat3 - f16;
		  paramFloat5 = paramFloat3 + f16;
		  if (paramFloat5 < 0.0F)
		  {
			paramFloat1 = paramFloat3 + f11;
		  }
		  else
		  {
			paramFloat2 = paramFloat5;
			paramFloat1 = paramFloat4;
			if (i < m)
			{
			  if (@bool)
			  {
				paramFloat1 = i * f6 + f5;
				paramFloat2 = paramFloat5;
			  }
			  else
			  {
				paramFloat2 = i * f6 + f5;
				paramFloat1 = paramFloat4;
			  }
			}
			paramFloat4 = paramFloat2;
			paramFloat5 = paramFloat1;
			if (i > k)
			{
			  if (@bool)
			  {
				paramFloat4 = i * f4 + f3;
				paramFloat5 = paramFloat1;
			  }
			  else
			  {
				paramFloat5 = i * f4 + f3;
				paramFloat4 = paramFloat2;
			  }
			}
			paramFloat1 = paramFloat5 + 0.5F;
			paramFloat4 += 0.5F;
			int i1 = (int)paramFloat1;
			if (paramFloat1 < 0.0F && paramFloat1 != i1)
			{
			  i1--;
			}
			int n = (int)paramFloat4;
			if (paramFloat4 < 0.0F && paramFloat4 != i1)
			{
			  n--;
			}
			if (i1 > n)
			{
			  paramFloat1 = paramFloat3 + f11;
			}
			else
			{
			  if (i >= 0 && i < 128)
			  {
				paramFloat5 = i1;
				paramFloat2 = n;
				int i2 = (int)((1.0F - paramFloat1 - paramFloat5) * 255.0F);
				int i3 = (int)(255.0F * (paramFloat4 - paramFloat2));
				if (i1 != n)
				{
				  int i5 = i << 7;
				  int i4 = i1 + 1;
				  for (i1 = i4; i1 < n; i1++)
				  {
					if (i1 >= 0 && i1 < 128 && (!c_Conflict || !a(f[i5 + i1])))
					{
					  f[i5 + i1] = (short)b_Conflict;
					}
				  }
				  c(i4 - 1, i, i2);
				  c(n, i, i3);
				}
				else
				{
				  c(n, i, i2 * i3 >> 8);
				}
			  }
			  paramFloat1 = paramFloat3 + f11;
			}
		  }
		  i++;
		}
	  }
	}
  }

  private static void a(int paramInt1, int paramInt2, float paramFloat)
  {
	if (paramInt2 - paramFloat < 128.0F && paramInt2 + paramFloat >= 0.0F)
	{
	  sbyte b;
	  if (paramInt2 < 0)
	  {
		b = -paramInt2;
	  }
	  else if (paramInt2 >= 128)
	  {
		b = paramInt2 - unchecked((sbyte)128) + 1;
	  }
	  else
	  {
		b = 0;
	  }
	  while (true)
	  {
		if (b <= paramFloat)
		{
		  int i = (int)(c(1.0F - (b * b) / paramFloat * paramFloat) * paramFloat);
		  a(paramInt1 - i, paramInt1 + i, paramInt2 + b);
		  if (b != 0)
		  {
			a(paramInt1 - i, i + paramInt1, paramInt2 - b);
		  }
		  b++;
		  continue;
		}
		return;
	  }
	}
  }

  private static void a(int paramInt1, int paramInt2, int paramInt3)
  {
	if (paramInt3 >= 0 && paramInt3 < 128)
	{
	  int i = (paramInt3 << 7) + paramInt1;
	  paramInt3 = paramInt1;
	  for (paramInt1 = i; paramInt3 < paramInt2; paramInt1++)
	  {
		if (paramInt3 >= 0 && paramInt3 < 128 && (!c_Conflict || !a(f[paramInt1])))
		{
		  f[paramInt1] = (short)b_Conflict;
		}
		paramInt3++;
	  }
	}
  }

  public static void a(int paramInt, bool paramBoolean)
  {
	paramInt = 0xFFFFFF & paramInt;
	b_Conflict = (short)(short)(paramInt >> 3 & 0x1F | (paramInt >> 19 & 0x1F) << 11 | (paramInt >> 10 & 0x3F) << 5);
	c_Conflict = paramBoolean;
  }

  public static bool a(aw paramaw, am paramam, bool paramBoolean)
  {
	null = true;
	bool @bool = false;
	if (paramaw.a())
	{
	  ax ax = paramaw.a(paramam);
	  if (ax != null)
	  {
		if (paramam.u >= ax.b_Conflict)
		{
		  null = @bool;
		  return (Math.Abs(paramam.l - paramam.zoom) - Math.Abs(ax.d - paramam.zoom) > 0) ? true : null;
		}
	  }
	  else
	  {
		null = @bool;
		if (paramBoolean)
		{
		  null = @bool;
		  if ((paramam.g & 0x2) == 2)
		  {
			paramam.g = (sbyte)0;
			if (paramam.f_Conflict != null)
			{
			  ap.a().b().c(paramam);
			}
			paramam.f_Conflict = null;
			paramam.l = (sbyte)-1;
			paramam.u = -1;
			null = true;
		  }
		}
		return null;
	  }
	}
	else
	{
	  if ((paramam.g & 0x2) != 2)
	  {
		null = false;
	  }
	  if (paramBoolean && null)
	  {
		paramam.g = (sbyte)0;
		if (paramam.f_Conflict != null)
		{
		  ap.a().b().c(paramam);
		}
		paramam.f_Conflict = null;
		paramam.l = (sbyte)-1;
		paramam.u = -1;
	  }
	  return null;
	}
	return true;
  }

  private static bool a(short paramShort)
  {
	bool bool1 = false;
	int i = (int)((uint)(0xF800 & paramShort) >> 8);
	if (i > 195)
	{
	  return bool1;
	}
	int j = (int)((uint)(paramShort & 0x7E0) >> 3);
	bool bool2 = bool1;
	if (j <= 195)
	{
	  int k = (paramShort & 0x1F) << 3;
	  bool2 = bool1;
	  if (k <= 195)
	  {
		bool2 = bool1;
		if (Math.Abs(i - j) <= 8)
		{
		  bool2 = bool1;
		  if (Math.Abs(j - k) <= 8)
		  {
			bool2 = bool1;
			if (Math.Abs(k - i) <= 8)
			{
			  bool2 = true;
			}
		  }
		}
	  }
	}
	return bool2;
  }

  public static int b(float paramFloat)
  {
	int i = (int)paramFloat;
	if (paramFloat > 0.0F && paramFloat != (int)paramFloat)
	{
	  sbyte b1 = 1;
	  return b1 + i;
	}
	sbyte b = 0;
	return b + i;
  }

  private static void b(int paramInt1, int paramInt2, int paramInt3)
  {
	if (paramInt2 >= 0 && paramInt2 < 128)
	{
	  paramInt1 = (paramInt2 << 7) + paramInt1;
	  paramInt3 = (int)((uint)paramInt3 >> 3);
	  paramInt2 = b_Conflict;
	  short s = f[paramInt1];
	  if (!c_Conflict || !a(s))
	  {
		int[][] arrayOfInt1 = a_Conflict[paramInt3];
		int[][] arrayOfInt2 = a_Conflict[32 - paramInt3];
		int i = arrayOfInt1[0][paramInt2 & 0xFF];
		paramInt3 = arrayOfInt2[0][s & 0xFF];
		paramInt2 = arrayOfInt1[1][(int)((uint)paramInt2 >> 8) & 0xFF] + i + paramInt3 + arrayOfInt2[1][(short)((ushort)s >> 8) & 0xFF] & (int)unchecked((int)0xF81F07E0);
		f[paramInt1] = (short)unchecked((short)(((int)((uint)paramInt2 >> 16)) + (0xFFFF & paramInt2)));
	  }
	}
  }

  private static float c(float paramFloat)
  {
	float f = (1.0F + paramFloat) * 0.5F;
	f = (f + paramFloat / f) * 0.5F;
	return (f + paramFloat / f) * 0.5F;
  }

  private static void c(int paramInt1, int paramInt2, int paramInt3)
  {
	if (paramInt1 >= 0 && paramInt1 < 128)
	{
	  paramInt1 = (paramInt2 << 7) + paramInt1;
	  paramInt3 = (int)((uint)paramInt3 >> 3);
	  paramInt2 = b_Conflict;
	  short s = f[paramInt1];
	  if (!c_Conflict || !a(s))
	  {
		int[][] arrayOfInt1 = a_Conflict[paramInt3];
		int[][] arrayOfInt2 = a_Conflict[32 - paramInt3];
		int i = arrayOfInt1[0][paramInt2 & 0xFF];
		paramInt3 = arrayOfInt2[0][s & 0xFF];
		paramInt2 = arrayOfInt1[1][(int)((uint)paramInt2 >> 8) & 0xFF] + i + paramInt3 + arrayOfInt2[1][(short)((ushort)s >> 8) & 0xFF] & (int)unchecked((int)0xF81F07E0);
		f[paramInt1] = (short)unchecked((short)(((int)((uint)paramInt2 >> 16)) + (0xFFFF & paramInt2)));
	  }
	}
  }

  public bool a(am paramam, bool paramBoolean)
  {
	if (this.d.a())
	{
	  try
	  {
		ax ax = this.d.a(paramam);
		if (ax != null)
		{
		  Bitmap bitmap = paramam.f_Conflict;
		  sbyte b = paramam.g;
		  if ((b & 0x2) == 2 || (b & 0x8) == 8)
		  {
			bitmap = am.b(paramam);
		  }
		  if (f == null || e == null)
		  {
			ShortBuffer shortBuffer = ShortBuffer.allocate(bitmap.getWidth() * bitmap.getWidth());
			e = shortBuffer;
			f = shortBuffer.array();
		  }
		  if (bitmap == null)
		  {
			aq.a_Conflict.copyPixelsToBuffer(e);
		  }
		  else
		  {
			bitmap.copyPixelsToBuffer(e);
		  }
		  e.rewind();
		  int i = 23 - paramam.zoom;
		  int j = paramam.i << i + 7;
		  int k = paramam.j << i + 7;
		  au au = this.d.c();
		  int m = ax.f;
		  sbyte b1 = 0;
		  bool @bool = false;
		  while (true)
		  {
			if (b1 < m)
			{
			  ba ba = ax.h[b1];
			  at[] arrayOfAt = au.a(ba.c, i, ba.d);
			  bool bool1 = @bool;
			  if (arrayOfAt != null)
			  {
				at at = arrayOfAt[i];
				bool1 = @bool;
				if (at != null)
				{
				  int n = at.m;
				  int i1 = n << 1;
				  bool1 = @bool;
				  if (b.a((ba.f - j >> i) - n, (ba.g - k >> i) - n, (ba.h - ba.f >> i) + i1, i1 + (ba.i - ba.g >> i)))
				  {
					float f1 = at.e - at.k * (ba.e - 1);
					int i2 = b.a(f1) >> 1;
					int i3 = i2 << 1;
					int[] arrayOfInt = ba.a_Conflict;
					int i4 = ba.b;
					float f2 = f1 * 0.5F;
					a(at.c, paramBoolean);
					i1 = arrayOfInt[0] - j >> i;
					n = arrayOfInt[1];
					sbyte b2 = 2;
					n = n - k >> i;
					while (b2 < i4)
					{
					  int i5 = arrayOfInt[b2] - j >> i;
					  int i6 = arrayOfInt[b2 + 1] - k >> i;
					  if (i1 != i5 || n != i6)
					  {
						int i9;
						int i10;
						int i7 = b.a(i5 - i1);
						int i8 = b.a(i6 - n);
						if (i5 > i1)
						{
						  i9 = i1;
						}
						else
						{
						  i9 = i5;
						}
						if (i6 > n)
						{
						  i10 = n;
						}
						else
						{
						  i10 = i6;
						}
						if (b.a(i9 - i2, i10 - i2, i7 + i3, i8 + i3))
						{
						  a(i1, n, f2);
						  a(i1, n, i5, i6, f1);
						  a(i5, i6, f2);
						}
						n = i6;
						i1 = i5;
					  }
					  b2 += 2;
					}
					if (at.l)
					{
					  i2 = b.a(at.h) >> 1;
					  i4 = i2 << 1;
					  arrayOfInt = ba.a_Conflict;
					  i3 = ba.b;
					  a(at.d, paramBoolean);
					  i1 = arrayOfInt[0] - j >> i;
					  n = arrayOfInt[1];
					  b2 = 2;
					  f2 = 0.0F;
					  n = n - k >> i;
					  while (true)
					  {
						if (b2 < i3)
						{
						  int i5 = arrayOfInt[b2] - j >> i;
						  int i6 = arrayOfInt[b2 + 1] - k >> i;
						  if (i1 != i5 || n != i6)
						  {
							int i9;
							int i10;
							int i8 = b.a(i5 - i1);
							int i7 = b.a(i6 - n);
							if (i5 > i1)
							{
							  i9 = i1;
							}
							else
							{
							  i9 = i5;
							}
							if (i6 > n)
							{
							  i10 = n;
							}
							else
							{
							  i10 = i6;
							}
							f1 = f2;
							if (b.a(i9 - i2, i10 - i2, i8 + i4, i7 + i4))
							{
							  i9 = i5 - i1;
							  i10 = i6 - n;
							  if (i9 == 0 && i10 == 0)
							  {
								f1 = f2;
							  }
							  else
							  {
								float f3 = i1;
								f1 = n;
								float f4 = i5;
								float f5 = i6;
								float f6 = (float)Math.Sqrt((i9 * i9 + i10 * i10));
								f4 = (f4 - f3) / f6;
								float f7 = (f5 - f1) / f6;
								float f8 = at.g;
								float f9 = at.f;
								f5 = f9 + f8;
								float f10 = at.i;
								float f11 = at.j;
								float f12 = at.h;
								float f13 = -f7 * f10;
								f10 *= f4;
								if (f2 > f8)
								{
								  if (f6 >= f2 - f8)
								  {
									float f14 = f2 - f8;
									f8 = f4 * f14 + f3;
									float f15 = f14 * f7 + f1;
									float f16 = f8 - f4 * f11;
									f14 = f15 - f7 * f11;
									a(f3, f1, f8, f15, f12);
									a(f8, f15, f16 + f13, f14 + f10, f12);
									a(f8, f15, f16 - f13, f14 - f10, f12);
								  }
								  else
								  {
									a(f3, f1, i5, i6, f12);
								  }
								}
								if (f6 <= f2)
								{
								  f1 = f2 - f6;
								}
								else
								{
								  f6 -= f2;
								  f3 = f4 * f2 + f3;
								  f2 = f1 + f2 * f7;
								  n = (int)(f6 / f5);
								  f6 -= n * f5;
								  i1 = n;
								  if (f6 >= f9)
								  {
									i1 = n + 1;
								  }
								  f1 = 0.0F;
								  for (n = 0; n < i1; n++)
								  {
									float f14 = f1 + f9;
									f8 = f4 * f14 + f3;
									f14 = f14 * f7 + f2;
									float f15 = f8 - f4 * f11;
									float f16 = f14 - f7 * f11;
									a(f8, f14, f15 + f13, f16 + f10, f12);
									a(f8, f14, f15 - f13, f16 - f10, f12);
									a(f4 * f1 + f3, f7 * f1 + f2, f8, f14, f12);
									f1 += f5;
								  }
								  if (f6 < f9)
								  {
									f1 = i1 * f5;
									a(f4 * f1 + f3, f1 * f7 + f2, i5, i6, f12);
								  }
								  f1 = f5 - f6;
								}
							  }
							}
							n = i6;
							i1 = i5;
						  }
						  else
						  {
							f1 = f2;
						  }
						  b2 += 2;
						  f2 = f1;
						  continue;
						}
						bool1 = true;
						Thread.yield();
						b1++;
						@bool = bool1;
						goto label126Continue;
					  }
					  break;
					}
					continue;
				  }
				  continue;
				}
				continue;
			  }
			  continue;
			}
			paramBoolean = @bool;
			try
			{
			  if (b == paramam.g)
			  {
				if (@bool)
				{
				  if (bitmap == aq.b_Conflict)
				  {
					bitmap = null;
				  }
				  am.a(paramam, bitmap, e, (sbyte)2);
				  paramBoolean = @bool;
				  if ((paramam.g & 0x2) == 2)
				  {
					paramam.u = ax.b_Conflict;
					paramam.l = (sbyte)ax.d;
					paramBoolean = @bool;
				  }
				  return paramBoolean;
				}
				paramam.u = ax.b_Conflict;
				paramam.l = (sbyte)ax.d;
				paramBoolean = @bool;
			  }
			}
			catch (Exception)
			{
			  paramBoolean = @bool;
			}
			return paramBoolean;
			  label126Continue:;
		  }
		  label126Break:;
		}
	  }
	  catch (Exception)
	  {
		return false;
	  }
	}
	return false;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\av.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */