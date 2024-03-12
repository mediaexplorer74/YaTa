// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Subpolyline
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
  [WebHostHidden]
  [Activatable(typeof (__ISubpolylineFactory), 1)]
  [Threading]
  [Version(1)]
  public sealed class Subpolyline : __ISubpolylinePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Subpolyline([In] PolylinePosition begin, [In] PolylinePosition end);

    public extern PolylinePosition Begin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern PolylinePosition End { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
