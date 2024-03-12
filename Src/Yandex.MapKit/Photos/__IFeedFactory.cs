// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Photos.__IFeedFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Photos
{
  [ExclusiveTo(typeof (Feed))]
  [Guid(3624080976, 11428, 13298, 128, 83, 121, 137, 176, 138, 133, 40)]
  [Version(1)]
  [WebHostHidden]
  internal interface __IFeedFactory
  {
    [Overload("CreateInstance1")]
    Feed CreateInstance([In] global::Yandex.MapKit.Atom.Feed atomFeed, [In] IVectorView<Entry> entries);
  }
}
