// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IRawSectionMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RawSectionMetadata))]
  [Version(1)]
  [Guid(1297725114, 21711, 13604, 165, 0, 173, 39, 231, 133, 121, 73)]
  internal interface __IRawSectionMetadataFactory
  {
    [Overload("CreateInstance1")]
    RawSectionMetadata CreateInstance(
      [In] Weight weight,
      [In] Wait wait,
      [In] RawWalk walk,
      [In] RawTransfer transfer,
      [In] IVectorView<Transport> transports);
  }
}
