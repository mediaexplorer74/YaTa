using System.Threading;

using Context = android.content.Context;
using CellLocation = android.telephony.CellLocation;
using NeighboringCellInfo = android.telephony.NeighboringCellInfo;
using TelephonyManager = android.telephony.TelephonyManager;
using GsmCellLocation = android.telephony.gsm.GsmCellLocation;
using SignalStrengthRequest = ru.yandex.core.SignalStrengthRequest;

public class i : ThreadStart
{
  public i(SignalStrengthRequest paramSignalStrengthRequest, Context paramContext)
  {
  }

  public virtual void run()
  {
	if (!SignalStrengthRequest.access$000(this.b))
	{
	  TelephonyManager telephonyManager = (TelephonyManager)this.a.getSystemService("phone");
	  CellLocation cellLocation = telephonyManager.getCellLocation();
	  if (cellLocation is GsmCellLocation)
	  {
		int j = ((GsmCellLocation)cellLocation).getCid();
		foreach (NeighboringCellInfo neighboringCellInfo in telephonyManager.getNeighboringCellInfo())
		{
		  if (neighboringCellInfo.getCid() == j)
		  {
			if (neighboringCellInfo.getRssi() != 99)
			{
			  SignalStrengthRequest.access$200(SignalStrengthRequest.access$100(this.b), true, neighboringCellInfo.getRssi() * 2 - 113);
			  // Byte code: goto -> 10
			}
			break;
		  }
		}
	  }
	  SignalStrengthRequest.access$200(SignalStrengthRequest.access$100(this.b), false, 99);
	}
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\i.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */