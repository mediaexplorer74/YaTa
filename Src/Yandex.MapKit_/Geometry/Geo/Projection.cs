// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geo.Projection
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry.Geo
{
  [Version(1)]
  [WebHostHidden]
  [Guid(272456088, 30551, 12336, 130, 91, 140, 82, 223, 74, 141, 224)]
  public interface Projection
  {
    XYPoint WorldToXY([In] Point geoPoint, [In] int zoom);

    Point XyToWorld([In] XYPoint xyPoint, [In] int zoom);
  }
}
