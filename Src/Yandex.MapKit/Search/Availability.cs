// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.Availability
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Search
{
  [Threading]
  [Activatable(typeof (__IAvailabilityFactory), 1)]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Static(typeof (__IAvailabilityStatics), 1)]
  public sealed class Availability : __IAvailabilityPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Availability From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Availability([In] DayGroup days, [In] IVectorView<TimeRange> timeRanges);

    public extern DayGroup Days { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<TimeRange> TimeRanges { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
