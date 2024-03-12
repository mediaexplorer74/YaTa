// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1458566954, 44113, 13285, 139, 129, 181, 151, 233, 165, 38, 209)]
  [ExclusiveTo(typeof (BusinessFilter))]
  internal interface __IBusinessFilterFactory
  {
    [Overload("CreateInstance1")]
    BusinessFilter CreateInstance(
      [In] string id,
      [In] string name,
      [In] IReference<bool> disabled,
      [In] BusinessFilterValues values);
  }
}
