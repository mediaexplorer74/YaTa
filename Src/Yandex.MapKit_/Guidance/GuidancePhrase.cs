﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.GuidancePhrase
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [MarshalingBehavior]
  [Activatable(typeof (__IGuidancePhraseFactory), 1)]
  [WebHostHidden]
  [Static(typeof (__IGuidancePhraseStatics), 1)]
  [Threading]
  [Version(1)]
  public sealed class GuidancePhrase : __IGuidancePhrasePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GuidancePhrase From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GuidancePhrase([In] IVectorView<GuidancePhrasePart> parts);

    public extern IVectorView<GuidancePhrasePart> Parts { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
