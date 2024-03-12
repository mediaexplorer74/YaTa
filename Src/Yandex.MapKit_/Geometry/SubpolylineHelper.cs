// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.SubpolylineHelper
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
  [Static(typeof (__ISubpolylineHelperStatics), 1)]
  [Activatable(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class SubpolylineHelper : __ISubpolylineHelperPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Polyline GetSubpolyline([In] Polyline polyline, [In] Subpolyline subpolyline);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern double GetSubpolylineLength([In] Polyline polyline, [In] Subpolyline subpolyline);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SubpolylineHelper();
  }
}
