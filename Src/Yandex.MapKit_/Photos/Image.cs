// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.Image
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IImageFactory), 1)]
  [Static(typeof (__IImageStatics), 1)]
  [WebHostHidden]
  [Threading]
  public sealed class Image : __IImagePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Image From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Image([In] uint width, [In] uint height, [In] ImageSize size, [In] string imageId);

    public extern uint Width { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Height { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ImageSize Size { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string ImageId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
