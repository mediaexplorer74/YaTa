// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__ISpeedLimitsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SpeedLimits))]
  [Version(1)]
  [Guid(331359000, 41686, 14675, 174, 125, 119, 194, 139, 123, 250, 20)]
  internal interface __ISpeedLimitsFactory
  {
    [Overload("CreateInstance1")]
    SpeedLimits CreateInstance(
      [In] LocalizedValue urban,
      [In] LocalizedValue rural,
      [In] LocalizedValue expressway);
  }
}
