// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IFixedPhraseFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(2036525321, 8814, 12294, 130, 7, 107, 230, 98, 204, 21, 82)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FixedPhrase))]
  [Version(1)]
  internal interface __IFixedPhraseFactory
  {
    [Overload("CreateInstance1")]
    FixedPhrase CreateInstance([In] FixedPhraseKind kind);
  }
}
