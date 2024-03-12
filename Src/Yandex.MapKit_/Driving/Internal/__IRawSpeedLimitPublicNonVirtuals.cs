// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSpeedLimitPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(2977451252, 6004, 12324, 150, 119, 162, 113, 228, 241, 255, 154)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (RawSpeedLimit))]
  internal interface __IRawSpeedLimitPublicNonVirtuals
  {
    int Count { get; }

    IReference<float> Speed { get; }
  }
}
