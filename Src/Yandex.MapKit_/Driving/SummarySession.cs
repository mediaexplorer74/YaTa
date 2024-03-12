// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Driving.SummarySession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Driving
{
  [WebHostHidden]
  [Version(1)]
  [Guid(2851335562, 42101, 12399, 157, 61, 100, 104, 186, 187, 68, 88)]
  public interface SummarySession
  {
    void Cancel();

    void Retry(
      [In] OnDrivingSummaries onDrivingSummaries,
      [In] OnDrivingSummariesError onDrivingSummariesError);
  }
}
