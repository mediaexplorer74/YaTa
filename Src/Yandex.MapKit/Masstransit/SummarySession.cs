// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Masstransit.SummarySession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Masstransit
{
  [Version(1)]
  [WebHostHidden]
  [Guid(4148486005, 14695, 16112, 183, 173, 171, 39, 157, 67, 125, 196)]
  public interface SummarySession
  {
    void Cancel();

    void Retry(
      [In] OnMasstransitSummaries onMasstransitSummaries,
      [In] OnMasstransitSummariesError onMasstransitSummariesError);
  }
}
