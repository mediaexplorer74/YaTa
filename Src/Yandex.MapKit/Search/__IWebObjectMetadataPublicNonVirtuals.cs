// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWebObjectMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (WebObjectMetadata))]
  [Version(1)]
  [WebHostHidden]
  [Guid(394855635, 37003, 15083, 151, 129, 179, 221, 171, 227, 208, 230)]
  internal interface __IWebObjectMetadataPublicNonVirtuals
  {
    SpannableString HighlightedTitle { get; }

    string Url { get; }

    IVectorView<SpannableString> HighlightedSnippets { get; }
  }
}
