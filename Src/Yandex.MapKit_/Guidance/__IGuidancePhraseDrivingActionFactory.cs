// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.__IGuidancePhraseDrivingActionFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Yandex.MapKit.Driving;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [Guid(3906695690, 10545, 12554, 130, 129, 105, 211, 253, 255, 90, 134)]
  [Version(1)]
  [ExclusiveTo(typeof (GuidancePhraseDrivingAction))]
  [WebHostHidden]
  internal interface __IGuidancePhraseDrivingActionFactory
  {
    [Overload("CreateInstance1")]
    GuidancePhraseDrivingAction CreateInstance(
      [In] IReference<uint> distance,
      [In] Action action,
      [In] IReference<uint> exitNumber,
      [In] IReference<uint> length,
      [In] IReference<Landmark> actionLandmark,
      [In] IReference<Landmark> destinationLandmark);
  }
}
