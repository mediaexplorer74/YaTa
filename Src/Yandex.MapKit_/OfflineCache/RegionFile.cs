// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.RegionFile
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  [global::Windows.Foundation.Metadata.Version(1)]
  [Activatable(typeof (__IRegionFileFactory), 1)]
  public sealed class RegionFile : __IRegionFilePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RegionFile(
      [In] string cacheType,
      [In] string version,
      [In] string downloadUrl,
      [In] long downloadSize,
      [In] long downloaded,
      [In] long unused_,
      [In] string downloadId);

    public extern string CacheType { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Version { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DownloadUrl { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long DownloadSize { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long Downloaded { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern long Unused_ { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DownloadId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
