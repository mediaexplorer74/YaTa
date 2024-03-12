// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Segment
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
  [Threading]
  [Activatable(typeof (__ISegmentFactory), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class Segment : __ISegmentPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Segment([In] Point startPoint, [In] Point endPoint);

    public extern Point StartPoint { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point EndPoint { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
