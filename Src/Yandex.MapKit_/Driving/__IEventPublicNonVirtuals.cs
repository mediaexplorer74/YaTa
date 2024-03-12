// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IEventPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(1039501039, 3229, 15146, 171, 197, 64, 153, 36, 177, 62, 60)]
  [ExclusiveTo(typeof (Event))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IEventPublicNonVirtuals
  {
    PolylinePosition PolylinePosition { get; }

    string EventId { get; }

    string DescriptionText { get; }

    IVectorView<EventType> Types { get; }

    global::Yandex.MapKit.Geometry.Point Location { get; }

    IReference<float> SpeedLimit { get; }

    IReference<AnnotationSchemeID> AnnotationSchemeId { get; }
  }
}
