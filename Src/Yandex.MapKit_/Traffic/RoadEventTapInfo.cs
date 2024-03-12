// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.RoadEventTapInfo
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Threading]
  [WebHostHidden]
  [MarshalingBehavior]
  [Version(1)]
  [Activatable(typeof (__IRoadEventTapInfoFactory), 1)]
  [Static(typeof (__IRoadEventTapInfoStatics), 1)]
  public sealed class RoadEventTapInfo : __IRoadEventTapInfoPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern RoadEventTapInfo From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern RoadEventTapInfo([In] string id, [In] string descriptionText, [In] EventType type);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string DescriptionText { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern EventType Type { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
