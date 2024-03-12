// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ISectionMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SectionMetadata))]
  [Version(1)]
  [Guid(3206112090, 5194, 15623, 154, 68, 110, 239, 182, 161, 228, 209)]
  internal interface __ISectionMetadataPublicNonVirtuals
  {
    uint LegIndex { get; }

    Weight Weight { get; }

    Annotation Annotation { get; }

    IReference<AnnotationSchemeID> SchemeId { get; }

    IVectorView<uint> ViaPointPositions { get; }
  }
}
