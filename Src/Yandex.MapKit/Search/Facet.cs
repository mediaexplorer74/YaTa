// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Facet
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
  [Version(1)]
  [Activatable(typeof (__IFacetFactory), 1)]
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  public sealed class Facet : __IFacetPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Facet([In] string facetClass, [In] string name, [In] uint ratings, [In] IReference<float> score);

    public extern string FacetClass { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Ratings { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<float> Score { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
