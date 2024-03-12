// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSectionMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RawSectionMetadata))]
  [Version(1)]
  [Guid(3509963210, 52429, 14053, 147, 178, 236, 198, 255, 40, 68, 71)]
  internal interface __IRawSectionMetadataFactory
  {
    [Overload("CreateInstance1")]
    RawSectionMetadata CreateInstance(
      [In] uint legIndex,
      [In] Weight weight,
      [In] Annotation annotation,
      [In] IVectorView<uint> viaPointPositions,
      [In] RawSpeedLimits speedLimits,
      [In] RawAnnotationSchemes annotationSchemes,
      [In] RawLaneSigns laneSigns);
  }
}
