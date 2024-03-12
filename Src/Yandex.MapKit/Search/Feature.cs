// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Feature
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Static(typeof (__IFeatureStatics), 1)]
  [Activatable(typeof (__IFeatureFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Version(1)]
  public sealed class Feature : __IFeaturePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Feature From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Feature([In] string id, [In] FeatureVariantValue value, [In] string name, [In] string aref);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern FeatureVariantValue Value { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Aref { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
