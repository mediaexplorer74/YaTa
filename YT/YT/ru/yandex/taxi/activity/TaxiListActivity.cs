using System;
using System.Collections.Generic;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using ListActivity = android.app.ListActivity;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using Bundle = android.os.Bundle;
	using Parcelable = android.os.Parcelable;
	using View = android.view.View;
	using ListView = android.widget.ListView;
	using nw;
	using nx;
	using Park = ru.yandex.taxi.data.Park;
	using Requirements = ru.yandex.taxi.data.Requirements;
	using GeocodeJsonObject = ru.yandex.taxi.map.GeocodeJsonObject;
	using MapUtils = ru.yandex.taxi.map.MapUtils;
	using TaxiDialogFactory = ru.yandex.taxi.ui.dialog.TaxiDialogFactory;
	using CoordConversion = ru.yandex.yandexmapkit.utils.CoordConversion;

	public class TaxiListActivity : ListActivity
	{
	  public const string REQUIREMENTS = "requirements";

	  public const string WHEN = "when";

	  private Park a;

	  private GeocodeJsonObject b;

	  private GeocodeJsonObject c;

	  private Requirements d;

	  private DateTime e;

	  private List<string> f = new List<string>();

	  private List<Park> g = new List<Park>();

	  private string h;

	  private bool i;

	  private ListView j;

	  private bool k;

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		if (paramInt1 == 1 && paramInt2 == 10)
		{
		  finish();
		}
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		string str;
		base.onCreate(paramBundle);
		setContentView(2130903077);
		getWindow().setFormat(1);
		this.j = getListView();
		if (getIntent().getExtras() != null)
		{
		  this.b = (GeocodeJsonObject)getIntent().getParcelableExtra("src point");
		  this.c = (GeocodeJsonObject)getIntent().getParcelableExtra("dest point");
		  this.e = (DateTime)getIntent().getSerializableExtra("when");
		  this.d = (Requirements)getIntent().getSerializableExtra("requirements");
		}
		string[] arrayOfString = getResources().getStringArray(2131165185);
		this.f.AddRange(new List<string> {arrayOfString});
		if (this.b == null)
		{
		  str = "Москва";
		}
		else
		{
		  str = this.b.City;
		}
		this.h = str;
		if (this.b != null && this.b.GeoPoint != null && CoordConversion.getDistance(this.b.GeoPoint, MapUtils.DEFAULT_POINT) < 100000.0D)
		{
		  this.h = "Москва";
		}
		this.i = this.f.Contains(this.h);
		(new nx(this)).execute((object[])new int?[0]);
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		string str1;
		Dialog dialog = null;
		switch (paramInt)
		{
		  default:
			return dialog;
		  case 1:
			dialog = TaxiDialogFactory.createCallDialog(1, (Activity)this, getResources().getString(2131296316), String.format(getResources().getString(2131296317), new object[] {this.a.Name}), this.a.Phone);
			  goto case 2;
		  case 2:
			break;
		}
		AlertDialog.Builder builder1 = new AlertDialog.Builder((Context)this);
		AlertDialog.Builder builder2 = builder1.setCancelable(false).setTitle(2131296529);
		string str2 = getResources().getString(2131296530);
		if (this.b == null)
		{
		  str1 = "Москва";
		}
		else
		{
		  str1 = this.b.City;
		}
		builder2.setMessage(String.format(str2, new object[] {str1})).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new nw(this));
		AlertDialog alertDialog = builder1.create();
	  }

	  protected internal virtual void onListItemClick(ListView paramListView, View paramView, int paramInt, long paramLong)
	  {
		Park park = (Park)paramListView.getAdapter().getItem(paramInt);
		if (park != null)
		{
		  if (park != null && !string.ReferenceEquals(park.Phone, null) && !"null".Equals(park.Phone))
		  {
			paramInt = 1;
		  }
		  else
		  {
			paramInt = 0;
		  }
		  if (!park.OrderAllowed && paramInt != 0)
		  {
			this.a = park;
			showDialog(1);
			return;
		  }
		}
		else
		{
		  return;
		}
		if (park.OrderAllowed)
		{
		  Intent intent = new Intent((Context)this, typeof(ParkInfoActivity));
		  intent.putExtra("type", 1);
		  intent.putExtra("park id", park.ParkId);
		  intent.putExtra("src point", (Parcelable)this.b);
		  intent.putExtra("dest point", (Parcelable)this.c);
		  intent.putExtra("when", this.e);
		  intent.putExtra("requirements", (Serializable)this.d);
		  startActivityForResult(intent, 1);
		}
	  }

	  protected internal virtual void onStart()
	  {
		base.onStart();
		this.k = true;
	  }

	  protected internal virtual void onStop()
	  {
		this.k = false;
		base.onStop();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\TaxiListActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}