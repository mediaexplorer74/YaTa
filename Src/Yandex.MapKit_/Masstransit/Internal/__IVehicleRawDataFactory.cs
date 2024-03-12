// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.Internal.__IVehicleRawDataFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit.Internal
{
  [Guid(941683251, 48536, 12901, 174, 195, 68, 137, 148, 141, 175, 158)]
  [ExclusiveTo(typeof (VehicleRawData))]
  [WebHostHidden]
  [Version(1)]
  internal interface __IVehicleRawDataFactory
  {
    [Overload("CreateInstance1")]
    VehicleRawData CreateInstance([In] string id, [In] string threadId, [In] Line line);
  }
}
