// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.__ITrafficLevelStatics
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [WebHostHidden]
  [Guid(1614912108, 59655, 13799, 157, 94, 76, 97, 225, 237, 57, 83)]
  [Version(1)]
  [ExclusiveTo(typeof (TrafficLevel))]
  internal interface __ITrafficLevelStatics
  {
    TrafficLevel From([In] AnyCollection anyCollection);
  }
}
