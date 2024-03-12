// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.CameraPosition
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
  [Activatable(typeof (__ICameraPositionFactory), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  public sealed class CameraPosition : __ICameraPositionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern CameraPosition([In] Point target, [In] float zoom, [In] float azimuth, [In] float tilt);

    public extern Point Target { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Zoom { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Azimuth { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern float Tilt { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
