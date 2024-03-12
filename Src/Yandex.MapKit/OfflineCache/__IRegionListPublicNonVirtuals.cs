// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionListPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [ExclusiveTo(typeof (RegionList))]
  [Version(1)]
  [Guid(1400501275, 56446, 12771, 179, 206, 162, 215, 142, 75, 211, 249)]
  [WebHostHidden]
  internal interface __IRegionListPublicNonVirtuals
  {
    IVectorView<RegionData> Regions { get; }

    string Etag { get; }
  }
}
