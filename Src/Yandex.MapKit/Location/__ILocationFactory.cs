// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.__ILocationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [Version(1)]
  [ExclusiveTo(typeof (global::Yandex.MapKit.Location.Location))]
  [Guid(2110269672, 29416, 13391, 149, 179, 25, 177, 33, 83, 41, 212)]
  [WebHostHidden]
  internal interface __ILocationFactory
  {
    [Overload("CreateInstance1")]
    global::Yandex.MapKit.Location.Location CreateInstance(
      [In] global::Yandex.MapKit.Geometry.Point position,
      [In] IReference<double> accuracy,
      [In] IReference<double> altitude,
      [In] IReference<double> altitudeAccuracy,
      [In] IReference<double> heading,
      [In] IReference<double> speed,
      [In] DateTime absoluteTimestamp,
      [In] DateTime relativeTimestamp);
  }
}
