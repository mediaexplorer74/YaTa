// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geometry
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Static(typeof (__IGeometryStatics), 1)]
  [Version(1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Threading]
  public sealed class Geometry : __IGeometryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.MapKit.Geometry.Geometry FromPoint([In] Point point);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.MapKit.Geometry.Geometry FromPolyline([In] Polyline polyline);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.MapKit.Geometry.Geometry FromPolygon([In] Polygon polygon);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.MapKit.Geometry.Geometry FromBoundingBox(
      [In] BoundingBox boundingBox);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern global::Yandex.MapKit.Geometry.Geometry FromCircle([In] Circle circle);

    public extern Point Point { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Polyline Polyline { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Polygon Polygon { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BoundingBox BoundingBox { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Circle Circle { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
