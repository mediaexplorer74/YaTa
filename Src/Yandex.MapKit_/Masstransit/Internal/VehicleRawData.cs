// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.VehicleRawData
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
  [WebHostHidden]
  [Activatable(typeof (__IVehicleRawDataFactory), 1)]
  [MarshalingBehavior]
  [Static(typeof (__IVehicleRawDataStatics), 1)]
  [Threading]
  [Version(1)]
  public sealed class VehicleRawData : __IVehicleRawDataPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern VehicleRawData From([In] AnyCollection anyCollection);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern VehicleRawData([In] string id, [In] string threadId, [In] Line line);

    public extern string Id { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern string ThreadId { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }

    public extern Line Line { [MethodImpl(MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
