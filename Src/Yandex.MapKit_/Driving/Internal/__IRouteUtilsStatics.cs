// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRouteUtilsStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(698559153, 42491, 15803, 136, 82, 176, 79, 84, 213, 44, 117)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RouteUtils))]
  internal interface __IRouteUtilsStatics
  {
    IVectorView<RequestPoint> GetRequestPointsAfterPosition([In] Route route, [In] PolylinePosition pos);
  }
}
