// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessFilterValues
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Threading]
  [MarshalingBehavior]
  [Static(typeof (__IBusinessFilterValuesStatics), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class BusinessFilterValues : __IBusinessFilterValuesPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessFilterValues FromBooleans(
      [In] IVectorView<BusinessFilterBooleanValue> booleans);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessFilterValues FromEnums([In] IVectorView<BusinessFilterEnumValue> enums);

    public extern IVectorView<BusinessFilterBooleanValue> Booleans { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<BusinessFilterEnumValue> Enums { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
