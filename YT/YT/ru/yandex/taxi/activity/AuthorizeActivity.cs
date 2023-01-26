using System;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using SharedPreferences = android.content.SharedPreferences;
	using Resources = android.content.res.Resources;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using TelephonyManager = android.telephony.TelephonyManager;
	using Html = android.text.Html;
	using TextWatcher = android.text.TextWatcher;
	using KeyEvent = android.view.KeyEvent;
	using View = android.view.View;
	using Button = android.widget.Button;
	using EditText = android.widget.EditText;
	using TextView = android.widget.TextView;
	using fq;
	using fr;
	using fs;
	using ft;
	using fu;
	using fv;
	using fw;
	using fx;
	using fy;
	using fz;
	using Utils = ru.yandex.taxi.Utils;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class AuthorizeActivity : Activity
	{
	  public const string BLOCK = "block";

	  public const string BLOCK_DEVICE = "id";

	  public const string BLOCK_NUMBER = "phone";

	  public const string BLOCK_TYPE = "block type";

	  public const string MAKE_ORDER = "make order";

	  public const string PREF_AUTHORIZED = "authorized";

	  public const string PREF_CLIENT_ID = "client id";

	  public const string PREF_LICENSE_ACCEPTED = "license accepted";

	  public const string PREF_PHONE_NUMBER = "phone number";

	  public const string RELEASE_DATE = "release date";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private TaxiClient a_Conflict;

	  private string b;

	  private SharedPreferences c;

	  private bool d;

	  private string e;

	  private DateTime f;

	  private bool g;

	  private string h;

	  private string i;

	  private Button j;

	  private EditText k;

	  private EditText l;

	  private TextView m;

	  private TextView n;

	  private Button o;

	  private void a()
	  {
		string str = "";
		if (this.f != null)
		{
		  SimpleDateFormat simpleDateFormat = new SimpleDateFormat("HH:mm dd MMMM yyyy", Utils.CurrentLocale);
		  str = "<br/>" + string.Format("<font color='red'>{0}</font>", new object[] {simpleDateFormat.format(this.f)});
		  if ("id".Equals(this.e))
		  {
			str = String.format(getResources().getString(2131296511), new object[] {str});
		  }
		  else
		  {
			string str1 = Utils.getFormatedPhoneNumber(this.c.getString("phone number", ""));
			string str2 = string.Format("<font color='red'>{0}</font>", new object[] {str1});
			string str3 = string.Format("<font color='red'>{0}</font>", new object[] {getResources().getString(2131296512)});
			str = String.format(getResources().getString(2131296509), new object[] {str2, str}) + "<br/>" + str3;
			this.o.setVisibility(0);
			this.o.setOnClickListener((View.OnClickListener)new fu(this, str1));
		  }
		}
		a(getResources().getString(2131296513), str);
	  }

	  private void a(string paramString1, string paramString2)
	  {
		setTitle(2131296488);
		if ("id".Equals(this.e))
		{
		  paramString1 = getResources().getString(2131296515);
		}
		paramString1 = string.Format("<font color='red'>{0}</font>", new object[] {paramString1});
		this.m.setText((CharSequence)Html.fromHtml(paramString1));
		this.n.setText((CharSequence)Html.fromHtml(paramString2));
		this.n.setVisibility(0);
		getWindow().setSoftInputMode(3);
	  }

	  protected internal virtual void onActivityResult(int paramInt1, int paramInt2, Intent paramIntent)
	  {
		string str;
		switch (paramInt2)
		{
		  default:
			return;
		  case -1:
			setResult(-1);
			finish();
			  goto case 1;
		  case 1:
			this.f = (DateTime)paramIntent.getExtras().getSerializable("release date");
			str = "";
			if (this.f != null)
			{
			  SimpleDateFormat simpleDateFormat = new SimpleDateFormat("HH:mm dd MMMM yyyy", Utils.CurrentLocale);
			  str = "<br/>" + string.Format("<font color='red'>{0}</font>", new object[] {simpleDateFormat.format(this.f)});
			  if ("id".Equals(this.e))
			  {
				paramInt1 = 2131296511;
			  }
			  else
			  {
				paramInt1 = 2131296510;
			  }
			  str = String.format(getResources().getString(paramInt1), new object[] {str});
			}
			a(getResources().getString(2131296514), str);
			this.m.setVisibility(8);
			this.k.setVisibility(8);
			this.l.setVisibility(8);
			findViewById(2131558400).setVisibility(8);
			  goto case 2;
		  case 2:
			break;
		}
		setResult(paramInt2);
		finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903040);
		getWindow().setFormat(1);
		this.a_Conflict = new TaxiClient(getApplicationContext(), (HttpUtils)new HttpUrlConnectionUtils());
		this.c = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
		this.b = this.c.getString("client id", null);
		paramBundle = getIntent().getExtras();
		if (paramBundle != null)
		{
		  this.d = paramBundle.getBoolean("block");
		  this.e = paramBundle.getString("block type");
		  this.f = (DateTime)paramBundle.getSerializable("release date");
		  this.g = paramBundle.getBoolean("make order");
		}
		if (!this.d)
		{
		  getWindow().setSoftInputMode(5);
		}
		this.h = Utils.getPureNumber(((TelephonyManager)getSystemService("phone")).getLine1Number());
		this.j = (Button)findViewById(2131558406);
		this.k = (EditText)findViewById(2131558402);
		this.m = (TextView)findViewById(2131558401);
		this.n = (TextView)findViewById(2131558404);
		this.l = (EditText)findViewById(2131558403);
		this.o = (Button)findViewById(2131558405);
		this.j.setEnabled(false);
		this.j.setText(2131296494);
		this.j.setOnClickListener((View.OnClickListener)new fq(this));
		this.k.setHint(2131296490);
		this.k.setGravity(19);
		this.k.setCompoundDrawablesWithIntrinsicBounds(2130837619, 0, 0, 0);
		this.k.setImeOptions(5);
		this.k.setNextFocusDownId(2131558403);
		this.l.setVisibility(0);
		if (this.d)
		{
		  a();
		}
		else
		{
		  this.m.setText(2131296497);
		}
		this.k.addTextChangedListener((TextWatcher)new fs(this));
		this.k.setOnKeyListener((View.OnKeyListener)new ft(this));
		if (!string.ReferenceEquals(this.h, null) && !"".Equals(this.h))
		{
		  this.k.setText(this.h);
		}
		this.c.getBoolean("license accepted", false);
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		AlertDialog.Builder builder;
		AlertDialog alertDialog;
		string str;
		Dialog dialog2 = null;
		switch (paramInt)
		{
		  default:
			return dialog2;
		  case 1:
			builder = new AlertDialog.Builder((Context)this);
			str = String.format(getResources().getString(2131296506), new object[] {Utils.getFormatedPhoneNumber(this.k.getText().ToString())});
			builder.setTitle(2131296507).setMessage(str).setPositiveButton(2131296276, (DialogInterface.OnClickListener)new fr(this)).setNegativeButton(2131296277, (DialogInterface.OnClickListener)new fz(this));
			alertDialog = builder.create();
			  goto case 2;
		  case 2:
			break;
		}
		Dialog dialog1 = new Dialog((Context)this);
		dialog1.setOnCancelListener((DialogInterface.OnCancelListener)new fv(this));
		Resources resources = getResources();
		dialog1.setContentView(2130903063);
		dialog1.setTitle(2131296478);
		((TextView)dialog1.findViewById(2131558401)).setText(2131296519);
		dialog1.findViewById(2131558448).setVisibility(8);
		Button button = (Button)dialog1.findViewById(2131558486);
		button.setText(2131296478);
		button.setOnClickListener((View.OnClickListener)new fw(this, resources));
		button = (Button)dialog1.findViewById(2131558487);
		button.setText(2131296520);
		button.setOnClickListener((View.OnClickListener)new fx(this));
		((Button)dialog1.findViewById(2131558415)).setOnClickListener((View.OnClickListener)new fy(this));
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
		setResult(0);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\AuthorizeActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}