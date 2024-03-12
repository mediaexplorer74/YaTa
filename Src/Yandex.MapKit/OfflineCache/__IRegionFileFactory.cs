// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionFileFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RegionFile))]
  [Version(1)]
  [Guid(2168253320, 8275, 13206, 151, 148, 34, 252, 70, 23, 87, 122)]
  internal interface __IRegionFileFactory
  {
    [Overload("CreateInstance1")]
    RegionFile CreateInstance(
      [In] string cacheType,
      [In] string version,
      [In] string downloadUrl,
      [In] long downloadSize,
      [In] long downloaded,
      [In] long unused_,
      [In] string downloadId);
  }
}
