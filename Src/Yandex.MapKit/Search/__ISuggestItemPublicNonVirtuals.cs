// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISuggestItemPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(3627821766, 31407, 14895, 138, 189, 148, 171, 22, 224, 182, 179)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SuggestItem))]
  internal interface __ISuggestItemPublicNonVirtuals
  {
    SuggestItemType Type { get; }

    SpannableString Title { get; }

    SpannableString Subtitle { get; }

    IVectorView<string> Tags { get; }

    string SearchText { get; }

    string Uri { get; }

    LocalizedValue Distance { get; }

    bool IsPersonal { get; }

    SuggestItemAction Action { get; }

    string LogId { get; }

    bool IsOffline { get; }
  }
}
