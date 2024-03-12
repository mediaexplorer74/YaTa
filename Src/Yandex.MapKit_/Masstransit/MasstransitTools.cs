// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.MasstransitTools
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Map;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [WebHostHidden]
  [Version(1)]
  [Threading]
  [Static(typeof (__IMasstransitToolsStatics), 1)]
  [Activatable(1)]
  [MarshalingBehavior]
  public sealed class MasstransitTools : __IMasstransitToolsPublicNonVirtuals
  {
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public static extern VehicleData GetVehicle([In] PlacemarkMapObject placemark);

    [Overload("CreateInstance1")]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    public extern MasstransitTools();
  }
}
