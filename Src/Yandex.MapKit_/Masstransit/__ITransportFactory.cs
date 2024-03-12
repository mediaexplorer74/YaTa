// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransportFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(4275329095, 6147, 13938, 162, 234, 92, 7, 119, 108, 227, 104)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Transport))]
  [Version(1)]
  internal interface __ITransportFactory
  {
    [Overload("CreateInstance1")]
    Transport CreateInstance([In] Line line, [In] IVectorView<TransportTransportThread> threads);
  }
}
