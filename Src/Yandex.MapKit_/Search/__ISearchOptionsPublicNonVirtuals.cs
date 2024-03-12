// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__ISearchOptionsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(3850766634, 46078, 14615, 146, 82, 152, 104, 251, 90, 91, 9)]
  [ExclusiveTo(typeof (SearchOptions))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISearchOptionsPublicNonVirtuals
  {
    SearchType SearchTypes { get; [param: In] set; }

    IReference<uint> ResultPageSize { get; [param: In] set; }

    Snippet Snippets { get; [param: In] set; }

    global::Yandex.MapKit.Geometry.Point UserPosition { get; [param: In] set; }

    string Origin { get; [param: In] set; }

    string DirectPageId { get; [param: In] set; }

    string DirectStatId { get; [param: In] set; }

    string AppleCtx { get; [param: In] set; }

    bool SearchClosed { get; [param: In] set; }

    bool Geometry { get; [param: In] set; }

    IReference<uint> MaxAdverts { get; [param: In] set; }
  }
}
