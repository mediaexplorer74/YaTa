// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IRouteStopFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (RouteStop))]
  [Version(1)]
  [WebHostHidden]
  [Guid(1181828445, 36283, 14684, 172, 204, 219, 155, 182, 127, 66, 106)]
  internal interface __IRouteStopFactory
  {
    [Overload("CreateInstance1")]
    RouteStop CreateInstance([In] Stop stop, [In] Point position);
  }
}
