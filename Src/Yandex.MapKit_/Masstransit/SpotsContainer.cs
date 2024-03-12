// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.SpotsContainer
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Activatable(typeof (__ISpotsContainerFactory), 1)]
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Static(typeof (__ISpotsContainerStatics), 1)]
  [Threading]
  public sealed class SpotsContainer : __ISpotsContainerPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern SpotsContainer From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern SpotsContainer([In] IVectorView<Spot> spots);

    public extern IVectorView<Spot> Spots { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
