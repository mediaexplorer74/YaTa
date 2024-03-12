// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.SectionMetadataSectionData
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Threading]
  [MarshalingBehavior]
  [Static(typeof (__ISectionMetadataSectionDataStatics), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class SectionMetadataSectionData : __ISectionMetadataSectionDataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadataSectionData FromWait([In] Wait wait);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadataSectionData FromWalk([In] Walk walk);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadataSectionData FromTransfer([In] Transfer transfer);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SectionMetadataSectionData FromTransports([In] IVectorView<Transport> transports);

    public extern Wait Wait { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Walk Walk { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Transfer Transfer { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Transport> Transports { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
