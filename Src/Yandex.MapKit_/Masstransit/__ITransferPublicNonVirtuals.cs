// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransferPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3362919798, 60420, 15129, 148, 115, 69, 121, 193, 109, 91, 20)]
  [Version(1)]
  [ExclusiveTo(typeof (Transfer))]
  [WebHostHidden]
  internal interface __ITransferPublicNonVirtuals
  {
    IVectorView<PedestrianConstructionID> Constructions { get; }
  }
}
