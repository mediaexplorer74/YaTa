// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.__ITrafficLevelPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Guid(1737297838, 55807, 16249, 154, 238, 53, 146, 72, 227, 124, 84)]
  [Version(1)]
  [ExclusiveTo(typeof (TrafficLevel))]
  [WebHostHidden]
  internal interface __ITrafficLevelPublicNonVirtuals
  {
    TrafficColor Color { get; }

    int Level { get; }
  }
}
