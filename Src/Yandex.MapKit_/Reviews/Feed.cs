﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.Feed
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [MarshalingBehavior]
  [Activatable(typeof (__IFeedFactory), 1)]
  [WebHostHidden]
  [Version(1)]
  [Static(typeof (__IFeedStatics), 1)]
  [Threading]
  public sealed class Feed : __IFeedPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Feed From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Feed([In] global::Yandex.MapKit.Atom.Feed atomFeed, [In] IVectorView<Entry> entries);

    public extern global::Yandex.MapKit.Atom.Feed AtomFeed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<Entry> Entries { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
