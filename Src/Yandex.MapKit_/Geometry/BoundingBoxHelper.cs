// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.BoundingBoxHelper
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Activatable(1)]
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [Static(typeof (__IBoundingBoxHelperStatics), 1)]
  [MarshalingBehavior]
  public sealed class BoundingBoxHelper : __IBoundingBoxHelperPublicNonVirtuals
  {
    [Overload("GetBounds1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BoundingBox GetBounds([In] BoundingBox first, [In] BoundingBox second);

    [Overload("GetBounds2")]
    [DefaultOverload]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BoundingBox GetBounds([In] Polygon geometry);

    [Overload("GetBounds3")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BoundingBox GetBounds([In] LinearRing geometry);

    [Overload("GetBounds4")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BoundingBox GetBounds([In] Polyline geometry);

    [Overload("GetBounds5")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BoundingBox GetBounds([In] Point geometry);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BoundingBoxHelper();
  }
}
