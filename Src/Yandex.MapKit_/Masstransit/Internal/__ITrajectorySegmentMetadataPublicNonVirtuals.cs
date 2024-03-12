// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__ITrajectorySegmentMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [WebHostHidden]
  [ExclusiveTo(typeof (TrajectorySegmentMetadata))]
  [Guid(1333909498, 26433, 15900, 157, 92, 163, 196, 130, 83, 239, 175)]
  [Version(1)]
  internal interface __ITrajectorySegmentMetadataPublicNonVirtuals
  {
    long Time { get; }

    uint Duration { get; }
  }
}
