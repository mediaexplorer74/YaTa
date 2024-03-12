// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Polyline
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
  [Threading]
  [Static(typeof (__IPolylineStatics), 1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IPolylineFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class Polyline : __IPolylinePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Polyline From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Polyline([In] IVectorView<Point> points);

    public extern IVectorView<Point> Points { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
