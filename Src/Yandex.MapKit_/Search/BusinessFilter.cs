﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.BusinessFilter
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IBusinessFilterFactory), 1)]
  [Static(typeof (__IBusinessFilterStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class BusinessFilter : __IBusinessFilterPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern BusinessFilter From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern BusinessFilter(
      [In] string id,
      [In] string name,
      [In] IReference<bool> disabled,
      [In] BusinessFilterValues values);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string Name { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<bool> Disabled { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern BusinessFilterValues Values { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
