// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IDisplayedAnnotationsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(13025099, 30392, 14168, 168, 244, 210, 120, 37, 48, 69, 80)]
  [Version(1)]
  [ExclusiveTo(typeof (DisplayedAnnotations))]
  [WebHostHidden]
  internal interface __IDisplayedAnnotationsFactory
  {
    [Overload("CreateInstance1")]
    DisplayedAnnotations CreateInstance(
      [In] IVectorView<AnnotationWithDistance> annotations,
      [In] string nextRoadName,
      [In] LaneSign laneSign);
  }
}
