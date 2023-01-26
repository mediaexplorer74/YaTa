using System;

using ProgressDialog = android.app.ProgressDialog;
using Context = android.content.Context;
using Intent = android.content.Intent;
using SharedPreferences = android.content.SharedPreferences;
using AsyncTask = android.os.AsyncTask;
using Bundle = android.os.Bundle;
using Log = android.util.Log;
using Utils = ru.yandex.taxi.Utils;
using ConfirmActivity = ru.yandex.taxi.activity.ConfirmActivity;
using SimpleResponse = ru.yandex.taxi.client.response.SimpleResponse;

public class gn : AsyncTask<int, int, int>
{
  private ProgressDialog b;

  private string c;

  private string d;

  private DateTime e;

  private gn(ConfirmActivity paramConfirmActivity, sbyte paramByte)
  {
  }

  protected internal virtual int? a()
  {
	bool @bool;
	try
	{
	  SharedPreferences.Editor editor;
	  SimpleResponse simpleResponse = ConfirmActivity.d(this.a).doAuthConfirm(ConfirmActivity.b(this.a), ConfirmActivity.c(this.a).getText().ToString());
	  if (simpleResponse.Code == 200)
	  {
		if ("1".Equals(simpleResponse.Data["authorized"]))
		{
		  editor = ConfirmActivity.e(this.a).edit();
		  editor.putBoolean("authorized", true);
		  editor.putString("phone number", ConfirmActivity.f(this.a));
		  editor.commit();
		  bool bool1 = false;
		  return Convert.ToInt32(bool1);
		}
		this.c = (string)editor.getData().get("block_time");
		this.d = (string)editor.getData().get("attempts_left");
		sbyte b = 2;
		return Convert.ToInt32(b);
	  }
	  if (editor.isBlocked())
	  {
		this.e = editor.getBlockDate();
		sbyte b = 3;
		return Convert.ToInt32(b);
	  }
	  @bool = true;
	}
	catch (Exception exception)
	{
	  Log.e("ConfirmActivity", "Fail request auth from server", exception);
	  @bool = true;
	}
	return Convert.ToInt32(@bool);
  }

  protected internal virtual void a(int? paramInteger)
  {
	Bundle bundle;
	Intent intent;
	this.b.dismiss();
	switch (paramInteger.Value)
	{
	  default:
		if (paramInteger.Value == 0)
		{
		  this.a.showDialog(2);
		  return;
		}
		break;
	  case 3:
		intent = new Intent();
		bundle = new Bundle();
		bundle.putSerializable("release date", this.e);
		intent.putExtras(bundle);
		this.a.setResult(1, intent);
		this.a.finish();
		return;
	}
	if ("0".Equals(this.d))
	{
	  ConfirmActivity.a(this.a, String.format(this.a.getResources().getString(2131296516), new object[] {this.c}));
	}
	else if (string.ReferenceEquals(this.d, null))
	{
	  ConfirmActivity.a(this.a, this.a.getResources().getString(2131296518));
	}
	else
	{
	  ConfirmActivity.a(this.a, String.format(this.a.getResources().getString(2131296517), new object[] {Utils.getWord(this.a.getResources().getStringArray(2131165193), Convert.ToInt32(this.d) + 1)}));
	}
	this.a.showDialog(1);
  }

  protected internal virtual void onPreExecute()
  {
	this.b = ProgressDialog.show((Context)this.a, "", this.a.getResources().getString(2131296505), true);
	this.b.show();
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\gn.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */