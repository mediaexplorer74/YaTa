using System;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Resources = android.content.res.Resources;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using Log = android.util.Log;
	using KeyEvent = android.view.KeyEvent;
	using View = android.view.View;
	using Button = android.widget.Button;
	using EditText = android.widget.EditText;
	using nj;
	using nk;
	using nl;
	using nm;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;
	using ErrorUtils = ru.yandex.taxi.error.ErrorUtils;
	using DragAndDropOverlay = ru.yandex.taxi.map.DragAndDropOverlay;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using MapView = ru.yandex.yandexmapkit.MapView;
	using OverlayManager = ru.yandex.yandexmapkit.OverlayManager;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;
	using DragAndDropItem = ru.yandex.yandexmapkit.overlay.drag.DragAndDropItem;
	using GeoPoint = ru.yandex.yandexmapkit.utils.GeoPoint;

	public class SelectPointActivity : Activity
	{
	  public const string INIT_LOCATION = "init location";

	  public const int RESULT_EDIT = 1;

	  public const int RESULT_POINT_SELECTED = 2;

	  public const int RESULT_TRANSIT = 3;

	  public const string SELECTED_LOCATION = "selected location";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private static SelectPointActivity a_Conflict;

	  private GeoPoint b;

	  private DragAndDropOverlay c;

	  private GeocodeJsonObject d;

	  private TaxiClient e;

	  private nl f;

	  private int g;

	  private MapView h;

	  private MapController i;

	  private OverlayManager j;

	  private EditText k;

	  private View l;

	  private Button m;

	  private void a(int paramInt)
	  {
		if (this.d != null)
		{
		  Intent intent = new Intent();
		  intent.putExtra("selected location", (Parcelable)this.d);
		  setResult(paramInt, intent);
		  return;
		}
		setResult(0);
	  }

	  public static SelectPointActivity Instance
	  {
		  get
		  {
			return a_Conflict;
		  }
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		switch (paramInt1)
		{
		  default:
			return;
		  case 1:
			break;
		}
		if (paramInt2 == -1 || paramInt2 == 3)
		{
		  setResult(3, paramIntent);
		  finish();
		}
	  }

	  public virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903061);
		getWindow().setFormat(1);
		a_Conflict = this;
		this.h = (MapView)findViewById(2131558454);
		this.i = this.h.MapController;
		this.j = this.i.OverlayManager;
		this.h.showZoomButtons(true);
		this.h.showFindMeButton(true);
		this.h.showJamsButton(false);
		this.i.ZoomCurrent = 16.0F;
		this.k = (EditText)findViewById(2131558479);
		this.l = findViewById(2131558483);
		this.k.setFocusable(false);
		this.k.setOnTouchListener((View.OnTouchListener)new nj(this));
		this.m = (Button)findViewById(2131558484);
		this.m.setOnClickListener((View.OnClickListener)new nk(this));
		try
		{
		  GeoPoint geoPoint;
		  int i;
		  TaxiClient taxiClient = new TaxiClient();
		  Context context = getApplicationContext();
		  HttpUrlConnectionUtils httpUrlConnectionUtils = new HttpUrlConnectionUtils();
		  this();
		  this(context, (HttpUtils)httpUrlConnectionUtils);
		  this.e = taxiClient;
		  Bundle bundle = getIntent().getExtras();
		  if (bundle != null)
		  {
			if (bundle.containsKey("type"))
			{
			  this.g = bundle.getInt("type");
			}
			bundle.getBoolean("final select");
			this.b = (GeoPoint)bundle.getParcelable("init location");
		  }
		  if (this.b == null)
		  {
			GeocodeJsonObject geocodeJsonObject = MapUtils.getUserLocation((Context)this);
			if (geocodeJsonObject != null)
			{
			  geoPoint = geocodeJsonObject.GeoPoint;
			}
			else
			{
			  geoPoint = MapUtils.DEFAULT_POINT;
			}
		  }
		  else
		  {
			geoPoint = this.b;
		  }
		  DragAndDropOverlay dragAndDropOverlay1 = new DragAndDropOverlay();
		  this(this.i);
		  this.c = dragAndDropOverlay1;
		  DragAndDropItem dragAndDropItem = new DragAndDropItem();
		  Resources resources = getResources();
		  if (this.g == 0)
		  {
			i = 2130837507;
		  }
		  else
		  {
			i = 2130837508;
		  }
		  this(geoPoint, BitmapFactory.decodeResource(resources, i));
		  dragAndDropItem.Dragable = true;
		  dragAndDropItem.OffsetX = -dragAndDropItem.Bitmap.getWidth() / 4;
		  dragAndDropItem.OffsetY = dragAndDropItem.Bitmap.getHeight() / 2;
		  this.c.DragItem = dragAndDropItem;
		  this.c.addOverlayItem((OverlayItem)dragAndDropItem);
		  DragAndDropOverlay dragAndDropOverlay2 = this.c;
		  nm nm = new nm();
		  this(this);
		  dragAndDropOverlay2.OnDragListener = (DragAndDropOverlay.OnDragListener)nm;
		  this.j.addOverlay((Overlay)this.c);
		  this.i.PositionAnimationTo = geoPoint;
		  nl nl1 = new nl();
		  this(this);
		  nl1.execute((object[])new GeoPoint[] {geoPoint});
		}
		catch (Exception exception)
		{
		  Log.e("SelectPointActivity", "Fail init fields", exception);
		  ErrorUtils.showErrorMessage(getApplicationContext(), "Fail init application");
		}
	  }

	  protected internal virtual void onDestroy()
	  {
		a_Conflict = null;
		base.onDestroy();
	  }

	  public virtual bool onKeyDown(int paramInt, KeyEvent paramKeyEvent)
	  {
		switch (paramInt)
		{
		  default:
			return base.onKeyDown(paramInt, paramKeyEvent);
		  case 4:
			break;
		}
		a(0);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\SelectPointActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}