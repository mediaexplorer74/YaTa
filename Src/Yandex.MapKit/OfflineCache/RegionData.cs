// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.RegionData
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IRegionDataFactory), 1)]
  [Static(typeof (__IRegionDataStatics), 1)]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class RegionData : __IRegionDataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RegionData From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RegionData(
      [In] uint id,
      [In] string name,
      [In] string country,
      [In] IVectorView<string> cities,
      [In] Point center,
      [In] LocalizedValue size,
      [In] IVectorView<RegionFile> files,
      [In] long releaseTime,
      [In] RegionState state,
      [In] bool outdated);

    public extern uint Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Country { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> Cities { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Center { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocalizedValue Size { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<RegionFile> Files { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long ReleaseTime { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern RegionState State { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern bool Outdated { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
