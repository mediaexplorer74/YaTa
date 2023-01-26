using System.Runtime.InteropServices;

namespace ru.yandex.core
{
	using PhoneStateListener = android.telephony.PhoneStateListener;

	internal sealed class SignalStrengthListener : PhoneStateListener
	{
//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void signal(int paramInt);

	  public void onSignalStrengthChanged(int paramInt)
	  {
		base.onSignalStrengthChanged(paramInt);
		signal((paramInt << 1) - 113);
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\core\SignalStrengthListener.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}