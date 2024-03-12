// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__ISpeedLimitsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(468286124, 46702, 15692, 189, 90, 69, 11, 126, 141, 121, 42)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SpeedLimits))]
  internal interface __ISpeedLimitsPublicNonVirtuals
  {
    LocalizedValue Urban { get; }

    LocalizedValue Rural { get; }

    LocalizedValue Expressway { get; }
  }
}
