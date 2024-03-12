// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IDrivingOptionsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DrivingOptions))]
  [Guid(474310045, 55690, 14309, 164, 249, 94, 158, 60, 111, 226, 41)]
  internal interface __IDrivingOptionsPublicNonVirtuals
  {
    IReference<double> InitialAzimuth { get; [param: In] set; }
  }
}
