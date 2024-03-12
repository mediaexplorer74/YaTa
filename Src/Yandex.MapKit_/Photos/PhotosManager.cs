// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.PhotosManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [Guid(3715974861, 6322, 13666, 153, 85, 187, 166, 14, 90, 175, 176)]
  [WebHostHidden]
  [Version(1)]
  public interface PhotosManager
  {
    PhotoSession Photos([In] string businessId);

    ImageSession Image(
      [In] string id,
      [In] ImageSize size,
      [In] OnImageReceived onImageReceived,
      [In] OnImageError onImageError);

    void Clear();
  }
}
