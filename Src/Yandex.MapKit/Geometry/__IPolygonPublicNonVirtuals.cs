// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.__IPolygonPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry
{
  [ExclusiveTo(typeof (Polygon))]
  [WebHostHidden]
  [Version(1)]
  [Guid(997426225, 21943, 13971, 176, 158, 210, 175, 159, 28, 231, 217)]
  internal interface __IPolygonPublicNonVirtuals
  {
    LinearRing OuterRing { get; }

    IVectorView<LinearRing> InnerRings { get; }
  }
}
