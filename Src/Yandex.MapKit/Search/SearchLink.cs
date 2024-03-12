// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.SearchLink
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Activatable(typeof (__ISearchLinkFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class SearchLink : __ISearchLinkPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SearchLink([In] string aref, [In] LinkType type, [In] AttributionLink link);

    public extern string Aref { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LinkType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AttributionLink Link { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
