// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransportTransportThreadFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (TransportTransportThread))]
  [Version(1)]
  [WebHostHidden]
  [Guid(1705287712, 30691, 14131, 174, 185, 154, 201, 12, 87, 77, 33)]
  internal interface __ITransportTransportThreadFactory
  {
    [Overload("CreateInstance1")]
    TransportTransportThread CreateInstance([In] Thread thread);
  }
}
