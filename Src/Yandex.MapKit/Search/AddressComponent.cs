// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.AddressComponent
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [MarshalingBehavior]
  [Threading]
  [WebHostHidden]
  [Version(1)]
  [Activatable(typeof (__IAddressComponentFactory), 1)]
  [Static(typeof (__IAddressComponentStatics), 1)]
  public sealed class AddressComponent : __IAddressComponentPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern AddressComponent From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern AddressComponent([In] string name, [In] IVectorView<ComponentKind> kinds);

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<ComponentKind> Kinds { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
