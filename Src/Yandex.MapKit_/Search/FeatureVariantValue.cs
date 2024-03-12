// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.FeatureVariantValue
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [Static(typeof (__IFeatureVariantValueStatics), 1)]
  [WebHostHidden]
  [Threading]
  [MarshalingBehavior]
  public sealed class FeatureVariantValue : __IFeatureVariantValuePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern FeatureVariantValue FromBooleanValue([In] bool booleanValue);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern FeatureVariantValue FromTextValue([In] IVectorView<string> textValue);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern FeatureVariantValue FromEnumValue([In] IVectorView<FeatureEnumValue> enumValue);

    public extern IReference<bool> BooleanValue { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<string> TextValue { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<FeatureEnumValue> EnumValue { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
