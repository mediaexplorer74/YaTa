// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IActionMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [ExclusiveTo(typeof (ActionMetadata))]
  [Guid(4198204781, 38950, 12743, 188, 140, 175, 27, 13, 228, 246, 141)]
  [WebHostHidden]
  internal interface __IActionMetadataPublicNonVirtuals
  {
    UturnMetadata UturnMetadata { get; }

    LeaveRoundaboutMetadata LeaveRoundaboutMetadada { get; }
  }
}
