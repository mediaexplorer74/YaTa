// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ILinearRingFactory
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
  [Guid(2311620522, 36987, 15341, 142, 237, 117, 157, 153, 174, 245, 176)]
  [ExclusiveTo(typeof (LinearRing))]
  [WebHostHidden]
  internal interface __ILinearRingFactory
  {
    [Overload("CreateInstance1")]
    LinearRing CreateInstance([In] IVectorView<Point> points);
  }
}
