// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Internal.__IPhraseToTextStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance.Internal
{
  [Version(1)]
  [Guid(1297532820, 6996, 12735, 134, 133, 11, 73, 203, 19, 56, 157)]
  [ExclusiveTo(typeof (PhraseToText))]
  [WebHostHidden]
  internal interface __IPhraseToTextStatics
  {
    string toText([In] Phrase phrase);
  }
}
