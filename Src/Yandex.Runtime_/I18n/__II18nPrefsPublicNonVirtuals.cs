// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.I18n.__II18nPrefsPublicNonVirtuals
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.I18n
{
  [WebHostHidden]
  [Version(1)]
  [Guid(481625369, 160, 16368, 155, 155, 111, 184, 106, 110, 88, 167)]
  [ExclusiveTo(typeof (I18nPrefs))]
  internal interface __II18nPrefsPublicNonVirtuals
  {
    SystemOfMeasurement Som { get; }

    TimeFormat TimeFormat { get; }
  }
}
