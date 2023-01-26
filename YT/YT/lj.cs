using DialogInterface = android.content.DialogInterface;
using Html = android.text.Html;
using ImageView = android.widget.ImageView;
using TextView = android.widget.TextView;
using RequirementsActivity = ru.yandex.taxi.activity.RequirementsActivity;

public class lj : DialogInterface.OnClickListener
{
  public lj(RequirementsActivity paramRequirementsActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	(RequirementsActivity.a(this.a)).smoke = RequirementsActivity.f(this.a).get(paramInt);
	((TextView)RequirementsActivity.e(this.a).get(1)).setText((CharSequence)Html.fromHtml(String.format(RequirementsActivity.c(this.a), new object[] {RequirementsActivity.g(this.a).get(RequirementsActivity.f(this.a).IndexOf((RequirementsActivity.a(this.a)).smoke))})));
	ImageView imageView = RequirementsActivity.h(this.a).get(1);
	RequirementsActivity requirementsActivity = this.a;
	imageView.setImageResource(RequirementsActivity.a(paramInt));
	this.a.removeDialog(1);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\lj.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */