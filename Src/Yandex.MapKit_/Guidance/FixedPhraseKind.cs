﻿// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.FixedPhraseKind
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  public enum FixedPhraseKind
  {
    RouteUpdated,
    GoneOffRoute,
    ReturnedOnRoute,
    SpeedLimitExceeded,
    ViaPointPassed,
    FasterRouteAvailable,
  }
}