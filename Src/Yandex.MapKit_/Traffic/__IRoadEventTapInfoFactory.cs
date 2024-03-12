// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Traffic.__IRoadEventTapInfoFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Yandex.MapKit.RoadEvents;

#nullable disable
namespace Yandex.MapKit.Traffic
{
  [Guid(203306417, 3894, 12526, 174, 140, 177, 109, 44, 42, 156, 117)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RoadEventTapInfo))]
  [Version(1)]
  internal interface __IRoadEventTapInfoFactory
  {
    [Overload("CreateInstance1")]
    RoadEventTapInfo CreateInstance([In] string id, [In] string descriptionText, [In] EventType type);
  }
}
