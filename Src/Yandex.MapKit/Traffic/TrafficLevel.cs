// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.TrafficLevel
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Version(1)]
  [WebHostHidden]
  [Activatable(typeof (__ITrafficLevelFactory), 1)]
  [Static(typeof (__ITrafficLevelStatics), 1)]
  [Threading]
  [MarshalingBehavior]
  public sealed class TrafficLevel : __ITrafficLevelPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern TrafficLevel From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern TrafficLevel([In] TrafficColor color, [In] int level);

    public extern TrafficColor Color { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern int Level { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
