// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.MapObjectVisitor
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Version(1)]
  [WebHostHidden]
  [Guid(2688918091, 11347, 15399, 162, 52, 251, 47, 222, 189, 81, 11)]
  public interface MapObjectVisitor
  {
    void OnPlacemarkVisited([In] PlacemarkMapObject placemark);

    void OnPolylineVisited([In] PolylineMapObject polyline);

    void OnColoredPolylineVisited([In] ColoredPolylineMapObject polyline);

    void OnPolygonVisited([In] PolygonMapObject polygon);

    void OnCircleVisited([In] CircleMapObject circle);

    bool OnCollectionVisitStart([In] MapObjectCollection collection);

    void OnCollectionVisitEnd([In] MapObjectCollection collection);
  }
}
