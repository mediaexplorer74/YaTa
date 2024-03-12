// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.ReviewSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Guid(2374728962, 29052, 15671, 162, 178, 85, 98, 67, 112, 179, 179)]
  [Version(1)]
  [WebHostHidden]
  public interface ReviewSession
  {
    bool HasNextPage();

    void FetchNextPage(
      [In] OnReviewsFeedReceived onReviewsFeedReceived,
      [In] OnReviewsFeedError onReviewsFeedError);

    void Cancel();
  }
}
