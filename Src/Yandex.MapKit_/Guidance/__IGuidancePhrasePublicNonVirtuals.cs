// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhrasePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [ExclusiveTo(typeof (GuidancePhrase))]
  [Version(1)]
  [Guid(4046973825, 49672, 15628, 142, 244, 203, 106, 209, 28, 230, 101)]
  [WebHostHidden]
  internal interface __IGuidancePhrasePublicNonVirtuals
  {
    IVectorView<GuidancePhrasePart> Parts { get; }
  }
}
