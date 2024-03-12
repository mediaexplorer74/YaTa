// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IFeedPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Guid(2504089106, 31316, 13306, 182, 247, 237, 122, 11, 4, 125, 131)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Feed))]
  [Version(1)]
  internal interface __IFeedPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Feed AtomFeed { get; }

    IVectorView<Entry> Entries { get; }
  }
}
