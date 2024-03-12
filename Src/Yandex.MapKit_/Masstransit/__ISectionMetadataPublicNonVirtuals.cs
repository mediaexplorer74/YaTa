// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SectionMetadata))]
  [Guid(1857430068, 1750, 14154, 159, 149, 149, 1, 169, 200, 250, 171)]
  internal interface __ISectionMetadataPublicNonVirtuals
  {
    Weight Weight { get; }

    SectionMetadataSectionData Data { get; }
  }
}
