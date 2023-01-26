using System;

namespace ru.yandex.taxi.map
{
	using Bitmap = android.graphics.Bitmap;
	using Canvas = android.graphics.Canvas;
	using Matrix = android.graphics.Matrix;
	using Paint = android.graphics.Paint;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using OverlayIRender = ru.yandex.yandexmapkit.overlay.OverlayIRender;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class RadarRender : OverlayIRender
	{
	  private int a;

	  private Bitmap b;

	  private Bitmap c;

	  private MapController d;

	  private GeoPoint e;

	  protected internal int mBitmapHeight;

	  protected internal int mBitmapWidth;

	  protected internal Paint mImgPaint;

	  protected internal float mLastZoom = 0.0F;

	  protected internal double mRadarMetersRadius;

	  protected internal int mRadarRadius;

	  protected internal int mRotateDegree = 5;

	  public RadarRender(MapView paramMapView, GeoPoint paramGeoPoint, Bitmap paramBitmap1, Bitmap paramBitmap2, int paramInt)
	  {
		this.d = paramMapView.MapController;
		this.e = paramGeoPoint;
		this.b = paramBitmap1;
		this.c = paramBitmap2;
		this.a = paramInt;
		this.mBitmapWidth = this.c.getWidth();
		this.mBitmapHeight = this.c.getHeight();
		this.mRadarRadius = this.mBitmapWidth / 2 - this.a;
		this.mImgPaint = new Paint();
	  }

	  public virtual int compareTo(object paramObject)
	  {
		return 0;
	  }

	  public override void draw(Canvas paramCanvas, OverlayItem paramOverlayItem)
	  {
		ScreenPoint screenPoint = this.d.getScreenPoint(paramOverlayItem.GeoPoint);
		Matrix matrix = new Matrix();
		this.mRotateDegree = (this.mRotateDegree + 5) % 360;
		matrix.postRotate(this.mRotateDegree);
		Bitmap bitmap = Bitmap.createBitmap(this.c, 0, 0, this.mBitmapWidth, this.mBitmapHeight, matrix, true);
		paramCanvas.drawBitmap(this.b, screenPoint.X - (this.b.getWidth() / 2), screenPoint.Y - (this.b.getHeight() / 2), this.mImgPaint);
		paramCanvas.drawBitmap(bitmap, screenPoint.X - (bitmap.getWidth() / 2), screenPoint.Y - (bitmap.getHeight() / 2), this.mImgPaint);
		GeoPoint geoPoint = this.d.getGeoPoint(new ScreenPoint(screenPoint.X + (this.mBitmapWidth / 2), screenPoint.Y));
		this.mRadarMetersRadius = CoordConversion.getDistance(paramOverlayItem.GeoPoint, geoPoint) / 1000.0D;
		paramCanvas.drawText(string.Format("{0,1:F1} км", new object[] {Convert.ToDouble(this.mRadarMetersRadius)}), screenPoint.X + (this.mBitmapWidth / 2), screenPoint.Y, this.mImgPaint);
	  }

	  public virtual double Radius
	  {
		  get
		  {
			return this.mRadarMetersRadius;
		  }
	  }

	  public virtual bool isCarInside(int paramInt1, int paramInt2)
	  {
		ScreenPoint screenPoint = this.d.getScreenPoint(this.e);
		paramInt1 = Math.Abs(paramInt1 - (int)screenPoint.X);
		paramInt2 = Math.Abs(paramInt2 - (int)screenPoint.Y);
		return (this.mRadarRadius > Math.Sqrt((paramInt2 * paramInt2 + paramInt1 * paramInt1)));
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\map\RadarRender.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}