// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IImagePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [ExclusiveTo(typeof (Image))]
  [WebHostHidden]
  [Guid(736416305, 41250, 14204, 179, 247, 208, 206, 209, 131, 244, 6)]
  [Version(1)]
  internal interface __IImagePublicNonVirtuals
  {
    uint Width { get; }

    uint Height { get; }

    ImageSize Size { get; }

    string ImageId { get; }
  }
}
