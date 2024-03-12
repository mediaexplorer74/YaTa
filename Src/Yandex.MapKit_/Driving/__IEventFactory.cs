// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IEventFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (Event))]
  [WebHostHidden]
  [Version(1)]
  [Guid(1108988048, 1607, 16126, 162, 250, 21, 39, 216, 216, 178, 109)]
  internal interface __IEventFactory
  {
    [Overload("CreateInstance1")]
    Event CreateInstance(
      [In] PolylinePosition polylinePosition,
      [In] string eventId,
      [In] string descriptionText,
      [In] IVectorView<EventType> types,
      [In] global::Yandex.MapKit.Geometry.Point location,
      [In] IReference<float> speedLimit,
      [In] IReference<AnnotationSchemeID> annotationSchemeId);
  }
}
