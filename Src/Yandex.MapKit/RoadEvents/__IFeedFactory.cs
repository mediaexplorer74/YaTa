// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__IFeedFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Version(1)]
  [ExclusiveTo(typeof (Feed))]
  [Guid(1045817760, 59772, 12335, 175, 165, 36, 36, 251, 249, 168, 215)]
  [WebHostHidden]
  internal interface __IFeedFactory
  {
    [Overload("CreateInstance1")]
    Feed CreateInstance([In] global::Yandex.MapKit.Atom.Feed atomFeed, [In] IVectorView<Entry> entries);
  }
}
