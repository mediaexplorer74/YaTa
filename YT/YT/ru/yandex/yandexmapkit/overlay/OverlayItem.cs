using System;

namespace ru.yandex.yandexmapkit.overlay
{
	using Bitmap = android.graphics.Bitmap;
	using by;
	using BalloonItem = ru.yandex.yandexmapkit.overlay.balloon.BalloonItem;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class OverlayItem : IComparable
	{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  protected internal GeoPoint a_Conflict;

	  protected internal by b;

	  protected internal ScreenPoint c;

	  protected internal Bitmap d;

	  protected internal bool e = true;

	  protected internal sbyte f = (sbyte)0;

	  protected internal int g = 0;

	  protected internal int h = 0;

	  private BalloonItem i;

	  private int j;

	  private int k;

	  public OverlayItem(GeoPoint paramGeoPoint, Bitmap paramBitmap)
	  {
		this.a_Conflict = paramGeoPoint;
		this.d = paramBitmap;
		this.b = CoordConversion.toXY(this.a_Conflict, null);
		if (this.d != null)
		{
		  this.k = this.d.getWidth() >> 1;
		  this.j = this.d.getHeight() >> 1;
		}
	  }

	  public virtual int a(OverlayItem paramOverlayItem)
	  {
		long l1 = Priority << 32L | (int)(Point).y;
		long l2 = paramOverlayItem.Priority << 32L | (int)(paramOverlayItem.Point).y;
		return (l1 < l2) ? -1 : ((l1 > l2) ? 1 : 0);
	  }

	  public virtual BalloonItem BalloonItem
	  {
		  get
		  {
			return this.i;
		  }
		  set
		  {
			this.i = value;
			this.i.OffsetCenterX = this.h;
			this.i.OffsetCenterY = this.j + this.g;
			this.i.OverlayItem = this;
		  }
	  }

	  public virtual Bitmap Bitmap
	  {
		  get
		  {
			return this.d;
		  }
		  set
		  {
			this.d = value;
			if (this.d != null)
			{
			  this.k = this.d.getWidth() >> 1;
			  this.j = this.d.getHeight() >> 1;
			}
		  }
	  }

	  public virtual GeoPoint GeoPoint
	  {
		  get
		  {
			return this.a_Conflict;
		  }
		  set
		  {
			this.a_Conflict = value;
			this.b = CoordConversion.toXY(this.a_Conflict, null);
			if (BalloonItem != null)
			{
			  BalloonItem.GeoPoint = value;
			}
		  }
	  }

	  public virtual int OffsetCenterX
	  {
		  get
		  {
			return this.k;
		  }
		  set
		  {
			this.k = value;
		  }
	  }

	  public virtual int OffsetCenterY
	  {
		  get
		  {
			return this.j;
		  }
		  set
		  {
			this.j = value;
		  }
	  }

	  public virtual int OffsetX
	  {
		  get
		  {
			return this.h;
		  }
		  set
		  {
			this.h = value;
			if (this.i != null)
			{
			  this.i.OffsetCenterX = this.h;
			}
		  }
	  }

	  public virtual int OffsetY
	  {
		  get
		  {
			return this.g;
		  }
		  set
		  {
			this.g = value;
			if (this.i != null)
			{
			  this.i.OffsetCenterY = this.j + this.g;
			}
		  }
	  }

	  public virtual by Point
	  {
		  get
		  {
			return this.b;
		  }
	  }

	  public virtual sbyte Priority
	  {
		  get
		  {
			return this.f;
		  }
		  set
		  {
			this.f = (sbyte)value;
		  }
	  }

	  public virtual ScreenPoint ScreenPoint
	  {
		  get
		  {
			return this.c;
		  }
		  set
		  {
			this.c = value;
		  }
	  }

	  public virtual bool Visible
	  {
		  get
		  {
			return this.e;
		  }
		  set
		  {
			this.e = value;
		  }
	  }










	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\OverlayItem.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}