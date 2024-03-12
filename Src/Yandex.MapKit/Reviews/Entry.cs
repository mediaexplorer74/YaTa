// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.Entry
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Threading]
  [Version(1)]
  [Activatable(typeof (__IEntryFactory), 1)]
  [WebHostHidden]
  [Static(typeof (__IEntryStatics), 1)]
  [MarshalingBehavior]
  public sealed class Entry : __IEntryPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Entry From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Entry([In] global::Yandex.MapKit.Atom.Entry atomEntry, [In] ReviewSpecificEntry content);

    public extern global::Yandex.MapKit.Atom.Entry AtomEntry { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern ReviewSpecificEntry Content { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
