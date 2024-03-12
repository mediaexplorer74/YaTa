// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__ITrajectorySegmentMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Version(1)]
  [WebHostHidden]
  [Guid(1306609383, 62919, 15201, 186, 161, 226, 157, 8, 172, 181, 129)]
  [ExclusiveTo(typeof (TrajectorySegmentMetadata))]
  internal interface __ITrajectorySegmentMetadataFactory
  {
    [Overload("CreateInstance1")]
    TrajectorySegmentMetadata CreateInstance([In] long time, [In] uint duration);
  }
}
