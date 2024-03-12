// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionDataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Guid(91923710, 48702, 13077, 153, 19, 203, 155, 236, 231, 236, 81)]
  [ExclusiveTo(typeof (RegionData))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRegionDataFactory
  {
    [Overload("CreateInstance1")]
    RegionData CreateInstance(
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
  }
}
