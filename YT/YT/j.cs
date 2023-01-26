using Context = android.content.Context;
using CellLocation = android.telephony.CellLocation;
using TelephonyManager = android.telephony.TelephonyManager;
using GsmCellLocation = android.telephony.gsm.GsmCellLocation;

public sealed class j
{
//JAVA TO C# CONVERTER NOTE: Field name conflicts with a method name of the current type:
  public bool a_Conflict = false;

  public int b = -1;

  public int c = -1;

  public string d = "";

  public string e = "";

  internal j(Context paramContext)
  {
	TelephonyManager telephonyManager = (TelephonyManager)paramContext.getSystemService("phone");
	CellLocation cellLocation = telephonyManager.getCellLocation();
	if (cellLocation is GsmCellLocation)
	{
	  GsmCellLocation gsmCellLocation = (GsmCellLocation)cellLocation;
	  this.a_Conflict = true;
	  this.b = gsmCellLocation.getCid();
	  this.c = gsmCellLocation.getLac();
	}
	string str = telephonyManager.getNetworkOperator();
	if (!string.ReferenceEquals(str, null) && str.Length >= 3)
	{
	  this.e = str.Substring(0, 3);
	  this.d = str.Substring(3);
	}
  }

  public static j a(Context paramContext)
  {
	return new j(paramContext);
  }
}


/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\j.class
 * Java compiler version: 6 (50.0)
 * JD-Core Version:       1.1.3
 */