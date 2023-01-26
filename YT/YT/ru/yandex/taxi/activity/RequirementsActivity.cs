using System.Collections.Generic;

namespace ru.yandex.taxi.activity
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using Intent = android.content.Intent;
	using Resources = android.content.res.Resources;
	using Bundle = android.os.Bundle;
	using PreferenceManager = android.preference.PreferenceManager;
	using Html = android.text.Html;
	using LayoutInflater = android.view.LayoutInflater;
	using View = android.view.View;
	using ViewGroup = android.view.ViewGroup;
	using ImageView = android.widget.ImageView;
	using LinearLayout = android.widget.LinearLayout;
	using TextView = android.widget.TextView;
	using lh;
	using li;
	using lj;
	using lk;
	using ll;
	using lm;
	using ln;
	using lo;
	using lp;
	using lq;
	using lr;
	using Requirements = ru.yandex.taxi.data.Requirements;

	public class RequirementsActivity : Activity
	{
	  public const string REQUIREMENTS = "requirements";

	  public const string RUSH_ORDER = "rush order";

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private Requirements a_Conflict;

//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
	  private List<string> b_Conflict;

	  private List<string> c;

	  private List<string> d;

	  private List<string> e;

	  private string f;

	  private bool g;

	  private List<TextView> h = new List<TextView>();

	  private List<ImageView> i = new List<ImageView>();

	  private void a(int paramInt1, bool paramBoolean, int paramInt2, int paramInt3)
	  {
		ImageView imageView = this.i[paramInt1];
		if (!paramBoolean)
		{
		  paramInt2 = paramInt3;
		}
		imageView.setImageResource(paramInt2);
	  }

	  private void a(ViewGroup paramViewGroup, View paramView, int paramInt, View.OnClickListener paramOnClickListener)
	  {
		ImageView imageView = (ImageView)paramView.findViewById(2131558429);
		this.i.Add(imageView);
		((TextView)paramView.findViewById(2131558403)).setText(paramInt);
		TextView textView = (TextView)paramView.findViewById(2131558457);
		this.h.Add(textView);
		paramView.setOnClickListener(paramOnClickListener);
		paramViewGroup.addView(paramView);
	  }

	  private static int b(int paramInt)
	  {
		switch (paramInt)
		{
		  default:
			return 2130837585;
		  case 0:
			return 2130837586;
		  case 1:
			break;
		}
		return 2130837581;
	  }

	  public virtual void finish()
	  {
		Intent intent = new Intent();
		intent.putExtra("requirements", (Serializable)this.a_Conflict);
		setResult(-1, intent);
		base.finish();
	  }

	  protected internal virtual void onCreate(Bundle paramBundle)
	  {
		base.onCreate(paramBundle);
		setContentView(2130903054);
		getWindow().setFormat(1);
		Resources resources = getResources();
		this.f = "%1$s";
		this.b_Conflict = (List<string>)new lh(resources);
		this.c = (List<string>)new lk(resources);
		this.d = (List<string>)new ll(resources);
		this.e = (List<string>)new lm(resources);
		Bundle bundle = getIntent().getExtras();
		if (bundle != null && bundle.containsKey("requirements"))
		{
		  this.a_Conflict = (Requirements)bundle.getSerializable("requirements");
		  this.g = bundle.getBoolean("rush order", false);
		}
		else
		{
		  this.a_Conflict = new Requirements((Context)this);
		  this.a_Conflict.childChair = this.b_Conflict[0];
		  this.a_Conflict.smoke = this.d[0];
		}
		getResources();
		LinearLayout linearLayout = (LinearLayout)findViewById(2131558442);
		LayoutInflater layoutInflater = (LayoutInflater)getSystemService("layout_inflater");
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2131296381, (View.OnClickListener)new ln(this));
		a(0, this.a_Conflict.conditioner, 2130837563, 2130837564);
		((TextView)this.h[0]).setVisibility(8);
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2131296382, (View.OnClickListener)new lo(this));
		((TextView)this.h[1]).setText((CharSequence)Html.fromHtml(String.format(this.f, new object[] {this.e[this.d.IndexOf(this.a_Conflict.smoke)]})));
		((ImageView)this.i[1]).setImageResource(b(this.d.IndexOf(this.a_Conflict.smoke)));
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2131296384, (View.OnClickListener)new lp(this));
		a(2, this.a_Conflict.universal, 2130837578, 2130837579);
		((TextView)this.h[2]).setVisibility(8);
		if (!this.g)
		{
		  bool @bool;
		  a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2131296385, (View.OnClickListener)new lq(this));
		  int i = this.b_Conflict.IndexOf(this.a_Conflict.childChair);
		  ((TextView)this.h[3]).setText((CharSequence)Html.fromHtml(String.format(this.f, new object[] {this.c[i]})));
		  if (i > 0)
		  {
			@bool = true;
		  }
		  else
		  {
			@bool = false;
		  }
		  a(3, @bool, 2130837568, 2130837569);
		}
		a((ViewGroup)linearLayout, layoutInflater.inflate(2130903050, null), 2131296387, (View.OnClickListener)new lr(this, linearLayout));
		a(linearLayout.getChildCount() - 1, this.a_Conflict.animal, 2130837566, 2130837567);
		((TextView)this.h[linearLayout.getChildCount() - 1]).setVisibility(8);
	  }

	  protected internal virtual Dialog onCreateDialog(int paramInt)
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)this);
		switch (paramInt)
		{
		  default:
			return (Dialog)builder.create();
		  case 0:
			builder.setTitle(2131296385);
			builder.setSingleChoiceItems(this.c.toArray<CharSequence>((CharSequence[])new string[0]), this.b_Conflict.IndexOf(this.a_Conflict.childChair), (DialogInterface.OnClickListener)new li(this));
			  goto case 1;
		  case 1:
			break;
		}
		builder.setTitle(2131296382);
		builder.setSingleChoiceItems(this.e.toArray<CharSequence>((CharSequence[])new string[0]), this.d.IndexOf(this.a_Conflict.smoke), (DialogInterface.OnClickListener)new lj(this));
	  }

	  protected internal virtual void onStop()
	  {
		PreferenceManager.getDefaultSharedPreferences(getApplicationContext()).edit().putString("requirements", this.a_Conflict.RequirementsString).commit();
		base.onStop();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\activity\RequirementsActivity.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}