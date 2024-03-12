// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.CircleMapObject
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [WebHostHidden]
  [Guid(4185978961, 29467, 13639, 162, 196, 17, 67, 25, 44, 0, 235)]
  [Version(1)]
  public interface CircleMapObject : MapObject
  {
    Circle Geometry { get; [param: In] set; }

    uint StrokeColor { get; [param: In] set; }

    float StrokeWidth { get; [param: In] set; }

    uint FillColor { get; [param: In] set; }

    bool Geodesic { get; [param: In] set; }
  }
}
