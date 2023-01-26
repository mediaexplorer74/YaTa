namespace ru.yandex.taxi.ui.dialog
{
	using Activity = android.app.Activity;
	using AlertDialog = android.app.AlertDialog;
	using Dialog = android.app.Dialog;
	using Context = android.content.Context;
	using DialogInterface = android.content.DialogInterface;
	using qt;
	using qu;

	public class TaxiDialogFactory
	{
	  public static Dialog createCallDialog(int paramInt, Activity paramActivity, string paramString1, string paramString2, string paramString3)
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)paramActivity);
		builder.setTitle(paramString1).setMessage(paramString2).setPositiveButton(2131296280, (DialogInterface.OnClickListener)new qu(paramString3, paramActivity, paramInt)).setNegativeButton(2131296279, (DialogInterface.OnClickListener)new qt(paramActivity, paramInt));
		return (Dialog)builder.create();
	  }

	  public static Dialog createCancelByTaxiDialog(Activity paramActivity, string paramString, DialogInterface.OnClickListener paramOnClickListener1, DialogInterface.OnClickListener paramOnClickListener2)
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder((Context)paramActivity);
		builder.setCancelable(false).setTitle(2131296311).setMessage(String.format(paramActivity.getResources().getString(2131296312), new object[] {paramString})).setPositiveButton(2131296280, paramOnClickListener1).setNegativeButton(2131296281, paramOnClickListener2);
		return (Dialog)builder.create();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\tax\\ui\dialog\TaxiDialogFactory.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}