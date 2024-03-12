// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSpeedLimitsPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [ExclusiveTo(typeof (RawSpeedLimits))]
  [Version(1)]
  [WebHostHidden]
  [Guid(752094512, 14566, 15692, 130, 48, 149, 171, 31, 170, 201, 50)]
  internal interface __IRawSpeedLimitsPublicNonVirtuals
  {
    IVectorView<RawSpeedLimit> SpeedLimits { get; }
  }
}
