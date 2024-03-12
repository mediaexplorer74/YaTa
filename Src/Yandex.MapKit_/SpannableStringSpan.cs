// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.SpannableStringSpan
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__ISpannableStringSpanFactory), 1)]
  [WebHostHidden]
  [Threading]
  public sealed class SpannableStringSpan : __ISpannableStringSpanPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SpannableStringSpan([In] int begin, [In] int end);

    public extern int Begin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int End { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
