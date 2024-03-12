// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Vehicle
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Geometry;
using Yandex.Runtime;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Threading]
  [MarshalingBehavior]
  [WebHostHidden]
  [Activatable(typeof (__IVehicleFactory), 1)]
  [Static(typeof (__IVehicleStatics), 1)]
  [Version(1)]
  public sealed class Vehicle : __IVehiclePublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern Vehicle From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Vehicle(
      [In] string id,
      [In] string threadId,
      [In] Line line,
      [In] IVectorView<VehicleStop> stops,
      [In] Point position);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string ThreadId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Line Line { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IVectorView<VehicleStop> Stops { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Point Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
