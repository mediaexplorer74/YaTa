// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Guidance.Report
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Guidance
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2820601457, 14088, 13052, 188, 14, 243, 137, 239, 222, 128, 75)]
  public interface Report
  {
    DateTime StartTime { get; }

    DateTime EndTime { get; }

    IVectorView<DateTime> ProblemMarks();

    global::Yandex.MapKit.Geometry.Point NearestPoint([In] DateTime timestamp);

    IReference<DateTime> NearestTimestamp([In] global::Yandex.MapKit.Geometry.Point point);
  }
}
