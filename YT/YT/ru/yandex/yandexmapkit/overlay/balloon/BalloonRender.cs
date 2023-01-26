using System;
using System.Collections.Generic;

namespace ru.yandex.yandexmapkit.overlay.balloon
{
	using Context = android.content.Context;
	using Resources = android.content.res.Resources;
	using Bitmap = android.graphics.Bitmap;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Canvas = android.graphics.Canvas;
	using NinePatch = android.graphics.NinePatch;
	using Paint = android.graphics.Paint;
	using RectF = android.graphics.RectF;
	using TextPaint = android.text.TextPaint;
	using bw;
	using IRender = ru.yandex.yandexmapkit.overlay.IRender;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class BalloonRender : IRender
	{
	  public const int ALIGN_BOTTOM = 8;

	  public const int ALIGN_CENTER = 1;

	  public const int ALIGN_LEFT = 4;

	  public const int ALIGN_RIGHT = 16;

	  public const int ALIGN_TOP = 2;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  public static int d_Conflict = 8;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal int a_Conflict = 50;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal int b_Conflict = 15;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  internal int c_Conflict = 15;

	  private NinePatch e;

	  private Bitmap f;

	  private float g;

	  private RectF h;

	  private TextPaint i;

	  private TextPaint j;

	  private TextPaint k;

	  private TextPaint l;

	  public BalloonRender(Context paramContext)
	  {
		Resources resources = paramContext.getResources();
		try
		{
		  this.g = (resources.getDisplayMetrics()).density;
		}
		catch (Exception)
		{
		  this.g = 1.0F;
		}
		Bitmap bitmap = BitmapFactory.decodeResource(resources, resources.getIdentifier("balloon_black", "drawable", paramContext.getPackageName()));
		this.e = new NinePatch(bitmap, bitmap.getNinePatchChunk(), null);
		this.f = BitmapFactory.decodeResource(resources, resources.getIdentifier("balloon_tail_black", "drawable", paramContext.getPackageName()));
		new Paint();
		this.i = new TextPaint();
		this.i.setColor(-1);
		this.i.setAntiAlias(true);
		this.i.setShadowLayer(0.1F, 0.0F, -1.0F, -16777216);
		this.j = new TextPaint();
		this.j.setColor(-1);
		this.j.setAntiAlias(true);
		this.j.setFakeBoldText(true);
		this.k = new TextPaint();
		this.k.setColor(-15981982);
		this.k.setAntiAlias(true);
		this.l = new TextPaint();
		this.l.setColor(-6710887);
		this.l.setAntiAlias(true);
		this.i.setTextSize(this.g * 18.0F);
		this.j.setTextSize(this.g * 18.0F);
		this.k.setTextSize(14.0F * this.g);
		this.l.setTextSize(this.g * 18.0F);
		this.b_Conflict = this.f.getHeight();
		this.c_Conflict = this.f.getWidth();
		this.a_Conflict = (int)(this.a_Conflict * this.g);
	  }

	  public virtual float a()
	  {
		return this.g;
	  }

	  public virtual void a(Canvas paramCanvas, BalloonItem paramBalloonItem)
	  {
		ScreenPoint screenPoint = paramBalloonItem.ScreenPoint;
		int i = -paramBalloonItem.OffsetX - paramBalloonItem.OffsetCenterX;
		int j = -paramBalloonItem.OffsetY - paramBalloonItem.OffsetCenterY;
		this.h = new RectF(screenPoint.X + i - paramBalloonItem.s * paramBalloonItem.r / 100.0F, screenPoint.Y - this.b_Conflict + j - paramBalloonItem.k * paramBalloonItem.r / 100.0F, screenPoint.X + i + (paramBalloonItem.j - paramBalloonItem.s) * paramBalloonItem.r / 100.0F, screenPoint.Y - this.b_Conflict + j);
		this.e.draw(paramCanvas, this.h);
		Bitmap bitmap = this.f;
		float f = screenPoint.X;
		paramCanvas.drawBitmap(bitmap, i + f - (this.f.getWidth() >> 1), screenPoint.Y + j - this.f.getHeight(), null);
		if (!paramBalloonItem.q)
		{
		  i = 0;
		  Bitmap bitmap1 = paramBalloonItem.Bitmap;
		  if (bitmap1 != null)
		  {
			int m = paramBalloonItem.Align & 0xFE;
			int n = paramBalloonItem.Align & 0x1;
			if (m == 4)
			{
			  int i2 = bitmap1.getWidth();
			  float f1 = this.h.left;
			  f = this.h.top;
			  if (n == 1)
			  {
				j = (int)(this.h.height() - bitmap1.getHeight()) >> 1;
			  }
			  else
			  {
				j = 4;
			  }
			  paramCanvas.drawBitmap(bitmap1, 4.0F + f1, j + f, (Paint)this.i);
			  j = i2;
			}
			else
			{
			  j = 0;
			}
			if (m == 2)
			{
			  int i2 = bitmap1.getHeight();
			  f = this.h.left;
			  if (n == 1)
			  {
				i = (int)(this.h.width() - bitmap1.getWidth()) >> 1;
			  }
			  else
			  {
				i = 4;
			  }
			  paramCanvas.drawBitmap(bitmap1, i + f, this.h.top + 4.0F, (Paint)this.i);
			  i = i2;
			}
			int i1 = i;
			i = j;
			j = i1;
		  }
		  else
		  {
			j = 0;
			i = 0;
		  }
		  int k;
		  for (k = 0; k < paramBalloonItem.m; k++)
		  {
			List<bw> arrayList = paramBalloonItem.l[k];
			int m = arrayList.Count;
			for (sbyte b = 0; b < m; b++)
			{
			  TextPaint textPaint1;
			  bw bw = arrayList[b];
			  if (bw.a_Conflict == 0)
			  {
				if (bw.c == 0)
				{
				  textPaint1 = this.i;
				}
				else
				{
				  textPaint1 = this.j;
				}
			  }
			  else
			  {
				textPaint1 = this.k;
			  }
			  TextPaint textPaint2 = textPaint1;
			  if (paramBalloonItem.o)
			  {
				textPaint2 = new TextPaint((Paint)textPaint1);
				textPaint2.setColor(-6710887);
			  }
			  paramCanvas.drawText(bw.d, bw.b + this.h.left + i + 5.0F * this.g, this.h.top + j + k * (paramBalloonItem.i + paramBalloonItem.n) - this.j.ascent() - 3.0F + 8.0F, (Paint)textPaint2);
			}
		  }
		  if (bitmap1 != null)
		  {
			k = paramBalloonItem.Align & 0xFE;
			i = paramBalloonItem.Align & 0x1;
			if (k == 16)
			{
			  float f2 = this.h.left;
			  f = this.h.width();
			  float f1 = bitmap1.getWidth();
			  float f3 = this.h.top;
			  if (i == 1)
			  {
				j = (int)(this.h.height() - bitmap1.getHeight()) >> 1;
			  }
			  else
			  {
				j = 4;
			  }
			  paramCanvas.drawBitmap(bitmap1, f - f1 - 4.0F + f2, j + f3, (Paint)this.i);
			}
			if (k == 8)
			{
			  f = this.h.left;
			  if (i == 1)
			  {
				j = (int)(this.h.width() - bitmap1.getWidth()) >> 1;
			  }
			  else
			  {
				j = 4;
			  }
			  paramCanvas.drawBitmap(bitmap1, j + f, this.h.top + this.h.height() - bitmap1.getHeight() - 4.0F, (Paint)this.i);
			}
		  }
		}
	  }

	  public virtual TextPaint b()
	  {
		return this.i;
	  }

	  public virtual TextPaint c()
	  {
		return this.j;
	  }

	  public virtual TextPaint d()
	  {
		return this.k;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\balloon\BalloonRender.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}