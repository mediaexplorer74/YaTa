// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.VisibleRegion
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IVisibleRegionFactory), 1)]
  public sealed class VisibleRegion : __IVisibleRegionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern VisibleRegion(
      [In] Point topLeft,
      [In] Point topRight,
      [In] Point bottomLeft,
      [In] Point bottomRight);

    public extern Point TopLeft { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point TopRight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point BottomLeft { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point BottomRight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
