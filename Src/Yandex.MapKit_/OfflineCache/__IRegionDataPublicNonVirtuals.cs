// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionDataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [WebHostHidden]
  [Guid(1767235960, 60659, 14699, 182, 98, 204, 23, 99, 248, 119, 246)]
  [Version(1)]
  [ExclusiveTo(typeof (RegionData))]
  internal interface __IRegionDataPublicNonVirtuals
  {
    uint Id { get; }

    string Name { get; }

    string Country { get; }

    IVectorView<string> Cities { get; }

    Point Center { get; }

    LocalizedValue Size { get; }

    IVectorView<RegionFile> Files { get; }

    long ReleaseTime { get; }

    RegionState State { get; }

    bool Outdated { get; }
  }
}
