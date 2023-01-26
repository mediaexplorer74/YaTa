using System;

using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public sealed class ba
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal int[] a_Conflict;

  internal int b;

  internal int c;

  internal float d;

  internal int e;

  internal int f;

  internal int g;

  internal int h;

  internal int i;

  internal by j;

  public ba(int paramInt1, float paramFloat, int paramInt2, int paramInt3)
  {
	int i = paramInt3;
	if (paramInt3 < 2)
	{
	  i = 2;
	}
	this.a_Conflict = new int[i];
	this.b = 0;
	this.f = int.MaxValue;
	this.g = int.MaxValue;
	this.h = 0;
	this.i = 0;
	this.j = new by();
	this.c = paramInt1;
	this.d = paramFloat;
	this.e = paramInt2;
  }

  public void a(GeoPoint paramGeoPoint)
  {
	if (this.b >= this.a_Conflict.Length - 1)
	{
	  int[] arrayOfInt1 = new int[this.a_Conflict.Length << 1];
	  Array.Copy(this.a_Conflict, 0, arrayOfInt1, 0, this.a_Conflict.Length);
	  this.a_Conflict = arrayOfInt1;
	}
	by by1 = CoordConversion.toXY(paramGeoPoint, this.j);
	int i = (int)by1.x;
	int j = (int)by1.y;
	if (i < this.f)
	{
	  this.f = i;
	}
	if (j < this.g)
	{
	  this.g = j;
	}
	if (i > this.h)
	{
	  this.h = i;
	}
	if (j > this.i)
	{
	  this.i = j;
	}
	int[] arrayOfInt = this.a_Conflict;
	int k = this.b;
	this.b = k + 1;
	arrayOfInt[k] = i;
	arrayOfInt = this.a_Conflict;
	k = this.b;
	this.b = k + 1;
	arrayOfInt[k] = j;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ba.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */