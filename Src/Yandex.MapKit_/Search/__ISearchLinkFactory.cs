// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchLinkFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (SearchLink))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2008278075, 12713, 15624, 173, 60, 216, 242, 168, 63, 187, 20)]
  internal interface __ISearchLinkFactory
  {
    [Overload("CreateInstance1")]
    SearchLink CreateInstance([In] string aref, [In] LinkType type, [In] AttributionLink link);
  }
}
