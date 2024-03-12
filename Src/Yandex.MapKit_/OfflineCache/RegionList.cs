// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.RegionList
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [WebHostHidden]
  [Activatable(typeof (__IRegionListFactory), 1)]
  [Static(typeof (__IRegionListStatics), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class RegionList : __IRegionListPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RegionList From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RegionList([In] IVectorView<RegionData> regions, [In] string etag);

    public extern IVectorView<RegionData> Regions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Etag { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
