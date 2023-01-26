using Context = android.content.Context;
using Bitmap = android.graphics.Bitmap;
using BitmapFactory = android.graphics.BitmapFactory;
using Canvas = android.graphics.Canvas;
using LinearGradient = android.graphics.LinearGradient;
using Paint = android.graphics.Paint;
using Shader = android.graphics.Shader;
using AsyncTask = android.os.AsyncTask;
using ImageView = android.widget.ImageView;
using TaxiOnTheWayToSourceActivity = ru.yandex.taxi.activity.TaxiOnTheWayToSourceActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;

public class os : AsyncTask<string, Void, Bitmap>
{
  private readonly WeakReference<ImageView> b;

  public os(TaxiOnTheWayToSourceActivity paramTaxiOnTheWayToSourceActivity, ImageView paramImageView)
  {
	this.b = new WeakReference<ImageView>(paramImageView);
  }

  protected internal virtual Bitmap a(params string[] paramVarArgs)
  {
	return this.a.mDemoMode ? BitmapFactory.decodeResource(this.a.getResources(), 2130837552) : TaxiClient.downloadBitmap((Context)this.a, paramVarArgs[0]);
  }

  protected internal virtual void a(Bitmap paramBitmap)
  {
	if (isCancelled())
	{
	  paramBitmap = null;
	}
	if (this.b != null)
	{
	  ImageView imageView = this.b.get();
	  if (imageView != null)
	  {
		Bitmap bitmap1 = paramBitmap;
		if (paramBitmap == null)
		{
		  bitmap1 = BitmapFactory.decodeResource(this.a.getResources(), 2130837518);
		}
		Bitmap bitmap2 = Bitmap.createBitmap(bitmap1.getWidth(), bitmap1.getHeight() + 10, Bitmap.Config.ARGB_8888);
		Canvas canvas = new Canvas(bitmap2);
		Paint paint = new Paint();
		paint.setShader((Shader)new LinearGradient(0.0F, 10.0F, 0.0F, 0.0F, -1608375774, 0, Shader.TileMode.MIRROR));
		paint.setAntiAlias(true);
		canvas.drawRect(0.0F, 0.0F, bitmap1.getWidth(), 10.0F, paint);
		canvas.drawBitmap(bitmap1, 0.0F, 10.0F, new Paint());
		imageView.setImageBitmap(bitmap2);
	  }
	  imageView.setVisibility(0);
	}
	this.a.findViewById(2131558499).setVisibility(8);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\os.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */