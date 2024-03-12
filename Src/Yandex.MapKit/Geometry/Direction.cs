// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Direction
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Threading]
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__IDirectionFactory), 1)]
  [MarshalingBehavior]
  public sealed class Direction : __IDirectionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Direction([In] double azimuth, [In] double tilt);

    public extern double Azimuth { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double Tilt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
