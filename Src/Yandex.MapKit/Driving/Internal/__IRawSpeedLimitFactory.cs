// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.Internal.__IRawSpeedLimitFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving.Internal
{
  [ExclusiveTo(typeof (RawSpeedLimit))]
  [Guid(1344327210, 32377, 14207, 149, 222, 88, 254, 151, 182, 248, 20)]
  [WebHostHidden]
  [Version(1)]
  internal interface __IRawSpeedLimitFactory
  {
    [Overload("CreateInstance1")]
    RawSpeedLimit CreateInstance([In] int count, [In] IReference<float> speed);
  }
}
