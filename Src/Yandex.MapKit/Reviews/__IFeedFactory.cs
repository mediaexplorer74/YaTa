// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IFeedFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Version(1)]
  [Guid(2936949050, 53620, 14399, 191, 63, 133, 55, 238, 34, 251, 115)]
  [ExclusiveTo(typeof (Feed))]
  [WebHostHidden]
  internal interface __IFeedFactory
  {
    [Overload("CreateInstance1")]
    Feed CreateInstance([In] global::Yandex.MapKit.Atom.Feed atomFeed, [In] IVectorView<Entry> entries);
  }
}
