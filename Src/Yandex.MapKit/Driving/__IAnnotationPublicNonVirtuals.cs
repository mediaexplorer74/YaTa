// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IAnnotationPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(1626024294, 56080, 16163, 161, 173, 231, 53, 226, 121, 97, 12)]
  [ExclusiveTo(typeof (Annotation))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IAnnotationPublicNonVirtuals
  {
    IReference<global::Yandex.MapKit.Driving.Action> Action { get; }

    string Toponym { get; }

    string DescriptionText { get; }

    ActionMetadata ActionMetadata { get; }

    IVectorView<Landmark> Landmarks { get; }
  }
}
