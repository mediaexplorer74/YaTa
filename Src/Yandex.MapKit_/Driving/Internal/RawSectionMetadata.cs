// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.RawSectionMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__IRawSectionMetadataFactory), 1)]
  [Version(1)]
  [Static(typeof (__IRawSectionMetadataStatics), 1)]
  [Threading]
  public sealed class RawSectionMetadata : __IRawSectionMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawSectionMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawSectionMetadata(
      [In] uint legIndex,
      [In] Weight weight,
      [In] Annotation annotation,
      [In] IVectorView<uint> viaPointPositions,
      [In] RawSpeedLimits speedLimits,
      [In] RawAnnotationSchemes annotationSchemes,
      [In] RawLaneSigns laneSigns);

    public extern uint LegIndex { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Weight Weight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Annotation Annotation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<uint> ViaPointPositions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawSpeedLimits SpeedLimits { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawAnnotationSchemes AnnotationSchemes { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawLaneSigns LaneSigns { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
