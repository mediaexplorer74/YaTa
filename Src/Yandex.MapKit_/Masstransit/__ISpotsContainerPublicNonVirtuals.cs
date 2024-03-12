// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISpotsContainerPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(3616070075, 50344, 14615, 174, 29, 57, 216, 46, 136, 36, 170)]
  [ExclusiveTo(typeof (SpotsContainer))]
  [WebHostHidden]
  internal interface __ISpotsContainerPublicNonVirtuals
  {
    IVectorView<Spot> Spots { get; }
  }
}
