using System.Runtime.InteropServices;

namespace ru.yandex.core
{
	using CellLocation = android.telephony.CellLocation;
	using PhoneStateListener = android.telephony.PhoneStateListener;
	using ServiceState = android.telephony.ServiceState;
	using j;

	internal sealed class TelephonyListener : PhoneStateListener
	{
//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signal(bool paramBoolean, int paramInt1, int paramInt2, string paramString1, string paramString2);

	  public void onCellLocationChanged(CellLocation paramCellLocation)
	  {
		base.onCellLocationChanged(paramCellLocation);
		j j = j.a(CoreApplication.applicationContext);
		signal(j.a_Conflict, j.b, j.c, j.d, j.e);
	  }

	  public void onServiceStateChanged(ServiceState paramServiceState)
	  {
		base.onServiceStateChanged(paramServiceState);
		j j = j.a(CoreApplication.applicationContext);
		signal(j.a_Conflict, j.b, j.c, j.d, j.e);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\TelephonyListener.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}