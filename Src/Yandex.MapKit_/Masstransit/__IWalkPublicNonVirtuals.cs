// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IWalkPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [ExclusiveTo(typeof (Walk))]
  [WebHostHidden]
  [Guid(2311671912, 36504, 14197, 132, 125, 197, 151, 133, 60, 207, 1)]
  internal interface __IWalkPublicNonVirtuals
  {
    IVectorView<PedestrianConstructionID> Constructions { get; }

    IVectorView<Spot> Spots { get; }
  }
}
