// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.ActionMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Activatable(typeof (__IActionMetadataFactory), 1)]
  [Version(1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class ActionMetadata : __IActionMetadataPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern ActionMetadata(
      [In] UturnMetadata uturnMetadata,
      [In] LeaveRoundaboutMetadata leaveRoundaboutMetadada);

    public extern UturnMetadata UturnMetadata { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern LeaveRoundaboutMetadata LeaveRoundaboutMetadada { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
