// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.I18n.__II18nPrefsFactory
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.I18n
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (I18nPrefs))]
  [Guid(1424524409, 730, 13252, 190, 110, 44, 96, 170, 70, 185, 5)]
  internal interface __II18nPrefsFactory
  {
    [Overload("CreateInstance1")]
    I18nPrefs CreateInstance([In] SystemOfMeasurement som, [In] TimeFormat timeFormat);
  }
}
