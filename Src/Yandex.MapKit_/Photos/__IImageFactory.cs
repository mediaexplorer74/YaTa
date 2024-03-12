// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IImageFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [ExclusiveTo(typeof (Image))]
  [Guid(2564539956, 27355, 13287, 178, 34, 231, 57, 28, 66, 199, 182)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IImageFactory
  {
    [Overload("CreateInstance1")]
    Image CreateInstance([In] uint width, [In] uint height, [In] ImageSize size, [In] string imageId);
  }
}
