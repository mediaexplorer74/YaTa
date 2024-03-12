// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSectionMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Version(1)]
  [ExclusiveTo(typeof (RawSectionMetadata))]
  [WebHostHidden]
  [Guid(3689444001, 38108, 12782, 184, 151, 25, 132, 37, 78, 105, 9)]
  internal interface __IRawSectionMetadataPublicNonVirtuals
  {
    uint LegIndex { get; }

    Weight Weight { get; }

    Annotation Annotation { get; }

    IVectorView<uint> ViaPointPositions { get; }

    RawSpeedLimits SpeedLimits { get; }

    RawAnnotationSchemes AnnotationSchemes { get; }

    RawLaneSigns LaneSigns { get; }
  }
}
