// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ITransportStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(1497505545, 15043, 16007, 185, 202, 236, 162, 172, 94, 1, 139)]
  [Version(1)]
  [ExclusiveTo(typeof (Transport))]
  [WebHostHidden]
  internal interface __ITransportStatics
  {
    Transport From([In] AnyCollection anyCollection);
  }
}
