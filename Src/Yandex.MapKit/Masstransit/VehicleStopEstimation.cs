// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.VehicleStopEstimation
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
  [Static(typeof (__IVehicleStopEstimationStatics), 1)]
  [Threading]
  [Activatable(typeof (__IVehicleStopEstimationFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class VehicleStopEstimation : __IVehicleStopEstimationPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern VehicleStopEstimation From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern VehicleStopEstimation([In] I18nTime arrivalTime, [In] I18nTime departureTime);

    public extern I18nTime ArrivalTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime DepartureTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
