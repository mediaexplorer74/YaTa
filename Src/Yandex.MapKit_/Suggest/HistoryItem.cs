// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Suggest.HistoryItem
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Suggest
{
  [Activatable(typeof (__IHistoryItemFactory), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__IHistoryItemStatics), 1)]
  public sealed class HistoryItem : __IHistoryItemPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern HistoryItem From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern HistoryItem([In] SpannableString spannableString);

    public extern SpannableString SpannableString { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
