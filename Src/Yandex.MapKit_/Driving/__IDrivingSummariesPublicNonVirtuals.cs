// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IDrivingSummariesPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [ExclusiveTo(typeof (DrivingSummaries))]
  [WebHostHidden]
  [Version(1)]
  [Guid(220142303, 19706, 15677, 187, 27, 83, 210, 9, 71, 42, 49)]
  internal interface __IDrivingSummariesPublicNonVirtuals
  {
    IVectorView<Summary> Summaries { get; }
  }
}
