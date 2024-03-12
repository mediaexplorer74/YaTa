// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.VehicleStop
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [MarshalingBehavior]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IVehicleStopFactory), 1)]
  [WebHostHidden]
  [Static(typeof (__IVehicleStopStatics), 1)]
  public sealed class VehicleStop : __IVehicleStopPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern VehicleStop From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern VehicleStop([In] Stop stop, [In] VehicleStopEstimation estimation);

    public extern Stop Stop { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern VehicleStopEstimation Estimation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
