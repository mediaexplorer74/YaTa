// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.EraseSession
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Version(1)]
  [Guid(96930346, 22885, 12324, 162, 177, 94, 23, 57, 113, 103, 159)]
  [WebHostHidden]
  public interface EraseSession
  {
    void Cancel();

    void Retry(
      [In] OnReviewsEraseCompleted onReviewsEraseCompleted,
      [In] OnReviewsEraseError onReviewsEraseError);
  }
}
