// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ISectionMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [Guid(2904684951, 46942, 15940, 154, 144, 52, 35, 176, 194, 197, 100)]
  [ExclusiveTo(typeof (SectionMetadata))]
  [WebHostHidden]
  internal interface __ISectionMetadataFactory
  {
    [Overload("CreateInstance1")]
    SectionMetadata CreateInstance(
      [In] uint legIndex,
      [In] Weight weight,
      [In] Annotation annotation,
      [In] IReference<AnnotationSchemeID> schemeId,
      [In] IVectorView<uint> viaPointPositions);
  }
}
