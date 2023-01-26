using System;
using System.Text;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using AsyncTask = android.os.AsyncTask;
using Log = android.util.Log;
using Toast = android.widget.Toast;
using Utils = ru.yandex.taxi.Utils;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;
using TaxiClient = ru.yandex.taxi.client.TaxiClient;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;

public class ga : AsyncTask<int, int, bool>
{
  private ProgressDialog b;

  private bool c;

  private ga(AuthorizeActivity paramAuthorizeActivity, sbyte paramByte)
  {
  }

  protected internal virtual bool? a()
  {
	bool bool2;
	bool bool1 = false;
	try
	{
	  TaxiClient taxiClient = AuthorizeActivity.e(this.a);
	  string str = AuthorizeActivity.b(this.a);
	  StringBuilder stringBuilder = new StringBuilder();
	  this();
	  SimpleResponse simpleResponse = taxiClient.doAuth(str, stringBuilder.Append("+").Append(Utils.getPureNumber(AuthorizeActivity.c(this.a).getText().ToString())).ToString(), AuthorizeActivity.d(this.a).getText().ToString());
	  this.c = simpleResponse.Blocked;
	  AuthorizeActivity.a(this.a, simpleResponse.BlockDate);
	  AuthorizeActivity.a(this.a, simpleResponse.BlockType);
	  bool2 = bool1;
	  if (!simpleResponse.Blocked)
	  {
		int i = simpleResponse.Code;
		bool2 = bool1;
		if (i == 200)
		{
		  bool2 = true;
		}
	  }
	}
	catch (Exception exception)
	{
	  Log.e("AuthorizeActivity", "Fail request auth from server", exception);
	  bool2 = bool1;
	}
	return Convert.ToBoolean(bool2);
  }

  protected internal virtual void a(bool? paramBoolean)
  {
	this.b.dismiss();
	if (paramBoolean.Value && !this.c)
	{
	  AuthorizeActivity.f(this.a).edit().putBoolean("authorized", false).commit();
	  AuthorizeActivity.b(this.a, "+" + Utils.getPureNumber(AuthorizeActivity.c(this.a).getText().ToString()));
	  Intent intent = new Intent((Context)this.a, typeof(ConfirmActivity));
	  intent.putExtra("phone", AuthorizeActivity.g(this.a));
	  intent.putExtra("make order", AuthorizeActivity.h(this.a));
	  this.a.startActivityForResult(intent, 1);
	  return;
	}
	if (this.c)
	{
	  AuthorizeActivity.a(this.a).setEnabled(false);
	  AuthorizeActivity.i(this.a);
	  return;
	}
	Toast.makeText(this.a.getApplicationContext(), 2131296499, 0).show();
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296496), true);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ga.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */