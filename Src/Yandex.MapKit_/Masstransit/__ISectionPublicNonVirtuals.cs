// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(1383186325, 29889, 16355, 167, 232, 87, 255, 216, 96, 108, 133)]
  [ExclusiveTo(typeof (Section))]
  [WebHostHidden]
  internal interface __ISectionPublicNonVirtuals
  {
    SectionMetadata Metadata { get; }

    Subpolyline Geometry { get; }

    IVectorView<RouteStop> Stops { get; }

    IVectorView<Subpolyline> RideLegs { get; }
  }
}
