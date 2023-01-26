namespace ru.yandex.yandexmapkit.overlay.balloon
{
	using Bitmap = android.graphics.Bitmap;
	using Paint = android.graphics.Paint;
	using MotionEvent = android.view.MotionEvent;
	using b;
	using bk;
	using ca;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;
	using ScreenPoint = ru.yandex.yandexmapkit.utils.ScreenPoint;

	public class BalloonOverlay : Overlay
	{
	  private bool d = false;

	  private BalloonItem e;

	  private BalloonRender f;

	  public BalloonOverlay(MapController paramMapController) : base(paramMapController)
	  {
		Priority = 127;
		this.f = new BalloonRender(paramMapController.l().getContext());
		IRender = this.f;
		this.e = new BalloonItem(new GeoPoint(0.0D, 0.0D), null);
		addOverlayItem(this.e);
	  }

	  private void a(BalloonItem paramBalloonItem)
	  {
		ca ca = new ca();
		ca.a(0);
		Paint[] arrayOfPaint = new Paint[2];
		arrayOfPaint[0] = (Paint)this.f.b();
		arrayOfPaint[1] = (Paint)this.f.c();
		int i = 0;
		int j = 0;
		Bitmap bitmap = paramBalloonItem.Bitmap;
		int k = paramBalloonItem.Align;
		float f = this.f.a();
		paramBalloonItem.m = 0;
		if (bitmap != null)
		{
		  int i1;
		  int i2;
		  string str;
		  switch (k & 0xFE)
		  {
			default:
			  k = bitmap.getHeight();
			  n = bitmap.getWidth();
			  i1 = n + 16;
			  i2 = k + 8;
			  k = i;
			  n = j;
			  i = i2;
			  j = i1;
			  str = paramBalloonItem.Text;
				goto case 2;
			case 2:
			case 8:
			  i = bitmap.getHeight();
				goto case 4;
			case 4:
			case 16:
			  j = bitmap.getWidth();
		  break;
		  }
		  int n = j;
		  j = i;
		  i = n;
		}
		else
		{
		  bool @bool = false;
		  j = 0;
		  k = 0;
		  i = 0;
		  string str = paramBalloonItem.Text;
		}
		int m = j;
		if (j < k)
		{
		  m = k + 8;
		}
		j = this.f.c_Conflict << 1;
		if (i < j)
		{
		  i = j;
		}
		j = i;
		if (bitmap != null)
		{
		  j = i;
		  if (i < bitmap.getWidth())
		  {
			j = bitmap.getWidth() + 8;
		  }
		}
		paramBalloonItem.j = j;
		paramBalloonItem.k = m;
		paramBalloonItem.s = paramBalloonItem.j - ((int)(15.0F * f) << 1);
	  }

	  private bool a(BalloonItem paramBalloonItem, int paramInt1, int paramInt2)
	  {
		ScreenPoint screenPoint = paramBalloonItem.ScreenPoint;
		int i = -paramBalloonItem.OffsetY - paramBalloonItem.OffsetCenterY;
		int j = -paramBalloonItem.OffsetX - paramBalloonItem.OffsetCenterX;
		int k = (int)screenPoint.X;
		int m = (int)screenPoint.Y;
		int n = k + j - paramBalloonItem.s;
		int i1 = m + i - paramBalloonItem.k - this.f.b_Conflict;
		return b.a(n, i1, j + k + paramBalloonItem.j - paramBalloonItem.s - n, i + m - this.f.b_Conflict - i1, paramInt1, paramInt2);
	  }

	  private void b(BalloonItem paramBalloonItem)
	  {
		// Byte code:
		//   0: iconst_0
		//   1: istore_2
		//   2: iconst_1
		//   3: istore_3
		//   4: aload_0
		//   5: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   8: aload_1
		//   9: invokevirtual getPoint : ()Lby;
		//   12: invokevirtual getScreenPoint : (Lby;)Lru/yandex/yandexmapkit/utils/ScreenPoint;
		//   15: astore #4
		//   17: aload #4
		//   19: invokevirtual getX : ()F
		//   22: f2i
		//   23: aload_1
		//   24: invokevirtual getOffsetX : ()I
		//   27: isub
		//   28: aload_1
		//   29: invokevirtual getOffsetCenterX : ()I
		//   32: isub
		//   33: istore #5
		//   35: aload #4
		//   37: invokevirtual getY : ()F
		//   40: f2i
		//   41: aload_1
		//   42: invokevirtual getOffsetY : ()I
		//   45: isub
		//   46: aload_1
		//   47: invokevirtual getOffsetCenterY : ()I
		//   50: isub
		//   51: istore #6
		//   53: ldc 10.0
		//   55: aload_0
		//   56: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   59: invokevirtual a : ()F
		//   62: fmul
		//   63: f2i
		//   64: istore #7
		//   66: ldc 20.0
		//   68: aload_0
		//   69: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   72: invokevirtual a : ()F
		//   75: fmul
		//   76: f2i
		//   77: istore #8
		//   79: aload_0
		//   80: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   83: invokevirtual l : ()Landroid/view/View;
		//   86: invokevirtual getHeight : ()I
		//   89: iconst_1
		//   90: ishr
		//   91: istore #9
		//   93: aload_0
		//   94: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   97: invokevirtual l : ()Landroid/view/View;
		//   100: invokevirtual getWidth : ()I
		//   103: iconst_1
		//   104: ishr
		//   105: istore #10
		//   107: iload #6
		//   109: aload_1
		//   110: getfield k : I
		//   113: isub
		//   114: aload_0
		//   115: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   118: getfield b : I
		//   121: isub
		//   122: ifge -> 285
		//   125: iload #6
		//   127: aload_1
		//   128: getfield k : I
		//   131: isub
		//   132: aload_0
		//   133: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   136: getfield b : I
		//   139: isub
		//   140: iload #7
		//   142: isub
		//   143: iload #9
		//   145: iadd
		//   146: istore #9
		//   148: iconst_1
		//   149: istore_2
		//   150: aload_0
		//   151: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   154: invokevirtual l : ()Landroid/view/View;
		//   157: invokevirtual getWidth : ()I
		//   160: aload_0
		//   161: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   164: getfield a : I
		//   167: isub
		//   168: istore #6
		//   170: aload_1
		//   171: getfield j : I
		//   174: iconst_1
		//   175: ishr
		//   176: iload #5
		//   178: iadd
		//   179: iload #6
		//   181: iload #7
		//   183: isub
		//   184: if_icmple -> 367
		//   187: aload_1
		//   188: aload_1
		//   189: getfield j : I
		//   192: iload #6
		//   194: isub
		//   195: iload #5
		//   197: iadd
		//   198: iload #7
		//   200: iadd
		//   201: putfield s : I
		//   204: aload_1
		//   205: getfield s : I
		//   208: aload_1
		//   209: getfield j : I
		//   212: iload #8
		//   214: isub
		//   215: if_icmple -> 430
		//   218: aload_1
		//   219: aload_1
		//   220: getfield j : I
		//   223: iload #8
		//   225: isub
		//   226: putfield s : I
		//   229: aload_1
		//   230: getfield j : I
		//   233: iload #6
		//   235: isub
		//   236: iload #5
		//   238: iadd
		//   239: iload #7
		//   241: iadd
		//   242: aload_1
		//   243: getfield j : I
		//   246: iload #8
		//   248: isub
		//   249: isub
		//   250: iload #10
		//   252: iadd
		//   253: istore_2
		//   254: iload_3
		//   255: ifeq -> 284
		//   258: aload_0
		//   259: invokevirtual getMapController : ()Lru/yandex/yandexmapkit/MapController;
		//   262: aload_0
		//   263: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   266: new ru/yandex/yandexmapkit/utils/ScreenPoint
		//   269: dup
		//   270: iload_2
		//   271: i2f
		//   272: iload #9
		//   274: i2f
		//   275: invokespecial <init> : (FF)V
		//   278: invokevirtual get23Point : (Lru/yandex/yandexmapkit/utils/ScreenPoint;)Lby;
		//   281: invokevirtual a : (Lby;)V
		//   284: return
		//   285: iload #6
		//   287: aload_0
		//   288: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   291: invokevirtual l : ()Landroid/view/View;
		//   294: invokevirtual getHeight : ()I
		//   297: aload_0
		//   298: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   301: getfield c : I
		//   304: isub
		//   305: if_icmple -> 438
		//   308: aload_1
		//   309: invokevirtual getOverlayItem : ()Lru/yandex/yandexmapkit/overlay/OverlayItem;
		//   312: invokevirtual getBitmap : ()Landroid/graphics/Bitmap;
		//   315: ifnull -> 331
		//   318: aload_1
		//   319: invokevirtual getOverlayItem : ()Lru/yandex/yandexmapkit/overlay/OverlayItem;
		//   322: invokevirtual getBitmap : ()Landroid/graphics/Bitmap;
		//   325: invokevirtual getHeight : ()I
		//   328: iconst_1
		//   329: ishr
		//   330: istore_2
		//   331: iload_2
		//   332: iload #6
		//   334: aload_0
		//   335: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   338: invokevirtual l : ()Landroid/view/View;
		//   341: invokevirtual getHeight : ()I
		//   344: isub
		//   345: aload_0
		//   346: getfield f : Lru/yandex/yandexmapkit/overlay/balloon/BalloonRender;
		//   349: getfield c : I
		//   352: iadd
		//   353: iadd
		//   354: iload #7
		//   356: iadd
		//   357: iload #9
		//   359: iadd
		//   360: istore #9
		//   362: iconst_1
		//   363: istore_2
		//   364: goto -> 150
		//   367: iload #5
		//   369: aload_1
		//   370: getfield j : I
		//   373: iconst_1
		//   374: ishr
		//   375: isub
		//   376: iload #7
		//   378: if_icmpge -> 420
		//   381: aload_1
		//   382: iload #5
		//   384: iload #7
		//   386: isub
		//   387: putfield s : I
		//   390: aload_1
		//   391: getfield s : I
		//   394: iload #8
		//   396: if_icmpge -> 430
		//   399: aload_1
		//   400: iload #8
		//   402: putfield s : I
		//   405: iload #10
		//   407: iload #8
		//   409: iload #5
		//   411: iload #7
		//   413: isub
		//   414: isub
		//   415: isub
		//   416: istore_2
		//   417: goto -> 254
		//   420: aload_1
		//   421: aload_1
		//   422: getfield j : I
		//   425: iconst_1
		//   426: ishr
		//   427: putfield s : I
		//   430: iload_2
		//   431: istore_3
		//   432: iload #10
		//   434: istore_2
		//   435: goto -> 254
		//   438: iconst_0
		//   439: istore_2
		//   440: goto -> 150
	  }

	  public virtual BalloonItem BalloonItem
	  {
		  get
		  {
			return OverlayItems[0];
		  }
		  set
		  {
			if (Visible && value != null && value.Visible)
			{
			  this.a_Conflict.Clear();
			  addOverlayItem(value);
			  this.d = true;
			}
		  }
	  }

	  public override bool onTouchEvent(MotionEvent paramMotionEvent)
	  {
		// Byte code:
		//   0: aload_1
		//   1: invokevirtual getX : ()F
		//   4: f2i
		//   5: istore_2
		//   6: aload_1
		//   7: invokevirtual getY : ()F
		//   10: f2i
		//   11: istore_3
		//   12: aload_0
		//   13: invokevirtual getPrepareDrawList : ()Ljava/util/List;
		//   16: invokeinterface iterator : ()Ljava/util/Iterator;
		//   21: astore #4
		//   23: aload #4
		//   25: invokeinterface hasNext : ()Z
		//   30: ifeq -> 269
		//   33: aload #4
		//   35: invokeinterface next : ()Ljava/lang/Object;
		//   40: checkcast ru/yandex/yandexmapkit/overlay/OverlayItem
		//   43: checkcast ru/yandex/yandexmapkit/overlay/balloon/BalloonItem
		//   46: astore #5
		//   48: aload #5
		//   50: ifnull -> 23
		//   53: aload_0
		//   54: aload #5
		//   56: iload_2
		//   57: iload_3
		//   58: invokespecial a : (Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;II)Z
		//   61: istore #6
		//   63: aload_1
		//   64: invokevirtual getAction : ()I
		//   67: tableswitch default -> 92, 0 -> 95, 1 -> 140, 2 -> 199
		//   92: goto -> 23
		//   95: iload #6
		//   97: ifeq -> 125
		//   100: aload #5
		//   102: iconst_1
		//   103: putfield p : Z
		//   106: aload #5
		//   108: iconst_1
		//   109: putfield o : Z
		//   112: aload_0
		//   113: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   116: invokevirtual notifyRepaint : ()V
		//   119: iconst_1
		//   120: istore #6
		//   122: iload #6
		//   124: ireturn
		//   125: aload #5
		//   127: iconst_0
		//   128: putfield p : Z
		//   131: aload #5
		//   133: iconst_0
		//   134: putfield o : Z
		//   137: goto -> 23
		//   140: iload #6
		//   142: ifeq -> 199
		//   145: aload #5
		//   147: getfield p : Z
		//   150: ifeq -> 199
		//   153: aload #5
		//   155: iconst_0
		//   156: putfield p : Z
		//   159: aload #5
		//   161: iconst_0
		//   162: putfield o : Z
		//   165: aload_0
		//   166: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   169: invokevirtual notifyRepaint : ()V
		//   172: aload #5
		//   174: invokevirtual getOnBalloonListener : ()Lru/yandex/yandexmapkit/overlay/balloon/OnBalloonListener;
		//   177: ifnull -> 193
		//   180: aload #5
		//   182: invokevirtual getOnBalloonListener : ()Lru/yandex/yandexmapkit/overlay/balloon/OnBalloonListener;
		//   185: aload_1
		//   186: aload #5
		//   188: invokeinterface onBalloonClick : (Landroid/view/MotionEvent;Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;)V
		//   193: iconst_1
		//   194: istore #6
		//   196: goto -> 122
		//   199: aload #5
		//   201: getfield p : Z
		//   204: ifeq -> 23
		//   207: aload_0
		//   208: aload #5
		//   210: iload_2
		//   211: iload_3
		//   212: invokespecial a : (Lru/yandex/yandexmapkit/overlay/balloon/BalloonItem;II)Z
		//   215: ifeq -> 245
		//   218: aload #5
		//   220: getfield o : Z
		//   223: ifne -> 239
		//   226: aload #5
		//   228: iconst_1
		//   229: putfield o : Z
		//   232: aload_0
		//   233: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   236: invokevirtual notifyRepaint : ()V
		//   239: iconst_1
		//   240: istore #6
		//   242: goto -> 122
		//   245: aload #5
		//   247: getfield o : Z
		//   250: ifeq -> 239
		//   253: aload #5
		//   255: iconst_0
		//   256: putfield o : Z
		//   259: aload_0
		//   260: getfield c : Lru/yandex/yandexmapkit/MapController;
		//   263: invokevirtual notifyRepaint : ()V
		//   266: goto -> 239
		//   269: iconst_0
		//   270: istore #6
		//   272: goto -> 122
	  }

	  public override System.Collections.IList prepareDraw()
	  {
		this.b.Clear();
		if (!Visible)
		{
		  return this.b;
		}
		balloonItem = BalloonItem;
		if (this.d && balloonItem != null)
		{
		  this.d = false;
		  a(balloonItem);
		  b(balloonItem);
		  balloonItem.q = true;
		  balloonItem.r = 30.0F * this.f.a();
		  Timer timer = new Timer();
		  timer.schedule((TimerTask)new bk(this, balloonItem, timer), 0L, 10L);
		}
		else if (balloonItem != null && balloonItem.b())
		{
		  balloonItem.a(false);
		  a(balloonItem);
		  b(balloonItem);
		}
		foreach (BalloonItem balloonItem in this.a_Conflict)
		{
		  if (balloonItem.Visible && (balloonItem.Bitmap != null || (!string.ReferenceEquals(balloonItem.Text, null) && balloonItem.Text.Length != 0)))
		  {
			ScreenPoint screenPoint = this.c.getScreenPoint(balloonItem.Point);
			balloonItem.ScreenPoint = screenPoint;
			int i = -balloonItem.OffsetX - balloonItem.OffsetCenterX;
			int j = -balloonItem.OffsetY - balloonItem.OffsetCenterY;
			int k = (int)screenPoint.X;
			int m = (int)screenPoint.Y;
			int n = k + i - balloonItem.s;
			int i1 = m + j - balloonItem.k - this.f.b_Conflict;
			if (b.a(n, i1, i + k + balloonItem.j - balloonItem.s - n, j + m - i1, 0, 0, this.c.l().getWidth(), this.c.l().getHeight()))
			{
			  this.b.Add(balloonItem);
			}
		  }
		}
		return PrepareDrawList;
	  }

	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\yandexmapkit\overlay\balloon\BalloonOverlay.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}