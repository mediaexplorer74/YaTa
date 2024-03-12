// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.RawSectionMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Activatable(typeof (__IRawSectionMetadataFactory), 1)]
  [Threading]
  [Static(typeof (__IRawSectionMetadataStatics), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  public sealed class RawSectionMetadata : __IRawSectionMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RawSectionMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RawSectionMetadata(
      [In] Weight weight,
      [In] Wait wait,
      [In] RawWalk walk,
      [In] RawTransfer transfer,
      [In] IVectorView<Transport> transports);

    public extern Weight Weight { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Wait Wait { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawWalk Walk { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RawTransfer Transfer { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Transport> Transports { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
