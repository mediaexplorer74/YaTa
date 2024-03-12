// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterEnumValueFactory
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
  [Version(1)]
  [ExclusiveTo(typeof (BusinessFilterEnumValue))]
  [Guid(4018127866, 54783, 14037, 132, 21, 79, 202, 105, 116, 87, 104)]
  internal interface __IBusinessFilterEnumValueFactory
  {
    [Overload("CreateInstance1")]
    BusinessFilterEnumValue CreateInstance(
      [In] FeatureEnumValue value,
      [In] IReference<bool> selected,
      [In] IReference<bool> disabled);
  }
}
