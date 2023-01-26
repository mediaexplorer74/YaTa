using Intent = android.content.Intent;
using Resources = android.content.res.Resources;
using View = android.view.View;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fu : View.OnClickListener
{
  public fu(AuthorizeActivity paramAuthorizeActivity, string paramString)
  {
  }

  public virtual void onClick(View paramView)
  {
	Resources resources = this.b.getResources();
	Intent intent = new Intent("android.intent.action.SEND");
	intent.setType("text/xml");
	intent.putExtra("android.intent.extra.EMAIL", new string[] {resources.getString(2131296261)});
	intent.putExtra("android.intent.extra.SUBJECT", String.format(resources.getString(2131296525), new object[] {this.a}));
	this.b.startActivity(Intent.createChooser(intent, resources.getString(2131296526)));
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fu.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */