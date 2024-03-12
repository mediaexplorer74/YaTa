// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransportPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [ExclusiveTo(typeof (Transport))]
  [Guid(2750316178, 38977, 15692, 163, 114, 130, 179, 181, 136, 115, 83)]
  [WebHostHidden]
  internal interface __ITransportPublicNonVirtuals
  {
    Line Line { get; }

    IVectorView<TransportTransportThread> Threads { get; }
  }
}
