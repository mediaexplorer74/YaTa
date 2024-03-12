// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Advertisement
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Static(typeof (__IAdvertisementStatics), 1)]
  [WebHostHidden]
  [Activatable(typeof (__IAdvertisementFactory), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class Advertisement : __IAdvertisementPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Advertisement From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Advertisement(
      [In] string text,
      [In] IVectorView<string> disclaimers,
      [In] string title,
      [In] string extra,
      [In] string url);

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Disclaimers { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Title { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Extra { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Url { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
