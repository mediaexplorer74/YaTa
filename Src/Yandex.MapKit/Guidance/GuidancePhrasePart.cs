// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.GuidancePhrasePart
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Version(1)]
  [MarshalingBehavior]
  [Static(typeof (__IGuidancePhrasePartStatics), 1)]
  [Threading]
  [WebHostHidden]
  public sealed class GuidancePhrasePart : __IGuidancePhrasePartPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GuidancePhrasePart FromAction([In] GuidancePhraseDrivingAction action);

    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern GuidancePhrasePart FromEvent([In] GuidancePhraseRoadEvent @event);

    public extern GuidancePhraseDrivingAction Action { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern GuidancePhraseRoadEvent Event { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
