// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IWebObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(2239878305, 49894, 13488, 184, 136, 100, 203, 229, 113, 16, 128)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (WebObjectMetadata))]
  internal interface __IWebObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    WebObjectMetadata CreateInstance(
      [In] SpannableString highlightedTitle,
      [In] string url,
      [In] IVectorView<SpannableString> highlightedSnippets);
  }
}
