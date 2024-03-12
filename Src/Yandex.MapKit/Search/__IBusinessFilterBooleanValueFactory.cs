// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterBooleanValueFactory
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
  [Guid(2501387280, 26137, 15298, 149, 6, 101, 38, 116, 230, 101, 13)]
  [ExclusiveTo(typeof (BusinessFilterBooleanValue))]
  [Version(1)]
  internal interface __IBusinessFilterBooleanValueFactory
  {
    [Overload("CreateInstance1")]
    BusinessFilterBooleanValue CreateInstance([In] bool value, [In] IReference<bool> selected);
  }
}
