// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.__IRoadEventTapInfoPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [ExclusiveTo(typeof (RoadEventTapInfo))]
  [WebHostHidden]
  [Guid(3789323021, 39598, 16209, 184, 222, 252, 127, 158, 63, 54, 180)]
  [Version(1)]
  internal interface __IRoadEventTapInfoPublicNonVirtuals
  {
    string Id { get; }

    string DescriptionText { get; }

    EventType Type { get; }
  }
}
