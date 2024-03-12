// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.Region
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [WebHostHidden]
  [Guid(897222728, 31584, 12512, 176, 208, 89, 221, 128, 31, 159, 5)]
  [Version(1)]
  public interface Region
  {
    void AddListener([In] RegionListener regionListener);

    void RemoveListener([In] RegionListener regionListener);

    void Start();

    void Stop();

    void Pause();

    string Name { get; }

    string Country { get; }

    IVectorView<string> Cities { get; }

    global::Yandex.MapKit.Geometry.Point Center { get; }

    uint RegionId { get; }

    RegionState State { get; }

    bool Outdated { get; }

    float Progress { get; }

    LocalizedValue DownloadSize { get; }

    DateTime ReleaseTime { get; }

    bool MayBeOutOfAvailableSpace();

    bool Valid { get; }
  }
}
