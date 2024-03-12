// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.TrajectorySegmentMetadata
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Activatable(typeof (__ITrajectorySegmentMetadataFactory), 1)]
  [Threading]
  [Version(1)]
  [MarshalingBehavior]
  [WebHostHidden]
  [Static(typeof (__ITrajectorySegmentMetadataStatics), 1)]
  public sealed class TrajectorySegmentMetadata : __ITrajectorySegmentMetadataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern TrajectorySegmentMetadata From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TrajectorySegmentMetadata([In] long time, [In] uint duration);

    public extern long Time { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern uint Duration { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
