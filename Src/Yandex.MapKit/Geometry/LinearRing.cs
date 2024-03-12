// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.LinearRing
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
  [Static(typeof (__ILinearRingStatics), 1)]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__ILinearRingFactory), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class LinearRing : __ILinearRingPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern LinearRing From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LinearRing([In] IVectorView<Point> points);

    public extern IVectorView<Point> Points { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
