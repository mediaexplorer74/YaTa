namespace ru.yandex.taxi.activity
{
	using Intent = android.content.Intent;
	using Bitmap = android.graphics.Bitmap;
	using BitmapFactory = android.graphics.BitmapFactory;
	using Bundle = android.os.Bundle;
	using Vibrator = android.os.Vibrator;
	using Log = android.util.Log;
	using Menu = android.view.Menu;
	using gp;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using MapController = ru.yandex.yandexmapkit.MapController;
	using Overlay = ru.yandex.yandexmapkit.overlay.Overlay;
	using OverlayItem = ru.yandex.yandexmapkit.overlay.OverlayItem;

	public class DelayOrderActivity : TaxiOnTheWayToSourceActivity
	{
	  public const string INIT = "init";

	  public const string PARK_ID = "park id";

	  public const string PARK_LOGO_URL = "park logo url";

	  public const string PARK_NAME = "park name";

	  public const string PARK_PHONE = "park phone";

	  public const string TARIFF_ID = "tariff id";

	  private Overlay a;

	  private gp b;

	  private bool c;

	  protected internal override void afterStartAction()
	  {
		this.b = new gp(this);
		this.b.Start();
	  }

	  protected internal override void beforeStopAction()
	  {
		this.b.Interrupt();
	  }

	  protected internal override void initOrderObjects()
	  {
		this.mSource = new Overlay(this.mMapController);
		Bitmap bitmap = BitmapFactory.decodeResource(this.mResources, 2130837507);
		OverlayItem overlayItem = new OverlayItem(this.mSrcAddress.GeoPoint, bitmap);
		overlayItem.OffsetX = -bitmap.getWidth() / 4;
		overlayItem.OffsetY = bitmap.getHeight() / 2;
		addAddressBalloon(this.mSrcAddress.GeoPoint, this.mSrcAddress.ShortAddress, overlayItem, false);
		this.mSource.addOverlayItem(overlayItem);
		this.mOverlayManager.addOverlay(this.mSource);
		if (this.mDestAddress != null && this.mDestAddress.GeoPoint != null)
		{
		  this.a = new Overlay(this.mMapController);
		  bitmap = BitmapFactory.decodeResource(this.mResources, 2130837508);
		  overlayItem = new OverlayItem(this.mDestAddress.GeoPoint, bitmap);
		  overlayItem.OffsetX = -bitmap.getWidth() / 4;
		  overlayItem.OffsetY = bitmap.getHeight() / 2;
		  addAddressBalloon(this.mDestAddress.GeoPoint, this.mDestAddress.ShortAddress, overlayItem, true);
		  this.a.addOverlayItem(overlayItem);
		  this.mOverlayManager.addOverlay(this.a);
		}
		this.mMapController.PositionNoAnimationTo = ((OverlayItem)this.mSource.OverlayItems[0]).GeoPoint;
		Bundle bundle = getIntent().getExtras();
		if (bundle != null)
		{
		  initTaxiInfoUi(bundle.getString("park id"), bundle.getString("park phone"), bundle.getString("park name"), bundle.getString("tariff id"), bundle.getString("park logo url"));
		  if (bundle.getBoolean("init", false))
		  {
			this.mDialogTitle = 2131296570;
			this.mDialogMsg = String.format(getResources().getString(2131296571), new object[] {this.mParkiName});
			showDialog(3);
		  }
		}
		this.mTaxiOnTheWayMode = false;
	  }

	  public override void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		this.mCurrentStatus = "pending";
	  }

	  public override bool onCreateOptionsMenu(Menu paramMenu)
	  {
		base.onCreateOptionsMenu(paramMenu);
		paramMenu.removeItem(4);
		return true;
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\DelayOrderActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}