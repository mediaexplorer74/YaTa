// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryEstimationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (ScheduleEntryEstimation))]
  [Guid(589792899, 23453, 12721, 191, 142, 2, 141, 229, 165, 162, 154)]
  internal interface __IScheduleEntryEstimationFactory
  {
    [Overload("CreateInstance1")]
    ScheduleEntryEstimation CreateInstance(
      [In] string vehicleId,
      [In] I18nTime arrivalTime,
      [In] I18nTime departureTime);
  }
}
