// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__ISpeedLimitsRulesPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [ExclusiveTo(typeof (SpeedLimitsRules))]
  [Guid(2675614710, 37275, 13429, 136, 21, 70, 204, 122, 35, 131, 141)]
  [WebHostHidden]
  [Version(1)]
  internal interface __ISpeedLimitsRulesPublicNonVirtuals
  {
    SpeedLimitsRulesType Urban { get; }

    SpeedLimitsRulesType Rural { get; }

    SpeedLimitsRulesType Expressway { get; }
  }
}
