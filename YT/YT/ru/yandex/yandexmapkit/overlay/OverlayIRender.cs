namespace ru.yandex.yandexmapkit.overlay
{
	using Bitmap = android.graphics.Bitmap;
	using Canvas = android.graphics.Canvas;
	using Paint = android.graphics.Paint;

	public class OverlayIRender : IRender
	{
	  public virtual void draw(Canvas paramCanvas, OverlayItem paramOverlayItem)
	  {
		int i = -paramOverlayItem.OffsetCenterX;
		int j = paramOverlayItem.OffsetX;
		int k = -paramOverlayItem.OffsetCenterY;
		int m = paramOverlayItem.OffsetY;
		Bitmap bitmap = paramOverlayItem.Bitmap;
		float f1 = paramOverlayItem.ScreenPoint.X;
		float f2 = (i - j);
		float f3 = paramOverlayItem.ScreenPoint.Y;
		paramCanvas.drawBitmap(bitmap, f2 + f1, (k - m) + f3, new Paint());
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\OverlayIRender.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}