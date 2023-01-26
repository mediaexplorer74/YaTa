using System.Collections;

namespace ru.yandex.yandexmapkit.overlay.balloon
{
	using Bitmap = android.graphics.Bitmap;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public sealed class BalloonItem : OverlayItem
	{
	  internal float i = 18.0F;

	  internal int j;

	  internal int k;

	  internal ArrayList l;

	  internal int m;

	  internal int n;

	  internal bool o = false;

	  internal bool p = false;

	  public bool q = false;

	  public float r = 100.0F;

	  internal int s;

	  private bool t = false;

	  private int u = 3;

	  private string v;

	  private OnBalloonListener w;

	  private OverlayItem x;

	  private int y = 18;

	  public BalloonItem(GeoPoint paramGeoPoint, Bitmap paramBitmap) : base(paramGeoPoint, null)
	  {
		Bitmap = paramBitmap;
		Priority = 127;
	  }

	  public int a()
	  {
		return this.y;
	  }

	  internal void a(bool paramBoolean)
	  {
		this.t = paramBoolean;
	  }

	  internal bool b()
	  {
		return this.t;
	  }

	  public int Align
	  {
		  get
		  {
			return this.u;
		  }
		  set
		  {
			this.u = value;
			a(true);
		  }
	  }

	  public OnBalloonListener OnBalloonListener
	  {
		  get
		  {
			return this.w;
		  }
		  set
		  {
			this.w = value;
		  }
	  }

	  public OverlayItem OverlayItem
	  {
		  get
		  {
			return this.x;
		  }
		  set
		  {
			this.x = value;
		  }
	  }

	  public string Text
	  {
		  get
		  {
			return this.v;
		  }
		  set
		  {
			this.v = value;
			a(true);
		  }
	  }


	  public override Bitmap Bitmap
	  {
		  set
		  {
			base.Bitmap = value;
			a(true);
		  }
	  }



	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\balloon\BalloonItem.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}