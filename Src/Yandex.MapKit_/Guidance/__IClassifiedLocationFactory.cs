// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IClassifiedLocationFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(3393688474, 36135, 14189, 175, 81, 25, 222, 78, 241, 244, 233)]
  [ExclusiveTo(typeof (ClassifiedLocation))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IClassifiedLocationFactory
  {
    [Overload("CreateInstance1")]
    ClassifiedLocation CreateInstance(
      [In] global::Yandex.MapKit.Location.Location location,
      [In] LocationClass locationClass,
      [In] NeedCameraJump needCameraJump);
  }
}
