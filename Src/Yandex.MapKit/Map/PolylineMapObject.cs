// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.PolylineMapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(3863584622, 50164, 12494, 166, 40, 247, 4, 189, 179, 175, 84)]
  [Version(1)]
  [WebHostHidden]
  public interface PolylineMapObject : MapObject
  {
    Polyline Geometry { get; [param: In] set; }

    uint StrokeColor { get; [param: In] set; }

    float StrokeWidth { get; [param: In] set; }

    bool Geodesic { get; [param: In] set; }

    float DashLength { get; [param: In] set; }

    float GapLength { get; [param: In] set; }
  }
}
