// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.PolylineBuilder
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [Activatable(1)]
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  public sealed class PolylineBuilder : __IPolylineBuilderPublicNonVirtuals
  {
    [Overload("Append1")]
    [DefaultOverload]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern void Append([In] Point point);

    [Overload("Append2")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern void Append([In] Polyline polyline);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Polyline Build();

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PolylineBuilder();
  }
}
