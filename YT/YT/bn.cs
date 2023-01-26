using Bitmap = android.graphics.Bitmap;
using Canvas = android.graphics.Canvas;
using Paint = android.graphics.Paint;
using IRender = ru.yandex.yandexmapkit.overlay.IRender;
using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
using MyLocationItem = ru.yandex.yandexmapkit.overlay.location.MyLocationItem;

public class bn : IRender
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  internal Paint a_Conflict = new Paint();

  internal Paint b;

  internal Paint c = new Paint(2);

  public bn()
  {
	this.a_Conflict.setColor(867934082);
	this.a_Conflict.setStyle(Paint.Style.FILL);
	this.a_Conflict.setAntiAlias(true);
	this.b = new Paint();
	this.b.setColor(-6913165);
	this.b.setStyle(Paint.Style.STROKE);
	this.b.setStrokeWidth(1.0F);
	this.b.setAntiAlias(true);
  }

  public virtual void a(Canvas paramCanvas, MyLocationItem paramMyLocationItem)
  {
	Bitmap bitmap;
	int i = -paramMyLocationItem.OffsetCenterX - paramMyLocationItem.OffsetX;
	int j = -paramMyLocationItem.OffsetCenterY - paramMyLocationItem.OffsetY;
	switch (paramMyLocationItem.Type)
	{
	  default:
		return;
	  case 1:
		paramCanvas.save();
		paramCanvas.rotate(paramMyLocationItem.Bearing, paramMyLocationItem.ScreenPoint.X, paramMyLocationItem.ScreenPoint.Y);
		bitmap = paramMyLocationItem.Bitmap;
		f1 = paramMyLocationItem.ScreenPoint.X;
		f2 = i;
		f3 = paramMyLocationItem.ScreenPoint.Y;
		paramCanvas.drawBitmap(bitmap, f2 + f1, j + f3, this.c);
		paramCanvas.restore();
		  goto case 2;
	  case 2:
		bitmap = paramMyLocationItem.Bitmap;
		f3 = paramMyLocationItem.ScreenPoint.X;
		f1 = i;
		f2 = paramMyLocationItem.ScreenPoint.Y;
		paramCanvas.drawBitmap(bitmap, f1 + f3, j + f2, this.c);
		  goto case 3;
	  case 3:
		break;
	}
	float f2 = ((bo)paramMyLocationItem).a();
	float f1 = paramMyLocationItem.ScreenPoint.X;
	float f3 = paramMyLocationItem.ScreenPoint.Y;
	paramCanvas.drawCircle(f1, f3, f2, this.a_Conflict);
	paramCanvas.drawCircle(f1, f3, f2, this.b);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\bn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */