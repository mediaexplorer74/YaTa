// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionFilePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [global::Windows.Foundation.Metadata.Version(1)]
  [Guid(2931506105, 60917, 15749, 191, 74, 114, 199, 193, 36, 209, 97)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RegionFile))]
  internal interface __IRegionFilePublicNonVirtuals
  {
    string CacheType { get; }

    string Version { get; }

    string DownloadUrl { get; }

    long DownloadSize { get; }

    long Downloaded { get; }

    long Unused_ { get; }

    string DownloadId { get; }
  }
}
