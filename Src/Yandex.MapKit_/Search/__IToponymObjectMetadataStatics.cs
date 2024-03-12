// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IToponymObjectMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (ToponymObjectMetadata))]
  [Version(1)]
  [WebHostHidden]
  [Guid(3010647610, 7320, 12776, 182, 57, 149, 185, 148, 88, 73, 61)]
  internal interface __IToponymObjectMetadataStatics
  {
    ToponymObjectMetadata From([In] AnyCollection anyCollection);
  }
}
