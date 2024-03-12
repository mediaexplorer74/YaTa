// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IReviewSpecificEntryPublicNonVirtuals
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [ExclusiveTo(typeof (ReviewSpecificEntry))]
  [WebHostHidden]
  [Version(1)]
  [Guid(2244675991, 44174, 13980, 159, 128, 22, 246, 92, 149, 248, 59)]
  internal interface __IReviewSpecificEntryPublicNonVirtuals
  {
    string BusinessId { get; }

    string DescriptionText { get; }

    string Snippet { get; }

    IReference<float> Rating { get; }

    IReference<int> Positive { get; }

    IReference<int> Negative { get; }

    IReference<Vote> UserVote { get; }

    IVectorView<global::Yandex.MapKit.Reviews.Tag> Tag { get; }

    IReference<global::Yandex.MapKit.Reviews.Status> Status { get; }
  }
}
