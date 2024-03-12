// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.LeaveRoundaboutMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [Activatable(typeof (__ILeaveRoundaboutMetadataFactory), 1)]
  [WebHostHidden]
  public sealed class LeaveRoundaboutMetadata : __ILeaveRoundaboutMetadataPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern LeaveRoundaboutMetadata([In] uint exitNumber);

    public extern uint ExitNumber { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
