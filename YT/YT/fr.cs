using DialogInterface = android.content.DialogInterface;
using AuthorizeActivity = ru.yandex.taxi.activity.AuthorizeActivity;

public class fr : DialogInterface.OnClickListener
{
  public fr(AuthorizeActivity paramAuthorizeActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	this.a.setTitle(2131296489);
	AuthorizeActivity.j(this.a).setText(2131296497);
	AuthorizeActivity.k(this.a).setText("");
	AuthorizeActivity.k(this.a).setVisibility(8);
	AuthorizeActivity.l(this.a).setVisibility(8);
	(new ga(this.a)).execute((object[])new int?[0]);
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\fr.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */