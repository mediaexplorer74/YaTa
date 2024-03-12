// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISuggestItemFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (SuggestItem))]
  [WebHostHidden]
  [Guid(1255228896, 50256, 15691, 173, 144, 76, 109, 5, 37, 212, 149)]
  internal interface __ISuggestItemFactory
  {
    [Overload("CreateInstance1")]
    SuggestItem CreateInstance(
      [In] SuggestItemType type,
      [In] SpannableString title,
      [In] SpannableString subtitle,
      [In] IVectorView<string> tags,
      [In] string searchText,
      [In] string uri,
      [In] LocalizedValue distance,
      [In] bool isPersonal,
      [In] SuggestItemAction action,
      [In] string logId,
      [In] bool isOffline);
  }
}
