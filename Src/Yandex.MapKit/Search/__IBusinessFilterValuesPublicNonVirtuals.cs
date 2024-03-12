// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterValuesPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [ExclusiveTo(typeof (BusinessFilterValues))]
  [WebHostHidden]
  [Guid(2198403237, 28886, 16060, 173, 189, 73, 185, 150, 20, 249, 41)]
  internal interface __IBusinessFilterValuesPublicNonVirtuals
  {
    IVectorView<BusinessFilterBooleanValue> Booleans { get; }

    IVectorView<BusinessFilterEnumValue> Enums { get; }
  }
}
