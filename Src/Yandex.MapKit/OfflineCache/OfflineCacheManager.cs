// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.OfflineCacheManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Guid(276773665, 51704, 14118, 146, 226, 36, 158, 239, 116, 120, 59)]
  [WebHostHidden]
  [Version(1)]
  public interface OfflineCacheManager
  {
    void AddListener([In] OfflineCacheManagerListener managerListener);

    void RemoveListener([In] OfflineCacheManagerListener managerListener);

    void AddStorageErrorListener([In] StorageErrorListener errorListener);

    void RemoveStorageErrorListener([In] StorageErrorListener errorListener);

    IVectorView<Region> Regions { get; }

    void AllowUseCellularNetwork([In] bool useCellular);

    void Clear([In] OnClearCompleted onClearCompleted);

    void CalcSize([In] OnSizeCalculated onSizeCalculated);

    void RequestPath([In] OnPathReceived onPathReceived, [In] OnPathReceiveError onPathReceiveError);

    void MoveData([In] string newPath, [In] DataMoveListener dataMoveListener);

    void EnableAutoUpdate([In] bool enable);

    bool Valid { get; }
  }
}
