// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IBusinessFilterValuesStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [ExclusiveTo(typeof (BusinessFilterValues))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2005920846, 19056, 13663, 164, 95, 9, 225, 42, 119, 200, 164)]
  internal interface __IBusinessFilterValuesStatics
  {
    BusinessFilterValues FromBooleans([In] IVectorView<BusinessFilterBooleanValue> booleans);

    BusinessFilterValues FromEnums([In] IVectorView<BusinessFilterEnumValue> enums);
  }
}
