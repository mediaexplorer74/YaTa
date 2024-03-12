// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.__IFeedFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Feed))]
  [Guid(763484407, 25555, 15377, 140, 230, 97, 231, 12, 6, 0, 191)]
  [Version(1)]
  internal interface __IFeedFactory
  {
    [Overload("CreateInstance1")]
    Feed CreateInstance([In] string nextpage, [In] IVectorView<Link> links);
  }
}
