namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using IntentFilter = android.content.IntentFilter;
	using SharedPreferences = android.content.SharedPreferences;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using Html = android.text.Html;
	using TextWatcher = android.text.TextWatcher;
	using KeyEvent = android.view.KeyEvent;
	using View = android.view.View;
	using Button = android.widget.Button;
	using EditText = android.widget.EditText;
	using TextView = android.widget.TextView;
	using gg;
	using gh;
	using gi;
	using gj;
	using gk;
	using gl;
	using gm;
	using Utils = ru.yandex.taxi.Utils;
	using HttpUrlConnectionUtils = ru.yandex.taxi.client.HttpUrlConnectionUtils;
	using HttpUtils = ru.yandex.taxi.client.HttpUtils;
	using TaxiClient = ru.yandex.taxi.client.TaxiClient;

	public class ConfirmActivity : Activity
	{
		private bool InstanceFieldsInitialized = false;

		public ConfirmActivity()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}
		}

		private void InitializeInstanceFields()
		{
			e = new ConfirmActivity$SmsReceiver(this);
		}

	  public const string PHONE = "phone";

	  public const int RESULT_BLOCK = 1;

	  public const int RESULT_CANCEL_ORDER = 2;

	  private TaxiClient a;

	  private string b;

	  private string c;

	  private SharedPreferences d;

	  private ConfirmActivity$SmsReceiver e;

	  private string f;

	  private bool g;

	  private Button h;

	  private EditText i;

	  private TextView j;

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		int i;
		base.onCreate(paramBundle);
		setContentView(2130903040);
		getWindow().setFormat(1);
		this.a = new TaxiClient((Context)this, (HttpUtils)new HttpUrlConnectionUtils());
		this.d = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
		this.b = this.d.getString("client id", null);
		this.d.edit().putBoolean("authorized", false).commit();
		paramBundle = getIntent().getExtras();
		if (paramBundle != null)
		{
		  this.f = paramBundle.getString("phone");
		  this.g = paramBundle.getBoolean("make order");
		}
		this.h = (Button)findViewById(2131558406);
		this.i = (EditText)findViewById(2131558402);
		this.j = (TextView)findViewById(2131558401);
		findViewById(2131558404);
		Button button = this.h;
		if (this.g)
		{
		  i = 2131296404;
		}
		else
		{
		  i = 2131296493;
		}
		button.setText(i);
		this.h.setOnClickListener((View.OnClickListener)new gg(this));
		string str = getResources().getString(2131296498);
		this.j.setText((CharSequence)Html.fromHtml(String.format(str, new object[] {"<br/><font color='white'>" + Utils.getFormatedPhoneNumber(this.f) + "</font>"})));
		this.h.setEnabled(false);
		this.i.setOnKeyListener((View.OnKeyListener)new gh(this));
		this.i.addTextChangedListener((TextWatcher)new gi(this));
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		AlertDialog.Builder builder2;
		AlertDialog alertDialog3;
		string str;
		AlertDialog alertDialog2;
		AlertDialog.Builder builder3;
		Dialog dialog = null;
		switch (paramInt)
		{
		  default:
			return dialog;
		  case 0:
			builder2 = new AlertDialog.Builder((Context)this);
			builder2.setTitle(2131296500).setMessage(2131296501).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new gm(this));
			alertDialog3 = builder2.create();
			  goto case 1;
		  case 1:
			str = this.c;
			builder3 = new AlertDialog.Builder((Context)this);
			builder3.setTitle(2131296508).setMessage(str).setPositiveButton(2131296278, (DialogInterface.OnClickListener)new gl(this));
			alertDialog2 = builder3.create();
			  goto case 2;
		  case 2:
			break;
		}
		AlertDialog.Builder builder1 = new AlertDialog.Builder((Context)this);
		builder1.setTitle(2131296522).setMessage(2131296521).setPositiveButton(2131296404, (DialogInterface.OnClickListener)new gk(this)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new gj(this));
		AlertDialog alertDialog1 = builder1.create();
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

	  protected internal virtual void onStart()
	  {
		base.onStart();
		IntentFilter intentFilter = new IntentFilter("android.provider.Telephony.SMS_RECEIVED");
		registerReceiver(this.e, intentFilter);
	  }

	  protected internal virtual void onStop()
	  {
		unregisterReceiver(this.e);
		base.onStop();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\ConfirmActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}