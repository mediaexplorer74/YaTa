// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolylinePublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (Polyline))]
  [Guid(658335637, 57374, 15128, 133, 127, 155, 139, 238, 73, 126, 97)]
  internal interface __IPolylinePublicNonVirtuals
  {
    IVectorView<Point> Points { get; }
  }
}
