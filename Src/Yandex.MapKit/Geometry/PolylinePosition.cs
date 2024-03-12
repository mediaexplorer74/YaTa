// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.PolylinePosition
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Activatable(typeof (__IPolylinePositionFactory), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  public sealed class PolylinePosition : __IPolylinePositionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PolylinePosition([In] uint segmentIndex, [In] double segmentPosition);

    public extern uint SegmentIndex { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern double SegmentPosition { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
