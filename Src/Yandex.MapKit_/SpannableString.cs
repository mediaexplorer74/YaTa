// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.SpannableString
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit
{
  [MarshalingBehavior]
  [Activatable(typeof (__ISpannableStringFactory), 1)]
  [WebHostHidden]
  [Threading]
  [Static(typeof (__ISpannableStringStatics), 1)]
  [Version(1)]
  public sealed class SpannableString : __ISpannableStringPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SpannableString From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SpannableString([In] string text, [In] IVectorView<SpannableStringSpan> spans);

    public extern string Text { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<SpannableStringSpan> Spans { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
