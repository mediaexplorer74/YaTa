﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Attribution
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit
{
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [Activatable(typeof (__IAttributionFactory), 1)]
  [MarshalingBehavior]
  public sealed class Attribution : __IAttributionPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Attribution([In] AttributionAuthor author, [In] AttributionLink link);

    public extern AttributionAuthor Author { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern AttributionLink Link { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
