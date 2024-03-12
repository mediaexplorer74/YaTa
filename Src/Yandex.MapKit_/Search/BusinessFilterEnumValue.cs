// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessFilterEnumValue
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Threading]
  [Activatable(typeof (__IBusinessFilterEnumValueFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  public sealed class BusinessFilterEnumValue : __IBusinessFilterEnumValuePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessFilterEnumValue(
      [In] FeatureEnumValue value,
      [In] IReference<bool> selected,
      [In] IReference<bool> disabled);

    public extern FeatureEnumValue Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Selected { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Disabled { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
