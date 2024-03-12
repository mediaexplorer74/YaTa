// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IWalkFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (Walk))]
  [Guid(3908471351, 49774, 15861, 161, 245, 38, 40, 79, 220, 5, 105)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IWalkFactory
  {
    [Overload("CreateInstance1")]
    Walk CreateInstance(
      [In] IVectorView<PedestrianConstructionID> constructions,
      [In] IVectorView<Spot> spots);
  }
}
