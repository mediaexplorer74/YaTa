// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.FixedPhrase
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IFixedPhraseFactory), 1)]
  [Static(typeof (__IFixedPhraseStatics), 1)]
  public sealed class FixedPhrase : __IFixedPhrasePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern FixedPhrase From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern FixedPhrase([In] FixedPhraseKind kind);

    public extern FixedPhraseKind Kind { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
