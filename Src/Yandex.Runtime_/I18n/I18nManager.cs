// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.I18n.I18nManager
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.I18n
{
  [Version(1)]
  [WebHostHidden]
  [Guid(368333230, 3357, 13761, 155, 113, 199, 99, 116, 56, 177, 63)]
  public interface I18nManager
  {
    string LocalizeDistance([In] int distance);

    string LocalizeDuration([In] int duration);

    string LocalizeSpeed([In] double speed);

    string LocalizeDataSize([In] long dataSize);

    I18nPrefs Prefs { get; [param: In] set; }

    SystemOfMeasurement Som { get; [param: In] set; }

    TimeFormat TimeFormat { get; [param: In] set; }

    bool Valid { get; }
  }
}
