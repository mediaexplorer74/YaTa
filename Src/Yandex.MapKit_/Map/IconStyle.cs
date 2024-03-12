// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.IconStyle
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [WebHostHidden]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [Activatable(typeof (__IIconStyleFactory), 1)]
  public sealed class IconStyle : __IIconStylePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern IconStyle(
      [In] IReference<Point> anchor,
      [In] IReference<global::Yandex.MapKit.Map.RotationType> rotationType,
      [In] IReference<float> zIndex,
      [In] IReference<bool> flat,
      [In] IReference<bool> visible);

    public extern IReference<Point> Anchor { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public extern IReference<global::Yandex.MapKit.Map.RotationType> RotationType { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public extern IReference<float> ZIndex { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public extern IReference<bool> Flat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    public extern IReference<bool> Visible { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
