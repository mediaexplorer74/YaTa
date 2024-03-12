// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IFeedPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(2221544748, 21790, 16130, 152, 98, 99, 95, 65, 130, 38, 95)]
  [ExclusiveTo(typeof (Feed))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IFeedPublicNonVirtuals
  {
    global::Yandex.MapKit.Atom.Feed AtomFeed { get; }

    IVectorView<Entry> Entries { get; }
  }
}
