// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.GeoHelper
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Activatable(1)]
  [Version(1)]
  [WebHostHidden]
  [Static(typeof (__IGeoHelperStatics), 1)]
  [MarshalingBehavior]
  [Threading]
  public sealed class GeoHelper : __IGeoHelperPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern double GetDistance([In] Point firstPoint, [In] Point secondPoint);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Point GetClosestPoint([In] Point point, [In] Segment segment);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Point GetPointOnSegmentByFactor([In] Segment segment, [In] double lambda);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern double GetCourse([In] Point firstPoint, [In] Point secondPoint);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GeoHelper();
  }
}
