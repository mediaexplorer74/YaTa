// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.PhotoSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [Guid(3598827763, 14848, 13906, 168, 98, 239, 235, 254, 164, 136, 158)]
  [Version(1)]
  [WebHostHidden]
  public interface PhotoSession
  {
    bool HasNextPage();

    void FetchNextPage(
      [In] OnPhotosFeedReceived onPhotosFeedReceived,
      [In] OnPhotosFeedError onPhotosFeedError);

    void Cancel();
  }
}
