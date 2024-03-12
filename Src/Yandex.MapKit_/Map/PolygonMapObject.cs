// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.PolygonMapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(1593290086, 3103, 13460, 132, 201, 190, 121, 171, 164, 232, 140)]
  [WebHostHidden]
  [Version(1)]
  public interface PolygonMapObject : MapObject
  {
    Polygon Geometry { get; [param: In] set; }

    uint StrokeColor { get; [param: In] set; }

    float StrokeWidth { get; [param: In] set; }

    uint FillColor { get; [param: In] set; }

    bool Geodesic { get; [param: In] set; }
  }
}
