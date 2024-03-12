// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Direct.Banner
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Direct
{
  [Static(typeof (__IBannerStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IBannerFactory), 1)]
  public sealed class Banner : __IBannerPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Banner From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Banner(
      [In] string title,
      [In] string text,
      [In] string extra,
      [In] IVectorView<string> disclaimers,
      [In] string domain,
      [In] string url,
      [In] string counter);

    public extern string Title { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Extra { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Disclaimers { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Domain { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Url { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Counter { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
