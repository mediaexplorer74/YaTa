// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehiclePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(908824510, 18064, 15606, 191, 85, 199, 146, 90, 217, 69, 219)]
  [ExclusiveTo(typeof (Vehicle))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IVehiclePublicNonVirtuals
  {
    string Id { get; }

    string ThreadId { get; }

    Line Line { get; }

    IVectorView<VehicleStop> Stops { get; }

    Point Position { get; }
  }
}
