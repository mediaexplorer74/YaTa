// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleStopPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(3082498513, 957, 13755, 150, 89, 241, 245, 159, 127, 38, 221)]
  [ExclusiveTo(typeof (VehicleStop))]
  [WebHostHidden]
  internal interface __IVehicleStopPublicNonVirtuals
  {
    Stop Stop { get; }

    VehicleStopEstimation Estimation { get; }
  }
}
