// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISpotStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [Guid(4151561530, 53172, 15536, 153, 178, 127, 59, 44, 100, 249, 191)]
  [ExclusiveTo(typeof (Spot))]
  [WebHostHidden]
  internal interface __ISpotStatics
  {
    Spot From([In] AnyCollection anyCollection);
  }
}
