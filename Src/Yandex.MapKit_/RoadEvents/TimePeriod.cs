﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.TimePeriod
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Activatable(typeof (__ITimePeriodFactory), 1)]
  [Version(1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Threading]
  public sealed class TimePeriod : __ITimePeriodPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TimePeriod([In] I18nTime begin, [In] I18nTime end);

    public extern I18nTime Begin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime End { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
