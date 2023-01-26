using Context = android.content.Context;
using DialogInterface = android.content.DialogInterface;
using Intent = android.content.Intent;
using Parcelable = android.os.Parcelable;
using EditAddressActivity = ru.yandex.taxi.activity.EditAddressActivity;
using SearchStreetActivity = ru.yandex.taxi.activity.SearchStreetActivity;
using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;

public class gs : DialogInterface.OnClickListener
{
  public gs(EditAddressActivity paramEditAddressActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	GeocodeJsonObject geocodeJsonObject = new GeocodeJsonObject();
	EditAddressActivity.a(this.a, geocodeJsonObject);
	Intent intent = new Intent((Context)this.a, typeof(SearchStreetActivity));
	intent.putExtra("type", EditAddressActivity.a(this.a));
	intent.putExtra("city name", geocodeJsonObject.City);
	intent.putExtra("select point", true);
	intent.putExtra("final select", true);
	intent.putExtra("init location", (Parcelable)EditAddressActivity.b(this.a));
	this.a.startActivityForResult(intent, 1);
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gs.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */