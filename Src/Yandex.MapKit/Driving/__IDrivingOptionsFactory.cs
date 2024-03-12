// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IDrivingOptionsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Guid(4127236095, 44143, 12897, 177, 170, 47, 90, 128, 23, 192, 200)]
  [ExclusiveTo(typeof (DrivingOptions))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IDrivingOptionsFactory
  {
    [Overload("CreateInstance1")]
    DrivingOptions CreateInstance([In] IReference<double> initialAzimuth);
  }
}
