// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessObjectMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1699766327, 47368, 14142, 164, 49, 158, 53, 84, 8, 196, 23)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (BusinessObjectMetadata))]
  internal interface __IBusinessObjectMetadataStatics
  {
    BusinessObjectMetadata From([In] AnyCollection anyCollection);
  }
}
