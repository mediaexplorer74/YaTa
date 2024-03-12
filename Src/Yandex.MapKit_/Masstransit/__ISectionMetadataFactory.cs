// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISectionMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SectionMetadata))]
  [Guid(1524846731, 29820, 13344, 160, 224, 129, 147, 11, 9, 126, 97)]
  internal interface __ISectionMetadataFactory
  {
    [Overload("CreateInstance1")]
    SectionMetadata CreateInstance([In] Weight weight, [In] SectionMetadataSectionData data);
  }
}
