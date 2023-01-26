using Context = android.content.Context;
using GestureDetector = android.view.GestureDetector;
using MotionEvent = android.view.MotionEvent;
using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

public class ab : GestureDetector.OnGestureListener
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  private long a_Conflict;

  protected internal GestureDetector n;

  protected internal ac o;

  protected internal bool p = false;

  protected internal bool q = false;

  protected internal bool r = false;

  protected internal bool s = false;

  protected internal float t = 0.0F;

  protected internal float u = 0.0F;

  internal bool v = false;

  public ab(Context paramContext, ac paramac)
  {
	this.n = new GestureDetector(paramContext, this);
	this.o = paramac;
  }

  public virtual void a(MotionEvent paramMotionEvent)
  {
	if (this.o != null && !this.n.onTouchEvent(paramMotionEvent))
	{
	  switch (paramMotionEvent.getAction())
	  {
		case 0:
		case 0:
		  return;
		case 1:
		  if (this.p || this.q)
		  {
			float f1 = paramMotionEvent.getX();
			float f2 = paramMotionEvent.getY();
			this.o.g(f1, f2);
		  }
		  this.q = false;
		  this.p = false;
			goto case 2;
		case 2:
		  break;
	  }
	  if (this.p)
	  {
		float f2 = paramMotionEvent.getX();
		float f3 = paramMotionEvent.getY();
		float f1 = this.t;
		float f4 = this.u;
		this.q = true;
		this.o.a(f2 - f1, f3 - f4, this.t, this.u);
		this.t = f2;
		this.u = f3;
	  }
	}
  }

  public virtual bool onDown(MotionEvent paramMotionEvent)
  {
	float f1;
	float f2;
	if (this.o != null && !this.s)
	{
	  f1 = paramMotionEvent.getX();
	  f2 = paramMotionEvent.getY();
	  if (DateTimeHelper.CurrentUnixTimeMillis() - this.a_Conflict < 200L)
	  {
		this.s = true;
		this.o.h(paramMotionEvent.getX(), paramMotionEvent.getY());
		this.s = false;
		return true;
	  }
	}
	else
	{
	  this.s = false;
	  return true;
	}
	this.o.f(f1, f2);
	this.a_Conflict = DateTimeHelper.CurrentUnixTimeMillis();
	new GeoPoint(f1, f2);
	this.s = false;
	return true;
  }

  public virtual bool onFling(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	if (this.o != null)
	{
	  this.o.b(paramFloat1, paramFloat2);
	}
	return true;
  }

  public virtual void onLongPress(MotionEvent paramMotionEvent)
  {
	if (this.o != null && !this.v)
	{
	  float f1 = paramMotionEvent.getX();
	  float f2 = paramMotionEvent.getY();
	  this.o.e(f1, f2);
	  this.p = true;
	  this.t = f1;
	  this.u = f2;
	}
  }

  public virtual bool onScroll(MotionEvent paramMotionEvent1, MotionEvent paramMotionEvent2, float paramFloat1, float paramFloat2)
  {
	if (this.o != null)
	{
	  this.q = true;
	  this.o.a(paramFloat1, paramFloat2, paramMotionEvent1.getX(), paramMotionEvent1.getY());
	}
	return true;
  }

  public virtual void onShowPress(MotionEvent paramMotionEvent)
  {
  }

  public virtual bool onSingleTapUp(MotionEvent paramMotionEvent)
  {
	if (this.o != null)
	{
	  float f1 = paramMotionEvent.getX();
	  float f2 = paramMotionEvent.getY();
	  this.o.d(f1, f2);
	}
	return true;
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ab.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */