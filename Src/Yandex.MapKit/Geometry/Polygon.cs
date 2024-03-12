// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Polygon
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Activatable(typeof (__IPolygonFactory), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Static(typeof (__IPolygonStatics), 1)]
  [Version(1)]
  public sealed class Polygon : __IPolygonPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Polygon From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Polygon([In] LinearRing outerRing, [In] IVectorView<LinearRing> innerRings);

    public extern LinearRing OuterRing { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<LinearRing> InnerRings { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
