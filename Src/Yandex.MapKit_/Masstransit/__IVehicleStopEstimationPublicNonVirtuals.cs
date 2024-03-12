// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleStopEstimationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2167470734, 23556, 13373, 158, 151, 104, 137, 119, 129, 146, 215)]
  [ExclusiveTo(typeof (VehicleStopEstimation))]
  internal interface __IVehicleStopEstimationPublicNonVirtuals
  {
    I18nTime ArrivalTime { get; }

    I18nTime DepartureTime { get; }
  }
}
