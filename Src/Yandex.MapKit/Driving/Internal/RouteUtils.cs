// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RouteUtils
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Activatable(1)]
  [WebHostHidden]
  [Static(typeof (__IRouteUtilsStatics), 1)]
  [Version(1)]
  [MarshalingBehavior]
  [Threading]
  public sealed class RouteUtils : __IRouteUtilsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern IVectorView<RequestPoint> GetRequestPointsAfterPosition(
      [In] Route route,
      [In] PolylinePosition pos);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RouteUtils();
  }
}
