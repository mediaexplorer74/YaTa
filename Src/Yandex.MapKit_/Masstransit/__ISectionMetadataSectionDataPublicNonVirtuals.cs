// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionMetadataSectionDataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(819742961, 61539, 15643, 165, 87, 4, 154, 72, 75, 34, 35)]
  [ExclusiveTo(typeof (SectionMetadataSectionData))]
  [Version(1)]
  [WebHostHidden]
  internal interface __ISectionMetadataSectionDataPublicNonVirtuals
  {
    Wait Wait { get; }

    Walk Walk { get; }

    Transfer Transfer { get; }

    IVectorView<Transport> Transports { get; }
  }
}
