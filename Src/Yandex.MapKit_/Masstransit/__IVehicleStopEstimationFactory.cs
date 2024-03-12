// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleStopEstimationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3724275660, 54984, 13947, 189, 36, 68, 11, 80, 191, 139, 226)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VehicleStopEstimation))]
  internal interface __IVehicleStopEstimationFactory
  {
    [Overload("CreateInstance1")]
    VehicleStopEstimation CreateInstance([In] I18nTime arrivalTime, [In] I18nTime departureTime);
  }
}
