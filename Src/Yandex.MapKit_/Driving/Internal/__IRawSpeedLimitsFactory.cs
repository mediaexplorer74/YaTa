// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSpeedLimitsFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [Guid(3718037921, 22776, 13359, 181, 150, 23, 96, 12, 207, 159, 205)]
  [ExclusiveTo(typeof (RawSpeedLimits))]
  [Version(1)]
  [WebHostHidden]
  internal interface __IRawSpeedLimitsFactory
  {
    [Overload("CreateInstance1")]
    RawSpeedLimits CreateInstance([In] IVectorView<RawSpeedLimit> speedLimits);
  }
}
