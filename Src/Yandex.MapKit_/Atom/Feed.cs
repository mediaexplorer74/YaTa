﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Atom.Feed
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Atom
{
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IFeedFactory), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Static(typeof (__IFeedStatics), 1)]
  public sealed class Feed : __IFeedPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Feed From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Feed([In] string nextpage, [In] IVectorView<Link> links);

    public extern string Nextpage { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Link> Links { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
