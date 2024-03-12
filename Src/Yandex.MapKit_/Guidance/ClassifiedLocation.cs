// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.ClassifiedLocation
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Activatable(typeof (__IClassifiedLocationFactory), 1)]
  [Version(1)]
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  public sealed class ClassifiedLocation : __IClassifiedLocationPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ClassifiedLocation(
      [In] global::Yandex.MapKit.Location.Location location,
      [In] LocationClass locationClass,
      [In] NeedCameraJump needCameraJump);

    public extern global::Yandex.MapKit.Location.Location Location { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LocationClass LocationClass { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern NeedCameraJump NeedCameraJump { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
