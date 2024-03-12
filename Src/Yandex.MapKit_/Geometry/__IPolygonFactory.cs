// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolygonFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Version(1)]
  [Guid(3522594054, 44900, 15412, 187, 91, 68, 210, 14, 242, 36, 30)]
  [ExclusiveTo(typeof (Polygon))]
  [WebHostHidden]
  internal interface __IPolygonFactory
  {
    [Overload("CreateInstance1")]
    Polygon CreateInstance([In] LinearRing outerRing, [In] IVectorView<LinearRing> innerRings);
  }
}
