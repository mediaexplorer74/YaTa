// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessListObjectMetadataStatics
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
  [ExclusiveTo(typeof (BusinessListObjectMetadata))]
  [WebHostHidden]
  [Guid(2357736861, 56419, 14467, 186, 97, 238, 75, 247, 180, 235, 114)]
  internal interface __IBusinessListObjectMetadataStatics
  {
    BusinessListObjectMetadata From([In] AnyCollection anyCollection);
  }
}
