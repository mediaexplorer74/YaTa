namespace ru.yandex.taxi.error
{
	using Context = android.content.Context;
	using Toast = android.widget.Toast;

	public class ErrorUtils
	{
	  public static void showErrorMessage(Context paramContext, string paramString)
	  {
		Toast.makeText(paramContext, paramString, 0).show();
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\error\ErrorUtils.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}