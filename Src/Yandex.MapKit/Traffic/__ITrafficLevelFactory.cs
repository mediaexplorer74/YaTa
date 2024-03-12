// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.__ITrafficLevelFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1483430815, 22968, 14659, 146, 156, 162, 222, 230, 200, 87, 202)]
  [ExclusiveTo(typeof (TrafficLevel))]
  internal interface __ITrafficLevelFactory
  {
    [Overload("CreateInstance1")]
    TrafficLevel CreateInstance([In] TrafficColor color, [In] int level);
  }
}
