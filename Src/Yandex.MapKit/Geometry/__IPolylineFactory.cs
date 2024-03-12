// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolylineFactory
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
  [Guid(505845044, 63301, 13992, 129, 59, 138, 8, 13, 59, 115, 103)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Polyline))]
  internal interface __IPolylineFactory
  {
    [Overload("CreateInstance1")]
    Polyline CreateInstance([In] IVectorView<Point> points);
  }
}
