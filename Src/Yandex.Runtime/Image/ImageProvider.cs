// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.Image.ImageProvider
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Imaging;

#nullable disable
namespace Yandex.Runtime.Image
{
  [Version(1)]
  [Static(typeof (__IImageProviderStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  public sealed class ImageProvider : __IImageProviderPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ImageProvider FromWriteableBitmap([In] WriteableBitmap writeableBitmap);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern IAsyncOperation<ImageProvider> FromResourceUriAsync([In] Uri resourceUri);
  }
}
