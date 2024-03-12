// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.__IDrivingSummariesFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DrivingSummaries))]
  [Guid(123531257, 21045, 15904, 142, 72, 212, 189, 67, 89, 160, 14)]
  [Version(1)]
  internal interface __IDrivingSummariesFactory
  {
    [Overload("CreateInstance1")]
    DrivingSummaries CreateInstance([In] IVectorView<Summary> summaries);
  }
}
