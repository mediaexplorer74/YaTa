// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.DrivingOptions
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__IDrivingOptionsFactory), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class DrivingOptions : __IDrivingOptionsPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern DrivingOptions([In] IReference<double> initialAzimuth);

    public extern IReference<double> InitialAzimuth { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
