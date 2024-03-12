// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Direct.__IBannerPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Direct
{
  [Guid(4262209329, 62797, 13656, 153, 41, 179, 97, 225, 229, 144, 219)]
  [Version(1)]
  [ExclusiveTo(typeof (Banner))]
  [WebHostHidden]
  internal interface __IBannerPublicNonVirtuals
  {
    string Title { get; }

    string Text { get; }

    string Extra { get; }

    IVectorView<string> Disclaimers { get; }

    string Domain { get; }

    string Url { get; }

    string Counter { get; }
  }
}
