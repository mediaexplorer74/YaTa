﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Glyphs.GlyphIdRange
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Glyphs
{
  [WebHostHidden]
  [Activatable(typeof (__IGlyphIdRangeFactory), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  public sealed class GlyphIdRange : __IGlyphIdRangePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GlyphIdRange([In] uint firstGlyphId, [In] uint lastGlyphId);

    public extern uint FirstGlyphId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint LastGlyphId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
