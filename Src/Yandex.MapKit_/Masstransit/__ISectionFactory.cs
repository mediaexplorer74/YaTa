// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3874557144, 42069, 16226, 141, 67, 123, 9, 138, 58, 31, 57)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Section))]
  [Version(1)]
  internal interface __ISectionFactory
  {
    [Overload("CreateInstance1")]
    Section CreateInstance(
      [In] SectionMetadata metadata,
      [In] Subpolyline geometry,
      [In] IVectorView<RouteStop> stops,
      [In] IVectorView<Subpolyline> rideLegs);
  }
}
