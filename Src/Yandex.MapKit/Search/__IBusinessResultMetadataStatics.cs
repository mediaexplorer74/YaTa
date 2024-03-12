// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessResultMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (BusinessResultMetadata))]
  [WebHostHidden]
  [Guid(2564971127, 8787, 14095, 139, 218, 101, 77, 198, 30, 167, 36)]
  internal interface __IBusinessResultMetadataStatics
  {
    BusinessResultMetadata From([In] AnyCollection anyCollection);
  }
}
