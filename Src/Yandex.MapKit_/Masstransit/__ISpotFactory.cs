// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.__ISpotFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [ExclusiveTo(typeof (Spot))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2707632470, 24377, 13911, 139, 102, 169, 81, 55, 215, 202, 209)]
  internal interface __ISpotFactory
  {
    [Overload("CreateInstance1")]
    Spot CreateInstance([In] IReference<PedestrianSpotType> type, [In] uint position);
  }
}
