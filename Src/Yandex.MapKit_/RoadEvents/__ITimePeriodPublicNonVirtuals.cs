﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.RoadEvents.__ITimePeriodPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.RoadEvents
{
  [Guid(4210457445, 35787, 12748, 183, 70, 30, 12, 70, 208, 22, 18)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TimePeriod))]
  internal interface __ITimePeriodPublicNonVirtuals
  {
    I18nTime Begin { get; }

    I18nTime End { get; }
  }
}
