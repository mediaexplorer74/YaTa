// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Event
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.MapKit.RoadEvents;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Activatable(typeof (__IEventFactory), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [Static(typeof (__IEventStatics), 1)]
  public sealed class Event : __IEventPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Event From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Event(
      [In] PolylinePosition polylinePosition,
      [In] string eventId,
      [In] string descriptionText,
      [In] IVectorView<EventType> types,
      [In] global::Yandex.MapKit.Geometry.Point location,
      [In] IReference<float> speedLimit,
      [In] IReference<AnnotationSchemeID> annotationSchemeId);

    public extern PolylinePosition PolylinePosition { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string EventId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<EventType> Types { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern global::Yandex.MapKit.Geometry.Point Location { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> SpeedLimit { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<AnnotationSchemeID> AnnotationSchemeId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
