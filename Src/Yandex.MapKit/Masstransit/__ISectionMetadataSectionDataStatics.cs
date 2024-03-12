// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionMetadataSectionDataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(535550054, 22972, 12873, 148, 183, 247, 87, 48, 171, 51, 224)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SectionMetadataSectionData))]
  internal interface __ISectionMetadataSectionDataStatics
  {
    SectionMetadataSectionData FromWait([In] Wait wait);

    SectionMetadataSectionData FromWalk([In] Walk walk);

    SectionMetadataSectionData FromTransfer([In] Transfer transfer);

    SectionMetadataSectionData FromTransports([In] IVectorView<Transport> transports);
  }
}
