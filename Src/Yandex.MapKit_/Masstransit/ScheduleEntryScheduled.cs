// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.ScheduleEntryScheduled
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__IScheduleEntryScheduledFactory), 1)]
  public sealed class ScheduleEntryScheduled : __IScheduleEntryScheduledPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScheduleEntryScheduled(
      [In] I18nTime arrivalTime,
      [In] I18nTime departureTime,
      [In] ScheduleEntryEstimation estimation);

    public extern I18nTime ArrivalTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime DepartureTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ScheduleEntryEstimation Estimation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
