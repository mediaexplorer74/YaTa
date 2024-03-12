// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Route
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.Uri;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1833374639, 19136, 15202, 184, 204, 223, 180, 71, 141, 114, 55)]
  public interface Route
  {
    RouteMetadata Metadata { get; }

    IVectorView<Section> Sections { get; }

    Polyline Geometry { get; }

    UriObjectMetadata UriMetadata { get; }
  }
}
