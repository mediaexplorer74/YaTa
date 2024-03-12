// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISpotsContainerFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (SpotsContainer))]
  [Guid(435213823, 20834, 12849, 156, 79, 141, 188, 133, 127, 106, 97)]
  internal interface __ISpotsContainerFactory
  {
    [Overload("CreateInstance1")]
    SpotsContainer CreateInstance([In] IVectorView<Spot> spots);
  }
}
