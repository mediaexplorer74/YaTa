// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ILineAtStopPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Guid(3812658679, 56189, 15113, 150, 124, 41, 211, 77, 21, 44, 192)]
  [ExclusiveTo(typeof (LineAtStop))]
  [Version(1)]
  internal interface __ILineAtStopPublicNonVirtuals
  {
    Line Line { get; }

    IVectorView<ThreadAtStop> ThreadsAtStop { get; }
  }
}
