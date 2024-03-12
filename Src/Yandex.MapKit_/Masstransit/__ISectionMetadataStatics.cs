// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionMetadataStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(1336887740, 35092, 16235, 164, 204, 1, 98, 58, 125, 21, 17)]
  [ExclusiveTo(typeof (SectionMetadata))]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISectionMetadataStatics
  {
    SectionMetadata From([In] AnyCollection anyCollection);
  }
}
