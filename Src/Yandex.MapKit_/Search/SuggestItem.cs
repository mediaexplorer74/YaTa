// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.SuggestItem
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
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__ISuggestItemFactory), 1)]
  [Version(1)]
  [Static(typeof (__ISuggestItemStatics), 1)]
  [MarshalingBehavior]
  public sealed class SuggestItem : __ISuggestItemPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SuggestItem From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SuggestItem(
      [In] SuggestItemType type,
      [In] SpannableString title,
      [In] SpannableString subtitle,
      [In] IVectorView<string> tags,
      [In] string searchText,
      [In] string uri,
      [In] LocalizedValue distance,
      [In] bool isPersonal,
      [In] SuggestItemAction action,
      [In] string logId,
      [In] bool isOffline);

    public extern SuggestItemType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SpannableString Title { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SpannableString Subtitle { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Tags { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string SearchText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Uri { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool IsPersonal { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern SuggestItemAction Action { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string LogId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool IsOffline { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
