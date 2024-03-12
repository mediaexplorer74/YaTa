// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Point
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [MarshalingBehavior]
  [Activatable(typeof (__IPointFactory), 1)]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  public sealed class Point : __IPointPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Point([In] double latitude, [In] double longitude);

    public extern double Latitude { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double Longitude { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
