﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Transfer
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
  [WebHostHidden]
  [MarshalingBehavior]
  [Threading]
  [Static(typeof (__ITransferStatics), 1)]
  [Activatable(typeof (__ITransferFactory), 1)]
  [Version(1)]
  public sealed class Transfer : __ITransferPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Transfer From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Transfer(
      [In] IVectorView<PedestrianConstructionID> constructions);

    public extern IVectorView<PedestrianConstructionID> Constructions { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
