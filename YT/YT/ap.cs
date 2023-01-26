using System;

using MapController = ru.yandex.yandexmapkit.MapController;
using MapLayer = ru.yandex.yandexmapkit.map.MapLayer;

public sealed class ap
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static am a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static bool b_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public static bool c_Conflict = false;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private static ap d_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private readonly al e_Conflict;

  private readonly a f;

  private readonly MapController g;

  private float h;

  public ap(a parama, MapController paramMapController)
  {
	// Byte code:
	//   0: aload_0
	//   1: invokespecial <init> : ()V
	//   4: aload_0
	//   5: fconst_1
	//   6: putfield h : F
	//   9: aload_0
	//   10: new al
	//   13: dup
	//   14: sipush #150
	//   17: sipush #400
	//   20: invokespecial <init> : (II)V
	//   23: putfield e : Lal;
	//   26: aload_0
	//   27: aload_2
	//   28: putfield g : Lru/yandex/yandexmapkit/MapController;
	//   31: aload_0
	//   32: aload_1
	//   33: putfield f : La;
	//   36: aload_0
	//   37: putstatic ap.d : Lap;
	//   40: ldc ap
	//   42: monitorenter
	//   43: getstatic ap.a : Lam;
	//   46: ifnonnull -> 117
	//   49: new am
	//   52: astore_1
	//   53: aload_1
	//   54: aload_2
	//   55: invokevirtual getContext : ()Landroid/content/Context;
	//   58: ldc2_w -1
	//   61: iconst_m1
	//   62: iconst_m1
	//   63: iconst_m1
	//   64: iconst_m1
	//   65: ldc ''
	//   67: iconst_0
	//   68: invokespecial <init> : (Landroid/content/Context;JIIIILjava/lang/String;Z)V
	//   71: aload_1
	//   72: putstatic ap.a : Lam;
	//   75: aload_1
	//   76: iconst_4
	//   77: i2b
	//   78: putfield k : B
	//   81: getstatic ap.a : Lam;
	//   84: getstatic aq.c : [B
	//   87: invokevirtual a : ([B)V
	//   90: getstatic ap.a : Lam;
	//   93: getstatic aq.b : Landroid/graphics/Bitmap;
	//   96: putfield f : Landroid/graphics/Bitmap;
	//   99: getstatic ap.a : Lam;
	//   102: astore_1
	//   103: getstatic ap.a : Lam;
	//   106: iconst_1
	//   107: i2b
	//   108: putfield h : B
	//   111: aload_1
	//   112: iconst_1
	//   113: i2b
	//   114: putfield g : B
	//   117: ldc ap
	//   119: monitorexit
	//   120: return
	//   121: astore_1
	//   122: ldc ap
	//   124: monitorexit
	//   125: aload_1
	//   126: athrow
	// Exception table:
	//   from	to	target	type
	//   43	117	121	finally
	//   117	120	121	finally
  }

  public static ap a()
  {
	return d_Conflict;
  }

  public static void a(ap paramap)
  {
	d_Conflict = paramap;
  }

  internal am a(int paramInt1, int paramInt2, int paramInt3, int paramInt4)
  {
	if (b.a(paramInt1, paramInt2, paramInt3))
	{
	  long l = am.a(paramInt1, paramInt2, paramInt3, paramInt4);
	  am am1 = this.e_Conflict.a(l);
	  am am2 = am1;
	  if (am1 == null)
	  {
		MapLayer mapLayer = this.g.a(paramInt4);
		am2 = am1;
		if (mapLayer != null)
		{
		  if (mapLayer.isService)
		  {
			am2 = new bg(this.g.Context, l, paramInt1, paramInt2, paramInt3, paramInt4, mapLayer.requestName, true);
		  }
		  else
		  {
			am2 = new am(this.g.Context, l, paramInt1, paramInt2, paramInt3, paramInt4, mapLayer.requestName, false);
			am2.a(e());
		  }
		  am2.e_Conflict = mapLayer.isCustom;
		  this.e_Conflict.a(l, am2);
		}
	  }
	  return am2;
	}
	return a_Conflict;
  }

  public void a(float paramFloat)
  {
	this.h = paramFloat;
  }

  internal void a(am paramam)
  {
	this.e_Conflict.a(paramam);
  }

  public void a(am paramam, bool paramBoolean)
  {
	if (paramam.a() == null || (paramam.a()).Length <= 0)
	{
	  if (paramBoolean)
	  {
		try
		{
		  if (!b_Conflict && !paramam.e_Conflict && (paramam.x || (paramam.w && this.g.a(paramam))))
		  {
			paramam.k = (sbyte)2;
			this.g.h().a(paramam);
			return;
		  }
		  paramam.k = (sbyte)3;
		}
		catch (Exception)
		{
		  paramam.k = (sbyte)4;
		}
		return;
	  }
	  paramam.k = (sbyte)4;
	  return;
	}
	if (paramam.d_Conflict)
	{
	  paramam.h = (sbyte)16;
	}
	else
	{
	  paramam.h = (sbyte)1;
	}
	MapLayer mapLayer = this.g.a(paramam.type);
	bool @bool = false;
	if (c_Conflict || (mapLayer != null && paramam.b() < mapLayer.version))
	{
	  if (paramam.s)
	  {
		paramam.k = (sbyte)3;
		paramam.a(mapLayer.version);
	  }
	  else
	  {
		if (!b_Conflict && paramBoolean)
		{
		  this.g.h().a(paramam);
		  paramam.k = (sbyte)5;
		}
		@bool = true;
	  }
	}
	else
	{
	  paramam.k = (sbyte)3;
	}
	paramam.v = true;
	if (!paramBoolean)
	{
	  try
	  {
		aq.i().h();
		if (paramam.k != 5 && !@bool)
		{
		  this.f.a_Conflict(paramam);
		}
	  }
	  catch (Exception)
	  {
	  }
	  return;
	}
	if (((am)exception).t && ((am)exception).k != 5 && !@bool)
	{
	  this.f.a_Conflict((am)exception);
	}
  }

  public al b()
  {
	return this.e_Conflict;
  }

  internal void b(am paramam)
  {
	if (paramam.k == 0 || paramam.h == 0)
	{
	  paramam.k = (sbyte)1;
	  this.f.b(paramam);
	}
  }

  internal void c()
  {
	this.f.e();
  }

  internal void d()
  {
	this.e_Conflict.b();
  }

  public float e()
  {
	return this.h;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ap.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */