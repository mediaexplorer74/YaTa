// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymResultMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ToponymResultMetadata))]
  [Version(1)]
  [Guid(1479535916, 39571, 13123, 158, 245, 191, 195, 42, 38, 52, 52)]
  internal interface __IToponymResultMetadataFactory
  {
    [Overload("CreateInstance1")]
    ToponymResultMetadata CreateInstance(
      [In] int found,
      [In] ToponymResultMetadataResponseInfo responseInfo,
      [In] Point reversePoint);
  }
}
