// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryScheduledFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(1678679461, 44448, 12690, 191, 80, 157, 45, 18, 138, 58, 10)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScheduleEntryScheduled))]
  [Version(1)]
  internal interface __IScheduleEntryScheduledFactory
  {
    [Overload("CreateInstance1")]
    ScheduleEntryScheduled CreateInstance(
      [In] I18nTime arrivalTime,
      [In] I18nTime departureTime,
      [In] ScheduleEntryEstimation estimation);
  }
}
