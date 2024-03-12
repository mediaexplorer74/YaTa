// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPSearchObjectMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (PSearchObjectMetadata))]
  [Guid(2539321323, 45051, 13616, 183, 176, 218, 31, 43, 199, 116, 139)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IPSearchObjectMetadataFactory
  {
    [Overload("CreateInstance1")]
    PSearchObjectMetadata CreateInstance(
      [In] string name,
      [In] string address,
      [In] string category,
      [In] LocalizedValue distance);
  }
}
