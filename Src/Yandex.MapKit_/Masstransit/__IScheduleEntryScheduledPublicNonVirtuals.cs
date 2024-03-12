// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryScheduledPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (ScheduleEntryScheduled))]
  [Guid(2476920172, 20588, 13072, 137, 23, 120, 145, 109, 134, 125, 115)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IScheduleEntryScheduledPublicNonVirtuals
  {
    I18nTime ArrivalTime { get; }

    I18nTime DepartureTime { get; }

    ScheduleEntryEstimation Estimation { get; }
  }
}
