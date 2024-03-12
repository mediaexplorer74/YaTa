// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Route
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [Guid(2122938163, 58427, 13999, 163, 25, 5, 3, 80, 75, 200, 95)]
  [WebHostHidden]
  public interface Route
  {
    string RouteId { get; }

    RouteMetadata Metadata { get; }

    IVectorView<Section> Sections { get; }

    Polyline Geometry { get; }

    IVectorView<JamSegment> JamSegments { get; }

    IVectorView<Event> Events { get; }

    IVectorView<IReference<float>> SpeedLimits { get; }

    IVectorView<AnnotationSchemeID> AnnotationSchemes { get; }

    IVectorView<LaneSign> LaneSigns { get; }

    PolylinePosition Position { get; [param: In] set; }

    bool AreConditionsOutdated { get; }

    void AddConditionsListener([In] ConditionsListener conditionsListener);

    void RemoveConditionsListener([In] ConditionsListener conditionsListener);

    uint SectionIndex([In] uint segmentIndex);
  }
}
