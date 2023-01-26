using System;

using Context = android.content.Context;
using GestureDetector = android.view.GestureDetector;
using MotionEvent = android.view.MotionEvent;

public class aa : ab, GestureDetector.OnDoubleTapListener
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  protected internal bool a_Conflict = false;

  protected internal bool b = false;

  protected internal long c;

  protected internal int d;

  protected internal int e;

  protected internal float f;

  protected internal float g;

  protected internal float h;

  protected internal float i;

  protected internal float j;

  internal int k;

  internal int l;

  internal bool m = false;

  public aa(Context paramContext, ac paramac) : base(paramContext, paramac)
  {
  }

  public override void a(MotionEvent paramMotionEvent)
  {
	this.e = paramMotionEvent.getPointerCount();
	if (this.e > this.d)
	{
	  this.d = this.e;
	}
	if (this.d >= 2 && this.e > 1)
	{
	  this.f = paramMotionEvent.getX(0);
	  this.g = paramMotionEvent.getY(0);
	  this.h = paramMotionEvent.getX(1);
	  this.i = paramMotionEvent.getY(1);
	}
	if (this.o == null)
	{
		;
	}
	if (!this.n.onTouchEvent(paramMotionEvent))
	{
	  float f1;
	  float f2;
	  switch (paramMotionEvent.getAction() & 0xFF)
	  {
		default:
		  switch (paramMotionEvent.getAction() & 0xFF)
		  {
			default:
			  return;
			case 1:
			  break;
		  }
		  this.d = 1;
			goto case 0;
		case 0:
		  this.u = 0.0F;
		  this.t = 0.0F;
		  this.q = true;
		  this.a_Conflict = false;
			goto case 5;
		case 5:
		  f1 = this.f - this.h;
		  f2 = this.g - this.i;
		  this.j = (float)Math.Sqrt((f1 * f1 + f2 * f2));
		  if (this.j == 0.0F)
		  {
			this.j = 1.0F;
		  }
		  f1 = (this.f + this.h) / 2.0F;
		  f2 = (this.g + this.i) / 2.0F;
		  this.o.c(f1, f2);
		  this.a_Conflict = true;
		  this.q = false;
		  this.c = DateTimeHelper.CurrentUnixTimeMillis();
		  this.b = true;
			goto case 2;
		case 2:
		  if (this.a_Conflict)
		  {
			f2 = this.f - this.h;
			f1 = this.g - this.i;
			float f = (float)Math.Sqrt((f2 * f2 + f1 * f1));
			f2 = (this.f + this.h) / 2.0F;
			f1 = (this.g + this.i) / 2.0F;
			f /= this.j;
			this.o.a(f2, f1, f);
			this.r = false;
			if (DateTimeHelper.CurrentUnixTimeMillis() - this.c > 250L)
			{
			  this.b = false;
			}
		  }
		  if (this.q)
		  {
			if (this.t == this.u && this.u == 0.0F)
			{
			  this.t = paramMotionEvent.getX();
			  this.u = paramMotionEvent.getY();
			}
			float f3 = paramMotionEvent.getX();
			float f4 = paramMotionEvent.getY();
			f1 = this.t;
			f2 = this.u;
			this.o.a(-(f3 - f1), -(f4 - f2), this.t, this.u);
			this.t = f3;
			this.u = f4;
			this.r = true;
		  }
			goto case 6;
		case 6:
		  this.a_Conflict = false;
		  this.q = true;
		  this.u = 0.0F;
		  this.t = 0.0F;
		  this.o.k();
			goto case 1;
		case 1:
		  break;
	  }
	  this.q = false;
	  this.d = 1;
	}
  }

  public virtual bool onDoubleTap(MotionEvent paramMotionEvent)
  {
	return true;
  }

  public virtual bool onDoubleTapEvent(MotionEvent paramMotionEvent)
  {
	int i;
	int j;
	switch (paramMotionEvent.getAction())
	{
	  default:
		return true;
	  case 0:
		this.k = (int)paramMotionEvent.getX();
		this.l = (int)paramMotionEvent.getY();
		this.m = true;
		this.v = true;
		return true;
	  case 2:
		i = (int)paramMotionEvent.getX();
		j = (int)paramMotionEvent.getY();
		if (!b.a(this.k - 5, this.l - 5, 10, 10, i, j))
		{
		  this.m = false;
		  this.v = true;
		}
		return false;
	  case 1:
		break;
	}
	if (this.m)
	{
	  this.s = true;
	  this.o.h(paramMotionEvent.getX(), paramMotionEvent.getY());
	}
	this.m = false;
	this.v = false;
	return true;
  }

  public override bool onDown(MotionEvent paramMotionEvent)
  {
	this.o.f(this.f, this.g);
	return false;
  }

  public override bool onFling(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	return this.r ? base.onFling(paramMotionEvent1, paramMotionEvent2, paramFloat1, paramFloat2) : true;
  }

  public override bool onScroll(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	return false;
  }

  public virtual bool onSingleTapConfirmed(MotionEvent paramMotionEvent)
  {
	return false;
  }

  public override bool onSingleTapUp(MotionEvent paramMotionEvent)
  {
	if (this.o != null)
	{
	  if (this.d == 2 && this.e == 1 && this.b)
	  {
		this.d = 1;
		float f1 = (this.f + this.h) / 2.0F;
		float f2 = (this.g + this.i) / 2.0F;
		this.o.a(f1, f2);
		return true;
	  }
	}
	else
	{
	  return true;
	}
	if (this.d == 1)
	{
	  float f2 = paramMotionEvent.getX();
	  float f1 = paramMotionEvent.getY();
	  this.o.d(f2, f1);
	}
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\aa.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */