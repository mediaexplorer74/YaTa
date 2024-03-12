// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geo.XYPoint
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry.Geo
{
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IXYPointFactory), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class XYPoint : __IXYPointPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern XYPoint([In] double x, [In] double y);

    public extern double X { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double Y { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
