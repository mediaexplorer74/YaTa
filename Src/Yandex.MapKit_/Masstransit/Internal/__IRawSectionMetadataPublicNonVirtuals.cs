// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawSectionMetadataPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Version(1)]
  [ExclusiveTo(typeof (RawSectionMetadata))]
  [WebHostHidden]
  [Guid(2049193961, 52469, 13782, 170, 214, 124, 90, 145, 234, 195, 215)]
  internal interface __IRawSectionMetadataPublicNonVirtuals
  {
    Weight Weight { get; }

    Wait Wait { get; }

    RawWalk Walk { get; }

    RawTransfer Transfer { get; }

    IVectorView<Transport> Transports { get; }
  }
}
