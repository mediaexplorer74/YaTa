// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.WebObjectMetadata
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
  [MarshalingBehavior]
  [Version(1)]
  [Static(typeof (__IWebObjectMetadataStatics), 1)]
  [Threading]
  [WebHostHidden]
  [Activatable(typeof (__IWebObjectMetadataFactory), 1)]
  public sealed class WebObjectMetadata : __IWebObjectMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern WebObjectMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern WebObjectMetadata(
      [In] SpannableString highlightedTitle,
      [In] string url,
      [In] IVectorView<SpannableString> highlightedSnippets);

    public extern SpannableString HighlightedTitle { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Url { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<SpannableString> HighlightedSnippets { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
