// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IDisplayedAnnotationsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [Guid(3478446733, 15776, 14549, 166, 137, 194, 158, 28, 240, 213, 142)]
  [ExclusiveTo(typeof (DisplayedAnnotations))]
  internal interface __IDisplayedAnnotationsPublicNonVirtuals
  {
    IVectorView<AnnotationWithDistance> Annotations { get; }

    string NextRoadName { get; }

    LaneSign LaneSign { get; }
  }
}
