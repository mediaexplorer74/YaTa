// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IRouteMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (RouteMetadata))]
  [Version(1)]
  [Guid(639427863, 36802, 12345, 179, 64, 80, 135, 94, 150, 145, 54)]
  [WebHostHidden]
  internal interface __IRouteMetadataPublicNonVirtuals
  {
    Weight Weight { get; }

    Flags Flags { get; }

    byte[] Descriptor { get; }

    byte[] Traits { get; }
  }
}
