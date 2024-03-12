// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IAnnotationWithDistancePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Guid(387418791, 53308, 14414, 187, 168, 147, 240, 193, 154, 1, 6)]
  [ExclusiveTo(typeof (AnnotationWithDistance))]
  [Version(1)]
  internal interface __IAnnotationWithDistancePublicNonVirtuals
  {
    Annotation Annotation { get; }

    LocalizedValue Distance { get; }
  }
}
