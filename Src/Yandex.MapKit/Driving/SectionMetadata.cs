// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.SectionMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Static(typeof (__ISectionMetadataStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__ISectionMetadataFactory), 1)]
  public sealed class SectionMetadata : __ISectionMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SectionMetadata(
      [In] uint legIndex,
      [In] Weight weight,
      [In] Annotation annotation,
      [In] IReference<AnnotationSchemeID> schemeId,
      [In] IVectorView<uint> viaPointPositions);

    public extern uint LegIndex { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Weight Weight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Annotation Annotation { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<AnnotationSchemeID> SchemeId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<uint> ViaPointPositions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
