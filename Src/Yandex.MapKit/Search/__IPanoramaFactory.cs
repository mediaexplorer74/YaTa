// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Search.__IPanoramaFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;

#nullable disable
namespace Yandex.MapKit.Search
{
  [WebHostHidden]
  [Version(1)]
  [Guid(1232368188, 31704, 15107, 168, 44, 234, 120, 157, 211, 57, 96)]
  [ExclusiveTo(typeof (Panorama))]
  internal interface __IPanoramaFactory
  {
    [Overload("CreateInstance1")]
    Panorama CreateInstance([In] string id, [In] Direction direction, [In] Span span, [In] Point point);
  }
}
