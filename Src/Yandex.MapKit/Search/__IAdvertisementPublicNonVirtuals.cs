// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IAdvertisementPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Guid(2054945135, 56103, 15059, 148, 231, 72, 177, 148, 189, 85, 126)]
  [ExclusiveTo(typeof (Advertisement))]
  [WebHostHidden]
  internal interface __IAdvertisementPublicNonVirtuals
  {
    string Text { get; }

    IVectorView<string> Disclaimers { get; }

    string Title { get; }

    string Extra { get; }

    string Url { get; }
  }
}
