// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IFeedPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [ExclusiveTo(typeof (Feed))]
  [Guid(1062899702, 42512, 13701, 189, 31, 108, 249, 87, 118, 14, 4)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IFeedPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Feed AtomFeed { get; }

    IVectorView<Entry> Entries { get; }
  }
}
