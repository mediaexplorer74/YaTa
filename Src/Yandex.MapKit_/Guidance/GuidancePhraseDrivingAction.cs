// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.GuidancePhraseDrivingAction
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Static(typeof (__IGuidancePhraseDrivingActionStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IGuidancePhraseDrivingActionFactory), 1)]
  public sealed class GuidancePhraseDrivingAction : __IGuidancePhraseDrivingActionPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GuidancePhraseDrivingAction From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern GuidancePhraseDrivingAction(
      [In] IReference<uint> distance,
      [In] Action action,
      [In] IReference<uint> exitNumber,
      [In] IReference<uint> length,
      [In] IReference<Landmark> actionLandmark,
      [In] IReference<Landmark> destinationLandmark);

    public extern IReference<uint> Distance { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Action Action { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> ExitNumber { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<uint> Length { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Landmark> ActionLandmark { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<Landmark> DestinationLandmark { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
