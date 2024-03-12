// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__IIconStyleFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [ExclusiveTo(typeof (IconStyle))]
  [Guid(2831329437, 12232, 15444, 185, 68, 230, 7, 196, 159, 103, 128)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IIconStyleFactory
  {
    [Overload("CreateInstance1")]
    IconStyle CreateInstance(
      [In] IReference<Point> anchor,
      [In] IReference<RotationType> rotationType,
      [In] IReference<float> zIndex,
      [In] IReference<bool> flat,
      [In] IReference<bool> visible);
  }
}
