// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.OfflineCache.__IRegionListFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.OfflineCache
{
  [Guid(2896809017, 21477, 12350, 138, 73, 231, 17, 163, 158, 109, 191)]
  [ExclusiveTo(typeof (RegionList))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRegionListFactory
  {
    [Overload("CreateInstance1")]
    RegionList CreateInstance([In] IVectorView<RegionData> regions, [In] string etag);
  }
}
