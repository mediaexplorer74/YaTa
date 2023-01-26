namespace ru.yandex.core
{
	using Context = android.content.Context;
	using AttributeSet = android.util.AttributeSet;
	using MotionEvent = android.view.MotionEvent;
	using SurfaceHolder = android.view.SurfaceHolder;
	using SurfaceView = android.view.SurfaceView;

	public class KDView : SurfaceView, SurfaceHolder.Callback
	{
	  internal bool isSurfaceCreated = false;

	  public KDView(Context paramContext) : base(paramContext)
	  {
		init();
	  }

	  public KDView(Context paramContext, AttributeSet paramAttributeSet) : base(paramContext, paramAttributeSet)
	  {
		init();
	  }

	  private void init()
	  {
		getHolder().addCallback(this);
		getHolder().setType(2);
	  }

	  public virtual bool dispatchTouchEvent(MotionEvent paramMotionEvent)
	  {
		return CoreApplication.dispatchTouchEvent(paramMotionEvent) ? true : base.dispatchTouchEvent(paramMotionEvent);
	  }

	  public virtual void surfaceChanged(SurfaceHolder paramSurfaceHolder, int paramInt1, int paramInt2, int paramInt3)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: iconst_1
		//   3: newarray int
		//   5: dup
		//   6: iconst_0
		//   7: bipush #48
		//   9: iastore
		//   10: invokestatic sendEvent : ([I)V
		//   13: aload_0
		//   14: monitorexit
		//   15: return
		//   16: astore_1
		//   17: aload_0
		//   18: monitorexit
		//   19: aload_1
		//   20: athrow
		// Exception table:
		//   from	to	target	type
		//   2	13	16	finally
	  }

	  public virtual void surfaceCreated(SurfaceHolder paramSurfaceHolder)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: iconst_1
		//   4: putfield isSurfaceCreated : Z
		//   7: invokestatic tryResume : ()V
		//   10: aload_0
		//   11: monitorexit
		//   12: return
		//   13: astore_1
		//   14: aload_0
		//   15: monitorexit
		//   16: aload_1
		//   17: athrow
		// Exception table:
		//   from	to	target	type
		//   2	10	13	finally
	  }

	  public virtual void surfaceDestroyed(SurfaceHolder paramSurfaceHolder)
	  {
		// Byte code:
		//   0: aload_0
		//   1: monitorenter
		//   2: aload_0
		//   3: iconst_0
		//   4: putfield isSurfaceCreated : Z
		//   7: invokestatic tryPause : ()V
		//   10: aload_0
		//   11: monitorexit
		//   12: return
		//   13: astore_1
		//   14: aload_0
		//   15: monitorexit
		//   16: aload_1
		//   17: athrow
		// Exception table:
		//   from	to	target	type
		//   2	10	13	finally
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\KDView.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}