// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IVehicleRawDataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Guid(3166889192, 15414, 13579, 163, 143, 190, 227, 167, 209, 181, 65)]
  [Version(1)]
  [ExclusiveTo(typeof (VehicleRawData))]
  [WebHostHidden]
  internal interface __IVehicleRawDataPublicNonVirtuals
  {
    string Id { get; }

    string ThreadId { get; }

    Line Line { get; }
  }
}
