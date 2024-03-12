// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Image.__IImageProviderStatics
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Imaging;

#nullable disable
namespace Yandex.Runtime.Image
{
  [ExclusiveTo(typeof (ImageProvider))]
  [Guid(1660820782, 30173, 16281, 139, 23, 46, 99, 101, 111, 12, 211)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IImageProviderStatics
  {
    ImageProvider FromWriteableBitmap([In] WriteableBitmap writeableBitmap);

    IAsyncOperation<ImageProvider> FromResourceUriAsync([In] Uri resourceUri);
  }
}
