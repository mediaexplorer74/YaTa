// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.ReviewsManager
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Version(1)]
  [WebHostHidden]
  [Guid(3905718654, 3460, 14483, 176, 105, 25, 16, 175, 176, 243, 100)]
  public interface ReviewsManager
  {
    ReviewSession Reviews([In] string businessId);

    EntrySession ReviewTemplate(
      [In] string businessId,
      [In] OnReviewsEntryReceived onReviewsEntryReceived,
      [In] OnReviewsEntryError onReviewsEntryError);

    EntrySession Update(
      [In] Entry filledTemplate,
      [In] OnReviewsEntryReceived onReviewsEntryReceived,
      [In] OnReviewsEntryError onReviewsEntryError);

    EraseSession Erase(
      [In] string businessId,
      [In] OnReviewsEraseCompleted onReviewsEraseCompleted,
      [In] OnReviewsEraseError onReviewsEraseError);
  }
}
