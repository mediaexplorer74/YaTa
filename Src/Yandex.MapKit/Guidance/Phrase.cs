// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Phrase
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  [Version(1)]
  [Static(typeof (__IPhraseStatics), 1)]
  public sealed class Phrase : __IPhrasePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Phrase FromFixed([In] FixedPhrase @fixed);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Phrase FromGuidance([In] GuidancePhrase guidance);

    public extern FixedPhrase Fixed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern GuidancePhrase Guidance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
