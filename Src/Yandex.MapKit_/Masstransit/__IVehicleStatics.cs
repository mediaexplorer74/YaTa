// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IVehicleStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(3743828279, 4532, 15526, 142, 168, 239, 106, 92, 28, 155, 143)]
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Vehicle))]
  internal interface __IVehicleStatics
  {
    Vehicle From([In] AnyCollection anyCollection);
  }
}
