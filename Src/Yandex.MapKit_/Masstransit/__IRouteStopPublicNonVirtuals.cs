// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IRouteStopPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (RouteStop))]
  [WebHostHidden]
  [Guid(1738073964, 11775, 12862, 150, 71, 140, 247, 107, 251, 63, 180)]
  [Version(1)]
  internal interface __IRouteStopPublicNonVirtuals
  {
    Stop Stop { get; }

    Point Position { get; }
  }
}
