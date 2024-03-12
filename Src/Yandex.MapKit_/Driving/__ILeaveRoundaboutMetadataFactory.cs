// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__ILeaveRoundaboutMetadataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(3290986135, 31493, 14896, 178, 189, 23, 220, 111, 25, 229, 59)]
  [ExclusiveTo(typeof (LeaveRoundaboutMetadata))]
  [Version(1)]
  [WebHostHidden]
  internal interface __ILeaveRoundaboutMetadataFactory
  {
    [Overload("CreateInstance1")]
    LeaveRoundaboutMetadata CreateInstance([In] uint exitNumber);
  }
}
