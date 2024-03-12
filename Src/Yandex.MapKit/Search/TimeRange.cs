// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.TimeRange
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Threading]
  [Activatable(typeof (__ITimeRangeFactory), 1)]
  public sealed class TimeRange : __ITimeRangePublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TimeRange(
      [In] IReference<bool> isTwentyFourHours,
      [In] IReference<uint> from,
      [In] IReference<uint> to);

    public extern IReference<bool> IsTwentyFourHours { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> From { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> To { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
