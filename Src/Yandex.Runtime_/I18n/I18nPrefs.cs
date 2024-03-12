// Decompiled with JetBrains decompiler
// Type: Yandex.Runtime.I18n.I18nPrefs
// Assembly: Yandex.Runtime, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F9FB2242-A9FD-4E4E-844A-232AF27794F7
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.Runtime.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.Runtime.I18n
{
  [MarshalingBehavior]
  [Version(1)]
  [WebHostHidden]
  [Threading]
  [Activatable(typeof (__II18nPrefsFactory), 1)]
  public sealed class I18nPrefs : __II18nPrefsPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern I18nPrefs([In] SystemOfMeasurement som, [In] TimeFormat timeFormat);

    public extern SystemOfMeasurement Som { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern TimeFormat TimeFormat { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
