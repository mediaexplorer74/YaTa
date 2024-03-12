// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__IStopMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Guid(124297741, 51853, 14268, 187, 62, 254, 61, 225, 72, 207, 176)]
  [WebHostHidden]
  [Version(1)]
  [ExclusiveTo(typeof (StopMetadata))]
  internal interface __IStopMetadataPublicNonVirtuals
  {
    Stop Stop { get; }

    IVectorView<LineAtStop> LinesAtStop { get; }
  }
}
