// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymResultMetadataResponseInfoFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Guid(2720235908, 31475, 13069, 185, 210, 150, 49, 4, 243, 153, 78)]
  [Version(1)]
  [ExclusiveTo(typeof (ToponymResultMetadataResponseInfo))]
  internal interface __IToponymResultMetadataResponseInfoFactory
  {
    [Overload("CreateInstance1")]
    ToponymResultMetadataResponseInfo CreateInstance(
      [In] ToponymResultMetadataSearchMode mode,
      [In] IReference<double> accuracy);
  }
}
