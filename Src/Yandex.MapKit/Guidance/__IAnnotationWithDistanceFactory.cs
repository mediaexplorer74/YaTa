// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IAnnotationWithDistanceFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Guid(170734984, 63501, 12368, 132, 194, 59, 15, 56, 226, 46, 18)]
  [ExclusiveTo(typeof (AnnotationWithDistance))]
  [Version(1)]
  internal interface __IAnnotationWithDistanceFactory
  {
    [Overload("CreateInstance1")]
    AnnotationWithDistance CreateInstance([In] Annotation annotation, [In] LocalizedValue distance);
  }
}
