// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Location.Location
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Location
{
  [MarshalingBehavior]
  [Threading]
  [Activatable(typeof (__ILocationFactory), 1)]
  [Version(1)]
  [WebHostHidden]
  public sealed class Location : __ILocationPublicNonVirtuals
  {
    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern Location(
      [In] global::Yandex.MapKit.Geometry.Point position,
      [In] IReference<double> accuracy,
      [In] IReference<double> altitude,
      [In] IReference<double> altitudeAccuracy,
      [In] IReference<double> heading,
      [In] IReference<double> speed,
      [In] DateTime absoluteTimestamp,
      [In] DateTime relativeTimestamp);

    public extern global::Yandex.MapKit.Geometry.Point Position { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Accuracy { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Altitude { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> AltitudeAccuracy { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Heading { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern IReference<double> Speed { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime AbsoluteTimestamp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern DateTime RelativeTimestamp { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
