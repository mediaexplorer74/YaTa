// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.EntrySession
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
  [Guid(573600651, 54997, 14525, 187, 212, 118, 49, 253, 0, 31, 126)]
  public interface EntrySession
  {
    void Cancel();

    void Retry(
      [In] OnReviewsEntryReceived onReviewsEntryReceived,
      [In] OnReviewsEntryError onReviewsEntryError);
  }
}
