// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.StorageErrorListener
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1483413842, 10074, 12864, 174, 237, 163, 238, 248, 178, 61, 82)]
  public interface StorageErrorListener
  {
    void OnStorageCorrupted();

    void OnStorageFull();

    void OnStorageAccessDenied();
  }
}
