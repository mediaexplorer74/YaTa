// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.ScheduleEntryEstimation
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IScheduleEntryEstimationFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  public sealed class ScheduleEntryEstimation : __IScheduleEntryEstimationPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScheduleEntryEstimation(
      [In] string vehicleId,
      [In] I18nTime arrivalTime,
      [In] I18nTime departureTime);

    public extern string VehicleId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime ArrivalTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime DepartureTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
