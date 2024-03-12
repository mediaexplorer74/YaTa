// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.ImageSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [WebHostHidden]
  [Guid(2132473874, 57327, 15319, 191, 237, 39, 179, 254, 24, 22, 246)]
  [Version(1)]
  public interface ImageSession
  {
    void Cancel();

    void Retry([In] OnImageReceived onImageReceived, [In] OnImageError onImageError);
  }
}
