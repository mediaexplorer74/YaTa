// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Geometry.Geo.__IProjectionsStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Geometry.Geo
{
  [ExclusiveTo(typeof (Projections))]
  [Version(1)]
  [WebHostHidden]
  [Guid(2754245088, 206, 12666, 164, 195, 241, 16, 29, 109, 44, 81)]
  internal interface __IProjectionsStatics
  {
    Projection CreateWgs84Mercator();
  }
}
