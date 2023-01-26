using DialogInterface = android.content.DialogInterface;
using Html = android.text.Html;
using TextView = android.widget.TextView;
using RequirementsActivity = ru.yandex.taxi.activity.RequirementsActivity;

public class li : DialogInterface.OnClickListener
{
  public li(RequirementsActivity paramRequirementsActivity)
  {
  }

  public virtual void onClick(DialogInterface paramDialogInterface, int paramInt)
  {
	bool @bool;
	(RequirementsActivity.a(this.a)).childChair = RequirementsActivity.b(this.a).get(paramInt);
	paramInt = RequirementsActivity.b(this.a).indexOf((RequirementsActivity.a(this.a)).childChair);
	((TextView)RequirementsActivity.e(this.a).get(3)).setText((CharSequence)Html.fromHtml(String.format(RequirementsActivity.c(this.a), new object[] {RequirementsActivity.d(this.a).get(paramInt)})));
	RequirementsActivity requirementsActivity = this.a;
	if (paramInt > 0)
	{
	  @bool = true;
	}
	else
	{
	  @bool = false;
	}
	RequirementsActivity.a(requirementsActivity, 3, @bool, 2130837568, 2130837569);
	this.a.removeDialog(0);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\li.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */