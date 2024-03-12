// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.VehicleData
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(303749019, 48024, 13470, 140, 246, 166, 101, 143, 135, 41, 38)]
  public interface VehicleData
  {
    string Id { get; }

    string ThreadId { get; }

    Line Line { get; }

    float CurrentAzimuth { get; }

    bool Valid { get; }
  }
}
