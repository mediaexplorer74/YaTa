// Decompiled with JetBrains decompiler
// Type: Yandex.MapKit.Reviews.__IReviewSpecificEntryFactory
// Assembly: Yandex.MapKit, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: E2FD2033-F732-4DA0-BCA4-7B33E4544802
// Assembly location: C:\Users\Admin\Desktop\RE\YandexTaxi\Yandex.MapKit.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

#nullable disable
namespace Yandex.MapKit.Reviews
{
  [Version(1)]
  [ExclusiveTo(typeof (ReviewSpecificEntry))]
  [Guid(2739712636, 14162, 14791, 180, 242, 225, 246, 233, 75, 193, 181)]
  [WebHostHidden]
  internal interface __IReviewSpecificEntryFactory
  {
    [Overload("CreateInstance1")]
    ReviewSpecificEntry CreateInstance(
      [In] string businessId,
      [In] string descriptionText,
      [In] string snippet,
      [In] IReference<float> rating,
      [In] IReference<int> positive,
      [In] IReference<int> negative,
      [In] IReference<Vote> userVote,
      [In] IVectorView<Tag> tag,
      [In] IReference<Status> status);
  }
}
