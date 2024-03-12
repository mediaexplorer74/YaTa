// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Map.__IVisibleRegionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Map
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisibleRegion))]
  [Version(1)]
  [Guid(2349207974, 18054, 14379, 175, 175, 186, 52, 27, 48, 27, 86)]
  internal interface __IVisibleRegionFactory
  {
    [Overload("CreateInstance1")]
    VisibleRegion CreateInstance(
      [In] Point topLeft,
      [In] Point topRight,
      [In] Point bottomLeft,
      [In] Point bottomRight);
  }
}
