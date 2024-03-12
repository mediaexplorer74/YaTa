// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessListObjectMetadataBusinessFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Guid(1399606128, 49969, 14307, 161, 218, 132, 85, 113, 228, 111, 138)]
  [Version(1)]
  [ExclusiveTo(typeof (BusinessListObjectMetadataBusiness))]
  [WebHostHidden]
  internal interface __IBusinessListObjectMetadataBusinessFactory
  {
    [Overload("CreateInstance1")]
    BusinessListObjectMetadataBusiness CreateInstance([In] string id, [In] string name);
  }
}
