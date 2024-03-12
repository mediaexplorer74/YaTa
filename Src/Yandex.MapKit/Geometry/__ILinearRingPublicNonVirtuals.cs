// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__ILinearRingPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [Guid(3750782554, 11096, 16090, 149, 166, 233, 159, 60, 47, 76, 222)]
  [Version(1)]
  [ExclusiveTo(typeof (LinearRing))]
  [WebHostHidden]
  internal interface __ILinearRingPublicNonVirtuals
  {
    IVectorView<Point> Points { get; }
  }
}
