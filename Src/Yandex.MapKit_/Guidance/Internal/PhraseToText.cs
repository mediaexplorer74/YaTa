// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Internal.PhraseToText
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance.Internal
{
  [Activatable(1)]
  [Threading]
  [Version(1)]
  [Static(typeof (__IPhraseToTextStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class PhraseToText : __IPhraseToTextPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern string toText([In] Phrase phrase);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern PhraseToText();
  }
}
