// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IScheduleEntryEstimationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [ExclusiveTo(typeof (ScheduleEntryEstimation))]
  [Guid(135132932, 1503, 13854, 189, 104, 137, 238, 141, 169, 117, 247)]
  [WebHostHidden]
  internal interface __IScheduleEntryEstimationPublicNonVirtuals
  {
    string VehicleId { get; }

    I18nTime ArrivalTime { get; }

    I18nTime DepartureTime { get; }
  }
}
