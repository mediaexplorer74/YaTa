// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__IVisibleRegionUtilsStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Map
{
  [Guid(957941042, 3907, 16084, 140, 184, 135, 84, 144, 118, 99, 98)]
  [ExclusiveTo(typeof (VisibleRegionUtils))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IVisibleRegionUtilsStatics
  {
    global::Yandex.MapKit.Geometry.Geometry ToPolygon([In] VisibleRegion visibleRegion);
  }
}
