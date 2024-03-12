// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObjectCollection
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [Guid(1846316102, 7414, 13975, 170, 115, 58, 45, 77, 132, 39, 131)]
  [WebHostHidden]
  public interface MapObjectCollection : MapObject
  {
    PlacemarkMapObject AddPlacemark([In] Point point);

    PolylineMapObject AddPolyline([In] Polyline polyline);

    ColoredPolylineMapObject AddColoredPolyline([In] Polyline polyline);

    PolygonMapObject AddPolygon([In] Polygon polygon);

    CircleMapObject AddCircle([In] Circle circle);

    MapObjectCollection AddCollection();

    void Traverse([In] MapObjectVisitor mapObjectVisitor);

    void Remove([In] MapObject mapObject);

    void Clear();

    void AddListener([In] MapObjectCollectionListener collectionListener);
  }
}
