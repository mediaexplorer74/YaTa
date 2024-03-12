// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.ScheduleEntryPeriodical
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Static(typeof (__IScheduleEntryPeriodicalStatics), 1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IScheduleEntryPeriodicalFactory), 1)]
  [Version(1)]
  [Threading]
  public sealed class ScheduleEntryPeriodical : __IScheduleEntryPeriodicalPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern ScheduleEntryPeriodical From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ScheduleEntryPeriodical(
      [In] LocalizedValue frequency,
      [In] I18nTime begin,
      [In] I18nTime end,
      [In] IVectorView<ScheduleEntryEstimation> estimations);

    public extern LocalizedValue Frequency { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime Begin { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern I18nTime End { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<ScheduleEntryEstimation> Estimations { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
